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
    public partial class Food : ContentPage
    {
        public IList<Hrana> Hranas { get; set; }
        public Food()
        {
            InitializeComponent();
            
        }
        public class Hrana
        {
            public string Food { get; set; }
            public string Serving { get; set; }
            public string Calories { get; set; }
        }

        private void Voće_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = null;
            trenutna.Text = "VOĆE";
            Hranas = new List<Hrana>();
            Hranas.Add(new Hrana
            {
                Food = "Jabuka",
                Serving = "1",
                Calories = "59"
            });
            Hranas.Add(new Hrana
            {
                Food = "Banana",
                Serving = "1",
                Calories = "151"
            });
            Hranas.Add(new Hrana
            {
                Food = "Grožđe",
                Serving = "1",
                Calories = "100"
            });
            Hranas.Add(new Hrana
            {
                Food = "Narandža",
                Serving = "1",
                Calories = "53"
            });
            Hranas.Add(new Hrana
            {
                Food = "Kruška",
                Serving = "1",
                Calories = "82"
            });
            Hranas.Add(new Hrana
            {
                Food = "Breskva",
                Serving = "1",
                Calories = "67"
            });
            Hranas.Add(new Hrana
            {
                Food = "Ananas",
                Serving = "1",
                Calories = "82"
            });
            Hranas.Add(new Hrana
            {
                Food = "Jagoda",
                Serving = "1 čaša",
                Calories = "53"
            });
            Hranas.Add(new Hrana
            {
                Food = "Lubenica",
                Serving = "1 čaša",
                Calories = "50"
            });
            BindingContext = this;
           
        }

        private void Povrce_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = null;
            trenutna.Text = "POVRĆE";
            Hranas = new List<Hrana>();
            Hranas.Add(new Hrana
            {
                Food = "Asparagus",
                Serving = "1 čaša",
                Calories = "27"
            });
            Hranas.Add(new Hrana
            {
                Food = "Brokula",
                Serving = "1 čaša",
                Calories = "45"
            });
            Hranas.Add(new Hrana
            {
                Food = "Mrkva",
                Serving = "1 čaša",
                Calories = "50"
            });
            Hranas.Add(new Hrana
            {
                Food = "Krastavac",
                Serving = "113 grama",
                Calories = "17"
            });
            Hranas.Add(new Hrana
            {
                Food = "Patlidžan",
                Serving = "1 čaša",
                Calories = "35"
            });
            Hranas.Add(new Hrana
            {
                Food = "salata",
                Serving = "1 čaša",
                Calories = "5"
            });
            Hranas.Add(new Hrana
            {
                Food = "Paradajz",
                Serving = "1 čaša",
                Calories = "22"
            });
            BindingContext = this;
        }

        private void Proteini_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = null;
            trenutna.Text = "PROTEINI";
            Hranas = new List<Hrana>();
            Hranas.Add(new Hrana
            {
                Food = "Govedina, regularna, kuhana",
                Serving = "56 grama",
                Calories = "142"
            });
            Hranas.Add(new Hrana
            {
                Food = "Piletina, kuhana",
                Serving = "56 grama",
                Calories = "136"
            });
            Hranas.Add(new Hrana
            {
                Food = "Tofu",
                Serving = "113 grama",
                Calories = "86"
            });
            Hranas.Add(new Hrana
            {
                Food = "Jaje",
                Serving = "1",
                Calories = "78"
            });
            Hranas.Add(new Hrana
            {
                Food = "Riba, kuhana",
                Serving = "56 grama",
                Calories = "136"
            });
            Hranas.Add(new Hrana
            {
                Food = "Svinjetina, kuhana",
                Serving = "56 grama",
                Calories = "137"
            });
            Hranas.Add(new Hrana
            {
                Food = "Škampi",
                Serving = "56 grama",
                Calories = "56"
            });
            BindingContext = this;

        }


        private void Pice_Clicked(object sender, EventArgs e)
        {
            this.BindingContext = null;
            trenutna.Text = "PIĆE/BEVERAGES/DAIRY";
            Hranas = new List<Hrana>();
            Hranas.Add(new Hrana
            {
                Food = "Piva",
                Serving = "1 limenka",
                Calories = "154"
            });
            Hranas.Add(new Hrana
            {
                Food = "Coca-Cola",
                Serving = "1 limenka",
                Calories = "150"
            });
            Hranas.Add(new Hrana
            {
                Food = "Coca-Cola Zero",
                Serving = "1 limenka",
                Calories = "0"
            });
            Hranas.Add(new Hrana
            {
                Food = "Mlijeko 1%",
                Serving = "1 čaša",
                Calories = "102"
            });
            Hranas.Add(new Hrana
            {
                Food = "Mlijeko 2%",
                Serving = "1 čaša",
                Calories = "122"
            });
            Hranas.Add(new Hrana
            {
                Food = "Mlijeko",
                Serving = "1 čaša",
                Calories = "146"
            });
            Hranas.Add(new Hrana
            {
                Food = "Sok od narandže",
                Serving = "1 čaša",
                Calories = "111"
            });
            Hranas.Add(new Hrana
            {
                Food = "Sok od jabuke",
                Serving = "1 čaša",
                Calories = "117"
            });
            Hranas.Add(new Hrana
            {
                Food = "Jogurt(low-fat)",
                Serving = "1 čaša",
                Calories = "154"
            });
            Hranas.Add(new Hrana
            {
                Food = "Jogurt(low-fat)",
                Serving = "1 čaša",
                Calories = "110"
            });
            BindingContext = this;
        }

        private void Nazad_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}