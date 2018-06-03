using System;
using System.Collections.Generic;
using System.Text;

namespace IT4ClubCar.IT4ClubCar.Interfaces
{
    /// <summary>
    /// Interface que fornece métodos para manipular a pasta do programa, bem como o seu conteúdo, no armazenamento interno.
    /// </summary>
    public interface IPastaProgramaService
    {
        /// <summary>
        /// Caminho para pasta no armazenamento interno na pasta dos documentos.
        /// </summary>
        string CaminhoParaPasta { get; }



        /// <summary>
        /// Verifica se a pasta já foi criada no armazenamento interno.
        /// </summary>
        /// <returns>True se a pasta já existir, false se não existir.</returns>
        bool VerificarSePastaJaFoiCriada();



        /// <summary>
        /// Cria a pasta do programa no caminho indicado pela propriedade CaminhoParaPasta.
        /// </summary>
        /// <exception cref="SecurityException">Throw quando o utilizador não tem permissões de escrita no tablet.</exception>
        void CriarPasta();



        /// <summary>
        /// Cria na pasta do program, o ficheiro SQLite.
        /// </summary>
        /// <exception cref="SecurityException">Throw quando o utilizador não tem permissões de escrita no tablet.</exception>
        void CriarFicheiroBD();
    }
}
