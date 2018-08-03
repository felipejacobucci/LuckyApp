using LuckyPOC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LuckyPOC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterAnimalPage : ContentPage
    {
        public RegisterAnimalPage()
        {
            InitializeComponent();

            LoadListView();
        }

        public void LoadListView()
        {
            typeListView.RowHeight = 20;

            typeListView.ItemsSource = new AnimalTypeItem[]
            {
                new AnimalTypeItem()
                {
                    Name = "Cachorro",
                    Type = AnimalType.Cachorro
                },
                new AnimalTypeItem()
                {
                    Name = "Gato",
                    Type = AnimalType.Gato
                },
                new AnimalTypeItem()
                {
                    Name = "Pássaro",
                    Type = AnimalType.Passaro
                },
                new AnimalTypeItem()
                {
                    Name = "Réptil",
                    Type = AnimalType.Reptil
                },
                new AnimalTypeItem()
                {
                    Name = "Roedor",
                    Type = AnimalType.Roedor
                }
            };

            typeListView.ItemTemplate = new DataTemplate(typeof(TextCell));
            typeListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Name");

            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.EndAndExpand,
            //    Children = { listView }
            //};
        }

        async void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                    "Salvar cadastro",
                    "Gostaria de salvar seu cadastro?",
                    "Sim",
                    "Não"))
            {

                Animal animal = new Animal();
                animal.Description = descriptionText.Text;
                animal.CreateDate = DateTime.Now;

                AnimalTypeItem animalType = (AnimalTypeItem)typeListView.SelectedItem;
                animal.AnimalTypeId = (int)animalType.Type;

                App.AnimalRepo.AddNewAnimal(animal);

                await Navigation.PushAsync(new MainPage());
            }
        }

    }
}