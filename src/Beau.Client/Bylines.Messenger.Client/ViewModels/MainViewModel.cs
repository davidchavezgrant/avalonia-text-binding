using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace Beau.Client.ViewModels;

public class MainViewModel : ViewModelBase
{

    public string Greeting { get; private set; } = "What's your name?";

    [Reactive]
    public string Input { get; set; } = "Your name";

    [ObservableAsProperty]
    public bool SendButtonIsVisible { get; set; }

    public void SayHello() { Greeting = "Hello World!"; }
    public MainViewModel()
    {
        this.WhenAnyValue(x => x.Input)
            .Select(x => !string.IsNullOrWhiteSpace(x) && x.Length > 0)
            .StartWith(false)
            .ToPropertyEx(this, x => x.SendButtonIsVisible);
    }
}
