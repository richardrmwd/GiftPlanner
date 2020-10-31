using System;
using System.Collections.Generic;
using Gift_Planner.ViewModels;
using Gift_Planner.Views;
using Xamarin.Forms;

namespace Gift_Planner
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
