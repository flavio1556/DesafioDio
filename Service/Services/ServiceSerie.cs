using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Domain.Intafaces;
using Domain.Intafaces.Serie;
namespace Service.Services
{
   public class  ServiceSerie : ISerieService
    {
        private IRepository<Series> _repository;
        public ServiceSerie()
        {
            _repository = new Domain.Repository.IRepository<Series>();
        }
        public void AtualizacaoSerie(int id, Series entidade)
        {
             _repository.Atualiza(id, entidade);
        }

        public List<Series> ConsultaCompleta()
        {
            return _repository.ListarAll();
        }

        public int ConsultaProximo()
        {
            return _repository.ProximoId();
        }

        public void ExcluiSerie(int id)
        {
            _repository.Exclui(id);
        }

        public void InclusaoSerie(Series entidade)
        {
            _repository.Insere(entidade);
        }

        public Series SerieID(int id)
        {
           return  _repository.RetornoPorId(id);
        }
    }
}
