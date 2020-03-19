using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using test_2.Data;

using test_2.Models;

namespace test_2.Pages
{
    public class orderModel : PageModel
    {
        private readonly BekaryShopContext _db;

        public orderModel(BekaryShopContext db) => this._db = db;
        public Product SelectedProduct { get; set; }
        [BindProperty,Display(Name = "Quantity")]
        public int Quantity { get; set; }
        [BindProperty,EmailAddress,Required,Display(Name ="Your Email")]
        public string OrderEmail { get; set; }
        [BindProperty, Required(ErrorMessage ="PLZ ADD ADDRESS"), Display(Name = "Shipping address")]
        public string OrderShippng { get; set; }
        [BindProperty(SupportsGet = true)] // to get ID from the link sent from main page
        public int id { get; set; }
        public void OnGet()
        {
            SelectedProduct = _db.Products.Find(id); // serch the product into database
        }
        public IActionResult OnPost()
        {
            SelectedProduct = _db.Products.Find(id);
            if (ModelState.IsValid)
            {
             
                return RedirectToPage("SuccessShipping");// REDIRECT TO SUCCESS SHIPPING
            }
            else {
                return Page(); // stay on the page and show requirments
            }
        }
    }
}
