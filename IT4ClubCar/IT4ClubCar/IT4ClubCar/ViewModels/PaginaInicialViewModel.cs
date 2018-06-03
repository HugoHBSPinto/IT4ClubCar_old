using IT4ClubCar.IT4ClubCar.Interfaces;
using IT4ClubCar.IT4ClubCar.Views;
using IT4ClubCar_IT4ClubCar_ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace IT4ClubCar.IT4ClubCar.ViewModels
{
    class PaginaInicialViewModel : BaseViewModel
    {
        /// <summary>
        /// Executado quando o utilizador clica no botão "Começar Jogo."
        /// Executa o método IrParaPaginaConfigurarJogo do IT4ClubCarNavgationService.
        /// </summary>
        private ICommand _irParaPaginaConfigurarJogo;
        public ICommand IrParaPaginaComConfigurarJogo
        {
            get
            {
                if (_irParaPaginaConfigurarJogo == null)
                    _irParaPaginaConfigurarJogo = new Command(p => base.NavigationService.NavegarParaPaginaConfigurarJogo(),p => { return true; });
                return _irParaPaginaConfigurarJogo;
            }
        }



        public PaginaInicialViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }



    }
}
