using LuckyPOC.Repositories;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace LuckyPOC
{
	public partial class App : Application
	{
        public static AnimalRepository AnimalRepo { get; private set; }

        public App (string dbPath)
		{
			InitializeComponent();

            AnimalRepo = new AnimalRepository(dbPath);

            MainPage = new NavigationPage(new MainPage());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
