using Microsoft.UI.Xaml.Controls;

using ntereksetims.ViewModels;

namespace ntereksetims.Views;

public sealed partial class PurchaseManagementPage : Page
{
    public PurchaseManagementViewModel ViewModel
    {
        get;
    }

    public PurchaseManagementPage()
    {
        ViewModel = App.GetService<PurchaseManagementViewModel>();
        InitializeComponent();
    }
}
