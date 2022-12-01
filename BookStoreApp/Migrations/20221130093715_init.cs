using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VirginMegastoreApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverPhoto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 1, "Electronics" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 2, "Clothes" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[] { 3, "Books" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Product_ID", "CategoryID", "CoverPhoto", "Description", "Price", "Product_Name" },
                values: new object[,]
                {
                    { 1, 1, "pic1.jpg", "Quiet Click Mouse with Ultra - Quiet Scrolling: Enjoy an ultra - quiet experience with over 90 % noise reduction(1) on the click sound - even the wide rubber scroll wheel glides in silence", 109.0, "Logitech Pebble Wireless Mouse" },
                    { 2, 1, "pic2.jpg", "PRO-II EVO is the Ducati electric scooter that surprises and conquers the road thanks to the double suspension and the control offered by the connection to the Ducati Urban e-Mobility App", 3499.0, "Ducati Pro II Evo Electric Scooter" },
                    { 3, 1, "pic3.jpg", "The original Hypervolt with some serious upgrades - lighter, more powerful, and a newly designed ergonomic handle. Give your muscles the daily relief they've been asking for with the Hypervolt 2's percussion massage. Warm up quickly, stay loose, and accelerate recovery at home and beyond - so you're ready to tackle whatever comes next. ", 1049.0, "Hyperice Hypervolt 2 - Percussion Massager" },
                    { 4, 1, "pic4.jpg", "Apple Watch Series 8 is a powerful health companion. Featuring advanced health sensors and apps, so you can take an ECG, measure heart rate and blood oxygen, and track temperature changes for advanced insights into your menstrual cycle", 3199.0, "Apple Watch Ultra GPS + Cellular 49mm Gold Titanium Case with Starlight Alpine Loop - Medium" },
                    { 5, 2, "pic5.jpg", "Is your little one into video games? Do you feel a sense of nostalgia when it comes to Super Mario? We've got the answer to your sentimentality and his gaming right here. Power-up his wardrobe with this colorful Super Mario™ suit. Covered in an all-over print with all the iconic characters from the Mushroom Kingdom, he’ll win the outfit game for sure.", 279.0, "Opposuits Nintendo Super Mario Kids Costume Suit" },
                    { 6, 2, "pic6.jpg", "Crew neck, short-sleeved t-shirt", 159.0, "Mister Tee Le Papillon Men's Oversize T-Shirt - White" },
                    { 7, 2, "pic7.jpg", "Trucker Snapback Cap with Cotton Sweatband ", 169.0, "Goorin Bros The Panther Unisex Trucker Cap Orange" },
                    { 8, 2, "pic8.jpg", "This cap is made from premium quality material with professional stitching, for excellent comfort and is official licensed merchandise from Star Wars", 26.0, "Difuzed Star Wars Galaxy Snapback Cap Black" },
                    { 9, 3, "pic9.jpg", "It's time for bed but Peppa and George are absolutely, definitely, not even a little bit tired in this delightful brand new picture book. A bedtime story from Granny Pig, Grandpa Pig, Daddy Pig AND Mummy Pig should send them to sleep ...Shouldn't it? This picture book story is perfect for reading at bedtime, playtime and over and over again! Based on the hit preschool animation Peppa Pig, shown daily on Five's Milkshake and Nick Jnr. ", 49.0, "Peppa Pig Goodnight Peppa | Peppa Pig" },
                    { 10, 3, "pic10.jpg", "Read, hear, and sing the hit song from Frozen 2, Into the Unknown, with this gorgeous illustrated songbook. Press 5 buttons to play the melody and practice on your own, then press the big button to sing the whole song with Elsa! Lyrics are printed in the book.", 69.0, "Little Music Note | Pi Kids" },
                    { 11, 3, "pic11.jpg", "Go back to the Space Race with No.1 bestselling author David Walliams for a breathless cinematic adventure full of mystery, action, laughs and surprises - and a secret that could change the course of history..", 85.0, "Spaceboy | David Walliams" },
                    { 12, 3, "pic12.jpg", "Learn 1000 first words with Peppa Pig in this fantastic new bumper sticker book! ", 55.0, "Peppa Pig 1000 First Words Sticker Book | Peppa Pig" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Comment", "Product_ID", "Rating", "ReviewDate" },
                values: new object[,]
                {
                    { 1, "A nice mouse to use", 1, 3, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "best electric scooter", 2, 4, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Good for back massage", 3, 3, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Very advanced", 4, 4, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, " I love the color", 5, 4, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Not the best fabric", 6, 1, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "didn’t like it", 7, 2, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "very comfy", 8, 3, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "useful", 9, 4, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "my kid enjoyed the book", 10, 4, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "very entertaining for kids", 11, 3, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "A good book", 12, 4, new DateTime(2022, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_Product_ID",
                table: "Reviews",
                column: "Product_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
