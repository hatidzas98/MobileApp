﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIcalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HowTo : ContentPage
    {
        public HowTo()
        {
            InitializeComponent();
        }

        private void Nazad_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}