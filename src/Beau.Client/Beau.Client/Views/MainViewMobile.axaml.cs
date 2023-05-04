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
        var logo         = this.FindControl<Image>("Logo");
        var signInButton = this.FindControl<Button>("SignInButton");
        var signUpButton = this.FindControl<Button>("SignUpButton");

        if (logo == null || signInButton == null || signUpButton == null)
            return;

        // Logo fade-in animation
        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(1000); // Wait for 1 second
                                                  logo.Opacity = 1;
                                              });

        // Buttons fade-in animation
        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(2000); // Wait for 2 seconds
                                                  signInButton.Opacity = 1;
                                                  signUpButton.Opacity = 1;
                                              });
    }
}