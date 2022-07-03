using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMIcalculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void calculator_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Calculator());
        }

        private void Calories_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Food());
        }

        private void Manual_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new HowTo());
        }

    }
}
