using Microsoft.UI.Xaml.Controls;

using ntereksetims.ViewModels;

namespace ntereksetims.Views;

public sealed partial class SalesManagementPage : Page
{
    public SalesManagementViewModel ViewModel
    {
        get;
    }

    public SalesManagementPage()
    {
        ViewModel = App.GetService<SalesManagementViewModel>();
        InitializeComponent();
    }
}
