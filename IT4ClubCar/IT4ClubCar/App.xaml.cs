using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Unity;
using IT4ClubCar.IT4ClubCar.Interfaces;
using IT4ClubCar.IT4ClubCar.Services.MudarPaginas;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace IT4ClubCar
{
	public partial class App : Application
	{
        /// <summary>
        /// Propriedade est�tica para poder ser utilizada por todas as classes que usem dependency injection.
        /// </summary>
        public static UnityContainer Container { get; set; }



		public App ()
		{
			InitializeComponent();

            Container = new UnityContainer();
            Container.RegisterType<INavigationService, IT4ClubCarNavigationService>();

			MainPage = new MainPage();
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
