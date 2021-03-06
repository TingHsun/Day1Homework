// <copyright file="ProductItemTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductItem;
using System.Collections.Generic;
using ExpectedObjects;

namespace ProductItem.Tests
{
    /// <summary>此類別包含 ProductItem 的參數化單元測試</summary>
    [PexClass(typeof(global::ProductItem.ProductItem))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProductItemTest
    {
        [TestMethod]
        public void SetResultForThree()
        {
            List<int> expected = new List<int>();
            expected.Add(6);
            expected.Add(15);
            expected.Add(24);
            expected.Add(21);

            List<Product> ProductList = GetProductItems();

            ProductItem target = new ProductItem();

            var actual = target.GetSumResult(ProductList, "Cost", 3);

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void SetResultForFour()
        {
            List<int> expected = new List<int>() { 50, 66, 60 };

            List<Product> ProductList = GetProductItems();

            ProductItem target = new ProductItem();

            var actual = target.GetSumResult(ProductList, "Revenue", 4);

            expected.ToExpectedObject().ShouldEqual(actual);
        }

        internal static List<Product> GetProductItems()
        {
            List<Product> product = new List<Product>();
            product.Add(new Product()
            {
                Id = 1,
                Cost = 1,
                Revenue = 11,
                SellPrice = 21
            });
            product.Add(new Product()
            {
                Id = 2,
                Cost = 2,
                Revenue = 12,
                SellPrice = 22
            });
            product.Add(new Product()
            {
                Id = 3,
                Cost = 3,
                Revenue = 13,
                SellPrice = 23
            });
            product.Add(new Product()
            {
                Id = 4,
                Cost = 4,
                Revenue = 14,
                SellPrice = 24
            });
            product.Add(new Product()
            {
                Id = 5,
                Cost = 5,
                Revenue = 15,
                SellPrice = 25
            });
            product.Add(new Product()
            {
                Id = 6,
                Cost = 6,
                Revenue = 16,
                SellPrice = 26
            });
            product.Add(new Product()
            {
                Id = 7,
                Cost = 7,
                Revenue = 17,
                SellPrice = 27
            });
            product.Add(new Product()
            {
                Id = 8,
                Cost = 8,
                Revenue = 18,
                SellPrice = 28
            });
            product.Add(new Product()
            {
                Id = 9,
                Cost = 9,
                Revenue = 19,
                SellPrice = 29
            });
            product.Add(new Product()
            {
                Id = 10,
                Cost = 10,
                Revenue = 20,
                SellPrice = 30
            });
            product.Add(new Product()
            {
                Id = 11,
                Cost = 11,
                Revenue = 21,
                SellPrice = 31
            });
            return product;
        }
    }

}
