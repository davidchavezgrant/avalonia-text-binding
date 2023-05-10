using System.Threading.Tasks;


namespace Bylines.Messenger.Client.Views;

public partial class MainViewMobile: UserControl
{
    public MainViewMobile()
    {
        InitializeComponent();
        var input = this.Find<TextBox>(nameof(Input));

        if (input is not null)
        {
            input.GotFocus += (_, _) => input.Text = string.Empty;
        }

        this.Animate();
    }

    private async void Animate()
    {
        var title = this.Find<TextBlock>(nameof(Message));
        var input = this.Find<TextBox>(nameof(Input));
        if (title is null || input is null) return;

        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(1000);
                                                  title.Opacity = 1;
                                              });

        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(1000);
                                                  input.Opacity = .2;
                                              });
    }
}