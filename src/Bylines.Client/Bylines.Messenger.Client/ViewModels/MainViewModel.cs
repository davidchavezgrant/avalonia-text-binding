using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;


namespace Bylines.Messenger.Client.ViewModels;

public class MainViewModel: ViewModelBase
{
    private const string PLACEHOLDER = "Your name";

    [Reactive]
    public string Header { get; set; } = "What's your name?";

    [Reactive]
    public string Input { get; set; } = PLACEHOLDER;

    [ObservableAsProperty]
    public bool SendButtonIsVisible { get; set; }

    public MainViewModel()
    {
        var canSend = this.WhenAnyValue(x => x.Input)
                          .Select(x => !string.IsNullOrWhiteSpace(x) && x.Length > 0 && x != PLACEHOLDER)
                          .StartWith(false);

        canSend.ToPropertyEx(this, x => x.SendButtonIsVisible);

        this.SendCommand = ReactiveCommand.Create<Unit, Unit>((_) =>
                                                              {
                                                                  this.Header = $"Hello, {this.Input}!";
                                                                  return Unit.Default;
                                                              },
                                                              canSend);
    }

    public ICommand SendCommand { get; }

}