namespace Inf_04_maui_part2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            ResultLabel.Text = $"Height: {Height}, Width: {Width}";
        }
    }
}
