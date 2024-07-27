namespace Vault
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var currentWindow = this.Window;
            var view1 = new Window(new View1());
            Application.Current.OpenWindow(view1);
            Application.Current.CloseWindow(currentWindow);

            
        }

        
    }
}