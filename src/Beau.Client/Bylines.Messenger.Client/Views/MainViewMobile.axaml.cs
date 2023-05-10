using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Animation;
using Avalonia.Threading;
using Contacts;
using Microsoft.Maui.Devices;
using SkiaSharp;


namespace Beau.Client.Views;

public partial class MainViewMobile: UserControl
{
    public MainViewMobile()
    {
        InitializeComponent();
        if (this.Input is not null)
        {
            this.Input.GotFocus += (_, _) => this.Input.Text = string.Empty;
        }

        Animate();
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
        var title = this.Find<TextBlock>(nameof(this.Message));
        if (title is null) return;

        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  title.Opacity = 1;
                                              });
    }

    private async Task RevealInputAsync()
    {
        var input = this.Find<TextBox>(nameof(this.Input));
        if (input is null) return;

        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  input.Opacity = .2;
                                              });
    }
}