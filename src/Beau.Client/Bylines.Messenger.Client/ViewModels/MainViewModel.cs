using System.Reactive.Linq;
using Beau.Client.ViewModels;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace Bylines.Messenger.Client.ViewModels;

public class MainViewModel: ViewModelBase
{
    private const string PLACEHOLDER = "Your name";

    [Reactive]
    public string Input { get; set; } = PLACEHOLDER;

    [ObservableAsProperty]
    public bool SendButtonIsVisible { get; set; }

    public MainViewModel()
    {
        this.WhenAnyValue(x => x.Input)
            .Select(x => !string.IsNullOrWhiteSpace(x) && x.Length > 0 && x != PLACEHOLDER)
            .StartWith(false)
            .ToPropertyEx(this, x => x.SendButtonIsVisible);
    }
}