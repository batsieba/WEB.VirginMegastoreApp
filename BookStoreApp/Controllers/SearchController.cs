using Microsoft.AspNetCore.Mvc;
using VirginMegastoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace VirginMegastoreApp.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext ctx;

        public SearchController(AppDbContext ctx)
        {
            this.ctx = ctx;
        }
  
        public IActionResult ProductByName(string? product_name)
        {
            if (String.IsNullOrEmpty(product_name))
            {
                // no title provided, display the view
                return View();
            }
            //when a title is provided retrieve the books that contain the title
            var products = ctx.Products
                          .Where(b => b.Product_Name.Contains(product_name))
                          .Include(b => b.Category) //eager loading, performs SQL join to get category details
                          .ToList();
            //return View(books);
            return PartialView("_PartialSearchResult", products);

        }
        public IActionResult ProductByCategory(int? catID)
        {   //first time page is requested, no catID will be provided
            if (catID == null || catID == 0)
            {   //to display a dropdown list of categories in the view
                var categoriesList = new SelectList(ctx.Categories.ToList(), "CategoryID", "CategoryName");
                ViewBag.CatList = categoriesList;
                return View();
            }
            //when an ID is provided read the books that contain the title and return the result
            var products = ctx.Products
                          .Where(b => b.CategoryID == catID)
                          .Include(b => b.Category) //eager loading, performs SQL join to get category details
                          .ToList();
            return PartialView("_PartialSearchResult", products);

        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            //eager loading
            Product product = ctx.Products.Where(b => b.Product_ID == id)
                                 .Include(b => b.Category) //join with Category table
                                 .Include(b => b.Reviews) //Join with Reviews table
                                 .FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            //view is returned only when there is a record to display
            return View(product);

        }
    }
}
