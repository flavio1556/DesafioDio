using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Intafaces.Serie
{
   public interface ISerieService
    {
        List<Series> ConsultaCompleta();
        Series SerieID(int id);
        void InclusaoSerie(Series entidade);
        void ExcluiSerie(int id);
        void AtualizacaoSerie(int id, Series entidade);
        int ConsultaProximo();
    }
}
