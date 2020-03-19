using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using test_2.Data;
using test_2.Models;

namespace test_2.Pages
{
    public class IndexModel : PageModel
    {
        // public int AGES { get; set; }
        private readonly BekaryShopContext _db;

        public IndexModel(BekaryShopContext db) => this._db = db;

        public List<Product> Products { set; get; } //= new List<Product>();
        public Product FeaturedProduct{ get; set; }
        public void OnGetAsync() {

            //Products = await _db.Products.ToListAsync(); // Probarity of BekaryShopContext ERROR LINE DONT USE ASYNC
            Products = _db.Products.ToList();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count)); //get a random product that not out of the range "ONE PRODUCT"
        }
    }
}


/*
 there are 3 type to get data from text box by a button
 1. traditional -> request form -> email = Request.Form["emailadd"]; // emailadd is the button name in HTML
 2. handler method
 3. pagemodel
 
    
    
    ViewData["PersonalData"] = Configuration["PersonalSetting:NAME"]; // read from configuration
     */
