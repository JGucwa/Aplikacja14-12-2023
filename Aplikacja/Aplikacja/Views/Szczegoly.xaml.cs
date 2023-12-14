using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Szczegoly : ContentPage
    {
        public Szczegoly(DateTime date)
        {
            InitializeComponent();

            List<Wydatek> tmp = new List<Wydatek>();
            for(int  i = 0; i < App.Database.GetAll().Result.Count;i++)
            {
                if(App.Database.GetAll().Result[i].Data == date)
                {
                    tmp.Add(App.Database.GetAll().Result[i]);
                }
            }
            Lista.ItemsSource = tmp;
        }
    }
}