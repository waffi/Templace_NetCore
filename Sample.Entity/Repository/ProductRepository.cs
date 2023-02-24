﻿using Sample.Entity.Models;
using Sample.Entity.RepositoryContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Entity.Repository
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext repositoryContext)
            : base(repositoryContext)
        {
        }
    }
}
