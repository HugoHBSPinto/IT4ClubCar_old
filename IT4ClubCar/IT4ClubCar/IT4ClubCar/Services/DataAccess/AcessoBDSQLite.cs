using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace IT4ClubCar.IT4ClubCar.Services.DataAccess
{
    class AcessoBDSQLite
    {
        /// <summary>
        /// Representa a ligação à BD. É utilizada para executar
        /// todas as operações na BD.
        /// </summary>
        public SQLiteConnection Conexao { get; set; }

        /// <summary>
        /// Contém o caminho para o ficheiro sqlite da BD, sendo utilizado quando
        /// se abre uma ligação.
        /// </summary>
        public string CaminhoParaFicheiroBD { get; set; }



        /// <summary>
        /// Construtor para a classe LocalDatabase.
        /// </summary>
        /// <param name="caminhoParaFicheiroBD">Caminho para o ficheiro db3 com a BD.</param>
        public AcessoBDSQLite(string caminhoParaFicheiroBD)
        {
            CaminhoParaFicheiroBD = caminhoParaFicheiroBD;
        }



        /// <summary>
        /// Cria uma nova instância de SQLiConnectin com os dados da propriedade Conexao.
        /// </summary>
        /// <returns>Devolve uma SQLiteConnection aberta para a BD representaada pela propriedade Conexao.</returns>
        public SQLiteConnection AbrirLigacao()
        {
            return new SQLiteConnection(CaminhoParaFicheiroBD);
        }



    }
}
