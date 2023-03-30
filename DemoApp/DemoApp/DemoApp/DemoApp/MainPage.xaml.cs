using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DemoApp;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace DemoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Initialize ListView
            List<ItemModel> items = new List<ItemModel>
            {
                new ItemModel { Name = "Book" },
                new ItemModel { Name = "Kindle" },
                new ItemModel { Name = "Table" },
                new ItemModel { Name = "Chair" },
                new ItemModel { Name = "Lamp" },
                new ItemModel { Name = "Pen" },
            };

            listView.ItemsSource = items;

            
        }
        

        // ButtonClicked Event
        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Button Clicked", "You clicked the button!", "OK");
        }

        // ComboBox SelectedIndexChanged Event
        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = picker.SelectedItem.ToString();
            DisplayAlert("Option Selected", $"You selected {selectedOption}", "OK");
        }
    }

    public class ItemModel
    {
        public string Name { get; set; }
    }
}


