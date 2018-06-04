using IT4ClubCar.IT4ClubCar.Models;
using IT4ClubCar_IT4ClubCar_ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT4ClubCar.IT4ClubCar.ViewModels
{
    class JogadorViewModel : BaseViewModel
    {
        private JogadorModel _jogadorModel;

        /// <summary>
        /// Obtém id do jogador.
        /// </summary>
        public int Id
        {
            get
            {
                return _jogadorModel.Id;
            }
        }
        
        /// <summary>
        /// Obtém ou define o nome do jogador.
        /// </summary>
        public string Nome
        {
            get
            {
                return _jogadorModel.Nome;
            }
            set
            {
                _jogadorModel.Nome = value;
                OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Obtém ou define a idade do jogador.
        /// </summary>
        public int Idade
        {
            get
            {
                return _jogadorModel.Idade;
            }
            set
            {
                _jogadorModel.Idade = value;
                OnPropertyChanged("Idade");
            }
        }

        /// <summary>
        /// Obtém o valor do jogador.
        /// </summary>
        public bool Ativo
        {
            get
            {
                return _jogadorModel.Ativo;
            }
        }


        public JogadorViewModel(JogadorModel jogadorModel) : base()
        {
            _jogadorModel = jogadorModel;
        }



    }
}
