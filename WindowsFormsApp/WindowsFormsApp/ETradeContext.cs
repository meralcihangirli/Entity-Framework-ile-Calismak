﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp
{
    public class ETradeContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }

}
