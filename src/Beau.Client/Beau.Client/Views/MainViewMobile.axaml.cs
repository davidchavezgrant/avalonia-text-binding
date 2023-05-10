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
        StartAnimations();
    }

    void CreateAccount()
    {

    }

    void SignIn()
    {

    }


    private async void StartAnimations()
    {
        var logo         = this.FindControl<Image>(nameof(this.Logo));
        var signInButton = this.FindControl<Label>(nameof(this.SignInButton));
        var signUpButton = this.FindControl<TextBox>(nameof(this.CreateAccountButton));

        if (logo == null || signInButton == null || signUpButton == null )
            return;

        // Logo fade-in animation
        await Dispatcher.UIThread.InvokeAsync(async () =>
                                              {
                                                  await Task.Delay(1000);
                                                  logo.Opacity = 1;
                                                  signInButton.Opacity = 1;
                                                    signUpButton.Opacity = 1;
                                              });

    }
}