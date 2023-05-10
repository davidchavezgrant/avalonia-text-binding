using System.Threading.Tasks;


namespace Bylines.Messenger.Client.Views;

public partial class MainViewMobile: UserControl
{
    public MainViewMobile()
    {
        InitializeComponent();
        if (this.Input is not null)
        {
            this.Input.GotFocus += (_, _) => this.Input.Text = string.Empty;
        }

        this.Animate();
    }

    private async void Animate()
    {
        await Task.Delay(1000);
        await this.RevealTitleAsync();
        await Task.Delay(1000);
        await this.RevealInputAsync();
    }

    private async Task RevealTitleAsync()
    {
        var title = this.Find<TextBlock>(nameof(Message));
        if (title is null) return;

        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  title.Opacity = 1;
                                              });
    }

    private async Task RevealInputAsync()
    {
        var input = this.Find<TextBox>(nameof(Input));
        if (input is null) return;

        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  input.Opacity = .2;
                                              });
    }
}