using LuckyPOC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LuckyPOC
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void MapButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MapPage());
        }

        async void CadastrarButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterAnimalPage());
        }

        private void listAnimalsButton_Clicked(object sender, EventArgs e)
        {
            List<Animal> animal = App.AnimalRepo.GetAllAnimals();
            animalsList.ItemsSource = animal;
        }
    }
}
