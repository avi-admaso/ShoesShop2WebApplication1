using ShoesShop2WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoesShop2WebApplication1.Controllers
{
    public class ShoeController : Controller
    {
        // GET: Shoe
        //static public List[] theShoes sportShoe  = new List[];
        public static List<sportShoe> shoesList = new List<sportShoe>()
        {
            new sportShoe(1,"nike",42,1200),
            new sportShoe(2,"adidas",41,1700),
            new sportShoe(3,"fendi",40,1500),
            new sportShoe(4,"dior",43,1600),

        };


        public ActionResult ShowModelName()
        {
            ViewBag.name = shoesList[0].modelName;
            return View();
        }
                //Id = 2;
        public ActionResult ShowTheShoe(int Id)
        {
            for (var i = 0; i < shoesList.Count; i++)
            {

                if (Id == shoesList[i].id)
                {

                    ViewBag.theShoe = shoesList[i].modelName;
                }
            }
            return View();
        }

        public ActionResult ShowShoes()
        {
            ViewBag.TheShoes = shoesList;
            return View();
        }
    }
}


