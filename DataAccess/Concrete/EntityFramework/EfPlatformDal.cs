﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPlatformDal : EfEntityRepositoryBase<Platform, TargeContext>, IPlatformDal
    {
        public string AddGuide()
        {
            return "eklendi";
        }
    }
}
