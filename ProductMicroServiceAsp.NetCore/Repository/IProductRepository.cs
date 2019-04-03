﻿using ProductMicroServiceAsp.NetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMicroServiceAsp.NetCore.Repository
{
    interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int ProductId);

        void InsertProduct(Product Product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product Product);
        void Save();
    }
}
