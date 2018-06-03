using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT4ClubCar_IT4ClubCar_Helpers
{
    class MultiDicionario<TKey,TValue> : Dictionary<TKey,List<TValue>>
    {
        //Quando se atribui um valor a uma chave vamos verificar se a chave
        //já foi criada. Se não tiver sido, criamos uma chave desse tipo e inicializamos essa lista
        //Se já tiver sido iniciada mas nenhum valor tiver sido atribuído temos também de inicializar a lista
        private void VerificarChave(TKey key)
        {
            if(ContainsKey(key))
            {
                //se ainda não tiver sido usado, o tvalue ainda não foi inicializado
                //verificar se já foi usado, se não inicializar o tvalue (que é uma lista)
                if (this[key] == null) this[key] = new List<TValue>();
            }
            else
            {
                this[key] = new List<TValue>(1);
            }
        }

        //Adicionar valor ou valores

        public void AdicionarValor(TKey key, TValue valor)
        {
            VerificarChave(key);
            this[key].Add(valor);
        }

        public void AdicionarValores(TKey key, IEnumerable<TValue> valores)
        {
            VerificarChave(key);
            this[key].AddRange(valores);
        }

        //Remover valor ou valores

        public void RemoverValor(TKey key, TValue valor)
        {
            //Verificar se chave passada como parâmetro existe
            if(ContainsKey(key))
            {
                this[key].Remove(valor);
            }
        }

        //O parâmetro de valores tem de ser do tipo Predicate porque o método RemoveAll aceita um
        //parâmetro desse tipo
        public void RemoverValores(TKey key, Predicate<TValue> valores)
        {
            //Verificar se chave passada como parâmetro existe
            if (ContainsKey(key))
            {
                this[key].RemoveAll(valores);
            }
        }
    }
}
