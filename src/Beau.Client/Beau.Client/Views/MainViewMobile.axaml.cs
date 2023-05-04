using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Animation;
using Avalonia.Threading;
using SkiaSharp;


namespace Beau.Client.Views;

public partial class MainViewMobile: UserControl
{
    public MainViewMobile()
    {
        InitializeComponent();
        StartAnimations();
    }

    private async void StartAnimations()
    {
        var logo         = this.FindControl<Image>(nameof(this.Logo));
        var signInButton = this.FindControl<Button>(nameof(this.SignInButton));
        var signUpButton = this.FindControl<Button>(nameof(this.CreateAccountButton));

        if (logo == null || signInButton == null || signUpButton == null)
            return;

        // Logo fade-in animation
        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(1000);
                                                  logo.Opacity = 1;
                                              });

        // Buttons fade-in animation
        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(1000);
                                                  signInButton.Opacity = 1;
                                                  signUpButton.Opacity = 1;
                                              });
    }
}