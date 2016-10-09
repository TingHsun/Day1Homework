using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductItem
{
    public class ProductItem
    {
        /// <param name="ProductList">商品列表</param>
        /// /// <param name="title">欄位名稱</param>
        /// /// <param name="setNumber">集合單位(多少商品為一組)</param>
        internal List<int> GetSumResult(List<Product> ProductList, string title, int setNumber)
        {
            int count = 0;
            int sum = 0;
            List<int> group = new List<int>();

            foreach (Product product in ProductList)
            {
                sum += (int)product.GetType().GetProperty(title).GetValue(product, null);

                count++;

                if (count % setNumber == 0)  //計數超過setNumber分成一組
                {
                    group.Add(sum);
                    //count = 0;      //重置計數
                    sum = 0;      //重置總和
                }
            }

            if (count % setNumber != 0/*count > 0*/)  //餘數須分成一組
            {
                group.Add(sum);
            }

            return group;
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
