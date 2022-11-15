using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class ApplyConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Address", "ContactNumber", "Email", "Name" },
                values: new object[] { 1L, "Novopolotsk Pushkina street", "+37529281133", "cinematrix@gmail.com", "Cinematrix" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price", "UrlPicture" },
                values: new object[,]
                {
                    { 12L, "A tortilla chip or nacho chips is a snack food made from corn tortillas, which are cut into wedges and then fried.", "Nachos", 3m, "https://i.pinimg.com/564x/d5/fa/fd/d5fafd4b3e1812c233fcff9412080601.jpg" },
                    { 10L, "A sauce made of butter, water or broth, and seasonings, thickened with flour, and used also as a basis for the making of other sauces (such as caper sauce or shrimp sauce) by the addition of special ingredients.", "Butter Topping", 4m, "https://i.pinimg.com/564x/78/2d/c1/782dc1b23a49df94690528e9f355c477.jpg" },
                    { 9L, "A hot dog is a food consisting of a grilled or steamed sausage served in the slit of a partially sliced bun. The term hot dog can also refer to the sausage itself.", "Hot Dog", 3m, "https://i.pinimg.com/564x/6d/7c/9e/6d7c9e6e15e8206339eaa91c3b810ce7.jpg" },
                    { 8L, "Mozerella sticks are typically eaten with Marinara. However, ranch, Thai sweet chili, cocktail sauce, BBQ, hot sauce, regular mayonnaise, garlic aioli, buffalo sauce, ketchup, tzatziki, donair, alfredo, salsa, and hollandaise are all good sauces to try.", "Mozzarella Sticks", 5m, "https://i.pinimg.com/564x/b0/46/31/b046315f129b2b1e002b5c8183c893c7.jpg" },
                    { 7L, "A deep-fried strip of chicken without bones or skin. A flap of chicken meat found on, and easily detached from, the breast.", "Chicken Tenders", 5m, "https://i.pinimg.com/564x/f1/e6/1c/f1e61c6808735b1b69a4b28d83417382.jpg" },
                    { 11L, "Melted cheese garnished with sliced chile peppers that is traditionally served with tortilla chips.", "Nacho Cheese", 5m, "https://i.pinimg.com/564x/97/c4/ac/97c4ac886aa8731e8ccf3e689be6a226.jpg" },
                    { 5L, "A kind of fries characterized by their spring-like shape, being cut from whole potatoes using a specialized spiral slicer.", "Curcly Fries", 4m, "https://i.pinimg.com/564x/67/63/26/6763268fae390dfae890e73eeb96b51c.jpg" },
                    { 4L, "A pretzel is a handheld yeast bread that's usually shaped into a twisted knot.", "Pretzel Bites", 4m, "https://i.pinimg.com/564x/15/ed/22/15ed22eb6702c520995a7f146c088505.jpg" },
                    { 3L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Large Plain Popcorn", 6m, "https://i.pinimg.com/564x/ad/0b/be/ad0bbe7809102011d85f2e9bc87b7b90.jpg" },
                    { 2L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Medium Plain Popcorn", 4.5m, "https://i.pinimg.com/564x/fc/cf/dc/fccfdcbe5355ba1b2662d92c305b6402.jpg" },
                    { 1L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Small Plain Popcorn", 3m, "https://i.pinimg.com/564x/27/54/4b/27544b30e1f053ef55aefc2758184445.jpg" },
                    { 6L, "French fries are long, thin pieces of potato fried in oil or fat. The French fries were thin and crispy. To cook the French fries, put them into a deep pan of oil.", "Fries", 3m, "https://i.pinimg.com/564x/7b/a7/f6/7ba7f65ae13d844bd26289b7ee8b8d8f.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "Id", "IsRentMovie", "MovieId" },
                values: new object[,]
                {
                    { 12L, true, 760741L },
                    { 20L, true, 999205L },
                    { 19L, true, 985939L },
                    { 18L, true, 961484L },
                    { 17L, true, 921360L },
                    { 16L, true, 916605L },
                    { 15L, true, 882598L },
                    { 14L, true, 877957L },
                    { 13L, true, 762504L },
                    { 11L, true, 760161L },
                    { 8L, true, 718930L },
                    { 9L, true, 744276L },
                    { 10L, true, 756999L },
                    { 2L, true, 526896L },
                    { 3L, true, 539681L },
                    { 4L, true, 576925L },
                    { 1L, true, 19995L },
                    { 6L, true, 634649L },
                    { 7L, true, 639933L },
                    { 5L, true, 610150L }
                });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "DateOfBirth", "ImageUrl", "Name", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2002, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "Admin", "+375291111111", "Admin" },
                    { 2L, new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "Staff", "+375291111112", "Staff" },
                    { 3L, new DateTime(2000, 11, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "User", "+375291111113", "User" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Admin" },
                    { 2L, "Staff" },
                    { 3L, "User" }
                });

            migrationBuilder.InsertData(
                table: "SeatTypes",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 2L, "Lux", 6m },
                    { 1L, "Standart", 4m },
                    { 3L, "Romantic", 8m }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "CinemaId", "Description", "Name", "Projector", "Screen", "ScreenResolution", "SoundSystem" },
                values: new object[,]
                {
                    { 1L, 1L, "Comfortable recliner chairs with adjustable back tilt, leg support and individual tables for each chair.", "LUX", "Sony", "8,7 x 3,9", "4K", "Dolby 7,1" },
                    { 2L, 1L, "Soft sofas for two. The atmosphere of privacy and comfort in individual boxes.", "SWEET BOX", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 3L, 1L, "Standard seats. For two Sofa Love.", "SMALL HALL", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 4L, 1L, "Standard seats. For two Sofa Love.", "BIG HALL", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" },
                    { 5L, 1L, "Standard seats. For two Sofa Love.", "ATMOS", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ProfileId", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 1L, "admin@gmail.com", "admin", 1L, 1L, "admin" },
                    { 2L, "staff@gmail.com", "staff", 2L, 2L, "staff" },
                    { 3L, "user@gmail.com", "user", 3L, 3L, "user" }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 1L, 1L, 1, 1, 2L },
                    { 226L, 4L, 6, 5, 1L },
                    { 227L, 4L, 7, 5, 1L },
                    { 228L, 4L, 8, 5, 1L },
                    { 229L, 4L, 9, 5, 1L },
                    { 230L, 4L, 10, 5, 1L },
                    { 231L, 4L, 11, 5, 1L },
                    { 232L, 4L, 12, 5, 1L },
                    { 233L, 4L, 13, 5, 1L },
                    { 225L, 4L, 5, 5, 1L },
                    { 234L, 4L, 14, 5, 1L },
                    { 236L, 4L, 16, 5, 1L },
                    { 237L, 4L, 17, 5, 1L },
                    { 238L, 4L, 18, 5, 1L },
                    { 239L, 4L, 1, 6, 1L },
                    { 240L, 4L, 2, 6, 1L },
                    { 241L, 4L, 3, 6, 1L },
                    { 242L, 4L, 4, 6, 1L },
                    { 243L, 4L, 5, 6, 1L },
                    { 235L, 4L, 15, 5, 1L },
                    { 224L, 4L, 4, 5, 1L },
                    { 223L, 4L, 3, 5, 1L },
                    { 222L, 4L, 2, 5, 1L },
                    { 203L, 4L, 1, 4, 1L },
                    { 204L, 4L, 2, 4, 1L },
                    { 205L, 4L, 3, 4, 1L },
                    { 206L, 4L, 4, 4, 1L },
                    { 207L, 4L, 5, 4, 1L },
                    { 208L, 4L, 6, 4, 1L },
                    { 209L, 4L, 7, 4, 1L },
                    { 210L, 4L, 8, 4, 1L },
                    { 211L, 4L, 9, 4, 1L },
                    { 212L, 4L, 10, 4, 1L },
                    { 213L, 4L, 11, 4, 1L },
                    { 214L, 4L, 12, 4, 1L },
                    { 215L, 4L, 13, 4, 1L },
                    { 216L, 4L, 14, 4, 1L },
                    { 217L, 4L, 15, 4, 1L },
                    { 218L, 4L, 16, 4, 1L },
                    { 219L, 4L, 17, 4, 1L },
                    { 220L, 4L, 18, 4, 1L },
                    { 221L, 4L, 1, 5, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 244L, 4L, 6, 6, 1L },
                    { 245L, 4L, 7, 6, 1L },
                    { 246L, 4L, 8, 6, 1L },
                    { 247L, 4L, 9, 6, 1L },
                    { 271L, 4L, 15, 7, 1L },
                    { 272L, 4L, 16, 7, 1L },
                    { 273L, 4L, 17, 7, 1L },
                    { 274L, 4L, 18, 7, 1L },
                    { 275L, 4L, 1, 8, 1L },
                    { 276L, 4L, 2, 8, 1L },
                    { 277L, 4L, 3, 8, 1L },
                    { 278L, 4L, 4, 8, 1L },
                    { 279L, 4L, 5, 8, 1L },
                    { 280L, 4L, 6, 8, 1L },
                    { 281L, 4L, 7, 8, 1L },
                    { 282L, 4L, 8, 8, 1L },
                    { 283L, 4L, 9, 8, 1L },
                    { 284L, 4L, 10, 8, 1L },
                    { 285L, 4L, 11, 8, 1L },
                    { 286L, 4L, 12, 8, 1L },
                    { 287L, 4L, 13, 8, 1L },
                    { 288L, 4L, 14, 8, 1L },
                    { 289L, 4L, 15, 8, 1L },
                    { 270L, 4L, 14, 7, 1L },
                    { 202L, 4L, 18, 3, 1L },
                    { 269L, 4L, 13, 7, 1L },
                    { 267L, 4L, 11, 7, 1L },
                    { 248L, 4L, 10, 6, 1L },
                    { 249L, 4L, 11, 6, 1L },
                    { 250L, 4L, 12, 6, 1L },
                    { 251L, 4L, 13, 6, 1L },
                    { 252L, 4L, 14, 6, 1L },
                    { 253L, 4L, 15, 6, 1L },
                    { 254L, 4L, 16, 6, 1L },
                    { 255L, 4L, 17, 6, 1L },
                    { 256L, 4L, 18, 6, 1L },
                    { 257L, 4L, 1, 7, 1L },
                    { 258L, 4L, 2, 7, 1L },
                    { 259L, 4L, 3, 7, 1L },
                    { 260L, 4L, 4, 7, 1L },
                    { 261L, 4L, 5, 7, 1L },
                    { 262L, 4L, 6, 7, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 263L, 4L, 7, 7, 1L },
                    { 264L, 4L, 8, 7, 1L },
                    { 265L, 4L, 9, 7, 1L },
                    { 266L, 4L, 10, 7, 1L },
                    { 268L, 4L, 12, 7, 1L },
                    { 290L, 4L, 16, 8, 1L },
                    { 201L, 4L, 17, 3, 1L },
                    { 199L, 4L, 15, 3, 1L },
                    { 134L, 3L, 4, 6, 1L },
                    { 135L, 3L, 5, 6, 1L },
                    { 136L, 3L, 6, 6, 1L },
                    { 137L, 3L, 7, 6, 1L },
                    { 138L, 3L, 8, 6, 1L },
                    { 139L, 3L, 9, 6, 1L },
                    { 140L, 3L, 10, 6, 1L },
                    { 141L, 3L, 11, 6, 1L },
                    { 133L, 3L, 3, 6, 1L },
                    { 142L, 3L, 12, 6, 1L },
                    { 144L, 3L, 2, 7, 3L },
                    { 145L, 3L, 3, 7, 3L },
                    { 146L, 3L, 4, 7, 3L },
                    { 147L, 3L, 5, 7, 3L },
                    { 148L, 3L, 6, 7, 3L },
                    { 149L, 4L, 1, 1, 1L },
                    { 150L, 4L, 2, 1, 1L },
                    { 151L, 4L, 3, 1, 1L },
                    { 143L, 3L, 1, 7, 3L },
                    { 132L, 3L, 2, 6, 1L },
                    { 131L, 3L, 1, 6, 1L },
                    { 130L, 3L, 12, 5, 1L },
                    { 111L, 3L, 5, 4, 1L },
                    { 112L, 3L, 6, 4, 1L },
                    { 113L, 3L, 7, 4, 1L },
                    { 114L, 3L, 8, 4, 1L },
                    { 115L, 3L, 9, 4, 1L },
                    { 116L, 3L, 10, 4, 1L },
                    { 117L, 3L, 11, 4, 1L },
                    { 118L, 3L, 12, 4, 1L },
                    { 119L, 3L, 1, 5, 1L },
                    { 120L, 3L, 2, 5, 1L },
                    { 121L, 3L, 3, 5, 1L },
                    { 122L, 3L, 4, 5, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 123L, 3L, 5, 5, 1L },
                    { 124L, 3L, 6, 5, 1L },
                    { 125L, 3L, 7, 5, 1L },
                    { 126L, 3L, 8, 5, 1L },
                    { 127L, 3L, 9, 5, 1L },
                    { 128L, 3L, 10, 5, 1L },
                    { 129L, 3L, 11, 5, 1L },
                    { 152L, 4L, 4, 1, 1L },
                    { 153L, 4L, 5, 1, 1L },
                    { 154L, 4L, 6, 1, 1L },
                    { 155L, 4L, 7, 1, 1L },
                    { 180L, 4L, 14, 2, 1L },
                    { 181L, 4L, 15, 2, 1L },
                    { 182L, 4L, 16, 2, 1L },
                    { 183L, 4L, 17, 2, 1L },
                    { 184L, 4L, 18, 2, 1L },
                    { 185L, 4L, 1, 3, 1L },
                    { 186L, 4L, 2, 3, 1L },
                    { 187L, 4L, 3, 3, 1L },
                    { 188L, 4L, 4, 3, 1L },
                    { 189L, 4L, 5, 3, 1L },
                    { 190L, 4L, 6, 3, 1L },
                    { 191L, 4L, 7, 3, 1L },
                    { 192L, 4L, 8, 3, 1L },
                    { 193L, 4L, 9, 3, 1L },
                    { 194L, 4L, 10, 3, 1L },
                    { 195L, 4L, 11, 3, 1L },
                    { 196L, 4L, 12, 3, 1L },
                    { 197L, 4L, 13, 3, 1L },
                    { 198L, 4L, 14, 3, 1L },
                    { 179L, 4L, 13, 2, 1L },
                    { 200L, 4L, 16, 3, 1L },
                    { 178L, 4L, 12, 2, 1L },
                    { 176L, 4L, 10, 2, 1L },
                    { 156L, 4L, 8, 1, 1L },
                    { 157L, 4L, 9, 1, 1L },
                    { 158L, 4L, 10, 1, 1L },
                    { 159L, 4L, 11, 1, 1L },
                    { 160L, 4L, 12, 1, 1L },
                    { 161L, 4L, 13, 1, 1L },
                    { 162L, 4L, 14, 1, 1L },
                    { 163L, 4L, 15, 1, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 164L, 4L, 16, 1, 1L },
                    { 165L, 4L, 17, 1, 1L },
                    { 166L, 4L, 18, 1, 1L },
                    { 167L, 4L, 1, 2, 1L },
                    { 168L, 4L, 2, 2, 1L },
                    { 169L, 4L, 3, 2, 1L },
                    { 170L, 4L, 4, 2, 1L },
                    { 171L, 4L, 5, 2, 1L },
                    { 173L, 4L, 7, 2, 1L },
                    { 174L, 4L, 8, 2, 1L },
                    { 175L, 4L, 9, 2, 1L },
                    { 177L, 4L, 11, 2, 1L },
                    { 291L, 4L, 17, 8, 1L },
                    { 292L, 4L, 18, 8, 1L },
                    { 293L, 4L, 1, 9, 1L },
                    { 409L, 5L, 1, 6, 1L },
                    { 410L, 5L, 2, 6, 1L },
                    { 411L, 5L, 3, 6, 1L },
                    { 412L, 5L, 4, 6, 1L },
                    { 413L, 5L, 5, 6, 1L },
                    { 414L, 5L, 6, 6, 1L },
                    { 415L, 5L, 7, 6, 1L },
                    { 416L, 5L, 8, 6, 1L },
                    { 408L, 5L, 16, 5, 1L },
                    { 417L, 5L, 9, 6, 1L },
                    { 419L, 5L, 11, 6, 1L },
                    { 420L, 5L, 12, 6, 1L },
                    { 421L, 5L, 13, 6, 1L },
                    { 422L, 5L, 14, 6, 1L },
                    { 423L, 5L, 15, 6, 1L },
                    { 424L, 5L, 16, 6, 1L },
                    { 425L, 5L, 1, 7, 1L },
                    { 426L, 5L, 2, 7, 1L },
                    { 418L, 5L, 10, 6, 1L },
                    { 407L, 5L, 15, 5, 1L },
                    { 406L, 5L, 14, 5, 1L },
                    { 405L, 5L, 13, 5, 1L },
                    { 386L, 5L, 10, 4, 1L },
                    { 387L, 5L, 11, 4, 1L },
                    { 388L, 5L, 12, 4, 1L },
                    { 389L, 5L, 13, 4, 1L },
                    { 390L, 5L, 14, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 391L, 5L, 15, 4, 1L },
                    { 392L, 5L, 16, 4, 1L },
                    { 393L, 5L, 1, 5, 1L },
                    { 394L, 5L, 2, 5, 1L },
                    { 395L, 5L, 3, 5, 1L },
                    { 396L, 5L, 4, 5, 1L },
                    { 397L, 5L, 5, 5, 1L },
                    { 398L, 5L, 6, 5, 1L },
                    { 399L, 5L, 7, 5, 1L },
                    { 400L, 5L, 8, 5, 1L },
                    { 401L, 5L, 9, 5, 1L },
                    { 402L, 5L, 10, 5, 1L },
                    { 403L, 5L, 11, 5, 1L },
                    { 404L, 5L, 12, 5, 1L },
                    { 427L, 5L, 3, 7, 1L },
                    { 428L, 5L, 4, 7, 1L },
                    { 429L, 5L, 5, 7, 1L },
                    { 430L, 5L, 6, 7, 1L },
                    { 454L, 5L, 14, 8, 1L },
                    { 455L, 5L, 15, 8, 1L },
                    { 456L, 5L, 16, 8, 1L },
                    { 457L, 5L, 1, 9, 2L },
                    { 458L, 5L, 2, 9, 2L },
                    { 459L, 5L, 3, 9, 2L },
                    { 460L, 5L, 4, 9, 2L },
                    { 461L, 5L, 5, 9, 2L },
                    { 462L, 5L, 6, 9, 2L },
                    { 463L, 5L, 7, 9, 2L },
                    { 464L, 5L, 8, 9, 2L },
                    { 465L, 5L, 1, 10, 2L },
                    { 466L, 5L, 2, 10, 2L },
                    { 467L, 5L, 3, 10, 2L },
                    { 468L, 5L, 4, 10, 2L },
                    { 469L, 5L, 5, 10, 2L },
                    { 470L, 5L, 6, 10, 2L },
                    { 471L, 5L, 7, 10, 2L },
                    { 472L, 5L, 8, 10, 2L },
                    { 453L, 5L, 13, 8, 1L },
                    { 385L, 5L, 9, 4, 1L },
                    { 452L, 5L, 12, 8, 1L },
                    { 450L, 5L, 10, 8, 1L },
                    { 431L, 5L, 7, 7, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 432L, 5L, 8, 7, 1L },
                    { 433L, 5L, 9, 7, 1L },
                    { 434L, 5L, 10, 7, 1L },
                    { 435L, 5L, 11, 7, 1L },
                    { 436L, 5L, 12, 7, 1L },
                    { 437L, 5L, 13, 7, 1L },
                    { 438L, 5L, 14, 7, 1L },
                    { 439L, 5L, 15, 7, 1L },
                    { 440L, 5L, 16, 7, 1L },
                    { 441L, 5L, 1, 8, 1L },
                    { 442L, 5L, 2, 8, 1L },
                    { 443L, 5L, 3, 8, 1L },
                    { 444L, 5L, 4, 8, 1L },
                    { 445L, 5L, 5, 8, 1L },
                    { 446L, 5L, 6, 8, 1L },
                    { 447L, 5L, 7, 8, 1L },
                    { 448L, 5L, 8, 8, 1L },
                    { 449L, 5L, 9, 8, 1L },
                    { 451L, 5L, 11, 8, 1L },
                    { 384L, 5L, 8, 4, 1L },
                    { 383L, 5L, 7, 4, 1L },
                    { 382L, 5L, 6, 4, 1L },
                    { 317L, 4L, 7, 10, 3L },
                    { 318L, 4L, 8, 10, 3L },
                    { 319L, 4L, 9, 10, 3L },
                    { 320L, 4L, 1, 11, 3L },
                    { 321L, 4L, 2, 11, 3L },
                    { 322L, 4L, 3, 11, 3L },
                    { 323L, 4L, 4, 11, 3L },
                    { 324L, 4L, 5, 11, 3L },
                    { 325L, 4L, 6, 11, 3L },
                    { 326L, 4L, 7, 11, 3L },
                    { 327L, 4L, 8, 11, 3L },
                    { 328L, 4L, 9, 11, 3L },
                    { 329L, 5L, 1, 1, 1L },
                    { 330L, 5L, 2, 1, 1L },
                    { 331L, 5L, 3, 1, 1L },
                    { 332L, 5L, 4, 1, 1L },
                    { 333L, 5L, 5, 1, 1L },
                    { 334L, 5L, 6, 1, 1L },
                    { 335L, 5L, 7, 1, 1L },
                    { 316L, 4L, 6, 10, 3L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 336L, 5L, 8, 1, 1L },
                    { 315L, 4L, 5, 10, 3L },
                    { 313L, 4L, 3, 10, 3L },
                    { 294L, 4L, 2, 9, 1L },
                    { 295L, 4L, 3, 9, 1L },
                    { 296L, 4L, 4, 9, 1L },
                    { 297L, 4L, 5, 9, 1L },
                    { 298L, 4L, 6, 9, 1L },
                    { 299L, 4L, 7, 9, 1L },
                    { 300L, 4L, 8, 9, 1L },
                    { 301L, 4L, 9, 9, 1L },
                    { 302L, 4L, 10, 9, 1L },
                    { 303L, 4L, 11, 9, 1L },
                    { 304L, 4L, 12, 9, 1L },
                    { 305L, 4L, 13, 9, 1L },
                    { 306L, 4L, 14, 9, 1L },
                    { 307L, 4L, 15, 9, 1L },
                    { 308L, 4L, 16, 9, 1L },
                    { 309L, 4L, 17, 9, 1L },
                    { 310L, 4L, 18, 9, 1L },
                    { 311L, 4L, 1, 10, 3L },
                    { 312L, 4L, 2, 10, 3L },
                    { 314L, 4L, 4, 10, 3L },
                    { 110L, 3L, 4, 4, 1L },
                    { 337L, 5L, 9, 1, 1L },
                    { 339L, 5L, 11, 1, 1L },
                    { 363L, 5L, 3, 3, 1L },
                    { 364L, 5L, 4, 3, 1L },
                    { 365L, 5L, 5, 3, 1L },
                    { 366L, 5L, 6, 3, 1L },
                    { 367L, 5L, 7, 3, 1L },
                    { 368L, 5L, 8, 3, 1L },
                    { 369L, 5L, 9, 3, 1L },
                    { 370L, 5L, 10, 3, 1L },
                    { 371L, 5L, 11, 3, 1L },
                    { 372L, 5L, 12, 3, 1L },
                    { 373L, 5L, 13, 3, 1L },
                    { 374L, 5L, 14, 3, 1L },
                    { 375L, 5L, 15, 3, 1L },
                    { 376L, 5L, 16, 3, 1L },
                    { 377L, 5L, 1, 4, 1L },
                    { 378L, 5L, 2, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 379L, 5L, 3, 4, 1L },
                    { 380L, 5L, 4, 4, 1L },
                    { 381L, 5L, 5, 4, 1L },
                    { 362L, 5L, 2, 3, 1L },
                    { 338L, 5L, 10, 1, 1L },
                    { 361L, 5L, 1, 3, 1L },
                    { 359L, 5L, 15, 2, 1L },
                    { 340L, 5L, 12, 1, 1L },
                    { 341L, 5L, 13, 1, 1L },
                    { 342L, 5L, 14, 1, 1L },
                    { 343L, 5L, 15, 1, 1L },
                    { 344L, 5L, 16, 1, 1L },
                    { 345L, 5L, 1, 2, 1L },
                    { 346L, 5L, 2, 2, 1L },
                    { 347L, 5L, 3, 2, 1L },
                    { 348L, 5L, 4, 2, 1L },
                    { 349L, 5L, 5, 2, 1L },
                    { 350L, 5L, 6, 2, 1L },
                    { 351L, 5L, 7, 2, 1L },
                    { 352L, 5L, 8, 2, 1L },
                    { 353L, 5L, 9, 2, 1L },
                    { 354L, 5L, 10, 2, 1L },
                    { 355L, 5L, 11, 2, 1L },
                    { 356L, 5L, 12, 2, 1L },
                    { 357L, 5L, 13, 2, 1L },
                    { 358L, 5L, 14, 2, 1L },
                    { 360L, 5L, 16, 2, 1L },
                    { 109L, 3L, 3, 4, 1L },
                    { 172L, 4L, 6, 2, 1L },
                    { 107L, 3L, 1, 4, 1L },
                    { 5L, 1L, 5, 1, 2L },
                    { 4L, 1L, 4, 1, 2L },
                    { 3L, 1L, 3, 1, 2L },
                    { 2L, 1L, 2, 1, 2L },
                    { 70L, 2L, 5, 6, 3L },
                    { 69L, 2L, 4, 6, 3L },
                    { 68L, 2L, 3, 6, 3L },
                    { 67L, 2L, 2, 6, 3L },
                    { 66L, 2L, 1, 6, 3L },
                    { 65L, 2L, 5, 5, 3L },
                    { 64L, 2L, 4, 5, 3L },
                    { 63L, 2L, 3, 5, 3L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 62L, 2L, 2, 5, 3L },
                    { 61L, 2L, 1, 5, 3L },
                    { 60L, 2L, 5, 4, 3L },
                    { 59L, 2L, 4, 4, 3L },
                    { 58L, 2L, 3, 4, 3L },
                    { 44L, 2L, 4, 1, 3L },
                    { 45L, 2L, 5, 1, 3L },
                    { 46L, 2L, 1, 2, 3L },
                    { 47L, 2L, 2, 2, 3L },
                    { 48L, 2L, 3, 2, 3L },
                    { 49L, 2L, 4, 2, 3L },
                    { 6L, 1L, 6, 1, 2L },
                    { 50L, 2L, 5, 2, 3L },
                    { 52L, 2L, 2, 3, 3L },
                    { 53L, 2L, 3, 3, 3L },
                    { 54L, 2L, 4, 3, 3L },
                    { 55L, 2L, 5, 3, 3L },
                    { 56L, 2L, 1, 4, 3L },
                    { 57L, 2L, 2, 4, 3L },
                    { 51L, 2L, 1, 3, 3L },
                    { 42L, 2L, 2, 1, 3L },
                    { 7L, 1L, 7, 1, 2L },
                    { 9L, 1L, 1, 2, 2L },
                    { 40L, 1L, 8, 5, 2L },
                    { 39L, 1L, 7, 5, 2L },
                    { 38L, 1L, 6, 5, 2L },
                    { 37L, 1L, 5, 5, 2L },
                    { 36L, 1L, 4, 5, 2L },
                    { 35L, 1L, 3, 5, 2L },
                    { 34L, 1L, 2, 5, 2L },
                    { 33L, 1L, 1, 5, 2L },
                    { 32L, 1L, 8, 4, 2L },
                    { 31L, 1L, 7, 4, 2L },
                    { 30L, 1L, 6, 4, 2L },
                    { 29L, 1L, 5, 4, 2L },
                    { 28L, 1L, 4, 4, 2L },
                    { 27L, 1L, 3, 4, 2L },
                    { 26L, 1L, 2, 4, 2L },
                    { 25L, 1L, 1, 4, 2L },
                    { 24L, 1L, 8, 3, 2L },
                    { 10L, 1L, 2, 2, 2L },
                    { 11L, 1L, 3, 2, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 12L, 1L, 4, 2, 2L },
                    { 13L, 1L, 5, 2, 2L },
                    { 14L, 1L, 6, 2, 2L },
                    { 15L, 1L, 7, 2, 2L },
                    { 8L, 1L, 8, 1, 2L },
                    { 16L, 1L, 8, 2, 2L },
                    { 18L, 1L, 2, 3, 2L },
                    { 19L, 1L, 3, 3, 2L },
                    { 20L, 1L, 4, 3, 2L },
                    { 21L, 1L, 5, 3, 2L },
                    { 22L, 1L, 6, 3, 2L },
                    { 23L, 1L, 7, 3, 2L },
                    { 17L, 1L, 1, 3, 2L },
                    { 41L, 2L, 1, 1, 3L },
                    { 43L, 2L, 3, 1, 3L },
                    { 101L, 3L, 7, 3, 1L },
                    { 86L, 3L, 4, 2, 1L },
                    { 87L, 3L, 5, 2, 1L },
                    { 88L, 3L, 6, 2, 1L },
                    { 89L, 3L, 7, 2, 1L },
                    { 90L, 3L, 8, 2, 1L },
                    { 91L, 3L, 9, 2, 1L },
                    { 92L, 3L, 10, 2, 1L },
                    { 93L, 3L, 11, 2, 1L },
                    { 94L, 3L, 12, 2, 1L },
                    { 95L, 3L, 1, 3, 1L },
                    { 108L, 3L, 2, 4, 1L },
                    { 96L, 3L, 2, 3, 1L },
                    { 106L, 3L, 12, 3, 1L },
                    { 105L, 3L, 11, 3, 1L },
                    { 104L, 3L, 10, 3, 1L },
                    { 103L, 3L, 9, 3, 1L },
                    { 102L, 3L, 8, 3, 1L },
                    { 97L, 3L, 3, 3, 1L },
                    { 100L, 3L, 6, 3, 1L },
                    { 85L, 3L, 3, 2, 1L },
                    { 84L, 3L, 2, 2, 1L },
                    { 83L, 3L, 1, 2, 1L },
                    { 82L, 3L, 12, 1, 1L },
                    { 99L, 3L, 5, 3, 1L },
                    { 72L, 3L, 2, 1, 1L },
                    { 73L, 3L, 3, 1, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 74L, 3L, 4, 1, 1L },
                    { 75L, 3L, 5, 1, 1L },
                    { 71L, 3L, 1, 1, 1L },
                    { 77L, 3L, 7, 1, 1L },
                    { 78L, 3L, 8, 1, 1L },
                    { 79L, 3L, 9, 1, 1L },
                    { 80L, 3L, 10, 1, 1L },
                    { 81L, 3L, 11, 1, 1L },
                    { 76L, 3L, 6, 1, 1L },
                    { 98L, 3L, 4, 3, 1L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 314L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 319L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 324L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 381L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 386L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 391L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 396L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 401L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 406L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 474L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 376L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 271L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 266L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 261L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 256L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 251L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 246L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 241L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 236L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 231L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 226L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 221L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 216L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 211L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 206L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 201L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 276L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 281L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 286L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 291L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 371L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 366L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 361L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 356L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 351L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 346L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 341L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 411L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 336L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 326L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 321L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 316L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 311L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 306L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 301L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 296L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 331L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 416L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 421L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 426L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 584L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 589L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 594L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 599L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 604L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 609L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 614L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 619L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 624L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 629L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 634L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 639L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 521L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 516L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 511L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 506L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 501L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 579L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 496L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 574L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 564L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 479L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 484L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 489L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 494L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 499L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 504L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 509L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 514L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 519L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 524L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 529L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 534L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 539L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 544L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 549L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 554L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 559L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 569L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 491L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 486L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 481L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 379L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 374L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 369L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 364L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 359L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 354L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 349L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 344L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 339L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 334L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 329L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 456L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 451L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 446L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 441L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 436L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 431L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 384L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 389L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 394L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 399L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 476L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 471L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 466L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 461L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 464L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 196L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 459L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 454L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 469L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 449L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 439L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 434L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 429L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 424L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 419L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 414L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 409L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 404L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 444L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 191L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 1L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 181L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 345L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 350L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 355L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 360L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 365L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 370L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 375L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 340L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 380L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 390L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 395L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 400L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 405L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 410L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 415L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 420L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 385L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 335L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 330L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 325L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 240L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 245L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 250L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 255L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 260L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 265L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 270L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 275L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 280L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 285L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 290L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 295L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 300L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 305L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 310L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 315L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 320L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 425L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 430L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 435L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 440L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 550L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 555L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 560L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 565L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 570L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 575L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 580L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 585L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 590L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 595L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 600L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 605L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 610L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 615L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 620L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 625L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 630L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 545L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 235L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 540L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 530L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 445L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 450L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 455L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 460L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 465L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 470L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 475L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 480L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 485L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 490L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 495L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 500L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 505L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 510L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 515L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 520L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 525L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 535L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 186L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 230L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 220L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 71L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 66L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 61L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 56L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 51L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 46L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 41L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 76L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 36L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 26L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 21L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 16L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 11L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 6L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 309L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 5L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 31L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 81L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 86L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 91L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 176L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 171L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 166L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 161L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 156L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 151L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 146L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 141L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 136L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 131L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 126L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 121L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 116L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 111L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 106L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 101L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 96L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 10L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 15L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 20L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 25L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 135L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 140L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 145L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 150L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 155L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 160L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 165L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 170L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 175L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 180L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 185L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 190L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 195L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 200L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 205L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 210L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 215L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 130L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 225L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 125L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 115L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 30L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 35L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 40L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 45L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 50L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 55L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 60L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 65L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 70L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 75L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 80L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 85L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 90L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 95L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 100L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 105L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 110L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 120L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 304L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 134L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 294L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 523L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 528L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 533L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 538L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 543L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 548L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 553L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 558L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 563L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 568L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 573L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 578L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 583L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 588L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 593L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 598L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 603L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 518L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 608L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 513L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 503L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 418L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 423L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 428L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 433L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 438L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 443L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 448L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 453L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 458L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 463L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 468L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 473L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 478L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 483L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 488L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 493L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 498L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 508L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 613L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 618L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 623L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 532L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 527L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 522L, new DateTime(2022, 11, 27, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 517L, new DateTime(2022, 11, 26, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 635L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 512L, new DateTime(2022, 11, 26, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 507L, new DateTime(2022, 11, 26, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 502L, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 497L, new DateTime(2022, 11, 26, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 492L, new DateTime(2022, 11, 26, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 487L, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 482L, new DateTime(2022, 11, 26, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 477L, new DateTime(2022, 11, 25, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 472L, new DateTime(2022, 11, 25, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 467L, new DateTime(2022, 11, 25, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 462L, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 457L, new DateTime(2022, 11, 25, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 537L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 542L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 547L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 552L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 628L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 633L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 638L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 627L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 622L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 617L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 612L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 607L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 413L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 602L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 592L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 587L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 582L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 577L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 572L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 567L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 562L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 557L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 597L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 452L, new DateTime(2022, 11, 25, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 408L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 398L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 98L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 103L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 108L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 113L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 118L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 123L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 128L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 133L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 138L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 143L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 148L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 153L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 158L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 163L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 168L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 173L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 178L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 93L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 183L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 88L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 78L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 637L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 632L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 3L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 8L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 13L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 18L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 23L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 28L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 33L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 38L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 43L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 48L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 53L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 58L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 63L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 68L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 73L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 83L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 188L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 193L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 198L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 313L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 318L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 323L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 328L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 333L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 338L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 343L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 348L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 353L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 358L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 363L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 368L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 373L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 378L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 383L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 388L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 393L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 308L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 303L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 298L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 293L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 203L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 208L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 213L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 218L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 223L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 228L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 233L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 238L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 403L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 243L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 253L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 258L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 263L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 268L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 273L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 278L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 283L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 288L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 248L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 447L, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 442L, new DateTime(2022, 11, 25, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 437L, new DateTime(2022, 11, 24, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 536L, new DateTime(2022, 11, 27, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 531L, new DateTime(2022, 11, 27, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 526L, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 4L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 9L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 14L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 19L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 24L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 29L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 34L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 39L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 44L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 49L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 54L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 59L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 64L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 69L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 541L, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 74L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 546L, new DateTime(2022, 11, 27, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 556L, new DateTime(2022, 11, 27, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 2L, new DateTime(2022, 11, 14, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 636L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 631L, new DateTime(2022, 11, 29, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 626L, new DateTime(2022, 11, 29, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 621L, new DateTime(2022, 11, 29, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 616L, new DateTime(2022, 11, 29, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 611L, new DateTime(2022, 11, 29, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 606L, new DateTime(2022, 11, 29, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 601L, new DateTime(2022, 11, 29, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 596L, new DateTime(2022, 11, 28, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 591L, new DateTime(2022, 11, 28, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 586L, new DateTime(2022, 11, 28, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 581L, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 576L, new DateTime(2022, 11, 28, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 571L, new DateTime(2022, 11, 28, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 566L, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 561L, new DateTime(2022, 11, 28, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 551L, new DateTime(2022, 11, 27, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 79L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 84L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 89L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 209L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 214L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 219L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 224L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 229L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 234L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 239L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 244L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 249L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 254L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 259L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 264L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 269L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 274L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 279L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 284L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 289L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 204L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 199L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 194L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 189L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 94L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 99L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 104L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 109L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 114L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 119L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 124L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 129L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 7L, new DateTime(2022, 11, 14, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 139L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 149L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 154L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 159L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 164L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 169L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 174L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 179L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 184L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 144L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 12L, new DateTime(2022, 11, 14, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 17L, new DateTime(2022, 11, 14, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 22L, new DateTime(2022, 11, 14, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 322L, new DateTime(2022, 11, 22, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 317L, new DateTime(2022, 11, 21, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 312L, new DateTime(2022, 11, 21, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 307L, new DateTime(2022, 11, 21, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 302L, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 297L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 292L, new DateTime(2022, 11, 21, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 287L, new DateTime(2022, 11, 21, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 282L, new DateTime(2022, 11, 21, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 277L, new DateTime(2022, 11, 20, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 272L, new DateTime(2022, 11, 20, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 267L, new DateTime(2022, 11, 20, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 262L, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 257L, new DateTime(2022, 11, 20, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 252L, new DateTime(2022, 11, 20, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 247L, new DateTime(2022, 11, 20, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 242L, new DateTime(2022, 11, 20, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 327L, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 332L, new DateTime(2022, 11, 22, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 337L, new DateTime(2022, 11, 22, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 342L, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 432L, new DateTime(2022, 11, 24, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 427L, new DateTime(2022, 11, 24, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 422L, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 417L, new DateTime(2022, 11, 24, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 412L, new DateTime(2022, 11, 24, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 407L, new DateTime(2022, 11, 24, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 402L, new DateTime(2022, 11, 24, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 397L, new DateTime(2022, 11, 23, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 237L, new DateTime(2022, 11, 19, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 392L, new DateTime(2022, 11, 23, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 382L, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 377L, new DateTime(2022, 11, 23, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 372L, new DateTime(2022, 11, 23, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 367L, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 362L, new DateTime(2022, 11, 23, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 357L, new DateTime(2022, 11, 22, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 352L, new DateTime(2022, 11, 22, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 347L, new DateTime(2022, 11, 22, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 387L, new DateTime(2022, 11, 23, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 299L, new DateTime(2022, 11, 21, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 232L, new DateTime(2022, 11, 19, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 222L, new DateTime(2022, 11, 19, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 107L, new DateTime(2022, 11, 16, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 102L, new DateTime(2022, 11, 16, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 97L, new DateTime(2022, 11, 16, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 92L, new DateTime(2022, 11, 16, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 87L, new DateTime(2022, 11, 16, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 82L, new DateTime(2022, 11, 16, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 77L, new DateTime(2022, 11, 15, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 72L, new DateTime(2022, 11, 15, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 67L, new DateTime(2022, 11, 15, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 62L, new DateTime(2022, 11, 15, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 57L, new DateTime(2022, 11, 15, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 52L, new DateTime(2022, 11, 15, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 47L, new DateTime(2022, 11, 15, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 42L, new DateTime(2022, 11, 15, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 37L, new DateTime(2022, 11, 14, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 32L, new DateTime(2022, 11, 14, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 27L, new DateTime(2022, 11, 14, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 112L, new DateTime(2022, 11, 16, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 117L, new DateTime(2022, 11, 16, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 122L, new DateTime(2022, 11, 17, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 127L, new DateTime(2022, 11, 17, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 217L, new DateTime(2022, 11, 19, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 212L, new DateTime(2022, 11, 19, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 207L, new DateTime(2022, 11, 19, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 202L, new DateTime(2022, 11, 19, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 197L, new DateTime(2022, 11, 18, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 192L, new DateTime(2022, 11, 18, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 187L, new DateTime(2022, 11, 18, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 182L, new DateTime(2022, 11, 18, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 227L, new DateTime(2022, 11, 19, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 177L, new DateTime(2022, 11, 18, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 167L, new DateTime(2022, 11, 18, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 162L, new DateTime(2022, 11, 18, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 157L, new DateTime(2022, 11, 17, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 152L, new DateTime(2022, 11, 17, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 147L, new DateTime(2022, 11, 17, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 142L, new DateTime(2022, 11, 17, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 137L, new DateTime(2022, 11, 17, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 132L, new DateTime(2022, 11, 17, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 172L, new DateTime(2022, 11, 18, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 640L, new DateTime(2022, 11, 29, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 19L, 1L, 34L, 1L },
                    { 540L, 1L, 255L, 44L },
                    { 541L, 1L, 256L, 44L },
                    { 542L, 2L, 257L, 44L },
                    { 550L, 2L, 248L, 44L },
                    { 551L, 2L, 249L, 44L },
                    { 552L, 2L, 250L, 44L },
                    { 536L, 3L, 176L, 44L },
                    { 67L, 1L, 186L, 49L },
                    { 69L, 3L, 188L, 49L },
                    { 520L, 1L, 206L, 49L },
                    { 158L, 2L, 308L, 54L },
                    { 159L, 3L, 309L, 54L },
                    { 160L, 2L, 310L, 54L },
                    { 248L, 2L, 216L, 54L },
                    { 68L, 3L, 187L, 49L },
                    { 170L, 1L, 179L, 44L },
                    { 169L, 3L, 178L, 44L },
                    { 168L, 2L, 177L, 44L },
                    { 228L, 3L, 295L, 19L },
                    { 438L, 2L, 188L, 19L },
                    { 439L, 2L, 189L, 19L },
                    { 440L, 1L, 190L, 19L },
                    { 454L, 1L, 167L, 19L },
                    { 455L, 3L, 168L, 19L },
                    { 98L, 2L, 314L, 24L },
                    { 99L, 2L, 315L, 24L },
                    { 556L, 2L, 312L, 24L },
                    { 557L, 2L, 313L, 24L },
                    { 343L, 1L, 302L, 29L },
                    { 344L, 1L, 303L, 29L },
                    { 418L, 1L, 284L, 29L },
                    { 136L, 3L, 196L, 39L },
                    { 137L, 3L, 197L, 39L },
                    { 249L, 2L, 217L, 54L },
                    { 427L, 2L, 250L, 54L },
                    { 428L, 1L, 251L, 54L },
                    { 514L, 2L, 287L, 54L },
                    { 199L, 2L, 168L, 69L },
                    { 200L, 1L, 169L, 69L },
                    { 324L, 1L, 154L, 79L },
                    { 325L, 3L, 155L, 79L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 326L, 1L, 156L, 79L },
                    { 271L, 1L, 214L, 84L },
                    { 272L, 1L, 215L, 84L },
                    { 273L, 2L, 216L, 84L },
                    { 500L, 3L, 280L, 84L },
                    { 250L, 2L, 176L, 89L },
                    { 251L, 3L, 177L, 89L },
                    { 311L, 2L, 185L, 89L },
                    { 312L, 2L, 186L, 89L },
                    { 313L, 2L, 187L, 89L },
                    { 501L, 2L, 183L, 89L },
                    { 133L, 3L, 208L, 69L },
                    { 227L, 3L, 294L, 19L },
                    { 132L, 1L, 207L, 69L },
                    { 130L, 2L, 205L, 69L },
                    { 515L, 3L, 288L, 54L },
                    { 93L, 1L, 209L, 59L },
                    { 94L, 2L, 210L, 59L },
                    { 95L, 2L, 211L, 59L },
                    { 477L, 2L, 212L, 59L },
                    { 478L, 3L, 213L, 59L },
                    { 116L, 1L, 290L, 64L },
                    { 117L, 3L, 291L, 64L },
                    { 284L, 2L, 256L, 64L },
                    { 285L, 2L, 257L, 64L },
                    { 295L, 3L, 182L, 64L },
                    { 296L, 1L, 183L, 64L },
                    { 297L, 3L, 184L, 64L },
                    { 17L, 1L, 166L, 69L },
                    { 18L, 3L, 167L, 69L },
                    { 131L, 1L, 206L, 69L },
                    { 502L, 2L, 184L, 89L },
                    { 167L, 3L, 253L, 19L },
                    { 112L, 2L, 171L, 19L },
                    { 124L, 2L, 111L, 73L },
                    { 220L, 1L, 91L, 78L },
                    { 221L, 3L, 92L, 78L },
                    { 416L, 3L, 117L, 78L },
                    { 417L, 2L, 118L, 78L },
                    { 564L, 2L, 138L, 78L },
                    { 123L, 3L, 110L, 73L },
                    { 565L, 1L, 139L, 78L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 65L, 2L, 103L, 83L },
                    { 66L, 3L, 104L, 83L },
                    { 375L, 3L, 110L, 83L },
                    { 376L, 1L, 111L, 83L },
                    { 377L, 3L, 112L, 83L },
                    { 378L, 1L, 113L, 83L },
                    { 64L, 1L, 102L, 83L },
                    { 507L, 3L, 97L, 68L },
                    { 506L, 3L, 96L, 68L },
                    { 369L, 2L, 80L, 68L },
                    { 570L, 2L, 147L, 48L },
                    { 401L, 1L, 100L, 53L },
                    { 195L, 1L, 143L, 58L },
                    { 196L, 3L, 144L, 58L },
                    { 387L, 2L, 123L, 58L },
                    { 424L, 2L, 78L, 58L },
                    { 474L, 1L, 95L, 58L },
                    { 475L, 2L, 96L, 58L },
                    { 29L, 2L, 102L, 63L },
                    { 30L, 3L, 103L, 63L },
                    { 178L, 1L, 89L, 63L },
                    { 179L, 1L, 90L, 63L },
                    { 363L, 3L, 89L, 68L },
                    { 364L, 2L, 90L, 68L },
                    { 368L, 3L, 79L, 68L },
                    { 80L, 2L, 137L, 88L },
                    { 81L, 2L, 138L, 88L },
                    { 347L, 1L, 115L, 88L },
                    { 348L, 3L, 116L, 88L },
                    { 238L, 2L, 161L, 9L },
                    { 352L, 2L, 212L, 9L },
                    { 353L, 2L, 213L, 9L },
                    { 577L, 3L, 320L, 9L },
                    { 578L, 3L, 321L, 9L },
                    { 579L, 2L, 322L, 9L },
                    { 229L, 2L, 290L, 14L },
                    { 230L, 1L, 291L, 14L },
                    { 231L, 2L, 292L, 14L },
                    { 395L, 3L, 157L, 14L },
                    { 396L, 3L, 158L, 14L },
                    { 23L, 3L, 247L, 19L },
                    { 24L, 1L, 248L, 19L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 25L, 1L, 249L, 19L },
                    { 111L, 2L, 170L, 19L },
                    { 283L, 3L, 267L, 4L },
                    { 166L, 2L, 252L, 19L },
                    { 102L, 3L, 216L, 4L },
                    { 100L, 2L, 214L, 4L },
                    { 425L, 3L, 93L, 88L },
                    { 426L, 1L, 94L, 88L },
                    { 298L, 2L, 103L, 93L },
                    { 299L, 1L, 104L, 93L },
                    { 87L, 1L, 143L, 98L },
                    { 88L, 2L, 144L, 98L },
                    { 175L, 2L, 125L, 98L },
                    { 176L, 1L, 126L, 98L },
                    { 177L, 2L, 127L, 98L },
                    { 291L, 2L, 141L, 98L },
                    { 292L, 3L, 142L, 98L },
                    { 89L, 2L, 294L, 4L },
                    { 90L, 3L, 295L, 4L },
                    { 91L, 1L, 296L, 4L },
                    { 92L, 2L, 297L, 4L },
                    { 101L, 2L, 215L, 4L },
                    { 569L, 1L, 146L, 48L },
                    { 503L, 1L, 306L, 89L },
                    { 134L, 1L, 204L, 94L },
                    { 303L, 3L, 415L, 65L },
                    { 304L, 2L, 416L, 65L },
                    { 44L, 1L, 430L, 70L },
                    { 45L, 1L, 431L, 70L },
                    { 46L, 1L, 432L, 70L },
                    { 47L, 3L, 433L, 70L },
                    { 294L, 2L, 418L, 65L },
                    { 212L, 2L, 422L, 70L },
                    { 449L, 3L, 457L, 70L },
                    { 450L, 2L, 458L, 70L },
                    { 451L, 2L, 459L, 70L },
                    { 267L, 1L, 353L, 75L },
                    { 345L, 1L, 393L, 75L },
                    { 346L, 2L, 394L, 75L },
                    { 213L, 3L, 423L, 70L },
                    { 293L, 1L, 417L, 65L },
                    { 572L, 2L, 367L, 60L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 571L, 2L, 366L, 60L },
                    { 444L, 3L, 378L, 45L },
                    { 445L, 3L, 379L, 45L },
                    { 446L, 3L, 380L, 45L },
                    { 452L, 3L, 451L, 45L },
                    { 51L, 1L, 357L, 50L },
                    { 52L, 1L, 358L, 50L },
                    { 83L, 2L, 447L, 55L },
                    { 84L, 1L, 448L, 55L },
                    { 85L, 3L, 449L, 55L },
                    { 125L, 2L, 413L, 55L },
                    { 192L, 2L, 363L, 60L },
                    { 193L, 2L, 364L, 60L },
                    { 194L, 1L, 365L, 60L },
                    { 373L, 3L, 447L, 60L },
                    { 374L, 3L, 448L, 60L },
                    { 411L, 3L, 469L, 75L },
                    { 412L, 1L, 470L, 75L },
                    { 453L, 3L, 403L, 75L },
                    { 533L, 2L, 417L, 75L },
                    { 365L, 1L, 386L, 85L },
                    { 366L, 1L, 387L, 85L },
                    { 367L, 1L, 388L, 85L },
                    { 485L, 1L, 383L, 85L },
                    { 486L, 2L, 384L, 85L },
                    { 487L, 1L, 385L, 85L },
                    { 553L, 1L, 363L, 90L },
                    { 554L, 2L, 364L, 90L },
                    { 555L, 1L, 365L, 90L },
                    { 15L, 1L, 458L, 95L },
                    { 16L, 3L, 459L, 95L },
                    { 268L, 1L, 420L, 95L },
                    { 269L, 3L, 421L, 95L },
                    { 270L, 2L, 422L, 95L },
                    { 488L, 3L, 441L, 95L },
                    { 302L, 3L, 332L, 85L },
                    { 443L, 3L, 391L, 45L },
                    { 301L, 2L, 331L, 85L },
                    { 191L, 3L, 395L, 85L },
                    { 534L, 2L, 418L, 75L },
                    { 535L, 2L, 419L, 75L },
                    { 591L, 2L, 430L, 75L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 592L, 3L, 431L, 75L },
                    { 12L, 1L, 412L, 80L },
                    { 13L, 1L, 413L, 80L },
                    { 14L, 2L, 414L, 80L },
                    { 146L, 1L, 365L, 80L },
                    { 147L, 2L, 366L, 80L },
                    { 148L, 2L, 367L, 80L },
                    { 161L, 2L, 395L, 80L },
                    { 162L, 1L, 396L, 80L },
                    { 8L, 2L, 437L, 85L },
                    { 55L, 2L, 372L, 85L },
                    { 56L, 2L, 373L, 85L },
                    { 300L, 3L, 330L, 85L },
                    { 504L, 1L, 307L, 89L },
                    { 442L, 1L, 390L, 45L },
                    { 389L, 1L, 356L, 45L },
                    { 528L, 2L, 382L, 10L },
                    { 529L, 2L, 383L, 10L },
                    { 530L, 3L, 384L, 10L },
                    { 580L, 2L, 333L, 10L },
                    { 581L, 3L, 334L, 10L },
                    { 103L, 2L, 440L, 15L },
                    { 517L, 1L, 458L, 10L },
                    { 104L, 1L, 441L, 15L },
                    { 165L, 1L, 469L, 15L },
                    { 262L, 1L, 357L, 15L },
                    { 263L, 2L, 358L, 15L },
                    { 419L, 2L, 337L, 15L },
                    { 420L, 2L, 338L, 15L },
                    { 421L, 2L, 339L, 15L },
                    { 105L, 2L, 442L, 15L },
                    { 516L, 1L, 457L, 10L },
                    { 505L, 3L, 440L, 10L },
                    { 372L, 2L, 385L, 10L },
                    { 135L, 1L, 205L, 94L },
                    { 252L, 2L, 176L, 94L },
                    { 253L, 2L, 177L, 94L },
                    { 254L, 1L, 178L, 94L },
                    { 357L, 3L, 161L, 94L },
                    { 399L, 3L, 219L, 94L },
                    { 400L, 1L, 220L, 94L },
                    { 476L, 3L, 253L, 94L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 523L, 3L, 206L, 94L },
                    { 524L, 2L, 207L, 94L },
                    { 525L, 3L, 208L, 94L },
                    { 359L, 3L, 436L, 10L },
                    { 360L, 3L, 437L, 10L },
                    { 361L, 1L, 438L, 10L },
                    { 362L, 1L, 439L, 10L },
                    { 39L, 1L, 385L, 20L },
                    { 40L, 1L, 386L, 20L },
                    { 41L, 2L, 387L, 20L },
                    { 236L, 2L, 428L, 20L },
                    { 173L, 2L, 430L, 30L },
                    { 174L, 2L, 431L, 30L },
                    { 431L, 3L, 334L, 30L },
                    { 53L, 3L, 468L, 35L },
                    { 54L, 3L, 469L, 35L },
                    { 408L, 3L, 399L, 35L },
                    { 409L, 2L, 400L, 35L },
                    { 410L, 3L, 401L, 35L },
                    { 491L, 3L, 405L, 35L },
                    { 492L, 1L, 406L, 35L },
                    { 49L, 1L, 385L, 40L },
                    { 50L, 2L, 386L, 40L },
                    { 138L, 3L, 353L, 40L },
                    { 139L, 2L, 354L, 40L },
                    { 388L, 2L, 355L, 45L },
                    { 172L, 3L, 383L, 30L },
                    { 441L, 1L, 389L, 45L },
                    { 171L, 2L, 382L, 30L },
                    { 109L, 1L, 445L, 30L },
                    { 329L, 2L, 346L, 20L },
                    { 397L, 3L, 334L, 20L },
                    { 398L, 2L, 335L, 20L },
                    { 255L, 3L, 390L, 25L },
                    { 314L, 2L, 330L, 25L },
                    { 315L, 3L, 331L, 25L },
                    { 316L, 1L, 332L, 25L },
                    { 327L, 2L, 409L, 25L },
                    { 328L, 3L, 410L, 25L },
                    { 543L, 3L, 468L, 25L },
                    { 544L, 3L, 469L, 25L },
                    { 545L, 2L, 470L, 25L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 546L, 1L, 471L, 25L },
                    { 34L, 1L, 452L, 30L },
                    { 35L, 2L, 453L, 30L },
                    { 110L, 3L, 446L, 30L },
                    { 568L, 1L, 145L, 48L },
                    { 567L, 3L, 96L, 48L },
                    { 566L, 2L, 95L, 48L },
                    { 211L, 3L, 40L, 81L },
                    { 597L, 1L, 35L, 81L },
                    { 598L, 2L, 36L, 81L },
                    { 305L, 3L, 3L, 86L },
                    { 306L, 2L, 4L, 86L },
                    { 307L, 3L, 5L, 86L },
                    { 210L, 2L, 39L, 81L },
                    { 415L, 2L, 2L, 86L },
                    { 464L, 2L, 6L, 91L },
                    { 513L, 2L, 33L, 91L },
                    { 599L, 3L, 34L, 91L },
                    { 600L, 1L, 35L, 91L },
                    { 405L, 1L, 13L, 96L },
                    { 406L, 2L, 14L, 96L },
                    { 463L, 1L, 5L, 91L },
                    { 145L, 1L, 33L, 71L },
                    { 144L, 3L, 32L, 71L },
                    { 496L, 3L, 32L, 66L },
                    { 205L, 2L, 15L, 61L },
                    { 222L, 2L, 6L, 61L },
                    { 223L, 2L, 7L, 61L },
                    { 224L, 3L, 8L, 61L },
                    { 232L, 3L, 31L, 61L },
                    { 490L, 1L, 9L, 61L },
                    { 587L, 1L, 22L, 61L },
                    { 588L, 1L, 23L, 61L },
                    { 256L, 3L, 33L, 66L },
                    { 257L, 2L, 34L, 66L },
                    { 258L, 1L, 35L, 66L },
                    { 379L, 2L, 25L, 66L },
                    { 380L, 1L, 26L, 66L },
                    { 381L, 3L, 27L, 66L },
                    { 495L, 1L, 31L, 66L },
                    { 407L, 3L, 15L, 96L },
                    { 183L, 3L, 51L, 2L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 286L, 3L, 68L, 2L },
                    { 287L, 2L, 69L, 2L },
                    { 163L, 1L, 50L, 17L },
                    { 164L, 1L, 51L, 17L },
                    { 259L, 2L, 58L, 17L },
                    { 260L, 1L, 59L, 17L },
                    { 261L, 2L, 60L, 17L },
                    { 341L, 3L, 48L, 17L },
                    { 342L, 1L, 49L, 17L },
                    { 518L, 1L, 69L, 17L },
                    { 519L, 1L, 70L, 17L },
                    { 281L, 1L, 49L, 22L },
                    { 282L, 1L, 50L, 22L },
                    { 358L, 3L, 67L, 22L },
                    { 432L, 2L, 43L, 22L },
                    { 433L, 2L, 44L, 22L },
                    { 434L, 1L, 45L, 22L },
                    { 128L, 3L, 68L, 17L },
                    { 204L, 1L, 14L, 61L },
                    { 127L, 3L, 67L, 17L },
                    { 563L, 3L, 67L, 12L },
                    { 288L, 1L, 70L, 2L },
                    { 392L, 3L, 62L, 2L },
                    { 393L, 2L, 63L, 2L },
                    { 394L, 2L, 64L, 2L },
                    { 60L, 1L, 64L, 7L },
                    { 61L, 2L, 65L, 7L },
                    { 289L, 2L, 45L, 7L },
                    { 290L, 1L, 46L, 7L },
                    { 217L, 1L, 46L, 12L },
                    { 218L, 3L, 47L, 12L },
                    { 219L, 3L, 48L, 12L },
                    { 339L, 1L, 57L, 12L },
                    { 340L, 1L, 58L, 12L },
                    { 561L, 2L, 65L, 12L },
                    { 562L, 1L, 66L, 12L },
                    { 126L, 3L, 66L, 17L },
                    { 497L, 2L, 62L, 22L },
                    { 22L, 1L, 13L, 61L },
                    { 539L, 2L, 8L, 56L },
                    { 574L, 1L, 30L, 6L },
                    { 575L, 1L, 31L, 6L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 82L, 2L, 40L, 11L },
                    { 154L, 3L, 13L, 16L },
                    { 155L, 2L, 14L, 16L },
                    { 113L, 2L, 4L, 21L },
                    { 573L, 2L, 29L, 6L },
                    { 114L, 1L, 5L, 21L },
                    { 149L, 2L, 2L, 21L },
                    { 150L, 3L, 3L, 21L },
                    { 320L, 3L, 7L, 21L },
                    { 321L, 3L, 8L, 21L },
                    { 322L, 1L, 9L, 21L },
                    { 323L, 1L, 10L, 21L },
                    { 115L, 3L, 6L, 21L },
                    { 522L, 1L, 16L, 6L },
                    { 521L, 2L, 15L, 6L },
                    { 391L, 2L, 28L, 6L },
                    { 20L, 3L, 35L, 1L },
                    { 140L, 3L, 30L, 1L },
                    { 141L, 2L, 31L, 1L },
                    { 142L, 3L, 32L, 1L },
                    { 143L, 2L, 33L, 1L },
                    { 214L, 2L, 6L, 1L },
                    { 215L, 1L, 7L, 1L },
                    { 216L, 3L, 8L, 1L },
                    { 241L, 2L, 21L, 1L },
                    { 242L, 1L, 22L, 1L },
                    { 243L, 2L, 23L, 1L },
                    { 384L, 1L, 14L, 1L },
                    { 385L, 3L, 15L, 1L },
                    { 386L, 1L, 16L, 1L },
                    { 390L, 1L, 27L, 6L },
                    { 370L, 2L, 20L, 21L },
                    { 276L, 3L, 15L, 26L },
                    { 277L, 1L, 16L, 26L },
                    { 278L, 1L, 17L, 26L },
                    { 233L, 3L, 27L, 46L },
                    { 234L, 2L, 28L, 46L },
                    { 235L, 2L, 29L, 46L },
                    { 244L, 1L, 1L, 51L },
                    { 245L, 1L, 2L, 51L },
                    { 246L, 1L, 3L, 51L },
                    { 247L, 2L, 4L, 51L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 73L, 3L, 27L, 56L },
                    { 74L, 2L, 28L, 56L },
                    { 225L, 2L, 15L, 56L },
                    { 226L, 3L, 16L, 56L },
                    { 371L, 2L, 17L, 56L },
                    { 469L, 2L, 18L, 56L },
                    { 470L, 2L, 19L, 56L },
                    { 538L, 1L, 7L, 56L },
                    { 356L, 2L, 31L, 41L },
                    { 21L, 2L, 12L, 61L },
                    { 355L, 1L, 30L, 41L },
                    { 264L, 2L, 9L, 41L },
                    { 465L, 2L, 39L, 26L },
                    { 526L, 1L, 40L, 26L },
                    { 537L, 2L, 35L, 26L },
                    { 413L, 3L, 6L, 31L },
                    { 414L, 2L, 7L, 31L },
                    { 508L, 2L, 29L, 31L },
                    { 509L, 3L, 30L, 31L },
                    { 510L, 2L, 31L, 31L },
                    { 493L, 2L, 16L, 36L },
                    { 494L, 2L, 17L, 36L },
                    { 96L, 1L, 7L, 41L },
                    { 97L, 2L, 8L, 41L },
                    { 180L, 3L, 25L, 41L },
                    { 181L, 2L, 26L, 41L },
                    { 182L, 1L, 27L, 41L },
                    { 354L, 2L, 29L, 41L },
                    { 498L, 2L, 63L, 22L },
                    { 499L, 1L, 64L, 22L },
                    { 189L, 3L, 54L, 27L },
                    { 548L, 3L, 133L, 13L },
                    { 549L, 3L, 134L, 13L },
                    { 558L, 1L, 144L, 13L },
                    { 559L, 3L, 145L, 13L },
                    { 560L, 3L, 146L, 13L },
                    { 26L, 3L, 124L, 18L },
                    { 547L, 3L, 132L, 13L },
                    { 27L, 1L, 125L, 18L },
                    { 207L, 2L, 102L, 18L },
                    { 208L, 1L, 103L, 18L },
                    { 209L, 1L, 104L, 18L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 317L, 2L, 146L, 18L },
                    { 318L, 3L, 147L, 18L },
                    { 319L, 3L, 148L, 18L },
                    { 28L, 3L, 126L, 18L },
                    { 484L, 1L, 138L, 13L },
                    { 483L, 2L, 137L, 13L },
                    { 482L, 2L, 136L, 13L },
                    { 429L, 3L, 127L, 3L },
                    { 430L, 3L, 128L, 3L },
                    { 62L, 1L, 128L, 8L },
                    { 63L, 1L, 129L, 8L },
                    { 156L, 2L, 100L, 8L },
                    { 157L, 3L, 101L, 8L },
                    { 265L, 2L, 73L, 8L },
                    { 266L, 1L, 74L, 8L },
                    { 308L, 1L, 129L, 13L },
                    { 309L, 3L, 130L, 13L },
                    { 310L, 1L, 131L, 13L },
                    { 330L, 2L, 95L, 13L },
                    { 331L, 2L, 96L, 13L },
                    { 332L, 1L, 97L, 13L },
                    { 351L, 2L, 135L, 13L },
                    { 335L, 2L, 142L, 18L },
                    { 336L, 3L, 143L, 18L },
                    { 337L, 3L, 144L, 18L },
                    { 382L, 1L, 114L, 18L },
                    { 187L, 3L, 102L, 38L },
                    { 188L, 3L, 103L, 38L },
                    { 403L, 1L, 83L, 38L },
                    { 404L, 2L, 84L, 38L },
                    { 1L, 1L, 92L, 43L },
                    { 2L, 1L, 93L, 43L },
                    { 3L, 3L, 94L, 43L },
                    { 239L, 1L, 95L, 43L },
                    { 240L, 3L, 96L, 43L },
                    { 349L, 3L, 71L, 43L },
                    { 350L, 2L, 72L, 43L },
                    { 48L, 2L, 97L, 48L },
                    { 57L, 3L, 140L, 48L },
                    { 58L, 1L, 141L, 48L },
                    { 59L, 3L, 142L, 48L },
                    { 186L, 1L, 101L, 38L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 79L, 2L, 120L, 3L },
                    { 122L, 2L, 140L, 38L },
                    { 86L, 3L, 97L, 38L },
                    { 383L, 2L, 115L, 18L },
                    { 576L, 1L, 90L, 18L },
                    { 184L, 1L, 110L, 23L },
                    { 185L, 3L, 111L, 23L },
                    { 197L, 3L, 128L, 23L },
                    { 198L, 3L, 129L, 23L },
                    { 129L, 2L, 91L, 28L },
                    { 279L, 1L, 103L, 28L },
                    { 280L, 3L, 104L, 28L },
                    { 274L, 1L, 104L, 33L },
                    { 275L, 3L, 105L, 33L },
                    { 402L, 2L, 138L, 33L },
                    { 466L, 3L, 126L, 33L },
                    { 467L, 3L, 127L, 33L },
                    { 468L, 1L, 128L, 33L },
                    { 121L, 3L, 139L, 38L },
                    { 78L, 2L, 119L, 3L },
                    { 532L, 1L, 60L, 97L },
                    { 531L, 3L, 59L, 97L },
                    { 435L, 1L, 53L, 52L },
                    { 436L, 2L, 54L, 52L },
                    { 437L, 2L, 55L, 52L },
                    { 151L, 1L, 64L, 57L },
                    { 152L, 2L, 65L, 57L },
                    { 153L, 2L, 66L, 57L },
                    { 237L, 3L, 63L, 57L },
                    { 589L, 2L, 61L, 57L },
                    { 590L, 3L, 62L, 57L },
                    { 584L, 3L, 45L, 62L },
                    { 585L, 1L, 46L, 62L },
                    { 586L, 2L, 47L, 62L },
                    { 11L, 2L, 60L, 67L },
                    { 31L, 3L, 46L, 67L },
                    { 32L, 2L, 47L, 67L },
                    { 120L, 2L, 59L, 52L },
                    { 33L, 1L, 48L, 67L },
                    { 119L, 1L, 58L, 52L },
                    { 473L, 3L, 47L, 47L },
                    { 190L, 3L, 55L, 27L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 447L, 1L, 53L, 27L },
                    { 489L, 3L, 52L, 27L },
                    { 6L, 2L, 47L, 37L },
                    { 7L, 1L, 48L, 37L },
                    { 42L, 2L, 69L, 37L },
                    { 43L, 2L, 70L, 37L },
                    { 456L, 2L, 49L, 37L },
                    { 457L, 2L, 50L, 37L },
                    { 527L, 3L, 43L, 42L },
                    { 75L, 2L, 63L, 47L },
                    { 76L, 3L, 64L, 47L },
                    { 77L, 3L, 65L, 47L },
                    { 471L, 3L, 45L, 47L },
                    { 472L, 2L, 46L, 47L },
                    { 118L, 1L, 57L, 52L },
                    { 511L, 3L, 435L, 95L },
                    { 422L, 2L, 43L, 67L },
                    { 448L, 2L, 45L, 67L },
                    { 72L, 3L, 47L, 82L },
                    { 106L, 3L, 68L, 82L },
                    { 107L, 3L, 69L, 82L },
                    { 108L, 1L, 70L, 82L },
                    { 594L, 2L, 52L, 82L },
                    { 595L, 2L, 53L, 82L },
                    { 596L, 1L, 54L, 82L },
                    { 458L, 3L, 67L, 87L },
                    { 459L, 1L, 68L, 87L },
                    { 460L, 1L, 69L, 87L },
                    { 461L, 3L, 45L, 87L },
                    { 462L, 3L, 46L, 87L },
                    { 201L, 1L, 43L, 97L },
                    { 202L, 2L, 44L, 97L },
                    { 203L, 3L, 45L, 97L },
                    { 71L, 1L, 46L, 82L },
                    { 423L, 3L, 44L, 67L },
                    { 70L, 2L, 45L, 82L },
                    { 582L, 2L, 55L, 77L },
                    { 4L, 3L, 57L, 72L },
                    { 5L, 2L, 58L, 72L },
                    { 9L, 3L, 62L, 72L },
                    { 10L, 3L, 63L, 72L },
                    { 338L, 1L, 70L, 72L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 593L, 1L, 61L, 72L },
                    { 36L, 3L, 52L, 77L },
                    { 37L, 2L, 53L, 77L },
                    { 38L, 1L, 54L, 77L },
                    { 206L, 3L, 51L, 77L },
                    { 333L, 3L, 48L, 77L },
                    { 334L, 2L, 49L, 77L },
                    { 479L, 1L, 60L, 77L },
                    { 480L, 2L, 61L, 77L },
                    { 481L, 3L, 62L, 77L },
                    { 583L, 1L, 56L, 77L },
                    { 512L, 2L, 436L, 95L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Posters",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 540L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 560L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 580L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 602L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 603L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 604L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 605L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 606L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 607L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 608L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 609L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 610L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 611L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 612L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 613L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 614L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 615L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 616L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 617L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 618L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 619L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 620L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 621L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 622L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 623L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 624L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 625L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 626L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 627L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 628L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 629L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 630L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 631L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 632L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 633L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 634L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 635L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 636L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 637L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 638L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 639L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 640L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 76L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 99L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 106L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 107L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 108L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 109L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 151L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 152L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 153L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 164L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 165L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 172L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 173L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 174L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 175L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 181L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 191L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 192L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 193L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 195L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 198L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 199L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 200L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 201L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 202L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 203L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 218L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 221L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 224L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 225L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 226L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 227L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 228L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 229L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 230L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 231L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 232L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 233L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 238L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 239L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 240L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 241L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 242L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 243L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 244L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 245L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 254L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 258L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 259L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 260L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 262L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 263L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 264L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 265L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 266L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 268L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 269L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 270L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 271L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 272L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 273L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 274L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 275L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 276L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 277L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 278L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 279L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 281L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 282L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 283L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 285L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 286L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 289L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 293L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 298L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 299L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 300L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 301L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 304L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 305L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 311L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 316L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 317L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 318L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 319L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 323L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 324L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 325L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 326L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 327L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 328L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 329L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 336L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 340L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 341L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 342L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 343L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 344L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 347L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 348L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 349L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 350L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 351L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 352L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 359L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 360L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 362L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 369L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 371L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 374L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 375L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 376L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 377L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 381L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 392L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 398L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 404L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 408L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 411L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 424L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 425L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 429L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 434L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 444L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 450L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 454L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 455L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 456L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 460L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 461L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 462L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 463L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 467L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 480L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 481L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 482L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 483L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 484L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 485L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 486L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 487L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 488L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 489L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 490L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 491L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 492L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 493L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 494L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 495L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 496L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 497L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 498L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 499L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 500L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 501L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 502L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 503L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 504L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 505L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 506L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 507L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 508L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 509L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 510L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 511L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 512L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 513L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 514L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 515L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 516L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 517L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 518L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 519L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 520L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 521L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 522L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 523L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 524L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 525L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 526L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 527L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 528L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 529L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 530L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 531L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 532L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 533L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 534L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 535L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 536L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 537L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 538L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 539L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 540L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 541L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 542L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 543L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 544L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 545L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 546L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 547L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 548L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 549L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 550L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 551L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 552L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 553L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 554L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 555L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 556L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 557L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 558L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 559L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 560L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 561L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 562L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 563L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 564L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 565L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 566L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 567L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 568L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 569L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 570L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 571L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 572L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 573L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 574L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 575L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 576L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 577L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 578L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 579L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 580L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 581L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 582L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 583L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 584L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 585L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 586L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 587L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 588L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 589L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 590L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 591L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 592L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 593L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 594L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 595L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 596L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 597L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 598L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 599L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 600L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 92L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 100L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 101L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 102L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 103L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 104L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 105L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 110L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 111L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 113L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 114L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 115L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 116L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 117L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 118L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 120L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 127L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 140L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 143L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 144L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 145L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 146L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 147L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 148L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 154L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 155L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 156L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 157L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 158L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 161L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 166L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 167L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 168L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 170L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 171L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 176L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 177L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 178L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 179L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 182L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 183L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 184L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 185L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 186L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 187L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 188L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 189L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 190L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 197L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 204L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 205L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 206L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 207L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 208L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 209L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 211L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 212L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 213L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 214L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 216L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 217L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 219L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 220L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 248L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 249L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 252L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 253L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 255L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 256L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 257L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 267L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 284L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 290L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 292L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 294L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 295L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 296L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 297L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 303L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 306L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 307L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 308L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 309L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 310L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 312L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 313L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 315L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 320L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 321L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 322L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 330L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 331L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 332L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 337L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 338L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 339L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 353L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 354L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 356L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 357L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 358L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 363L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 364L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 365L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 366L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 367L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 373L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 378L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 379L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 380L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 382L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 383L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 385L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 387L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 388L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 389L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 390L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 391L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 393L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 400L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 401L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 405L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 406L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 409L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 410L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 413L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 414L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 415L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 416L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 417L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 418L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 419L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 420L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 421L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 422L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 423L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 430L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 431L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 432L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 433L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 435L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 436L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 437L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 438L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 439L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 441L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 442L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 445L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 446L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 447L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 448L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 449L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 451L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 452L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 453L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 457L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 458L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 469L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 470L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 471L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 38L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 40L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 42L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 43L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 44L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 45L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 46L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 47L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 48L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 49L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 50L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 51L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 52L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 53L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 54L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 55L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 56L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 57L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 58L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 59L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 60L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 61L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 62L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 63L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 64L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 65L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 66L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 67L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 68L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 69L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 70L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 71L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 72L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 73L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 77L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 78L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 79L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 80L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 82L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 83L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 84L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 85L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 86L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 87L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 88L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 89L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 90L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 91L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 93L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 94L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 95L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 96L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 97L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Halls",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "SeatTypes",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "SeatTypes",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "SeatTypes",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "Id",
                keyValue: 1L);
        }
    }
}
