using BussinesLayer.Abstract;
using DataAccesLayer.Abstract;
using EntitiyLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrate
{
    public class PortfolioManeger : İPortfolioService
    {
        İPortfolioDal _portfolioDal;

        public PortfolioManeger(İPortfolioDal portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TADD(Portfolio t)
        {
            _portfolioDal.İnsert(t);
        }

        public void TDelete(Portfolio t)
        {
            _portfolioDal.Delete(t);    
        }

        public Portfolio TGetByID(int id)
        {
            return _portfolioDal.GetByID(id);   
        }

        public List<Portfolio> TGetList()
        {
            return _portfolioDal.GetList(); 
        }

        public void TUpdate(Portfolio t)
        {
            _portfolioDal.Update(t);    
        }
    }
}
