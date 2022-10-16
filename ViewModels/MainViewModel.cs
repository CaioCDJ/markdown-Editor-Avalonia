using ReactiveUI;

namespace markdownEditor.ViewModels;

public class MainViewModel : ViewModelBase{

    private string? _Text;
    public string Text
    {
        get => _Text;

        set => this.RaiseAndSetIfChanged(ref _Text, value);
    }
}