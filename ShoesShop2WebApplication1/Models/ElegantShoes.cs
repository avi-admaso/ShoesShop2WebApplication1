using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoesShop2WebApplication1.Models
{
    //10.	צרו מודל של נעלי יציאה עם שדות :ID , שם חברה, מגדר, האם יש עקב, האם קיים במלאי, מידה ומחיר.
    public class ElegantShoes
    {
        public int id;
        public string companyName;
        public string gender;
        public bool haveHeels;
        public bool haveInShop;
        public int price;
    }
}