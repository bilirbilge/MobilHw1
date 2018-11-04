using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace hw1ceng
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Altyapı : ContentPage
    {


        public Altyapı()
        {
            InitializeComponent();
            var listView = new ListView();
            listView.ItemsSource = new string[]
            {
  "Derslik-B1",
  "Derslik-B2",
  "Derslik-B3",
  "Derslik-B4",
  "Derslik-B5",
  "Derslik-B6",
  "Derslik-B4",
  "Lab-01",
  "Lab-02"
            };
        }


    }
}

    

