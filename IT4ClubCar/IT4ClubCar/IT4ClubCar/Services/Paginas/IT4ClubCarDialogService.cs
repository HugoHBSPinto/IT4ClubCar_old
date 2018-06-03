using IT4ClubCar.IT4ClubCar.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IT4ClubCar.IT4ClubCar.Services.Paginas
{
    class IT4ClubCarDialogService : IDialogService
    {
        public async Task MostrarMensagem(string mensagemAMostrar,string titulo)
        {
            if(Application.Current.MainPage != null)
                await Application.Current.MainPage.DisplayAlert("Aviso", mensagemAMostrar, "Cancel");
        }
    }
}
