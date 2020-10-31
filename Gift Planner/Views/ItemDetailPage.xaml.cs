using System.ComponentModel;
using Xamarin.Forms;
using Gift_Planner.ViewModels;

namespace Gift_Planner.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}