using IT4ClubCar.IT4ClubCar.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using SQLite;
using System.IO;
using IT4ClubCar.IT4ClubCar.Models;
using IT4ClubCar.IT4ClubCar.ViewModels;

namespace IT4ClubCar.IT4ClubCar.Services.DataAccess
{
    static class DataAccessBDInternaService
    {
        /// <summary>
        /// Propriedade utilizada para estabelecer ligação 
        /// à BD interna. Quando é definida utiliza como parâmetro
        /// para o construtor do AcessoBDInterna a propriedade CaminhoParaPasta+"IT4ClubCar" do
        /// PastaProgramaService.
        /// </summary>
        private static AcessoBDSQLite _acessoBD;
        public static AcessoBDSQLite AcessoBD
        {
            get
            {
                if (_acessoBD == null)
                    _acessoBD = new AcessoBDSQLite(Path.Combine(DependencyService.Get<IPastaProgramaService>().CaminhoParaPasta,"IT4ClubCarSQLite.db3"));

                return _acessoBD;
            }
        }


        #region Criação de BD.
        /// <summary>
        /// Cria a estrutura inicial da BD interna, populando a mesma com os dados iniciais.
        /// </summary>
        /// <exception cref="SQLiteException">Throw quando ocorre algum problema na BD.</exception>
        public static void InicializarBD()
        {
            ExecutarOperacao(() =>
            {
                CriarEstrutura();
                PopularBD();
            });
        }

        /// <summary>
        /// Cria as tabelas necessárias na BD.
        /// </summary>
        private static void CriarEstrutura()
        {
            AcessoBD.Conexao.CreateTable<JogadorModel>();
        }

        /// <summary>
        /// Popula a BD com os dados iniciais.
        /// </summary>
        private static void PopularBD()
        {
            //Jogadores.
            for (int i = 1; i <= 4; i++)
                AcessoBD.Conexao.Insert(new JogadorModel(i,"Indefinido",0,false));
        }
        #endregion



        #region Jogadores

        /// <summary>
        /// Obtém o primeiro jogador inativo. Se o jogador 1 já tiver sido definido, devolve o jogador 2. Se o 2 já tiver
        /// sido definido devolve o 3.
        /// </summary>
        /// <returns>JogadorViewModel que representa o jogador inativo.</returns>
        /// <exception cref="SQLiteException">Throw quando ocorre algum problema na BD.</exception>
        public static JogadorViewModel ObterJogadorInativo()
        {
            JogadorViewModel jogadorInativo = null;

            ExecutarOperacao(() =>
            {
                jogadorInativo = new JogadorViewModel(AcessoBD.Conexao.FindWithQuery<JogadorModel>("SELECT * FROM JogadorModel WHERE Ativo = 0;"));
                
            });

            return jogadorInativo;
        }

        #endregion


        /// <summary>
        ///  Executa um método na BD representada pela propriedade AcessoBD.
        ///  </summary>
        /// <param name="metodoAExecutar">The metodo a executar.</param>
        private static void ExecutarOperacao(Action metodoAExecutar)
        {
            try
            {
                using (AcessoBD.Conexao = AcessoBD.AbrirLigacao())
                {
                    metodoAExecutar();
                }
            }
            catch(SQLiteException e)
            {
                throw;
            }
        }



    }
}
