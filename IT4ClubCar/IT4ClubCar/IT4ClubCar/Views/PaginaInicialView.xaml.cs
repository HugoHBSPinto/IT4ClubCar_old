using IT4ClubCar.IT4ClubCar.Interfaces;
using IT4ClubCar.IT4ClubCar.Services.MudarPaginas;
using IT4ClubCar.IT4ClubCar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IT4ClubCar.IT4ClubCar.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaginaInicialView : ContentPage
	{
		public PaginaInicialView ()
		{
			InitializeComponent ();
            BindingContext = new PaginaInicialViewModel(App.Container.Resolve(typeof(IT4ClubCarNavigationService), "_navigationService") as INavigationService);
        }
	}
}