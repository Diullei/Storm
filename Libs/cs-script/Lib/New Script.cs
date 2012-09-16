using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Scripting
{
    public class Form1 : System.Windows.Forms.Form
    {
        private PropertyGrid propertyGrid1;
        private System.ComponentModel.Container components = null;

        public Form1()
        {
            InitializeComponent();
            propertyGrid1.SelectedObject = new Customer();
        }

        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(389, 238);
            this.propertyGrid1.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(435, 264);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
        #endregion
    }

    [DefaultPropertyAttribute("Name")]
    public class Customer
    {
        private string _name;
        private int _age;
        private DateTime _dateOfBirth;
        private string _SSN;
        private string _address;
        private string _email;
        private bool _frequentBuyer;
        // Name property with category attribute and
        // description attribute added
        [CategoryAttribute("ID Settings"), DescriptionAttribute("Name of the customer")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        [CategoryAttribute("ID Settings"),
        DescriptionAttribute("Social Security Number of the customer")]
        public string SSN
        {
            get
            {
                return _SSN;
            }
            set
            {
                _SSN = value;
            }
        }
        [CategoryAttribute("ID Settings"),
        DescriptionAttribute("Address of the customer")]
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        [CategoryAttribute("ID Settings"),
        DescriptionAttribute("Date of Birth of the Customer (optional)")]
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                _dateOfBirth = value;
            }
        }
        [CategoryAttribute("ID Settings"), DescriptionAttribute("Age of the customer")]
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        [CategoryAttribute("Marketting Settings"), DescriptionAttribute("If the customer as bought more than 10 times, this is set to true")]
        public bool FrequentBuyer
        {
            get
            {
                return _frequentBuyer;
            }
            set
            {
                _frequentBuyer = value;
            }
        }
        [CategoryAttribute("Marketting Settings"), DescriptionAttribute("Most current e-mail of the customer")]
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public Customer()
        {
        }
    } 

    class Script
    {
        const string usage = "Usage: cscscript WinForm ...\nThe primitive example that demonstrates how to create WinForm application.\n";
        [STAThread]
        static public void Main(string[] args)
        {
            if (args.Length == 1 && (args[0] == "?" || args[0] == "/?" || args[0] == "-?" || args[0].ToLower() == "help"))
            {
                Console.WriteLine(usage);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }
}