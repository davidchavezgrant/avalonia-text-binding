namespace Beau.Client.ViewModels;

public class MainViewModel : ViewModelBase
{

    public string Greeting { get; private set; } = "What's your name?";

    public string Input { get; set; } = "";

    public void SayHello() { Greeting = "Hello World!"; }
    public MainViewModel()
    {

    }
}
