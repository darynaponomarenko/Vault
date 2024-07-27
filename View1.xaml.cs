namespace Vault;

public partial class View1 : ContentPage
{
	public View1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        var currentWindow = this.Window;
        var view2 = new Window(new View2());
        Application.Current.OpenWindow(view2);
        Application.Current.CloseWindow(currentWindow);

    }
}