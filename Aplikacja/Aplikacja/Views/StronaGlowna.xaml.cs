using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StronaGlowna : TabbedPage
    {
        public StronaGlowna()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            wyswietl();
        }
        void wyswietl()
        {
            List<Wydatek> tmp = new List<Wydatek>();

            for (int i = 0; i < App.Database.GetAll().Result.Count; i++)
            {
                bool istnieje = false;
                for (int j = 0; j < tmp.Count; j++)
                {
                    if (App.Database.GetAll().Result[i].Data == tmp[j].Data)
                    {
                        istnieje = true;
                    }

                }
                if (!istnieje)
                {
                    tmp.Add(App.Database.GetAll().Result[i]);
                }
            }

            Lista.ItemsSource = tmp;
        }
        public async void Add(object s, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Nazwa.Text))
            {
                await App.Database.Add(new Wydatek() { Data = Data.Date, Nazwa = "Brak tytulu", Kwota = decimal.Parse(Kwota.Text) });
            }
            else
            {
                await App.Database.Add(new Wydatek() { Data = Data.Date, Nazwa = Nazwa.Text, Kwota = decimal.Parse(Kwota.Text) });
            }
            wyswietl();
        }
        public async void Szczegoly(object s, EventArgs e)
        {

            await Navigation.PushAsync(new Szczegoly((Lista.SelectedItem as Wydatek).Data));

        }
    }
}