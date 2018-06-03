using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT4ClubCar_IT4ClubCar_Models
{
    class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;



        public BaseModel()
        {

        }



        public void OnPropertyChanged(string propriedadeNome)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propriedadeNome));
        }



    }
}
