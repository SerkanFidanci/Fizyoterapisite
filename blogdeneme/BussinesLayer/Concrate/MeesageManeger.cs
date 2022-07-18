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
    public class MeesageManeger : İMessageService
    {
        İMessageDal _messageDal;

        public MeesageManeger(İMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TADD(Message t)
        {
            _messageDal.İnsert(t);
        }

        public void TDelete(Message t)
        {
            throw new NotImplementedException();
        }

        public Message TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
