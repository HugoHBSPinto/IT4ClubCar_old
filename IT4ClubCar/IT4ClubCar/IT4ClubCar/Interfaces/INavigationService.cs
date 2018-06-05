using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IT4ClubCar.IT4ClubCar.Interfaces
{
    interface INavigationService
    {
        Task NavegarParaPaginaInicial();

        Task NavegarParaPaginaConfigurarJogo();

        Task NavegarParaPaginaConfiguracaoJogador();
    }
}
