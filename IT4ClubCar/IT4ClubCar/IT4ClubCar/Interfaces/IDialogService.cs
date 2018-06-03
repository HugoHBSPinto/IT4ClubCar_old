using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IT4ClubCar.IT4ClubCar.Interfaces
{
    interface IDialogService
    {
        Task MostrarMensagem(string mensagemAMostrar, string titulo);
    }
}
