using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
   public class Series : BaseEntity
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
    

        public Series(int id, Genero genero, string titulo, string descricao, int ano) : base(id)
        {
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
         
        }
        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine($"Genero: {this.Genero}");
            retorno.AppendLine($"Titulo: {this.Titulo}");
            retorno.AppendLine($"Descricao: {this.Descricao}");
            retorno.AppendLine($"Ano de Início: {this.Ano}");
            retorno.AppendLine($"Excluido {this.Excluido}");
            return retorno.ToString();
        }
        public string retornaTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
      
    }
}
