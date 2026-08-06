using CommunityToolkit.Mvvm.ComponentModel;
using FUT18Launcher.Navigation;

namespace FUT18Launcher.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly NavigationStore _navigationStore;

    public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;

    public MainViewModel(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;

        _navigationStore.CurrentViewModelChanged += () =>
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        };
    }
}
