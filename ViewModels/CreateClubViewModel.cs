using CommunityToolkit.Mvvm.ComponentModel;

namespace FUT18Launcher.ViewModels;

public partial class CreateClubViewModel : BaseViewModel
{
    [ObservableProperty]
    private string clubName = string.Empty;

    [ObservableProperty]
    private string managerName = string.Empty;
}
