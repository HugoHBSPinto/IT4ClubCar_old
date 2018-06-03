using IT4ClubCar.IT4ClubCar.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IT4ClubCar.IT4ClubCar.Services.MudarPaginas
{
    class IT4ClubCarNavigation : INavigationService
    {
        public async Task NavegarParaPaginaInicial()
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new PaginaInicialView());
        }

        public async Task NavegarParaPaginaConfigurarJogo()
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new ConfigurarJogoView());
        }
    }
}
