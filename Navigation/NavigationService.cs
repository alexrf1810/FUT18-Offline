using FUT18Launcher.ViewModels;

namespace FUT18Launcher.Navigation;

public class NavigationService : INavigationService
{
    private readonly NavigationStore _navigationStore;

    public NavigationService(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public void Navigate(BaseViewModel viewModel)
    {
        _navigationStore.CurrentViewModel = viewModel;
    }
}
