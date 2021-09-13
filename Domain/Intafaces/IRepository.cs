using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Intafaces
{
   public  interface IRepository<T>
    {
        List<T> ListarAll();
        T RetornoPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
