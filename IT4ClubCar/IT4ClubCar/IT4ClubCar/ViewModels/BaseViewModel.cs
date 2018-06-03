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

        public event PropertyChangedEventHandler PropertyChanged;



        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }



        public void OnPropertyChanged(string propriedadeNome)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propriedadeNome));
        }



    }
}
