using System.Windows.Controls;
using FUT18Launcher.ViewModels;

namespace FUT18Launcher.Views;

public partial class CreateClubView : UserControl
{
    public CreateClubView()
    {
        InitializeComponent();

        DataContext = new CreateClubViewModel();
    }
}
