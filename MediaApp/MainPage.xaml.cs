using CommunityToolkit.Maui.Views;

namespace MediaApp

{
    public partial class MainPage : ContentPage
    {
        private bool _isPlaying = false;
        public MainPage()
        {
            InitializeComponent();
        }


        private async void VerVideoClicked(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                AudioPlayer.Pause();
                _isPlaying = false;
                AudioBtn.Text = "Audio";
            }

            await Navigation.PushModalAsync(new Video());
        }
        private void AudioBtnClicked(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                AudioPlayer.Pause();
                _isPlaying = false;
                AudioBtn.Text = "Audio";
            }
            else
            {
                AudioPlayer.Play();
                _isPlaying = true;
                AudioBtn.Text = "Pausar audio";
            }
        
        }
    }
}
