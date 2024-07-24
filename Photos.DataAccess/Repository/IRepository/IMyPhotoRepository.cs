﻿using Photos.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photos.DataAccess.Repository.IRepository
{
    public interface IMyPhotoRepository : IRepository<MyPhoto>
    {
        void Update(MyPhoto obj);
    }   
}
