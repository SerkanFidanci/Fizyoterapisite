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
    public class AboutManeger : İAboutService
    {
        İAboutDal _aboutDal;

        public AboutManeger(İAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TADD(About t)
        {
            _aboutDal.İnsert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);    
        }

        public About TGetByID(int id)
        {
           return _aboutDal.GetByID(id);    
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList(); 
        }

        public void TUpdate(About t)
        {
             _aboutDal.Update(t);
        }
    }
}
