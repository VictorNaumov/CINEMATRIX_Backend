using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class ApplyDataConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price", "UrlPicture" },
                values: new object[,]
                {
                    { 1L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Small Plain Popcorn", 3m, "https://i.pinimg.com/564x/27/54/4b/27544b30e1f053ef55aefc2758184445.jpg" },
                    { 11L, "Melted cheese garnished with sliced chile peppers that is traditionally served with tortilla chips.", "Nacho Cheese", 5m, "https://i.pinimg.com/564x/97/c4/ac/97c4ac886aa8731e8ccf3e689be6a226.jpg" },
                    { 10L, "A sauce made of butter, water or broth, and seasonings, thickened with flour, and used also as a basis for the making of other sauces (such as caper sauce or shrimp sauce) by the addition of special ingredients.", "Butter Topping", 4m, "https://i.pinimg.com/564x/78/2d/c1/782dc1b23a49df94690528e9f355c477.jpg" },
                    { 9L, "A hot dog is a food consisting of a grilled or steamed sausage served in the slit of a partially sliced bun. The term hot dog can also refer to the sausage itself.", "Hot Dog", 3m, "https://i.pinimg.com/564x/6d/7c/9e/6d7c9e6e15e8206339eaa91c3b810ce7.jpg" },
                    { 8L, "Mozerella sticks are typically eaten with Marinara. However, ranch, Thai sweet chili, cocktail sauce, BBQ, hot sauce, regular mayonnaise, garlic aioli, buffalo sauce, ketchup, tzatziki, donair, alfredo, salsa, and hollandaise are all good sauces to try.", "Mozzarella Sticks", 5m, "https://i.pinimg.com/564x/b0/46/31/b046315f129b2b1e002b5c8183c893c7.jpg" },
                    { 7L, "A deep-fried strip of chicken without bones or skin. A flap of chicken meat found on, and easily detached from, the breast.", "Chicken Tenders", 5m, "https://i.pinimg.com/564x/f1/e6/1c/f1e61c6808735b1b69a4b28d83417382.jpg" },
                    { 12L, "A tortilla chip or nacho chips is a snack food made from corn tortillas, which are cut into wedges and then fried.", "Nachos", 3m, "https://i.pinimg.com/564x/d5/fa/fd/d5fafd4b3e1812c233fcff9412080601.jpg" },
                    { 5L, "A kind of fries characterized by their spring-like shape, being cut from whole potatoes using a specialized spiral slicer.", "Curcly Fries", 4m, "https://i.pinimg.com/564x/67/63/26/6763268fae390dfae890e73eeb96b51c.jpg" },
                    { 4L, "A pretzel is a handheld yeast bread that's usually shaped into a twisted knot.", "Pretzel Bites", 4m, "https://i.pinimg.com/564x/15/ed/22/15ed22eb6702c520995a7f146c088505.jpg" },
                    { 3L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Large Plain Popcorn", 6m, "https://i.pinimg.com/564x/ad/0b/be/ad0bbe7809102011d85f2e9bc87b7b90.jpg" },
                    { 2L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Medium Plain Popcorn", 4.5m, "https://i.pinimg.com/564x/fc/cf/dc/fccfdcbe5355ba1b2662d92c305b6402.jpg" },
                    { 6L, "French fries are long, thin pieces of potato fried in oil or fat. The French fries were thin and crispy. To cook the French fries, put them into a deep pan of oil.", "Fries", 3m, "https://i.pinimg.com/564x/7b/a7/f6/7ba7f65ae13d844bd26289b7ee8b8d8f.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "Description", "Name", "Projector", "Screen", "ScreenResolution", "SoundSystem" },
                values: new object[,]
                {
                    { 1L, "Comfortable recliner chairs with adjustable back tilt, leg support and individual tables for each chair.", "LUX", "Sony", "8,7 x 3,9", "4K", "Dolby 7,1" },
                    { 2L, "Soft sofas for two. The atmosphere of privacy and comfort in individual boxes.", "SWEET BOX", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 3L, "Standard seats. For two Sofa Love.", "SMALL HALL", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 4L, "Standard seats. For two Sofa Love.", "BIG HALL", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" },
                    { 5L, "Standard seats. For two Sofa Love.", "ATMOS", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" }
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
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 61L, 3L, 1, 1, 1L },
                    { 436L, 5L, 2, 9, 1L },
                    { 435L, 5L, 1, 9, 1L },
                    { 434L, 5L, 16, 8, 1L },
                    { 433L, 5L, 15, 8, 1L },
                    { 432L, 5L, 14, 8, 1L },
                    { 431L, 5L, 13, 8, 1L },
                    { 430L, 5L, 12, 8, 1L },
                    { 429L, 5L, 11, 8, 1L },
                    { 428L, 5L, 10, 8, 1L },
                    { 427L, 5L, 9, 8, 1L },
                    { 426L, 5L, 8, 8, 1L },
                    { 425L, 5L, 7, 8, 1L },
                    { 437L, 5L, 3, 9, 1L },
                    { 424L, 5L, 6, 8, 1L },
                    { 422L, 5L, 4, 8, 1L },
                    { 421L, 5L, 3, 8, 1L },
                    { 420L, 5L, 2, 8, 1L },
                    { 419L, 5L, 1, 8, 1L },
                    { 418L, 5L, 16, 7, 1L },
                    { 417L, 5L, 15, 7, 1L },
                    { 416L, 5L, 14, 7, 1L },
                    { 415L, 5L, 13, 7, 1L },
                    { 414L, 5L, 12, 7, 1L },
                    { 413L, 5L, 11, 7, 1L },
                    { 412L, 5L, 10, 7, 1L },
                    { 411L, 5L, 9, 7, 1L },
                    { 423L, 5L, 5, 8, 1L },
                    { 410L, 5L, 8, 7, 1L },
                    { 438L, 5L, 4, 9, 1L },
                    { 440L, 5L, 6, 9, 1L },
                    { 466L, 5L, 14, 10, 1L },
                    { 465L, 5L, 13, 10, 1L },
                    { 464L, 5L, 12, 10, 1L },
                    { 463L, 5L, 11, 10, 1L },
                    { 462L, 5L, 10, 10, 1L },
                    { 461L, 5L, 9, 10, 1L },
                    { 460L, 5L, 8, 10, 1L },
                    { 459L, 5L, 7, 10, 1L },
                    { 458L, 5L, 6, 10, 1L },
                    { 457L, 5L, 5, 10, 1L },
                    { 456L, 5L, 4, 10, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 455L, 5L, 3, 10, 1L },
                    { 439L, 5L, 5, 9, 1L },
                    { 454L, 5L, 2, 10, 1L },
                    { 452L, 5L, 18, 9, 1L },
                    { 451L, 5L, 17, 9, 1L },
                    { 450L, 5L, 16, 9, 1L },
                    { 449L, 5L, 15, 9, 1L },
                    { 448L, 5L, 14, 9, 1L },
                    { 447L, 5L, 13, 9, 1L },
                    { 446L, 5L, 12, 9, 1L },
                    { 445L, 5L, 11, 9, 1L },
                    { 444L, 5L, 10, 9, 1L },
                    { 443L, 5L, 9, 9, 1L },
                    { 442L, 5L, 8, 9, 1L },
                    { 441L, 5L, 7, 9, 1L },
                    { 453L, 5L, 1, 10, 1L },
                    { 467L, 5L, 15, 10, 1L },
                    { 409L, 5L, 7, 7, 1L },
                    { 407L, 5L, 5, 7, 1L },
                    { 376L, 5L, 6, 5, 1L },
                    { 375L, 5L, 5, 5, 1L },
                    { 374L, 5L, 4, 5, 1L },
                    { 373L, 5L, 3, 5, 1L },
                    { 372L, 5L, 2, 5, 1L },
                    { 371L, 5L, 1, 5, 1L },
                    { 370L, 5L, 16, 4, 1L },
                    { 369L, 5L, 15, 4, 1L },
                    { 368L, 5L, 14, 4, 1L },
                    { 367L, 5L, 13, 4, 1L },
                    { 366L, 5L, 12, 4, 1L },
                    { 365L, 5L, 11, 4, 1L },
                    { 377L, 5L, 7, 5, 1L },
                    { 364L, 5L, 10, 4, 1L },
                    { 362L, 5L, 8, 4, 1L },
                    { 361L, 5L, 7, 4, 1L },
                    { 360L, 5L, 6, 4, 1L },
                    { 359L, 5L, 5, 4, 1L },
                    { 358L, 5L, 4, 4, 1L },
                    { 357L, 5L, 3, 4, 1L },
                    { 356L, 5L, 2, 4, 1L },
                    { 355L, 5L, 1, 4, 1L },
                    { 354L, 5L, 16, 3, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 353L, 5L, 15, 3, 1L },
                    { 352L, 5L, 14, 3, 1L },
                    { 351L, 5L, 13, 3, 1L },
                    { 363L, 5L, 9, 4, 1L },
                    { 408L, 5L, 6, 7, 1L },
                    { 378L, 5L, 8, 5, 1L },
                    { 380L, 5L, 10, 5, 1L },
                    { 406L, 5L, 4, 7, 1L },
                    { 405L, 5L, 3, 7, 1L },
                    { 404L, 5L, 2, 7, 1L },
                    { 403L, 5L, 1, 7, 1L },
                    { 402L, 5L, 16, 6, 1L },
                    { 401L, 5L, 15, 6, 1L },
                    { 400L, 5L, 14, 6, 1L },
                    { 399L, 5L, 13, 6, 1L },
                    { 398L, 5L, 12, 6, 1L },
                    { 397L, 5L, 11, 6, 1L },
                    { 396L, 5L, 10, 6, 1L },
                    { 395L, 5L, 9, 6, 1L },
                    { 379L, 5L, 9, 5, 1L },
                    { 394L, 5L, 8, 6, 1L },
                    { 392L, 5L, 6, 6, 1L },
                    { 391L, 5L, 5, 6, 1L },
                    { 390L, 5L, 4, 6, 1L },
                    { 389L, 5L, 3, 6, 1L },
                    { 388L, 5L, 2, 6, 1L },
                    { 387L, 5L, 1, 6, 1L },
                    { 386L, 5L, 16, 5, 1L },
                    { 385L, 5L, 15, 5, 1L },
                    { 384L, 5L, 14, 5, 1L },
                    { 383L, 5L, 13, 5, 1L },
                    { 382L, 5L, 12, 5, 1L },
                    { 381L, 5L, 11, 5, 1L },
                    { 393L, 5L, 7, 6, 1L },
                    { 350L, 5L, 12, 3, 1L },
                    { 468L, 5L, 16, 10, 1L },
                    { 470L, 5L, 18, 10, 1L },
                    { 284L, 4L, 4, 10, 3L },
                    { 283L, 4L, 3, 10, 3L },
                    { 282L, 4L, 2, 10, 3L },
                    { 281L, 4L, 1, 10, 3L },
                    { 280L, 4L, 16, 9, 3L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 279L, 4L, 15, 9, 3L },
                    { 278L, 4L, 14, 9, 3L },
                    { 277L, 4L, 13, 9, 3L },
                    { 276L, 4L, 12, 9, 3L },
                    { 275L, 4L, 11, 9, 3L },
                    { 274L, 4L, 10, 9, 3L },
                    { 273L, 4L, 9, 9, 3L },
                    { 285L, 4L, 5, 10, 3L },
                    { 272L, 4L, 8, 9, 3L },
                    { 270L, 4L, 6, 9, 3L },
                    { 269L, 4L, 5, 9, 3L },
                    { 268L, 4L, 4, 9, 3L },
                    { 267L, 4L, 3, 9, 3L },
                    { 266L, 4L, 2, 9, 3L },
                    { 265L, 4L, 1, 9, 3L },
                    { 144L, 3L, 6, 7, 3L },
                    { 143L, 3L, 5, 7, 3L },
                    { 142L, 3L, 4, 7, 3L },
                    { 141L, 3L, 3, 7, 3L },
                    { 140L, 3L, 2, 7, 3L },
                    { 139L, 3L, 1, 7, 3L },
                    { 271L, 4L, 7, 9, 3L },
                    { 60L, 2L, 6, 6, 3L },
                    { 286L, 4L, 6, 10, 3L },
                    { 288L, 4L, 8, 10, 3L },
                    { 478L, 5L, 8, 11, 3L },
                    { 477L, 5L, 7, 11, 3L },
                    { 476L, 5L, 6, 11, 3L },
                    { 475L, 5L, 5, 11, 3L },
                    { 474L, 5L, 4, 11, 3L },
                    { 473L, 5L, 3, 11, 3L },
                    { 472L, 5L, 2, 11, 3L },
                    { 471L, 5L, 1, 11, 3L },
                    { 306L, 4L, 10, 11, 3L },
                    { 305L, 4L, 9, 11, 3L },
                    { 304L, 4L, 8, 11, 3L },
                    { 303L, 4L, 7, 11, 3L },
                    { 287L, 4L, 7, 10, 3L },
                    { 302L, 4L, 6, 11, 3L },
                    { 300L, 4L, 4, 11, 3L },
                    { 299L, 4L, 3, 11, 3L },
                    { 298L, 4L, 2, 11, 3L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 297L, 4L, 1, 11, 3L },
                    { 296L, 4L, 16, 10, 3L },
                    { 295L, 4L, 15, 10, 3L },
                    { 294L, 4L, 14, 10, 3L },
                    { 293L, 4L, 13, 10, 3L },
                    { 292L, 4L, 12, 10, 3L },
                    { 291L, 4L, 11, 10, 3L },
                    { 290L, 4L, 10, 10, 3L },
                    { 289L, 4L, 9, 10, 3L },
                    { 301L, 4L, 5, 11, 3L },
                    { 469L, 5L, 17, 10, 1L },
                    { 59L, 2L, 5, 6, 3L },
                    { 57L, 2L, 3, 6, 3L },
                    { 26L, 1L, 5, 4, 2L },
                    { 25L, 1L, 4, 4, 2L },
                    { 24L, 1L, 3, 4, 2L },
                    { 23L, 1L, 2, 4, 2L },
                    { 22L, 1L, 1, 4, 2L },
                    { 21L, 1L, 7, 3, 2L },
                    { 20L, 1L, 6, 3, 2L },
                    { 19L, 1L, 5, 3, 2L },
                    { 18L, 1L, 4, 3, 2L },
                    { 17L, 1L, 3, 3, 2L },
                    { 16L, 1L, 2, 3, 2L },
                    { 15L, 1L, 1, 3, 2L },
                    { 27L, 1L, 6, 4, 2L },
                    { 14L, 1L, 7, 2, 2L },
                    { 12L, 1L, 5, 2, 2L },
                    { 11L, 1L, 4, 2, 2L },
                    { 10L, 1L, 3, 2, 2L },
                    { 9L, 1L, 2, 2, 2L },
                    { 8L, 1L, 1, 2, 2L },
                    { 7L, 1L, 7, 1, 2L },
                    { 6L, 1L, 6, 1, 2L },
                    { 5L, 1L, 5, 1, 2L },
                    { 4L, 1L, 4, 1, 2L },
                    { 3L, 1L, 3, 1, 2L },
                    { 2L, 1L, 2, 1, 2L },
                    { 1L, 1L, 1, 1, 2L },
                    { 13L, 1L, 6, 2, 2L },
                    { 58L, 2L, 4, 6, 3L },
                    { 28L, 1L, 7, 4, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 30L, 2L, 1, 1, 3L },
                    { 56L, 2L, 2, 6, 3L },
                    { 55L, 2L, 1, 6, 3L },
                    { 54L, 2L, 5, 5, 3L },
                    { 53L, 2L, 4, 5, 3L },
                    { 52L, 2L, 3, 5, 3L },
                    { 51L, 2L, 2, 5, 3L },
                    { 50L, 2L, 1, 5, 3L },
                    { 49L, 2L, 5, 4, 3L },
                    { 48L, 2L, 4, 4, 3L },
                    { 47L, 2L, 3, 4, 3L },
                    { 46L, 2L, 2, 4, 3L },
                    { 45L, 2L, 1, 4, 3L },
                    { 29L, 1L, 8, 4, 2L },
                    { 44L, 2L, 5, 3, 3L },
                    { 42L, 2L, 3, 3, 3L },
                    { 41L, 2L, 2, 3, 3L },
                    { 40L, 2L, 1, 3, 3L },
                    { 39L, 2L, 5, 2, 3L },
                    { 38L, 2L, 4, 2, 3L },
                    { 37L, 2L, 3, 2, 3L },
                    { 36L, 2L, 2, 2, 3L },
                    { 35L, 2L, 1, 2, 3L },
                    { 34L, 2L, 5, 1, 3L },
                    { 33L, 2L, 4, 1, 3L },
                    { 32L, 2L, 3, 1, 3L },
                    { 31L, 2L, 2, 1, 3L },
                    { 43L, 2L, 4, 3, 3L },
                    { 349L, 5L, 11, 3, 1L },
                    { 348L, 5L, 10, 3, 1L },
                    { 347L, 5L, 9, 3, 1L },
                    { 153L, 4L, 9, 1, 1L },
                    { 152L, 4L, 8, 1, 1L },
                    { 151L, 4L, 7, 1, 1L },
                    { 150L, 4L, 6, 1, 1L },
                    { 149L, 4L, 5, 1, 1L },
                    { 148L, 4L, 4, 1, 1L },
                    { 147L, 4L, 3, 1, 1L },
                    { 146L, 4L, 2, 1, 1L },
                    { 145L, 4L, 1, 1, 1L },
                    { 138L, 3L, 13, 6, 1L },
                    { 137L, 3L, 12, 6, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 136L, 3L, 11, 6, 1L },
                    { 154L, 4L, 10, 1, 1L },
                    { 135L, 3L, 10, 6, 1L },
                    { 133L, 3L, 8, 6, 1L },
                    { 132L, 3L, 7, 6, 1L },
                    { 131L, 3L, 6, 6, 1L },
                    { 130L, 3L, 5, 6, 1L },
                    { 129L, 3L, 4, 6, 1L },
                    { 128L, 3L, 3, 6, 1L },
                    { 127L, 3L, 2, 6, 1L },
                    { 126L, 3L, 1, 6, 1L },
                    { 125L, 3L, 13, 5, 1L },
                    { 124L, 3L, 12, 5, 1L },
                    { 123L, 3L, 11, 5, 1L },
                    { 122L, 3L, 10, 5, 1L },
                    { 134L, 3L, 9, 6, 1L },
                    { 121L, 3L, 9, 5, 1L },
                    { 155L, 4L, 11, 1, 1L },
                    { 157L, 4L, 13, 1, 1L },
                    { 183L, 4L, 9, 3, 1L },
                    { 182L, 4L, 8, 3, 1L },
                    { 181L, 4L, 7, 3, 1L },
                    { 180L, 4L, 6, 3, 1L },
                    { 179L, 4L, 5, 3, 1L },
                    { 178L, 4L, 4, 3, 1L },
                    { 177L, 4L, 3, 3, 1L },
                    { 176L, 4L, 2, 3, 1L },
                    { 175L, 4L, 1, 3, 1L },
                    { 174L, 4L, 15, 2, 1L },
                    { 173L, 4L, 14, 2, 1L },
                    { 172L, 4L, 13, 2, 1L },
                    { 156L, 4L, 12, 1, 1L },
                    { 171L, 4L, 12, 2, 1L },
                    { 169L, 4L, 10, 2, 1L },
                    { 168L, 4L, 9, 2, 1L },
                    { 167L, 4L, 8, 2, 1L },
                    { 166L, 4L, 7, 2, 1L },
                    { 165L, 4L, 6, 2, 1L },
                    { 164L, 4L, 5, 2, 1L },
                    { 163L, 4L, 4, 2, 1L },
                    { 162L, 4L, 3, 2, 1L },
                    { 161L, 4L, 2, 2, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 160L, 4L, 1, 2, 1L },
                    { 159L, 4L, 15, 1, 1L },
                    { 158L, 4L, 14, 1, 1L },
                    { 170L, 4L, 11, 2, 1L },
                    { 184L, 4L, 10, 3, 1L },
                    { 120L, 3L, 8, 5, 1L },
                    { 118L, 3L, 6, 5, 1L },
                    { 87L, 3L, 1, 3, 1L },
                    { 86L, 3L, 13, 2, 1L },
                    { 85L, 3L, 12, 2, 1L },
                    { 84L, 3L, 11, 2, 1L },
                    { 83L, 3L, 10, 2, 1L },
                    { 82L, 3L, 9, 2, 1L },
                    { 81L, 3L, 8, 2, 1L },
                    { 80L, 3L, 7, 2, 1L },
                    { 79L, 3L, 6, 2, 1L },
                    { 78L, 3L, 5, 2, 1L },
                    { 77L, 3L, 4, 2, 1L },
                    { 76L, 3L, 3, 2, 1L },
                    { 88L, 3L, 2, 3, 1L },
                    { 75L, 3L, 2, 2, 1L },
                    { 73L, 3L, 13, 1, 1L },
                    { 72L, 3L, 12, 1, 1L },
                    { 71L, 3L, 11, 1, 1L },
                    { 70L, 3L, 10, 1, 1L },
                    { 69L, 3L, 9, 1, 1L },
                    { 68L, 3L, 8, 1, 1L },
                    { 67L, 3L, 7, 1, 1L },
                    { 66L, 3L, 6, 1, 1L },
                    { 65L, 3L, 5, 1, 1L },
                    { 64L, 3L, 4, 1, 1L },
                    { 63L, 3L, 3, 1, 1L },
                    { 62L, 3L, 2, 1, 1L },
                    { 74L, 3L, 1, 2, 1L },
                    { 119L, 3L, 7, 5, 1L },
                    { 89L, 3L, 3, 3, 1L },
                    { 91L, 3L, 5, 3, 1L },
                    { 117L, 3L, 5, 5, 1L },
                    { 116L, 3L, 4, 5, 1L },
                    { 115L, 3L, 3, 5, 1L },
                    { 114L, 3L, 2, 5, 1L },
                    { 113L, 3L, 1, 5, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 112L, 3L, 13, 4, 1L },
                    { 111L, 3L, 12, 4, 1L },
                    { 110L, 3L, 11, 4, 1L },
                    { 109L, 3L, 10, 4, 1L },
                    { 108L, 3L, 9, 4, 1L },
                    { 107L, 3L, 8, 4, 1L },
                    { 106L, 3L, 7, 4, 1L },
                    { 90L, 3L, 4, 3, 1L },
                    { 105L, 3L, 6, 4, 1L },
                    { 103L, 3L, 4, 4, 1L },
                    { 102L, 3L, 3, 4, 1L },
                    { 101L, 3L, 2, 4, 1L },
                    { 100L, 3L, 1, 4, 1L },
                    { 99L, 3L, 13, 3, 1L },
                    { 98L, 3L, 12, 3, 1L },
                    { 97L, 3L, 11, 3, 1L },
                    { 96L, 3L, 10, 3, 1L },
                    { 95L, 3L, 9, 3, 1L },
                    { 94L, 3L, 8, 3, 1L },
                    { 93L, 3L, 7, 3, 1L },
                    { 92L, 3L, 6, 3, 1L },
                    { 104L, 3L, 5, 4, 1L },
                    { 185L, 4L, 11, 3, 1L },
                    { 186L, 4L, 12, 3, 1L },
                    { 187L, 4L, 13, 3, 1L },
                    { 316L, 5L, 10, 1, 1L },
                    { 315L, 5L, 9, 1, 1L },
                    { 314L, 5L, 8, 1, 1L },
                    { 313L, 5L, 7, 1, 1L },
                    { 312L, 5L, 6, 1, 1L },
                    { 311L, 5L, 5, 1, 1L },
                    { 310L, 5L, 4, 1, 1L },
                    { 309L, 5L, 3, 1, 1L },
                    { 308L, 5L, 2, 1, 1L },
                    { 307L, 5L, 1, 1, 1L },
                    { 264L, 4L, 15, 8, 1L },
                    { 263L, 4L, 14, 8, 1L },
                    { 317L, 5L, 11, 1, 1L },
                    { 262L, 4L, 13, 8, 1L },
                    { 260L, 4L, 11, 8, 1L },
                    { 259L, 4L, 10, 8, 1L },
                    { 258L, 4L, 9, 8, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 257L, 4L, 8, 8, 1L },
                    { 256L, 4L, 7, 8, 1L },
                    { 255L, 4L, 6, 8, 1L },
                    { 254L, 4L, 5, 8, 1L },
                    { 253L, 4L, 4, 8, 1L },
                    { 252L, 4L, 3, 8, 1L },
                    { 251L, 4L, 2, 8, 1L },
                    { 250L, 4L, 1, 8, 1L },
                    { 249L, 4L, 15, 7, 1L },
                    { 261L, 4L, 12, 8, 1L },
                    { 248L, 4L, 14, 7, 1L },
                    { 318L, 5L, 12, 1, 1L },
                    { 320L, 5L, 14, 1, 1L },
                    { 346L, 5L, 8, 3, 1L },
                    { 345L, 5L, 7, 3, 1L },
                    { 344L, 5L, 6, 3, 1L },
                    { 343L, 5L, 5, 3, 1L },
                    { 342L, 5L, 4, 3, 1L },
                    { 341L, 5L, 3, 3, 1L },
                    { 340L, 5L, 2, 3, 1L },
                    { 339L, 5L, 1, 3, 1L },
                    { 338L, 5L, 16, 2, 1L },
                    { 337L, 5L, 15, 2, 1L },
                    { 336L, 5L, 14, 2, 1L },
                    { 335L, 5L, 13, 2, 1L },
                    { 319L, 5L, 13, 1, 1L },
                    { 334L, 5L, 12, 2, 1L },
                    { 332L, 5L, 10, 2, 1L },
                    { 331L, 5L, 9, 2, 1L },
                    { 330L, 5L, 8, 2, 1L },
                    { 329L, 5L, 7, 2, 1L },
                    { 328L, 5L, 6, 2, 1L },
                    { 327L, 5L, 5, 2, 1L },
                    { 326L, 5L, 4, 2, 1L },
                    { 325L, 5L, 3, 2, 1L },
                    { 324L, 5L, 2, 2, 1L },
                    { 323L, 5L, 1, 2, 1L },
                    { 322L, 5L, 16, 1, 1L },
                    { 321L, 5L, 15, 1, 1L },
                    { 333L, 5L, 11, 2, 1L },
                    { 247L, 4L, 13, 7, 1L },
                    { 246L, 4L, 12, 7, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 245L, 4L, 11, 7, 1L },
                    { 213L, 4L, 9, 5, 1L },
                    { 212L, 4L, 8, 5, 1L },
                    { 211L, 4L, 7, 5, 1L },
                    { 210L, 4L, 6, 5, 1L },
                    { 209L, 4L, 5, 5, 1L },
                    { 208L, 4L, 4, 5, 1L },
                    { 207L, 4L, 3, 5, 1L },
                    { 206L, 4L, 2, 5, 1L },
                    { 205L, 4L, 1, 5, 1L },
                    { 204L, 4L, 15, 4, 1L },
                    { 203L, 4L, 14, 4, 1L },
                    { 202L, 4L, 13, 4, 1L },
                    { 214L, 4L, 10, 5, 1L },
                    { 201L, 4L, 12, 4, 1L },
                    { 199L, 4L, 10, 4, 1L },
                    { 198L, 4L, 9, 4, 1L },
                    { 197L, 4L, 8, 4, 1L },
                    { 196L, 4L, 7, 4, 1L },
                    { 195L, 4L, 6, 4, 1L },
                    { 194L, 4L, 5, 4, 1L },
                    { 193L, 4L, 4, 4, 1L },
                    { 192L, 4L, 3, 4, 1L },
                    { 191L, 4L, 2, 4, 1L },
                    { 190L, 4L, 1, 4, 1L },
                    { 189L, 4L, 15, 3, 1L },
                    { 188L, 4L, 14, 3, 1L },
                    { 200L, 4L, 11, 4, 1L },
                    { 215L, 4L, 11, 5, 1L },
                    { 216L, 4L, 12, 5, 1L },
                    { 217L, 4L, 13, 5, 1L },
                    { 244L, 4L, 10, 7, 1L },
                    { 243L, 4L, 9, 7, 1L },
                    { 242L, 4L, 8, 7, 1L },
                    { 241L, 4L, 7, 7, 1L },
                    { 240L, 4L, 6, 7, 1L },
                    { 239L, 4L, 5, 7, 1L },
                    { 238L, 4L, 4, 7, 1L },
                    { 237L, 4L, 3, 7, 1L },
                    { 236L, 4L, 2, 7, 1L },
                    { 235L, 4L, 1, 7, 1L },
                    { 234L, 4L, 15, 6, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 233L, 4L, 14, 6, 1L },
                    { 232L, 4L, 13, 6, 1L },
                    { 231L, 4L, 12, 6, 1L },
                    { 230L, 4L, 11, 6, 1L },
                    { 229L, 4L, 10, 6, 1L },
                    { 228L, 4L, 9, 6, 1L },
                    { 227L, 4L, 8, 6, 1L },
                    { 226L, 4L, 7, 6, 1L },
                    { 225L, 4L, 6, 6, 1L },
                    { 224L, 4L, 5, 6, 1L },
                    { 223L, 4L, 4, 6, 1L },
                    { 222L, 4L, 3, 6, 1L },
                    { 221L, 4L, 2, 6, 1L },
                    { 220L, 4L, 1, 6, 1L },
                    { 219L, 4L, 15, 5, 1L },
                    { 218L, 4L, 14, 5, 1L },
                    { 479L, 5L, 9, 11, 3L },
                    { 480L, 5L, 10, 11, 3L }
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
                keyValue: 11L);

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
                keyValue: 24L);

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
                keyValue: 37L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 38L);

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
                keyValue: 41L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 42L);

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
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 82L);

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
                keyValue: 98L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 99L);

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
                keyValue: 121L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 122L);

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
                keyValue: 159L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 160L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 161L);

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
                keyValue: 180L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 181L);

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
                keyValue: 196L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 197L);

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
                keyValue: 218L);

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
                keyValue: 254L);

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
                keyValue: 267L);

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
                keyValue: 280L);

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
                keyValue: 284L);

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
                keyValue: 287L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 288L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 289L);

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
                keyValue: 293L);

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
                keyValue: 302L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 303L);

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
                keyValue: 311L);

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
                keyValue: 336L);

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
                keyValue: 346L);

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
                keyValue: 372L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 373L);

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
                keyValue: 381L);

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
                keyValue: 392L);

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
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 398L);

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
                keyValue: 402L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 403L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 404L);

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
                keyValue: 407L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 408L);

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
                keyValue: 411L);

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
                keyValue: 428L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 429L);

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
                keyValue: 434L);

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
                keyValue: 443L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 444L);

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
                keyValue: 450L);

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
                table: "Seats",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 473L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 474L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 475L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 476L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 477L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 478L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 479L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 480L);

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
        }
    }
}
