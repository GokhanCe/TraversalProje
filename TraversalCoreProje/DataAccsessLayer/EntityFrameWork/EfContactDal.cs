﻿using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.EntityFrameWork
{
    internal class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}
