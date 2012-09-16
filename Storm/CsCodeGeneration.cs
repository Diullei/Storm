using System.Collections.Generic;
using System.Linq;
using System.Text;
using Esprima.NET;
using Esprima.NET.Syntax;

namespace Storm
{
    public class CsCodeGeneration : ICodeGeneration
    {
        private readonly bool _debugMode;

        public CsCodeGeneration(bool debugMode)
        {
            _debugMode = debugMode;
        }

        protected bool DeclarationContext { get; set; }
        protected bool ReturnContext { get; set; }

        private List<string> _declaredVar = new List<string>();

        public string Generate(ISyntax syntax)
        {
            var sb = new StringBuilder();
            var typeName = syntax.GetType().Name;
            switch (typeName)
            {
                    #region "Program"

                case "Program":
                    var program = (syntax as Program);
                    sb.Append("using Storm;");
                    sb.Append("public class C0 : JsObject");
                    sb.Append("{");
                    sb.Append("public C0(IDebugger debugger):base(debugger){}");
                    this.DeclarationContext = true;
                    // colocar esceção para tipo não suportado
                    program.Body.ToList().Where(inst => inst is VariableDeclaration).ToList().ForEach(b => sb.Append(b.ToString()));
                    this.DeclarationContext = false;

                    sb.Append("public override object Exec()");
                    sb.Append("{");
                    program.Body.ForEach(b => sb.Append(b.ToString()));
                    this.ReturnContext = true;
                    sb.Append("return JsObject.Undefined;");
                    this.ReturnContext = true;
                    sb.Append("}");

                    sb.Append("}");

                    break;

                    #endregion

                    #region "VariableDeclaration":

                case "VariableDeclaration":
                    var variableDeclaration = (syntax as VariableDeclaration);

                    if (this.ReturnContext)
                    {
                        sb.Append("this.private_" + variableDeclaration.Declarations.Last().ToString());
                    }
                    else
                    {
                        foreach (var d in variableDeclaration.Declarations)
                        {
                            if (_debugMode && !this.DeclarationContext)
                                sb.Append(string.Format("Debugger.BreakPoint({0}, {1}, {2}, {3}, {4}, {5});", d.Range.Start, d.Range.End, d.Loc.Start.Line, d.Loc.Start.Column, d.Loc.End.Line, d.Loc.End.Column));

                            if (this.DeclarationContext)
                            {
                                if (!_declaredVar.Contains(d.ToString()))
                                {
                                    sb.Append("private object private_");
                                    sb.Append(d.ToString());
                                    sb.Append("{get;set;}");
                                    _declaredVar.Add(d.ToString());
                                }
                            }
                            else
                            {
                                sb.Append("this.private_");
                                sb.Append(d.ToString());
                                sb.Append(";");
                            }

                            if (_debugMode && !this.DeclarationContext)
                                sb.Append("Debugger.BreakPoint(this);");
                        }
                    }
                    break;

                    #endregion

                    #region "VariableDeclarator"

                case "VariableDeclarator":
                    var variableDeclarator = (syntax as VariableDeclarator);

                    if (this.ReturnContext)
                    {
                        sb.Append(variableDeclarator.Id);
                    }
                    else
                    {
                        sb.Append(variableDeclarator.Id);
                        if (!this.DeclarationContext)
                        {
                            sb.Append(" = ");
                            if (variableDeclarator.Init != null)
                            {
                                sb.Append(variableDeclarator.Init);
                            }
                            else
                            {
                                sb.Append("JsObject.Null");
                            }
                        }
                    }
                    break;

                    #endregion

                    #region "Identifier"

                case "Identifier":
                    var identifier = (syntax as Identifier);
                    sb.Append(identifier.Name);

                    break;

                    #endregion

                    #region "Literal"

                case "Literal":
                    var literal = (syntax as Literal);
                    if (literal.IsString) sb.Append("\"");
                    sb.Append(literal.Value);
                    if (literal.IsString) sb.Append("\"");

                    break;

                    #endregion

                #region "ExpressionStatement"

                case "ExpressionStatement":
                    var expression = (syntax as ExpressionStatement);
                    if (_debugMode && !this.DeclarationContext)
                        sb.Append(string.Format("Debugger.BreakPoint({0}, {1}, {2}, {3}, {4}, {5});", expression.Range.Start, expression.Range.End, expression.Loc.Start.Line, expression.Loc.Start.Column, expression.Loc.End.Line, expression.Loc.End.Column));

                    sb.Append(expression.Expression.ToString());
                    sb.Append(";");

                    if (_debugMode && !this.DeclarationContext)
                        sb.Append("Debugger.BreakPoint(this);");

                    break;

                #endregion

                #region "AssignmentExpression"

                case "AssignmentExpression":
                    var assign = (syntax as AssignmentExpression);
                    sb.Append("this.private_" + assign.Left.ToString());
                    sb.Append(string.Format(" {0} ", assign.Operator));
                    sb.Append(assign.Right.ToString());

                    break;

                #endregion

            }

            return sb.ToString();
        }
    }
}