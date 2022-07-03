using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIcalculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calories : ContentPage
    {
       
        double BMRnew;
        double _bmr;
        double _bmi;
        public Calories(double bmr, double bmi)
        {
            InitializeComponent();
            _bmr = bmr;
            _bmi = bmi;
            BMI.Text = bmi.ToString();
            BMR.Text = bmr.ToString();
            
           //Console.WriteLine(age);
        }

        private async void Calculate_Clicked(object sender, EventArgs e)
        {
            if(picker.SelectedItem == null)
            {
                await DisplayAlert("Pažnja", "Molimo vas odaberite aktivnost", "OK");
            }
            else
            {
                string exercise = picker.SelectedItem.ToString();
                switch (exercise)
                {
                    case ("Malo ili nimalo vježbanja"):
                        BMRnew = _bmr * 1.2;
                        activityBMR.Text = ((float)BMRnew).ToString();
                        show.IsVisible = true;
                        frameshow.BackgroundColor = Color.LightPink;
                        frameshow.HasShadow = true;
                        break;

                    case ("Lagana tjelovježba / sport 1-3 dana u sedmici"):
                        BMRnew = _bmr * 1.375;
                        activityBMR.Text = ((float)BMRnew).ToString();
                        show.IsVisible = true;
                        frameshow.BackgroundColor = Color.LightPink;
                        frameshow.HasShadow = true;
                        break;

                    case ("Umjerena tjelovježba / sport 3-5 dana u sedmici"):
                        BMRnew = _bmr * 1.55;
                        activityBMR.Text = ((float)BMRnew).ToString();
                        show.IsVisible = true;
                        frameshow.BackgroundColor = Color.LightPink;
                        frameshow.HasShadow = true;
                        break;

                    case ("Žestoko vježbanje / sport 6-7 dana u sedmici"):
                        BMRnew = _bmr * 1.725;
                        activityBMR.Text = ((float)BMRnew).ToString();
                        show.IsVisible = true;
                        frameshow.BackgroundColor = Color.LightPink;
                        frameshow.HasShadow = true;
                        break;

                    case ("vrlo teška vježba / sportski i fizički posao ili 2x trening"):
                        BMRnew = _bmr * 1.9;
                        activityBMR.Text = ((float)BMRnew).ToString();
                        show.IsVisible = true;
                        frameshow.BackgroundColor = Color.LightPink;
                        frameshow.HasShadow = true;
                        break;
                }
            }
            
            
        }

        private void Food_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Food());
        }
    }
}