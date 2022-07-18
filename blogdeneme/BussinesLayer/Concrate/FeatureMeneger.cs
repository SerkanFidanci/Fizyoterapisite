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
    public class FeatureMeneger : İGenericService<Feature>
    {
        İFeatureDal _featureDal;

        public FeatureMeneger(İFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TADD(Feature t)
        {
            _featureDal.İnsert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t); 
        }

        public Feature TGetByID(int id)
        {
           return _featureDal.GetByID(id); 
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();   
        }

        public void TUpdate(Feature t)
        {
           _featureDal.Update(t);   
        }
    }
}
