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
    public partial class Calculator : ContentPage
    {
        public Calculator()
        {
            InitializeComponent();
        }
        double bmi = 0.0;
        double bmr = 0.0;
        private async void BMI_Clicked(object sender, EventArgs e)
        {
            
            if (Age.Text == null || Height.Text == null || Weight.Text == null)
            {
                await DisplayAlert("Pažnja", "Molimo unesite potrebne podatke", "OK");
            }
            else {
                double age = double.Parse(Age.Text);
                double height = int.Parse(Height.Text);
                double weight = double.Parse(Weight.Text);
                Console.WriteLine(age);
                Console.WriteLine(height);
                Console.WriteLine(weight);
                double heightM = height / 100;
                

                bmi = (weight) / (heightM * heightM);
                bmi = Math.Round(bmi, 2);
                bmr = 447.593 +(9.247 * weight) + (3.098 * height) - (4.330 * age);
                Console.WriteLine(bmi);
                pointer.Value = bmi;
                labelBMI.Text = "Vaš BMI je: " + bmi;
                if (bmi < 18.5)
                {
                    description.Text = "Vaš BMI spada u klasu: Underweight";
                }
                else if (bmi >= 18.5 && bmi < 25)
                {
                    description.Text = "Vaš BMI spada u klasu: Normal weight";
                }
                else if (bmi >= 25 && bmi < 30)
                {
                    description.Text = "Vaš BMI spada u klasu: Overweight";
                }
                else if (bmi >= 30 && bmi < 35)
                {
                    description.Text = "Vaš BMI spada u klasu: Obesity class I";
                }
                else if (bmi >= 35 && bmi < 40)
                {
                    description.Text = "Vaš BMI spada u klasu: Obesity class II";
                }
                else
                {
                    description.Text = "Vaš BMI spada u klasu: Obesity class III";
                }
            }
            
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            pointer.Value = 0;
            Age.Text = null;
            Height.Text = null;
            Weight.Text = null;
            labelBMI.Text = null;
            description.Text = null;
            bmi = 0.0;
        }

        private async void Calories_Clicked(object sender, EventArgs e)
        {
            if(bmi == 0.0)
            {
                await DisplayAlert("Pažnja", "Molimo vas da izračunate BMI prvo", "OK");
            }
            else
            {
                await Navigation.PushModalAsync(new Calories(bmr, bmi));
            }
            
        }

        private void Nazad_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}