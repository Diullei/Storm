namespace CommonTools.PropertyDialog
{
	public interface IPropertyDialogPage
	{
		void BeforeDeactivated(object dataObject);
		void BeforeActivated(object dataObject);
	}
}
