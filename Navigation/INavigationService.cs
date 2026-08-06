namespace FUT18Launcher.Navigation;

public interface INavigationService
{
    void NavigateTo<TViewModel>()
        where TViewModel : ViewModels.BaseViewModel, new();
}
