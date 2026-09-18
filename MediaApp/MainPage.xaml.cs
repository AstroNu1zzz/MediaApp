namespace MediaApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void VerVideoClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(Video)}");
        }
        private async void AudioBtnClicked(object sender, EventArgs e)
        {

        }
    }
}
