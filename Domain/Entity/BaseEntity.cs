using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
     public abstract class BaseEntity 
    {
        protected int Id { get; set; }
        protected bool Excluido { get; set; }
        public BaseEntity(int id)
        {
            this.Id = id;
            this.Excluido = false;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
}
