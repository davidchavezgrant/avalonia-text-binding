using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace Beau.Client.ViewModels;

public class MainViewModel : ViewModelBase
{

    public string Greeting { get; private set; } = "What's your name?";

    public string Input { get; set; } = "";

    [ObservableAsProperty]
    public bool SendButtonIsVisible { get; set; } = true;

    public void SayHello() { Greeting = "Hello World!"; }
    public MainViewModel()
    {
        this.WhenAnyValue(x => x.Input)
            .Select(x => !string.IsNullOrWhiteSpace(x) && x.Length > 1)
            .ToPropertyEx(this, x => x.SendButtonIsVisible);
    }
}
