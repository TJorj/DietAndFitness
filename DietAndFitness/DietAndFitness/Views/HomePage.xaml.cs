﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DietAndFitness.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : MasterDetailPage
    {
        public HomePage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomePageMenuItem;
            if (item == null)
                return;
            IsPresented = false;
            MasterPage.ListView.SelectedItem = null;
            await Task.Run(() =>
            {
                var page = (Page)Activator.CreateInstance(item.TargetType);
                page.Title = item.Title;
                var navigationPage = Detail as NavigationPage;
                Device.BeginInvokeOnMainThread(async () =>
                {
                    navigationPage.Navigation.InsertPageBefore(page, navigationPage.RootPage);
                    await navigationPage.PopToRootAsync();
                });
                
            });
        }


    }
}