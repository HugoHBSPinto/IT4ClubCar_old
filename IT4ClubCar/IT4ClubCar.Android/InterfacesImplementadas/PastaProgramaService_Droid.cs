using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using IT4ClubCar.Droid.InterfacesImplementadas;
using IT4ClubCar.IT4ClubCar.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(PastaProgramaService_Droid))]
namespace IT4ClubCar.Droid.InterfacesImplementadas
{
    class PastaProgramaService_Droid : IPastaProgramaService
    {
        /// <summary>
        /// Obtém o caminho para a pasta no armazenamento interno.
        /// </summary>
        /// <value>
        /// O caminho para a pasta.
        /// </value>
        public string CaminhoParaPasta
        {
            get
            {
                return Path.Combine(global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath.ToString(), "IT4ClubCar/");
            }
        }



        /// <summary>
        /// Verifica se a pasta já foi criada.
        /// </summary>
        /// <returns>
        /// True se a pasta já existir, false se não existir.
        /// </returns>
        public bool VerificarSePastaJaFoiCriada()
        {
            return Directory.Exists(CaminhoParaPasta);
        }



        /// <summary>
        /// Cria a pasta do programa no armazenamento interno, no caminho definido
        /// pela Propriedade CaminhoParaPasta.
        /// </summary>
        public void CriarPasta()
        {
            Directory.CreateDirectory(CaminhoParaPasta);
        }



        /// <summary>
        /// Cria o ficheiro para a BD na localização definida pela Propriedadde CaminhoParaPasta e
        /// com o nome IT4ClubCarSQLite.db3.
        /// </summary>
        public void CriarFicheiroBD()
        {
            string caminhoOndeCriarFicheiro = CaminhoParaPasta + "IT4ClubCarSQLite.db3";
            File.Create(caminhoOndeCriarFicheiro);
        }



    }
}