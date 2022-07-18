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
    public class ExperienceManeger : İExperienceService
    {
        İExperienceDal _experienceDal;

        public ExperienceManeger(İExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TADD(Experience t)
        {
            _experienceDal.İnsert(t);
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);   
        }

        public Experience TGetByID(int id)
        {
            return _experienceDal.GetByID(id);      
        }

        public List<Experience> TGetList()
        {
           return _experienceDal.GetList(); 
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);   
        }
    }
}
