namespace FUT18Launcher.ViewModels;

public partial class MainViewModel : BaseViewModel
{
    private string _applicationTitle = "FUT18 Offline";

    public string ApplicationTitle
    {
        get => _applicationTitle;
        set => SetProperty(ref _applicationTitle, value);
    }
}
