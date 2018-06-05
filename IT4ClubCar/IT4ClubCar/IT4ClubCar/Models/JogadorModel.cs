using IT4ClubCar_IT4ClubCar_Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT4ClubCar.IT4ClubCar.Models
{
    [Table("JogadorModel")]
    class JogadorModel : BaseModel
    {
        /// <summary>
        /// Obtém ou define o id.
        /// </summary>
        [PrimaryKey, Column("Id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtém ou define o nome.
        /// </summary>
        [Column("Nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define a idade.
        /// </summary>
        [Column("Idade")]
        public int Idade { get; set; }

        /// <summary>
        /// Obtém ou define se o jogador está ativo.
        /// </summary>
        [Column("Ativo")]
        public bool Ativo { get; set; }



        public JogadorModel()
        {
            
        }



        public JogadorModel(int id,string nome, int idade, bool ativo)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Ativo = ativo;
        }



    }
}
