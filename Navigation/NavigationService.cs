using FUT18Launcher.ViewModels;

namespace FUT18Launcher.Navigation;

public class NavigationService : INavigationService
{
    private readonly NavigationStore _navigationStore;

    public NavigationService(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public void NavigateTo<TViewModel>()
        where TViewModel : BaseViewModel, new()
    {
        _navigationStore.CurrentViewModel = new TViewModel();
    }
}
