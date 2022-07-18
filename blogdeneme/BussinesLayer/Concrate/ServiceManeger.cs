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
    public class ServiceManeger : İServiceService
    {
        İServiceDal _serviceDal;

        public ServiceManeger(İServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TADD(Service t)
        {
            _serviceDal.İnsert(t);
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service TGetByID(int id)
        {
          return _serviceDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList(); 
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);  
        }
    }
}
