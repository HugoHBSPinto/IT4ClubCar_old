using IT4ClubCar.IT4ClubCar.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Attributes;

namespace IT4ClubCar_IT4ClubCar_ViewModels
{
    /// <summary>
    /// Classe base para todos os viewmodels, implementa a interface INotifyPropertyChanged e contém
    /// uma instância do INavigationService, para permitir navegar entre as páginas.
    /// </summary>
    class BaseViewModel : INotifyPropertyChanged
    {
        //[Dependency] faz parte do Unity (biblioteca utilizada para IOC). Indica que é uma dependency property. Ou seja
        //vai obter o seu valor através de injection.

        
        [Dependency]
        public INavigationService NavigationService { get; set; }

        [Dependency]
        public IDialogService DialogService { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;



        /// <summary>
        /// Construtor para ViewModel relativo a uma página e não um model.
        /// É necessário passar instâncias do service de navegação e dialog.
        /// </summary>
        /// <param name="navigationService">Instância do serviço de navegegção para permitir ao viewmodel mudar de página.</param>
        /// <param name="dialogService">Instância do service de dialogs para permitir ao viewmodel msotrar pop ups / mensagens.</param>
        public BaseViewModel(INavigationService navigationService, IDialogService dialogService)
        {
            NavigationService = navigationService;
            DialogService = dialogService;
        }



        /// <summary>
        /// Construtor sem parâmetros para viewmodels que fazem wrap a models. Não necessita de instâncias do serviço de navegação
        /// e dialogs pois não serão usados.
        /// </summary>
        public BaseViewModel()
        {

        }



        public void OnPropertyChanged(string propriedadeNome)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propriedadeNome));
        }



    }
}
