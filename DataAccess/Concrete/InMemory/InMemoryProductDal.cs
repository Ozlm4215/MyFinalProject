﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId = 1, CategoryId=1, ProductName= "Bardak", UnitPrice=15, UnitsInStock=15 },
            new Product{ProductId = 2, CategoryId=1, ProductName= "Kamera", UnitPrice=500, UnitsInStock=3 },
            new Product{ProductId = 3, CategoryId=1, ProductName= "Telefon", UnitPrice=1500, UnitsInStock=2 },
            new Product{ProductId = 4, CategoryId=1, ProductName= "Klavye", UnitPrice=150, UnitsInStock=65 },
            new Product{ProductId = 5, CategoryId=1, ProductName= "Fare", UnitPrice=1574, UnitsInStock=1 }
            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product deleteProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(deleteProduct);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product updateProduct = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            updateProduct.ProductName = product.ProductName;
            updateProduct.UnitPrice = product.UnitPrice;
            updateProduct.UnitsInStock = product.UnitsInStock;
            updateProduct.CategoryId = product.CategoryId;
        }
    }
}
