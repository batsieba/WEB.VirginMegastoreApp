using VirginMegastoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace VirginMegastoreApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly AppDbContext ctx;

        public ProductController(AppDbContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categoriesList = new SelectList(ctx.Categories.ToList(), "CategoryID", "CategoryName");
            ViewBag.CatList = categoriesList;
            return View();
        }

        [HttpPost]
        [Authorize(Roles ="Adminstrator")]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ctx.Products.Add(product);
                ctx.SaveChanges();
                //upload file and update file name in table 
                if (product.ImageFile != null)
                {
                    string newFileName = uploadPhoto(product);

                    // update CoverPhotoName in database table
                    product.CoverPhoto = newFileName;
                    ctx.Products.Update(product);
                    ctx.SaveChanges();
                }

                //pass the ID of the newly created products to the details act 
                return Redirect("/Search/Detail/" + product.Product_ID);
            }
            var categoriesList = new SelectList(ctx.Categories.ToList(), "CategoryID", "CategoryName");
            ViewBag.CatList = categoriesList;
            return View();
        }

        private string uploadPhoto(Product product)
        {
            int productid = product.Product_ID;
            //upload photo
            string uplaodsFolder = "wwwroot/images/";
            //change filename to a unique name picxx.filetype
            string uniqueFilename = "pic" + productid + Path.GetExtension(product.ImageFile.FileName);
            string filePath = uplaodsFolder + uniqueFilename;
            //upload photo to folder
            product.ImageFile.CopyTo(new FileStream(filePath, FileMode.Create));
            return uniqueFilename;
        }

        [HttpPost]
        [Authorize(Roles = "Member")]
        [ValidateAntiForgeryToken]
        public IActionResult AddReview(Review review)
        {
            review.ReviewDate = DateTime.Now;
            ctx.Reviews.Add(review);
            ctx.SaveChanges();
            return Redirect("/Search/Detail/" + review.Product_ID);
        }

        [HttpGet]
        [Authorize(Roles = "Adminstrator")]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return BadRequest(); //must use global exeception handling to redirect to custom error page
            }
            Product product = ctx.Products.Find(id);//find the products with the given ID

            if (product == null)
            {
                return NotFound(); // must use global exeption handling to redirect user custom error page
            }

            var categoriesList = new SelectList(ctx.Categories.ToList(), "CategoryID", "CategoryName");
            ViewBag.CatList = categoriesList;
            return View(product);

        }

        [HttpPost]
        [Authorize(Roles = "Adminstrator")]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                //--------------- if a new photo was selected ------ //
                if (product.ImageFile != null)
                {
                    string newFileName = uploadPhoto(product);
                    product.CoverPhoto = newFileName;
                }
                // -------- update CoverPhotoName in database table ----------

                ctx.Products.Update(product);
                ctx.SaveChanges();
                //redirect the user to the Details View and pass the products id of current products
                return Redirect("/Search/Detail/" + product.Product_ID);
            }
            return View(product);

        }

        [HttpGet]
        [Authorize(Roles = "Adminstrator")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return BadRequest(); //must use global exeception handling to redirect to custom error page
            }
            Product product = ctx.Products.Find(id);

            if (product == null)
            {
                return NotFound(); // must use global exeption handling to redirect user custom error page
            }

            var categoriesList = new SelectList(ctx.Categories.ToList(), "CategoryID", "CategoryName");
            ViewBag.CatList = categoriesList;
            return View(product);

        }

        [HttpPost]
        [Authorize(Roles = "Adminstrator")]
        public IActionResult Delete(Product product)
        {
            //delete the coverphoto from the filesystem
            if (product.CoverPhoto == null || product.CoverPhoto != "noimage.jpg")
            {
                string uploadsFolder = "wwwroot/images/";
                string uniqueFilename = product.CoverPhoto;
                FileInfo file = new FileInfo(uploadsFolder + uniqueFilename);
                if (file.Exists)//check file exsit or not  
                {
                    file.Delete();

                }
            }
            ctx.Products.Remove(product);
            ctx.SaveChanges();
            //redirect the user search page
            return Redirect("/Search/ProductByCategory/");

        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
