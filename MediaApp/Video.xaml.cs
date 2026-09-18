namespace MediaApp;

public partial class Video : ContentPage
{
	public Video()
	{
		InitializeComponent();
	}

	public async void CerrarBtnClicked (object sender, EventArgs e)
	{
        await Navigation.PopModalAsync();
    }
}
