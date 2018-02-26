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
	public partial class FoodListPage : ContentPage
	{
		public FoodListPage ()
		{
			InitializeComponent ();
		}

        async private void AddFoodItemButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddFoodItemPage());
        }
    }
}