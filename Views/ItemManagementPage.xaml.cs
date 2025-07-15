using Microsoft.UI.Xaml.Controls;
using ntereksetims.ViewModels;

namespace ntereksetims.Views
{
    public sealed partial class ItemManagementPage : Page
    {
        public ItemManagementViewModel ViewModel
        {
            get;
        }

        public ItemManagementPage()
        {
            this.InitializeComponent(); // Hook up with XAML partial
            ViewModel = App.GetService<ItemManagementViewModel>();
        }
    }
}
