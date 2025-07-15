using Microsoft.UI.Xaml.Controls;

using ntereksetims.ViewModels;

namespace ntereksetims.Views;

public sealed partial class StockManagementPage : Page
{
    public StockManagementViewModel ViewModel
    {
        get;
    }

    public StockManagementPage()
    {
        ViewModel = App.GetService<StockManagementViewModel>();
        InitializeComponent();
    }
}
