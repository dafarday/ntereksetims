using Microsoft.UI.Xaml.Controls;

using ntereksetims.ViewModels;

namespace ntereksetims.Views;

public sealed partial class EnvironmentPage : Page
{
    public EnvironmentViewModel ViewModel
    {
        get;
    }

    public EnvironmentPage()
    {
        ViewModel = App.GetService<EnvironmentViewModel>();
        InitializeComponent();
    }
}
