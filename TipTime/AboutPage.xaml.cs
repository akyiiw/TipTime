namespace TipTime;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void EnviarGitBtn_Clicked(object sender, EventArgs e)
    {
        Launcher.Default.OpenAsync("https://github.com/akyiiw");
    }
}