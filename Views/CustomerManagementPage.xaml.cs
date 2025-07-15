using Microsoft.UI.Xaml.Controls;

using ntereksetims.ViewModels;

namespace ntereksetims.Views;

public sealed partial class CustomerManagementPage : Page
{
    public CustomerManagementViewModel ViewModel
    {
        get;
    }

    public CustomerManagementPage()
    {
        ViewModel = App.GetService<CustomerManagementViewModel>();
        InitializeComponent();
    }
}
