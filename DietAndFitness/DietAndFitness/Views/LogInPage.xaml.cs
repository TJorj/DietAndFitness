﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DietAndFitness
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
            if(Device.RuntimePlatform.Equals(Device.Android))
            {
                ProfilePicker.WidthRequest = 75;
            }
        }

        async void OnCreateProfileButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserDataPage());
        }

    }
}