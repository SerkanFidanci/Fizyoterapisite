﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repostory;
using EntitiyLayer.Concreate;

namespace DataAccesLayer.EntitiyFreamwork
{
    public class EfFeatureDal:GenericRepostory<Feature>, İFeatureDal
    {
    }
}