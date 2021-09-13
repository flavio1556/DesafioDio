using Domain.Entity;
using Domain.Intafaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Domain.Repository
{
    public class IRepository<T> : Intafaces.IRepository<T> where T : BaseEntity         
    {
        List<T> Lista = new List<T>();
        public void Atualiza(int id, T entidade)
        {
            Lista[id] = entidade;
        }

        public void Exclui(int id)
        {
            Lista[id].Excluir();
        }

        public void Insere(T entidade)
        {
            Lista.Add(entidade);
        }

        public List<T> ListarAll()
        {
            return Lista;
        }

        public int ProximoId()
        {
            return Lista.Count();
        }

        public T RetornoPorId(int id)
        {
            return Lista[id];
        }
    }
}
