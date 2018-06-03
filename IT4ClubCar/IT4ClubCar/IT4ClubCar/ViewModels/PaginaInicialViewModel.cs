using CommonServiceLocator;
using IT4ClubCar.IT4ClubCar.Interfaces;
using IT4ClubCar.IT4ClubCar.Views;
using IT4ClubCar_IT4ClubCar_ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security;
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



        public PaginaInicialViewModel(INavigationService navigationService, IDialogService dialogService) : base(navigationService,dialogService)
        {
            Inicializar();
        }



        /// <summary>
        /// Executa os métodos necessários tendo em conta se é a primeira vez que a aplicação é executada ou não.
        /// </summary>
        private async void Inicializar()
        {
            PrepararPastaPrograma();
            await base.DialogService.MostrarMensagem("HIIIIII","Titulo");
        }



        /// <summary>
        /// Verifica se é a primeira vez que a aplicação é executada. Se for
        /// cria a pasta do programa no armazenamento interno, populando-a com
        /// o ficheiro da BD.
        /// </summary>
        private void PrepararPastaPrograma()
        {
            //Verificar se é a primeira vez que a aplicação é executada. Verifica-se a pasta já foi criada.
            if(!DependencyService.Get<IPastaProgramaService>().VerificarSePastaJaFoiCriada())
            {
                //É a primeira vez que a aplicação é executada. A pasta ainda não foi criada. Cria-se a pasta.
                try
                {
                    DependencyService.Get<IPastaProgramaService>().CriarPasta();
                    DependencyService.Get<IPastaProgramaService>().CriarFicheiroBD();
                }
                catch(SecurityException e)
                {
                    //base.DialogService.MostrarMensagem("HELLO THERE","Titulo");
                }
            }
        }



    }
}
