using DataAccesLayer.Abstract;
using DataAccesLayer.Repostory;
using EntitiyLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntitiyFreamwork
{
    public class EfExperienceDal:GenericRepostory<Experience>, İExperienceDal
    {
    }
}
