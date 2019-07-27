﻿using ClothBazar.Database;
using ClothBazar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
    public class CatagoriesServices
    {
        public void SaveCatagory(Catagory catagory) {
            using (var context = new CBContext()) {
                context.catagories.Add(catagory);
                context.SaveChanges();
            } 
        }
    }
}
