using IT4ClubCar.IT4ClubCar.Interfaces;
using IT4ClubCar.IT4ClubCar.Services.ArmazenamentoInterno;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(PastaProgramaService_Droid))]
namespace IT4ClubCar.IT4ClubCar.Services.ArmazenamentoInterno
{
    class PastaProgramaService_Droid : IPastaProgramaService
    {
        public string CaminhoParaPasta
        {
            get
            {
                return Path.Combine(global::Android.OS.Environment.ExternalStorageDirectory.AbsolutePath.ToString(), "IT4ClubCar/");
            }
        }

        

        public bool VerificarSePastaJaFoiCriada()
        {
            return Directory.Exists(CaminhoParaPasta);
        }



        public void CriarPasta()
        {
            Directory.CreateDirectory(CaminhoParaPasta);
        }



        public void CriarFicheiroBD()
        {
            string caminhoOndeCriarFicheiro = CaminhoParaPasta + "IT4ClubCarSQLite.db3";
            File.Create(caminhoOndeCriarFicheiro);
        }



    }
}
