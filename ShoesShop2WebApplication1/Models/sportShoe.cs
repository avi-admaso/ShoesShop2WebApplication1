using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesShop2WebApplication1.Models
{
    public class sportShoe
    {
        public int id;
        public string modelName;
        public int size;
        public int price;

        public sportShoe(int id, string modelName, int size, int price)
        {
            this.id = id;
            this.modelName = modelName;
            this.size = size;
            this.price = price;
        }
    }
}