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
        this.CreateAccountButton.Click +=(_,_) => this.Click();
        StartAnimations();
    }

    void Click()
    {
        HapticFeedback.Perform(HapticFeedbackType.Click);
        var contact = new CNMutableContact();
        contact.GivenName = "John";
        contact.FamilyName = "Appleseed";

        var store = new CNContactStore();
        var saveRequest = new CNSaveRequest();
        saveRequest.AddContact(contact, null);
        store.ExecuteSaveRequest(saveRequest, out var error);

    }

    private async void StartAnimations()
    {
        var logo         = this.FindControl<Image>(nameof(this.Logo));
        var signIn       = this.FindControl<Border>(nameof(this.SignIn));
        var signInButton = this.FindControl<Button>(nameof(this.SignInButton));
        var signUpButton = this.FindControl<Button>(nameof(this.CreateAccountButton));

        if (logo == null || signInButton == null || signUpButton == null || signIn == null)
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
                                                  signIn.Opacity       = 1;
                                                  signInButton.Opacity = 1;
                                                  signUpButton.Opacity = 1;
                                              });
    }
}