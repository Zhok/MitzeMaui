namespace MitzeMaui;

public partial class MainPage : ContentPage
{
	private bool isPlaying = false;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnPlayClicked(object sender, EventArgs e)
	{
        if (isPlaying)
        {
            this.Output.Text = String.Empty;
            SemanticScreenReader.Announce(this.Output.Text);

            this.PlayBtn.Text = "Play";
            SemanticScreenReader.Announce(this.PlayBtn.Text);
            this.isPlaying = false;
        }
		else
        {
            this.isPlaying = true;
            this.PlayBtn.Text = "Stop";
            SemanticScreenReader.Announce(this.PlayBtn.Text);

            var lyric = await new LyricsSource().GetLyrics();

            await lyric.ToList().ForEachAsync(async x =>
            {
                if (isPlaying)
                {
                    this.Output.Text += x;
                    SemanticScreenReader.Announce(this.Output.Text);
                    await Task.Delay(25);
                }
            });
            
        }		
	}
}

