using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace VirginMegastoreApp.Models
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Review> Reviews { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Electronics" },
               new Category { CategoryID = 2, CategoryName = "Clothes" },
               new Category { CategoryID = 3, CategoryName = "Books" }
               );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Product_ID = 1,
                    Product_Name = "Logitech Pebble Wireless Mouse",
                    Price = 109,
                    Description = "Quiet Click Mouse with Ultra - Quiet Scrolling: Enjoy an ultra - quiet experience with over 90 % noise reduction(1) on the click sound - even the wide rubber scroll wheel glides in silence",
                    CoverPhoto = "pic1.jpg",
                    CategoryID = 1,
                },
                 new Product
                 {
                     Product_ID = 2,
                     Product_Name = "Ducati Pro II Evo Electric Scooter",
                     Price = 3499,
                     Description = "PRO-II EVO is the Ducati electric scooter that surprises and conquers the road thanks to the double suspension and the control offered by the connection to the Ducati Urban e-Mobility App",
                     CoverPhoto = "pic2.jpg",
                     CategoryID = 1
                 },
                  new Product
                  {
                      Product_ID = 3,
                      Product_Name = "Hyperice Hypervolt 2 - Percussion Massager",
                      Price = 1049,
                      Description = "The original Hypervolt with some serious upgrades - lighter, more powerful, and a newly designed ergonomic handle. Give your muscles the daily relief they've been asking for with the Hypervolt 2's percussion massage. Warm up quickly, stay loose, and accelerate recovery at home and beyond - so you're ready to tackle whatever comes next. ",
                      CoverPhoto = "pic3.jpg",
                      CategoryID = 1
                  },
                    new Product
                    {
                        Product_ID = 4,
                        Product_Name = "Apple Watch Ultra GPS + Cellular 49mm Gold Titanium Case with Starlight Alpine Loop - Medium",
                        Price = 3199,
                        Description = "Apple Watch Series 8 is a powerful health companion. Featuring advanced health sensors and apps, so you can take an ECG, measure heart rate and blood oxygen, and track temperature changes for advanced insights into your menstrual cycle",
                        CoverPhoto = "pic4.jpg",
                        CategoryID = 1
                    },
                      new Product
                      {
                          Product_ID = 5,
                          Product_Name = "Opposuits Nintendo Super Mario Kids Costume Suit",
                          Price = 279,
                          Description = "Is your little one into video games? Do you feel a sense of nostalgia when it comes to Super Mario? We've got the answer to your sentimentality and his gaming right here. Power-up his wardrobe with this colorful Super Mario™ suit. Covered in an all-over print with all the iconic characters from the Mushroom Kingdom, he’ll win the outfit game for sure.",
                          CoverPhoto = "pic5.jpg",
                          CategoryID = 2
                      },
                       new Product
                       {
                           Product_ID = 6,
                           Product_Name = "Mister Tee Le Papillon Men's Oversize T-Shirt - White",
                           Price = 159,
                           Description = "Crew neck, short-sleeved t-shirt",
                           CoverPhoto = "pic6.jpg",
                           CategoryID = 2
                       },
                      new Product
                      {
                          Product_ID = 7,
                          Product_Name = "Goorin Bros The Panther Unisex Trucker Cap Orange",
                          Price = 169,
                          Description = "Trucker Snapback Cap with Cotton Sweatband ",
                          CoverPhoto = "pic7.jpg",
                          CategoryID = 2
                      },
                      new Product
                      {
                          Product_ID = 8,
                          Product_Name = "Difuzed Star Wars Galaxy Snapback Cap Black",
                          Price = 26,
                          Description = "This cap is made from premium quality material with professional stitching, for excellent comfort and is official licensed merchandise from Star Wars",
                          CoverPhoto = "pic8.jpg",
                          CategoryID = 2
                      }
                      ,
                      new Product
                      {
                          Product_ID = 9,
                          Product_Name = "Peppa Pig Goodnight Peppa | Peppa Pig",
                          Price = 49,
                          Description = "It's time for bed but Peppa and George are absolutely, definitely, not even a little bit tired in this delightful brand new picture book. A bedtime story from Granny Pig, Grandpa Pig, Daddy Pig AND Mummy Pig should send them to sleep ...Shouldn't it? This picture book story is perfect for reading at bedtime, playtime and over and over again! Based on the hit preschool animation Peppa Pig, shown daily on Five's Milkshake and Nick Jnr. ",
                          CoverPhoto = "pic9.jpg",
                          CategoryID = 3
                      }
                      ,
                      new Product
                      {
                          Product_ID = 10,
                          Product_Name = "Little Music Note | Pi Kids",
                          Price = 69,
                          Description = "Read, hear, and sing the hit song from Frozen 2, Into the Unknown, with this gorgeous illustrated songbook. Press 5 buttons to play the melody and practice on your own, then press the big button to sing the whole song with Elsa! Lyrics are printed in the book.",
                          CoverPhoto = "pic10.jpg",
                          CategoryID = 3
                      },
                      new Product
                      {
                          Product_ID = 11,
                          Product_Name = "Spaceboy | David Walliams",
                          Price = 85,
                          Description = "Go back to the Space Race with No.1 bestselling author David Walliams for a breathless cinematic adventure full of mystery, action, laughs and surprises - and a secret that could change the course of history..",
                          CoverPhoto = "pic11.jpg",
                          CategoryID = 3
                      },
                      new Product
                      {
                          Product_ID = 12,
                          Product_Name = "Peppa Pig 1000 First Words Sticker Book | Peppa Pig",
                          Price = 55,
                          Description = "Learn 1000 first words with Peppa Pig in this fantastic new bumper sticker book! ",
                          CoverPhoto = "pic12.jpg",
                          CategoryID = 3
                      }

                );
            modelBuilder.Entity<Review>().HasData(
                new Review { ReviewID = 1, ReviewDate = DateTime.Parse("07/01/2022"), Rating = 3, Comment = "A nice mouse to use", Product_ID = 1 },
               new Review { ReviewID = 2, ReviewDate = DateTime.Parse("07/01/2022"), Rating = 4, Comment = "best electric scooter", Product_ID = 2 },
               new Review { ReviewID = 3, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 3, Comment = "Good for back massage", Product_ID = 3 },
               new Review { ReviewID = 4, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 4, Comment = "Very advanced", Product_ID = 4 },
               new Review { ReviewID = 5, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 4, Comment = " I love the color", Product_ID = 5 },
               new Review { ReviewID = 6, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 1, Comment = "Not the best fabric", Product_ID = 6 },
               new Review { ReviewID = 7, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 2, Comment = "didn’t like it", Product_ID = 7 },
               new Review { ReviewID = 8, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 3, Comment = "very comfy", Product_ID = 8 },
               new Review { ReviewID = 9, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 4, Comment = "useful", Product_ID = 9 },
               new Review { ReviewID = 10, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 4, Comment = "my kid enjoyed the book", Product_ID = 10 },
               new Review { ReviewID = 11, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 3, Comment = "very entertaining for kids", Product_ID = 11 },
               new Review { ReviewID = 12, ReviewDate = DateTime.Parse("07/03/2022"), Rating = 4, Comment = "A good book", Product_ID = 12 }
               );

            //------------- Seeding Roles and Admin Account Data ----------------//
            var adminroleid = Guid.NewGuid().ToString();

            //Seeding a  'Admin' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminroleid,
                    Name = "Administrator",
                    NormalizedName = "Administrator".ToUpper()
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Member",
                    NormalizedName = "Member".ToUpper()
                }
                );
            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<ApplicationUser>();

            //Seeding the User to AspNetUsers table
            var userid = Guid.NewGuid().ToString();
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = userid, // GUID created earlier as primary key
                    UserName = "admin@virginMegastore.com",
                    NormalizedUserName = "admin@virginMegastore.com".ToUpper(),
                    FirstName = "Admin",
                    LastName = "User",
                    Email = "admin@virginMegastore.com",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")
                }
            );

            //Assiging the Admin User to the Addministrator role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminroleid,
                    UserId = userid
                }
            );

            //end of seeding

        }
    }
}
