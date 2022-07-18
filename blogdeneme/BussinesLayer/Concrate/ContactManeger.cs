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
    public class ContactManeger : İContactService
    {
        İContactDal _icontactDal;

        public ContactManeger(İContactDal icontactDal)
        {
            _icontactDal = icontactDal;
        }

        public void TADD(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> TGetList()
        {
            return _icontactDal.GetList();  
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
