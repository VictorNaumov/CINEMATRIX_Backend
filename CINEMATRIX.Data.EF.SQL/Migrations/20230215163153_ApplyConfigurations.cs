using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CINEMATRIX.Data.EF.SQL.Migrations
{
    public partial class ApplyConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "Id", "Address", "ContactNumber", "Email", "Name" },
                values: new object[] { 1L, "Novopolotsk Pushkina street", "+37529281133", "cinematrix@gmail.com", "Cinematrix" });

            migrationBuilder.InsertData(
                table: "FAQs",
                columns: new[] { "Id", "Answer", "Category", "DateAdded", "Question" },
                values: new object[,]
                {
                    { 1L, "To make a reservation for seats, you need to select a movie, the date and time of the session, as well as select seats on the cinema map. After that, you need to enter your contact details and choose a payment method. After confirming the booking, you will receive an e-ticket to the specified email address.", "Seat reservation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How do I make a seat reservation??" },
                    { 2L, "Yes, you can return the ticket within 24 hours of purchase. To do this, you need to contact the cinema box office or contact our support service. Please note that when returning a ticket, a commission is charged, the amount of which depends on the terms of sale. Some tickets (for example, promotional ones) are non-refundable.", "Seat reservation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can I return the ticket?" },
                    { 3L, "In order to download an e-ticket, you need to log in to the cinema website using your account. In the \"My reservations\" section, you need to find the session for which you need to download a ticket and click on the \"Download\" button. The ticket will be saved in PDF format, which can be printed or shown on the phone screen at the entrance to the cinema.", "Tickets", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "How to download an e-ticket?" },
                    { 4L, "Yes, you can change the date and time of the session if possible. To do this, you need to contact the cinema box office or contact our support service. Please note that if the date and time of the session change, the ticket price may change.", "Seat reservation", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can I change the date and time of the session?" },
                    { 5L, "Yes, you can cancel your ticket if it is not yet time for the movie to start. To cancel your ticket, log in to your account on our website and go to the \"My bookings\" section. Find the booking that you want to cancel and click on the \"Cancel\" button. Please note that a cancellation fee may apply, depending on the terms and conditions of the ticket.", "Tickets", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can I cancel my ticket?" },
                    { 6L, "Yes, some movies may have age restrictions due to their content. These age restrictions are indicated on the movie page on our website and at the ticket counter. Children under the age of 18 must be accompanied by an adult to see movies with age restrictions.", "Movies", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Is there an age restriction for certain movies?" },
                    { 7L, "Our cinema is open every day from 10:00am to 11:00pm. The ticket counter opens at 9:30am and closes at 10:30pm. The concessions stand is open from 10:00am to 10:30pm. Please note that the cinema may be closed on certain holidays.", "Opening hours", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "What are the opening hours of the cinema?" },
                    { 8L, "Yes, we offer wheelchair access to all of our theaters. Please inform us in advance if you require wheelchair access so that we can reserve a suitable seat for you. You can do this by contacting our customer support or by mentioning it in the \"Special requests\" field when booking your tickets online.", "Accessibility", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Do you offer wheelchair access?" },
                    { 9L, "No, it is not allowed to bring your own food and drinks to the cinema. We have a concessions stand that offers a variety of snacks, drinks, and meals for you to enjoy during the movie. You are welcome to purchase food and drinks from the concessions stand or at one of our vending machines.", "Food and drinks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Can I bring my own food and drinks to the cinema?" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "Description", "Name", "Price", "UrlPicture" },
                values: new object[,]
                {
                    { 12L, "A tortilla chip or nacho chips is a snack food made from corn tortillas, which are cut into wedges and then fried.", "Nachos", 3m, "https://i.pinimg.com/564x/d5/fa/fd/d5fafd4b3e1812c233fcff9412080601.jpg" },
                    { 11L, "Melted cheese garnished with sliced chile peppers that is traditionally served with tortilla chips.", "Nacho Cheese", 5m, "https://i.pinimg.com/564x/97/c4/ac/97c4ac886aa8731e8ccf3e689be6a226.jpg" },
                    { 10L, "A sauce made of butter, water or broth, and seasonings, thickened with flour, and used also as a basis for the making of other sauces (such as caper sauce or shrimp sauce) by the addition of special ingredients.", "Butter Topping", 4m, "https://i.pinimg.com/564x/78/2d/c1/782dc1b23a49df94690528e9f355c477.jpg" },
                    { 9L, "A hot dog is a food consisting of a grilled or steamed sausage served in the slit of a partially sliced bun. The term hot dog can also refer to the sausage itself.", "Hot Dog", 3m, "https://i.pinimg.com/564x/6d/7c/9e/6d7c9e6e15e8206339eaa91c3b810ce7.jpg" },
                    { 8L, "Mozerella sticks are typically eaten with Marinara. However, ranch, Thai sweet chili, cocktail sauce, BBQ, hot sauce, regular mayonnaise, garlic aioli, buffalo sauce, ketchup, tzatziki, donair, alfredo, salsa, and hollandaise are all good sauces to try.", "Mozzarella Sticks", 5m, "https://i.pinimg.com/564x/b0/46/31/b046315f129b2b1e002b5c8183c893c7.jpg" },
                    { 7L, "A deep-fried strip of chicken without bones or skin. A flap of chicken meat found on, and easily detached from, the breast.", "Chicken Tenders", 5m, "https://i.pinimg.com/564x/f1/e6/1c/f1e61c6808735b1b69a4b28d83417382.jpg" },
                    { 6L, "French fries are long, thin pieces of potato fried in oil or fat. The French fries were thin and crispy. To cook the French fries, put them into a deep pan of oil.", "Fries", 3m, "https://i.pinimg.com/564x/7b/a7/f6/7ba7f65ae13d844bd26289b7ee8b8d8f.jpg" },
                    { 5L, "A kind of fries characterized by their spring-like shape, being cut from whole potatoes using a specialized spiral slicer.", "Curcly Fries", 4m, "https://i.pinimg.com/564x/67/63/26/6763268fae390dfae890e73eeb96b51c.jpg" },
                    { 4L, "A pretzel is a handheld yeast bread that's usually shaped into a twisted knot.", "Pretzel Bites", 4m, "https://i.pinimg.com/564x/15/ed/22/15ed22eb6702c520995a7f146c088505.jpg" },
                    { 3L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Large Plain Popcorn", 6m, "https://i.pinimg.com/564x/ad/0b/be/ad0bbe7809102011d85f2e9bc87b7b90.jpg" },
                    { 2L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Medium Plain Popcorn", 4.5m, "https://i.pinimg.com/564x/fc/cf/dc/fccfdcbe5355ba1b2662d92c305b6402.jpg" },
                    { 1L, "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.", "Small Plain Popcorn", 3m, "https://i.pinimg.com/564x/27/54/4b/27544b30e1f053ef55aefc2758184445.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Posters",
                columns: new[] { "Id", "IsRentMovie", "MovieId" },
                values: new object[,]
                {
                    { 20L, true, 999205L },
                    { 19L, true, 985939L },
                    { 18L, true, 961484L },
                    { 17L, true, 921360L },
                    { 16L, true, 916605L },
                    { 15L, true, 882598L },
                    { 14L, true, 877957L },
                    { 13L, true, 762504L },
                    { 12L, true, 760741L },
                    { 11L, true, 760161L },
                    { 4L, true, 576925L },
                    { 9L, true, 744276L },
                    { 10L, true, 756999L },
                    { 2L, true, 526896L },
                    { 3L, true, 539681L },
                    { 1L, true, 19995L },
                    { 6L, true, 634649L },
                    { 7L, true, 639933L },
                    { 8L, true, 718930L },
                    { 5L, true, 610150L }
                });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "DateOfBirth", "ImageUrl", "Name", "PhoneNumber", "SecondName" },
                values: new object[,]
                {
                    { 1L, new DateTime(2003, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "Admin", "+375291111111", "Admin" },
                    { 2L, new DateTime(2002, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "Staff", "+375291111112", "Staff" },
                    { 3L, new DateTime(2001, 2, 15, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "User", "+375291111113", "User" }
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
                table: "FavoriteMovies",
                columns: new[] { "Id", "MovieId", "ProfileId", "Rating" },
                values: new object[,]
                {
                    { 10L, 760741L, 3L, 3 },
                    { 6L, 718930L, 2L, 3 },
                    { 2L, 576925L, 2L, 4 },
                    { 4L, 634649L, 3L, 5 },
                    { 7L, 744276L, 3L, 4 },
                    { 1L, 539681L, 1L, 5 },
                    { 3L, 610150L, 1L, 3 },
                    { 5L, 639933L, 1L, 4 },
                    { 8L, 756999L, 1L, 5 },
                    { 9L, 760161L, 2L, 4 }
                });

            migrationBuilder.InsertData(
                table: "Halls",
                columns: new[] { "Id", "CinemaId", "Description", "Name", "Projector", "Screen", "ScreenResolution", "SoundSystem" },
                values: new object[,]
                {
                    { 1L, 1L, "Comfortable recliner chairs with adjustable back tilt, leg support and individual tables for each chair.", "LUX", "Sony", "8,7 x 3,9", "4K", "Dolby 7,1" },
                    { 4L, 1L, "Standard seats. For two Sofa Love.", "BIG HALL", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" },
                    { 3L, 1L, "Standard seats. For two Sofa Love.", "SMALL HALL", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 2L, 1L, "Soft sofas for two. The atmosphere of privacy and comfort in individual boxes.", "SWEET BOX", "Sony", "8,7 х 3,9", "4K", "Dolby 7,1" },
                    { 5L, 1L, "Standard seats. For two Sofa Love.", "ATMOS", "Sony", "13,3 x 5,7", "4K", "Dolby 7,1" }
                });

            migrationBuilder.InsertData(
                table: "MovieComments",
                columns: new[] { "Id", "DateTime", "IsDeleted", "MovieId", "ParentCommentId", "ProfileId", "Text" },
                values: new object[,]
                {
                    { 12L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9510), false, 526896L, null, 2L, "I thought the acting was a bit weak, but the plot was intriguing." },
                    { 7L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9501), false, 19995L, null, 2L, "I thought the plot was a bit predictable, but the action scenes were great." },
                    { 5L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9498), false, 19995L, null, 2L, "I was blown away by the visuals in this film. The story was a bit weak, but overall it was a great movie experience." },
                    { 3L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9494), false, 19995L, null, 2L, "I was really disappointed in this movie. The plot was too predictable and the acting was subpar." },
                    { 11L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9508), false, 526896L, null, 1L, "This movie was really good! I really enjoyed the action and special effects." },
                    { 10L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9507), false, 19995L, null, 1L, "I wasn't a huge fan of the movie overall. It was okay, but not one of my favorites." },
                    { 8L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9502), false, 19995L, null, 1L, "I totally agree about the special effects, they were some of the best I've ever seen in a movie." },
                    { 6L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9499), false, 19995L, null, 1L, "This movie was amazing! The special effects were unbelievable." },
                    { 4L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9496), false, 19995L, null, 1L, "I thought the plot was interesting and the acting was solid. Definitely worth a watch!" },
                    { 1L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(2299), false, 19995L, null, 1L, "I absolutely loved this movie! The visual effects were stunning and the story was captivating." },
                    { 2L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9466), false, 19995L, null, 2L, "I agree, the special effects in this movie were groundbreaking. The plot was a bit predictable, but overall it was an enjoyable film." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "IsEmailConfirmed", "Password", "ProfileId", "RoleId", "UserName" },
                values: new object[,]
                {
                    { 2L, "staff@gmail.com", false, "staff", 2L, 2L, "staff" },
                    { 1L, "admin@gmail.com", false, "admin", 1L, 1L, "admin" },
                    { 3L, "user@gmail.com", false, "user", 3L, 3L, "user" }
                });

            migrationBuilder.InsertData(
                table: "MovieComments",
                columns: new[] { "Id", "DateTime", "IsDeleted", "MovieId", "ParentCommentId", "ProfileId", "Text" },
                values: new object[,]
                {
                    { 14L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9512), false, 526896L, 12L, 2L, "I disagree, I thought the acting was top notch and really brought the characters to life." },
                    { 9L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9506), false, 19995L, 8L, 2L, "I thought the plot was actually really interesting and kept me engaged throughout the movie." },
                    { 13L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9511), false, 526896L, 11L, 3L, "I agree, the action scenes were definitely a highlight of the film." }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 227L, 4L, 7, 5, 1L },
                    { 228L, 4L, 8, 5, 1L },
                    { 229L, 4L, 9, 5, 1L },
                    { 230L, 4L, 10, 5, 1L },
                    { 231L, 4L, 11, 5, 1L },
                    { 232L, 4L, 12, 5, 1L },
                    { 233L, 4L, 13, 5, 1L },
                    { 234L, 4L, 14, 5, 1L },
                    { 235L, 4L, 15, 5, 1L },
                    { 236L, 4L, 16, 5, 1L },
                    { 237L, 4L, 17, 5, 1L },
                    { 238L, 4L, 18, 5, 1L },
                    { 239L, 4L, 1, 6, 1L },
                    { 240L, 4L, 2, 6, 1L },
                    { 241L, 4L, 3, 6, 1L },
                    { 242L, 4L, 4, 6, 1L },
                    { 243L, 4L, 5, 6, 1L },
                    { 226L, 4L, 6, 5, 1L },
                    { 225L, 4L, 5, 5, 1L },
                    { 224L, 4L, 4, 5, 1L },
                    { 223L, 4L, 3, 5, 1L },
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
                    { 222L, 4L, 2, 5, 1L },
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
                    { 203L, 4L, 1, 4, 1L },
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
                    { 261L, 4L, 5, 7, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 262L, 4L, 6, 7, 1L },
                    { 263L, 4L, 7, 7, 1L },
                    { 264L, 4L, 8, 7, 1L },
                    { 265L, 4L, 9, 7, 1L },
                    { 266L, 4L, 10, 7, 1L },
                    { 268L, 4L, 12, 7, 1L },
                    { 202L, 4L, 18, 3, 1L },
                    { 200L, 4L, 16, 3, 1L },
                    { 290L, 4L, 16, 8, 1L },
                    { 135L, 3L, 5, 6, 1L },
                    { 136L, 3L, 6, 6, 1L },
                    { 137L, 3L, 7, 6, 1L },
                    { 138L, 3L, 8, 6, 1L },
                    { 139L, 3L, 9, 6, 1L },
                    { 140L, 3L, 10, 6, 1L },
                    { 141L, 3L, 11, 6, 1L },
                    { 142L, 3L, 12, 6, 1L },
                    { 134L, 3L, 4, 6, 1L },
                    { 143L, 3L, 1, 7, 3L },
                    { 145L, 3L, 3, 7, 3L },
                    { 146L, 3L, 4, 7, 3L },
                    { 147L, 3L, 5, 7, 3L },
                    { 148L, 3L, 6, 7, 3L },
                    { 149L, 4L, 1, 1, 1L },
                    { 150L, 4L, 2, 1, 1L },
                    { 151L, 4L, 3, 1, 1L },
                    { 152L, 4L, 4, 1, 1L },
                    { 144L, 3L, 2, 7, 3L },
                    { 133L, 3L, 3, 6, 1L },
                    { 132L, 3L, 2, 6, 1L },
                    { 131L, 3L, 1, 6, 1L },
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
                    { 130L, 3L, 12, 5, 1L },
                    { 153L, 4L, 5, 1, 1L },
                    { 154L, 4L, 6, 1, 1L },
                    { 155L, 4L, 7, 1, 1L },
                    { 156L, 4L, 8, 1, 1L },
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
                    { 199L, 4L, 15, 3, 1L },
                    { 180L, 4L, 14, 2, 1L },
                    { 201L, 4L, 17, 3, 1L },
                    { 179L, 4L, 13, 2, 1L },
                    { 177L, 4L, 11, 2, 1L },
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
                    { 172L, 4L, 6, 2, 1L },
                    { 173L, 4L, 7, 2, 1L },
                    { 175L, 4L, 9, 2, 1L },
                    { 176L, 4L, 10, 2, 1L },
                    { 178L, 4L, 12, 2, 1L },
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
                    { 425L, 5L, 1, 7, 2L },
                    { 426L, 5L, 2, 7, 2L },
                    { 418L, 5L, 10, 6, 1L },
                    { 407L, 5L, 15, 5, 1L },
                    { 406L, 5L, 14, 5, 1L },
                    { 405L, 5L, 13, 5, 1L },
                    { 386L, 5L, 10, 4, 1L },
                    { 387L, 5L, 11, 4, 1L },
                    { 388L, 5L, 12, 4, 1L },
                    { 389L, 5L, 13, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 390L, 5L, 14, 4, 1L },
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
                    { 427L, 5L, 3, 7, 2L },
                    { 428L, 5L, 4, 7, 2L },
                    { 429L, 5L, 5, 7, 2L },
                    { 430L, 5L, 6, 7, 2L },
                    { 454L, 5L, 14, 8, 2L },
                    { 455L, 5L, 15, 8, 2L },
                    { 456L, 5L, 16, 8, 2L },
                    { 457L, 5L, 1, 9, 3L },
                    { 458L, 5L, 2, 9, 3L },
                    { 459L, 5L, 3, 9, 3L },
                    { 460L, 5L, 4, 9, 3L },
                    { 461L, 5L, 5, 9, 3L },
                    { 462L, 5L, 6, 9, 3L },
                    { 463L, 5L, 7, 9, 3L },
                    { 464L, 5L, 8, 9, 3L },
                    { 465L, 5L, 1, 10, 3L },
                    { 466L, 5L, 2, 10, 3L },
                    { 467L, 5L, 3, 10, 3L },
                    { 468L, 5L, 4, 10, 3L },
                    { 469L, 5L, 5, 10, 3L },
                    { 470L, 5L, 6, 10, 3L },
                    { 471L, 5L, 7, 10, 3L },
                    { 472L, 5L, 8, 10, 3L },
                    { 453L, 5L, 13, 8, 2L },
                    { 385L, 5L, 9, 4, 1L },
                    { 452L, 5L, 12, 8, 2L },
                    { 450L, 5L, 10, 8, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 431L, 5L, 7, 7, 2L },
                    { 432L, 5L, 8, 7, 2L },
                    { 433L, 5L, 9, 7, 2L },
                    { 434L, 5L, 10, 7, 2L },
                    { 435L, 5L, 11, 7, 2L },
                    { 436L, 5L, 12, 7, 2L },
                    { 437L, 5L, 13, 7, 2L },
                    { 438L, 5L, 14, 7, 2L },
                    { 439L, 5L, 15, 7, 2L },
                    { 440L, 5L, 16, 7, 2L },
                    { 441L, 5L, 1, 8, 2L },
                    { 442L, 5L, 2, 8, 2L },
                    { 443L, 5L, 3, 8, 2L },
                    { 444L, 5L, 4, 8, 2L },
                    { 445L, 5L, 5, 8, 2L },
                    { 446L, 5L, 6, 8, 2L },
                    { 447L, 5L, 7, 8, 2L },
                    { 448L, 5L, 8, 8, 2L },
                    { 449L, 5L, 9, 8, 2L },
                    { 451L, 5L, 11, 8, 2L },
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
                    { 335L, 5L, 7, 1, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 316L, 4L, 6, 10, 3L },
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
                    { 111L, 3L, 5, 4, 1L },
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
                    { 377L, 5L, 1, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 378L, 5L, 2, 4, 1L },
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
                    { 110L, 3L, 4, 4, 1L },
                    { 174L, 4L, 8, 2, 1L },
                    { 108L, 3L, 2, 4, 1L },
                    { 50L, 2L, 5, 2, 3L },
                    { 49L, 2L, 4, 2, 3L },
                    { 48L, 2L, 3, 2, 3L },
                    { 47L, 2L, 2, 2, 3L },
                    { 46L, 2L, 1, 2, 3L },
                    { 45L, 2L, 5, 1, 3L },
                    { 51L, 2L, 1, 3, 3L },
                    { 44L, 2L, 4, 1, 3L },
                    { 42L, 2L, 2, 1, 3L },
                    { 41L, 2L, 1, 1, 3L },
                    { 109L, 3L, 3, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 40L, 1L, 8, 5, 2L },
                    { 39L, 1L, 7, 5, 2L },
                    { 38L, 1L, 6, 5, 2L },
                    { 43L, 2L, 3, 1, 3L },
                    { 37L, 1L, 5, 5, 2L },
                    { 52L, 2L, 2, 3, 3L },
                    { 54L, 2L, 4, 3, 3L },
                    { 68L, 2L, 3, 6, 3L },
                    { 67L, 2L, 2, 6, 3L },
                    { 66L, 2L, 1, 6, 3L },
                    { 65L, 2L, 5, 5, 3L },
                    { 64L, 2L, 4, 5, 3L },
                    { 63L, 2L, 3, 5, 3L },
                    { 53L, 2L, 3, 3, 3L },
                    { 62L, 2L, 2, 5, 3L },
                    { 60L, 2L, 5, 4, 3L },
                    { 59L, 2L, 4, 4, 3L },
                    { 58L, 2L, 3, 4, 3L },
                    { 57L, 2L, 2, 4, 3L },
                    { 56L, 2L, 1, 4, 3L },
                    { 55L, 2L, 5, 3, 3L },
                    { 61L, 2L, 1, 5, 3L },
                    { 69L, 2L, 4, 6, 3L },
                    { 36L, 1L, 4, 5, 2L },
                    { 34L, 1L, 2, 5, 2L },
                    { 15L, 1L, 7, 2, 2L },
                    { 14L, 1L, 6, 2, 2L },
                    { 13L, 1L, 5, 2, 2L },
                    { 12L, 1L, 4, 2, 2L },
                    { 11L, 1L, 3, 2, 2L },
                    { 10L, 1L, 2, 2, 2L },
                    { 16L, 1L, 8, 2, 2L },
                    { 9L, 1L, 1, 2, 2L },
                    { 7L, 1L, 7, 1, 2L },
                    { 6L, 1L, 6, 1, 2L },
                    { 5L, 1L, 5, 1, 2L },
                    { 4L, 1L, 4, 1, 2L },
                    { 3L, 1L, 3, 1, 2L },
                    { 2L, 1L, 2, 1, 2L },
                    { 8L, 1L, 8, 1, 2L },
                    { 35L, 1L, 3, 5, 2L },
                    { 17L, 1L, 1, 3, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 19L, 1L, 3, 3, 2L },
                    { 33L, 1L, 1, 5, 2L },
                    { 32L, 1L, 8, 4, 2L },
                    { 31L, 1L, 7, 4, 2L },
                    { 30L, 1L, 6, 4, 2L },
                    { 29L, 1L, 5, 4, 2L },
                    { 28L, 1L, 4, 4, 2L },
                    { 18L, 1L, 2, 3, 2L },
                    { 27L, 1L, 3, 4, 2L },
                    { 25L, 1L, 1, 4, 2L },
                    { 24L, 1L, 8, 3, 2L },
                    { 23L, 1L, 7, 3, 2L },
                    { 22L, 1L, 6, 3, 2L },
                    { 21L, 1L, 5, 3, 2L },
                    { 20L, 1L, 4, 3, 2L },
                    { 26L, 1L, 2, 4, 2L },
                    { 70L, 2L, 5, 6, 3L },
                    { 1L, 1L, 1, 1, 2L },
                    { 96L, 3L, 2, 3, 1L },
                    { 80L, 3L, 10, 1, 1L },
                    { 82L, 3L, 12, 1, 1L },
                    { 83L, 3L, 1, 2, 1L },
                    { 84L, 3L, 2, 2, 1L },
                    { 85L, 3L, 3, 2, 1L },
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
                    { 97L, 3L, 3, 3, 1L },
                    { 98L, 3L, 4, 3, 1L },
                    { 99L, 3L, 5, 3, 1L },
                    { 100L, 3L, 6, 3, 1L },
                    { 101L, 3L, 7, 3, 1L },
                    { 102L, 3L, 8, 3, 1L },
                    { 103L, 3L, 9, 3, 1L },
                    { 104L, 3L, 10, 3, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 105L, 3L, 11, 3, 1L },
                    { 106L, 3L, 12, 3, 1L },
                    { 79L, 3L, 9, 1, 1L },
                    { 78L, 3L, 8, 1, 1L },
                    { 81L, 3L, 11, 1, 1L },
                    { 76L, 3L, 6, 1, 1L },
                    { 75L, 3L, 5, 1, 1L },
                    { 77L, 3L, 7, 1, 1L },
                    { 74L, 3L, 4, 1, 1L },
                    { 73L, 3L, 3, 1, 1L },
                    { 72L, 3L, 2, 1, 1L },
                    { 71L, 3L, 1, 1, 1L },
                    { 107L, 3L, 1, 4, 1L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 346L, new DateTime(2023, 2, 22, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L, "Beast" },
                    { 351L, new DateTime(2023, 2, 22, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" },
                    { 356L, new DateTime(2023, 2, 22, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L, "Fall" },
                    { 361L, new DateTime(2023, 2, 23, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L, "Smile" },
                    { 261L, new DateTime(2023, 2, 20, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L, "The_Infernal_Machine" },
                    { 266L, new DateTime(2023, 2, 20, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 341L, new DateTime(2023, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 256L, new DateTime(2023, 2, 20, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 251L, new DateTime(2023, 2, 20, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L, "The_Infernal_Machine" },
                    { 246L, new DateTime(2023, 2, 20, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L, "Stowaway" },
                    { 366L, new DateTime(2023, 2, 23, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 336L, new DateTime(2023, 2, 22, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L, "Avatar" },
                    { 271L, new DateTime(2023, 2, 20, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L, "Beast" },
                    { 326L, new DateTime(2023, 2, 22, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L, "Bullet_Train" },
                    { 321L, new DateTime(2023, 2, 22, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" },
                    { 316L, new DateTime(2023, 2, 21, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L, "Beast" },
                    { 311L, new DateTime(2023, 2, 21, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 306L, new DateTime(2023, 2, 21, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 301L, new DateTime(2023, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L, "The_Northman" },
                    { 296L, new DateTime(2023, 2, 21, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 291L, new DateTime(2023, 2, 21, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L, "Fall" },
                    { 286L, new DateTime(2023, 2, 21, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 281L, new DateTime(2023, 2, 21, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L, "The_Infernal_Machine" },
                    { 276L, new DateTime(2023, 2, 20, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L, "Drifting_Home" },
                    { 241L, new DateTime(2023, 2, 20, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 331L, new DateTime(2023, 2, 22, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L, "Fall" },
                    { 236L, new DateTime(2023, 2, 19, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L, "The_Infernal_Machine" },
                    { 173L, new DateTime(2023, 2, 18, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 226L, new DateTime(2023, 2, 19, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L, "The_Infernal_Machine" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 106L, new DateTime(2023, 2, 16, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 111L, new DateTime(2023, 2, 16, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 116L, new DateTime(2023, 2, 16, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 121L, new DateTime(2023, 2, 17, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 126L, new DateTime(2023, 2, 17, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 131L, new DateTime(2023, 2, 17, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L, "Morbius" },
                    { 136L, new DateTime(2023, 2, 17, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 141L, new DateTime(2023, 2, 17, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 146L, new DateTime(2023, 2, 17, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L, "The_Northman" },
                    { 151L, new DateTime(2023, 2, 17, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L, "Nope" },
                    { 156L, new DateTime(2023, 2, 17, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L, "Smile" },
                    { 161L, new DateTime(2023, 2, 18, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 166L, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 171L, new DateTime(2023, 2, 18, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L, "Avatar" },
                    { 176L, new DateTime(2023, 2, 18, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 181L, new DateTime(2023, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L, "Drifting_Home" },
                    { 186L, new DateTime(2023, 2, 18, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 191L, new DateTime(2023, 2, 18, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 196L, new DateTime(2023, 2, 18, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 371L, new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L, "Nope" },
                    { 201L, new DateTime(2023, 2, 19, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 206L, new DateTime(2023, 2, 19, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" },
                    { 211L, new DateTime(2023, 2, 19, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 216L, new DateTime(2023, 2, 19, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L, "Drifting_Home" },
                    { 221L, new DateTime(2023, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 231L, new DateTime(2023, 2, 19, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 376L, new DateTime(2023, 2, 23, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L, "Drifting_Home" },
                    { 381L, new DateTime(2023, 2, 23, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 386L, new DateTime(2023, 2, 23, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 454L, new DateTime(2023, 2, 25, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 459L, new DateTime(2023, 2, 25, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L, "Morbius" },
                    { 464L, new DateTime(2023, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 469L, new DateTime(2023, 2, 25, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L, "The_Northman" },
                    { 474L, new DateTime(2023, 2, 25, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 479L, new DateTime(2023, 2, 25, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 484L, new DateTime(2023, 2, 26, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L, "Smile" },
                    { 489L, new DateTime(2023, 2, 26, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 494L, new DateTime(2023, 2, 26, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 499L, new DateTime(2023, 2, 26, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 504L, new DateTime(2023, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 509L, new DateTime(2023, 2, 26, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 514L, new DateTime(2023, 2, 26, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 519L, new DateTime(2023, 2, 26, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 524L, new DateTime(2023, 2, 27, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" },
                    { 529L, new DateTime(2023, 2, 27, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 534L, new DateTime(2023, 2, 27, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L, "Bullet_Train" },
                    { 539L, new DateTime(2023, 2, 27, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 544L, new DateTime(2023, 2, 27, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 449L, new DateTime(2023, 2, 25, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 444L, new DateTime(2023, 2, 25, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 439L, new DateTime(2023, 2, 24, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L, "The_Infernal_Machine" },
                    { 434L, new DateTime(2023, 2, 24, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 334L, new DateTime(2023, 2, 22, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 339L, new DateTime(2023, 2, 22, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" },
                    { 344L, new DateTime(2023, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L, "The_Infernal_Machine" },
                    { 349L, new DateTime(2023, 2, 22, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L, "Stowaway" },
                    { 354L, new DateTime(2023, 2, 22, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L, "After_Ever_Happy" },
                    { 359L, new DateTime(2023, 2, 22, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 364L, new DateTime(2023, 2, 23, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 369L, new DateTime(2023, 2, 23, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 374L, new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 549L, new DateTime(2023, 2, 27, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 379L, new DateTime(2023, 2, 23, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 389L, new DateTime(2023, 2, 23, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 394L, new DateTime(2023, 2, 23, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" },
                    { 399L, new DateTime(2023, 2, 23, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 404L, new DateTime(2023, 2, 24, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L, "The_Infernal_Machine" },
                    { 409L, new DateTime(2023, 2, 24, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L, "After_Ever_Happy" },
                    { 414L, new DateTime(2023, 2, 24, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 419L, new DateTime(2023, 2, 24, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L, "Orphan_First_Kill" },
                    { 424L, new DateTime(2023, 2, 24, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" },
                    { 429L, new DateTime(2023, 2, 24, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 384L, new DateTime(2023, 2, 23, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L, "Morbius" },
                    { 101L, new DateTime(2023, 2, 16, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 554L, new DateTime(2023, 2, 27, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L, "Smile" },
                    { 564L, new DateTime(2023, 2, 28, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 481L, new DateTime(2023, 2, 26, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L, "Beast" },
                    { 476L, new DateTime(2023, 2, 25, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 471L, new DateTime(2023, 2, 25, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L, "The_Northman" },
                    { 466L, new DateTime(2023, 2, 25, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 461L, new DateTime(2023, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 456L, new DateTime(2023, 2, 25, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L, "Smile" },
                    { 451L, new DateTime(2023, 2, 25, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L, "Stowaway" },
                    { 446L, new DateTime(2023, 2, 25, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 441L, new DateTime(2023, 2, 25, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" },
                    { 436L, new DateTime(2023, 2, 24, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 431L, new DateTime(2023, 2, 24, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L, "The_Northman" },
                    { 426L, new DateTime(2023, 2, 24, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 421L, new DateTime(2023, 2, 24, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L, "Fall" },
                    { 416L, new DateTime(2023, 2, 24, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L, "Nope" },
                    { 411L, new DateTime(2023, 2, 24, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L, "Smile" },
                    { 406L, new DateTime(2023, 2, 24, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 401L, new DateTime(2023, 2, 24, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L, "Stowaway" },
                    { 396L, new DateTime(2023, 2, 23, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 391L, new DateTime(2023, 2, 23, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 486L, new DateTime(2023, 2, 26, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L, "Bullet_Train" },
                    { 491L, new DateTime(2023, 2, 26, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 496L, new DateTime(2023, 2, 26, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L, "Stowaway" },
                    { 501L, new DateTime(2023, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L, "The_Northman" },
                    { 569L, new DateTime(2023, 2, 28, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L, "Stowaway" },
                    { 574L, new DateTime(2023, 2, 28, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 579L, new DateTime(2023, 2, 28, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 584L, new DateTime(2023, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 589L, new DateTime(2023, 2, 28, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L, "Bullet_Train" },
                    { 594L, new DateTime(2023, 2, 28, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L, "Smile" },
                    { 599L, new DateTime(2023, 2, 28, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L, "Smile" },
                    { 604L, new DateTime(2023, 3, 1, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 609L, new DateTime(2023, 3, 1, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 559L, new DateTime(2023, 2, 27, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 614L, new DateTime(2023, 3, 1, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 624L, new DateTime(2023, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 629L, new DateTime(2023, 3, 1, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 634L, new DateTime(2023, 3, 1, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L, "Stowaway" },
                    { 639L, new DateTime(2023, 3, 1, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L, "After_Ever_Happy" },
                    { 526L, new DateTime(2023, 2, 27, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 521L, new DateTime(2023, 2, 27, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 516L, new DateTime(2023, 2, 26, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 511L, new DateTime(2023, 2, 26, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 506L, new DateTime(2023, 2, 26, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 619L, new DateTime(2023, 3, 1, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 96L, new DateTime(2023, 2, 16, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L, "Avatar" },
                    { 1L, new DateTime(2023, 2, 14, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 86L, new DateTime(2023, 2, 16, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" },
                    { 385L, new DateTime(2023, 2, 23, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L, "Beast" },
                    { 390L, new DateTime(2023, 2, 23, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 395L, new DateTime(2023, 2, 23, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L, "Orphan_First_Kill" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 400L, new DateTime(2023, 2, 23, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L, "The_Black_Phone" },
                    { 405L, new DateTime(2023, 2, 24, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 410L, new DateTime(2023, 2, 24, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L, "Drifting_Home" },
                    { 380L, new DateTime(2023, 2, 23, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L, "My_Sweet_Monster" },
                    { 415L, new DateTime(2023, 2, 24, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 425L, new DateTime(2023, 2, 24, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L, "Drifting_Home" },
                    { 430L, new DateTime(2023, 2, 24, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L, "Beast" },
                    { 435L, new DateTime(2023, 2, 24, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L, "My_Sweet_Monster" },
                    { 440L, new DateTime(2023, 2, 24, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 445L, new DateTime(2023, 2, 25, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 450L, new DateTime(2023, 2, 25, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 420L, new DateTime(2023, 2, 24, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L, "The_Black_Phone" },
                    { 375L, new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 370L, new DateTime(2023, 2, 23, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 365L, new DateTime(2023, 2, 23, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 290L, new DateTime(2023, 2, 21, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L, "After_Ever_Happy" },
                    { 295L, new DateTime(2023, 2, 21, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L, "Orphan_First_Kill" },
                    { 300L, new DateTime(2023, 2, 21, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 305L, new DateTime(2023, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 310L, new DateTime(2023, 2, 21, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 315L, new DateTime(2023, 2, 21, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 320L, new DateTime(2023, 2, 21, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 325L, new DateTime(2023, 2, 22, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 330L, new DateTime(2023, 2, 22, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L, "Morbius" },
                    { 335L, new DateTime(2023, 2, 22, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 340L, new DateTime(2023, 2, 22, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 345L, new DateTime(2023, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 350L, new DateTime(2023, 2, 22, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 355L, new DateTime(2023, 2, 22, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 360L, new DateTime(2023, 2, 22, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 455L, new DateTime(2023, 2, 25, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L, "Beast" },
                    { 460L, new DateTime(2023, 2, 25, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L, "My_Sweet_Monster" },
                    { 465L, new DateTime(2023, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 470L, new DateTime(2023, 2, 25, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L, "Orphan_First_Kill" },
                    { 570L, new DateTime(2023, 2, 28, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 575L, new DateTime(2023, 2, 28, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 580L, new DateTime(2023, 2, 28, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 585L, new DateTime(2023, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 590L, new DateTime(2023, 2, 28, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L, "The_Infernal_Machine" },
                    { 595L, new DateTime(2023, 2, 28, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 600L, new DateTime(2023, 2, 28, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L, "Last_Seen_Alive" },
                    { 605L, new DateTime(2023, 3, 1, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 610L, new DateTime(2023, 3, 1, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 615L, new DateTime(2023, 3, 1, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 620L, new DateTime(2023, 3, 1, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L, "The_Infernal_Machine" },
                    { 625L, new DateTime(2023, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 630L, new DateTime(2023, 3, 1, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 635L, new DateTime(2023, 3, 1, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 640L, new DateTime(2023, 3, 1, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 565L, new DateTime(2023, 2, 28, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 285L, new DateTime(2023, 2, 21, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L, "Orphan_First_Kill" },
                    { 560L, new DateTime(2023, 2, 27, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 550L, new DateTime(2023, 2, 27, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 475L, new DateTime(2023, 2, 25, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 480L, new DateTime(2023, 2, 25, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 485L, new DateTime(2023, 2, 26, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L, "Nope" },
                    { 490L, new DateTime(2023, 2, 26, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L, "After_Ever_Happy" },
                    { 495L, new DateTime(2023, 2, 26, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L, "My_Sweet_Monster" },
                    { 500L, new DateTime(2023, 2, 26, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 505L, new DateTime(2023, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L, "Nope" },
                    { 510L, new DateTime(2023, 2, 26, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 515L, new DateTime(2023, 2, 26, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L, "Nope" },
                    { 520L, new DateTime(2023, 2, 26, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 525L, new DateTime(2023, 2, 27, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 530L, new DateTime(2023, 2, 27, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 535L, new DateTime(2023, 2, 27, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 540L, new DateTime(2023, 2, 27, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 545L, new DateTime(2023, 2, 27, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 555L, new DateTime(2023, 2, 27, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 280L, new DateTime(2023, 2, 20, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 275L, new DateTime(2023, 2, 20, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 270L, new DateTime(2023, 2, 20, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L, "Drifting_Home" },
                    { 5L, new DateTime(2023, 2, 14, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 10L, new DateTime(2023, 2, 14, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 15L, new DateTime(2023, 2, 14, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 20L, new DateTime(2023, 2, 14, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 25L, new DateTime(2023, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 30L, new DateTime(2023, 2, 14, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 35L, new DateTime(2023, 2, 14, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 40L, new DateTime(2023, 2, 14, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 45L, new DateTime(2023, 2, 15, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 50L, new DateTime(2023, 2, 15, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 55L, new DateTime(2023, 2, 15, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 60L, new DateTime(2023, 2, 15, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 65L, new DateTime(2023, 2, 15, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L, "The_Black_Phone" },
                    { 70L, new DateTime(2023, 2, 15, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L, "Beast" },
                    { 75L, new DateTime(2023, 2, 15, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L, "After_Ever_Happy" },
                    { 3L, new DateTime(2023, 2, 14, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 80L, new DateTime(2023, 2, 15, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L, "The_Black_Phone" },
                    { 8L, new DateTime(2023, 2, 14, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 6L, new DateTime(2023, 2, 14, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 81L, new DateTime(2023, 2, 16, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 76L, new DateTime(2023, 2, 15, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L, "Avatar" },
                    { 71L, new DateTime(2023, 2, 15, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 66L, new DateTime(2023, 2, 15, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 61L, new DateTime(2023, 2, 15, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 56L, new DateTime(2023, 2, 15, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 51L, new DateTime(2023, 2, 15, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 46L, new DateTime(2023, 2, 15, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L, "The_Infernal_Machine" },
                    { 41L, new DateTime(2023, 2, 15, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L, "Smile" },
                    { 36L, new DateTime(2023, 2, 14, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L, "Bullet_Train" },
                    { 31L, new DateTime(2023, 2, 14, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 26L, new DateTime(2023, 2, 14, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L, "Drifting_Home" },
                    { 21L, new DateTime(2023, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 16L, new DateTime(2023, 2, 14, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L, "The_Black_Phone" },
                    { 11L, new DateTime(2023, 2, 14, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 329L, new DateTime(2023, 2, 22, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L, "Morbius" },
                    { 91L, new DateTime(2023, 2, 16, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 85L, new DateTime(2023, 2, 16, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 95L, new DateTime(2023, 2, 16, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 195L, new DateTime(2023, 2, 18, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L, "Nope" },
                    { 200L, new DateTime(2023, 2, 18, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L, "My_Sweet_Monster" },
                    { 205L, new DateTime(2023, 2, 19, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 210L, new DateTime(2023, 2, 19, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 215L, new DateTime(2023, 2, 19, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L, "After_Ever_Happy" },
                    { 220L, new DateTime(2023, 2, 19, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L, "Orphan_First_Kill" },
                    { 225L, new DateTime(2023, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 230L, new DateTime(2023, 2, 19, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 235L, new DateTime(2023, 2, 19, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L, "Drifting_Home" },
                    { 240L, new DateTime(2023, 2, 19, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 245L, new DateTime(2023, 2, 20, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L, "Nope" },
                    { 250L, new DateTime(2023, 2, 20, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 255L, new DateTime(2023, 2, 20, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 260L, new DateTime(2023, 2, 20, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 265L, new DateTime(2023, 2, 20, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 190L, new DateTime(2023, 2, 18, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L, "Last_Seen_Alive" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 90L, new DateTime(2023, 2, 16, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 185L, new DateTime(2023, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L, "The_Infernal_Machine" },
                    { 175L, new DateTime(2023, 2, 18, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L, "The_Black_Phone" },
                    { 100L, new DateTime(2023, 2, 16, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L, "The_Northman" },
                    { 105L, new DateTime(2023, 2, 16, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L, "Beast" },
                    { 110L, new DateTime(2023, 2, 16, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 115L, new DateTime(2023, 2, 16, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L, "Last_Seen_Alive" },
                    { 120L, new DateTime(2023, 2, 16, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L, "Avatar" },
                    { 125L, new DateTime(2023, 2, 17, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L, "My_Sweet_Monster" },
                    { 130L, new DateTime(2023, 2, 17, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L, "Bullet_Train" },
                    { 135L, new DateTime(2023, 2, 17, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L, "Nope" },
                    { 140L, new DateTime(2023, 2, 17, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L, "Smile" },
                    { 145L, new DateTime(2023, 2, 17, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L, "Stowaway" },
                    { 150L, new DateTime(2023, 2, 17, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L, "Wire_Room" },
                    { 155L, new DateTime(2023, 2, 17, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L, "After_Ever_Happy" },
                    { 160L, new DateTime(2023, 2, 17, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 165L, new DateTime(2023, 2, 18, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L, "Fall" },
                    { 170L, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L, "After_Ever_Happy" },
                    { 180L, new DateTime(2023, 2, 18, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L, "Last_Seen_Alive" },
                    { 168L, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 324L, new DateTime(2023, 2, 22, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 314L, new DateTime(2023, 2, 21, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" },
                    { 572L, new DateTime(2023, 2, 28, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L, "The_Infernal_Machine" },
                    { 567L, new DateTime(2023, 2, 28, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L, "Nope" },
                    { 562L, new DateTime(2023, 2, 28, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 557L, new DateTime(2023, 2, 27, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 552L, new DateTime(2023, 2, 27, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 547L, new DateTime(2023, 2, 27, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 542L, new DateTime(2023, 2, 27, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L, "Stowaway" },
                    { 537L, new DateTime(2023, 2, 27, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 532L, new DateTime(2023, 2, 27, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 527L, new DateTime(2023, 2, 27, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 522L, new DateTime(2023, 2, 27, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 517L, new DateTime(2023, 2, 26, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L, "The_Infernal_Machine" },
                    { 512L, new DateTime(2023, 2, 26, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 507L, new DateTime(2023, 2, 26, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 502L, new DateTime(2023, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 497L, new DateTime(2023, 2, 26, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 492L, new DateTime(2023, 2, 26, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 577L, new DateTime(2023, 2, 28, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 487L, new DateTime(2023, 2, 26, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 582L, new DateTime(2023, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 592L, new DateTime(2023, 2, 28, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 603L, new DateTime(2023, 3, 1, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L, "The_Infernal_Machine" },
                    { 608L, new DateTime(2023, 3, 1, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 613L, new DateTime(2023, 3, 1, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 618L, new DateTime(2023, 3, 1, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 623L, new DateTime(2023, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 628L, new DateTime(2023, 3, 1, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 633L, new DateTime(2023, 3, 1, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L, "Beast" },
                    { 638L, new DateTime(2023, 3, 1, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L, "Drifting_Home" },
                    { 637L, new DateTime(2023, 3, 1, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 632L, new DateTime(2023, 3, 1, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 627L, new DateTime(2023, 3, 1, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L, "After_Ever_Happy" },
                    { 622L, new DateTime(2023, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 617L, new DateTime(2023, 3, 1, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 612L, new DateTime(2023, 3, 1, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 607L, new DateTime(2023, 3, 1, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L, "Nope" },
                    { 602L, new DateTime(2023, 3, 1, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 597L, new DateTime(2023, 2, 28, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 587L, new DateTime(2023, 2, 28, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L, "After_Ever_Happy" },
                    { 598L, new DateTime(2023, 2, 28, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L, "Last_Seen_Alive" },
                    { 482L, new DateTime(2023, 2, 26, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 472L, new DateTime(2023, 2, 25, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L, "The_Infernal_Machine" },
                    { 362L, new DateTime(2023, 2, 23, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 357L, new DateTime(2023, 2, 22, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L, "Orphan_First_Kill" },
                    { 352L, new DateTime(2023, 2, 22, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 347L, new DateTime(2023, 2, 22, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 342L, new DateTime(2023, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L, "Wire_Room" },
                    { 337L, new DateTime(2023, 2, 22, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 332L, new DateTime(2023, 2, 22, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 327L, new DateTime(2023, 2, 22, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L, "Orphan_First_Kill" },
                    { 322L, new DateTime(2023, 2, 22, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 317L, new DateTime(2023, 2, 21, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L, "After_Ever_Happy" },
                    { 312L, new DateTime(2023, 2, 21, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 307L, new DateTime(2023, 2, 21, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 302L, new DateTime(2023, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 297L, new DateTime(2023, 2, 21, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 292L, new DateTime(2023, 2, 21, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 287L, new DateTime(2023, 2, 21, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 282L, new DateTime(2023, 2, 21, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 367L, new DateTime(2023, 2, 23, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L, "Beast" },
                    { 477L, new DateTime(2023, 2, 25, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 372L, new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L, "Beast" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 382L, new DateTime(2023, 2, 23, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 467L, new DateTime(2023, 2, 25, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 462L, new DateTime(2023, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 457L, new DateTime(2023, 2, 25, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 452L, new DateTime(2023, 2, 25, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 447L, new DateTime(2023, 2, 25, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L, "Beast" },
                    { 442L, new DateTime(2023, 2, 25, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 437L, new DateTime(2023, 2, 24, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 432L, new DateTime(2023, 2, 24, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 427L, new DateTime(2023, 2, 24, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 422L, new DateTime(2023, 2, 24, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 417L, new DateTime(2023, 2, 24, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L, "After_Ever_Happy" },
                    { 412L, new DateTime(2023, 2, 24, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 407L, new DateTime(2023, 2, 24, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 402L, new DateTime(2023, 2, 24, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 397L, new DateTime(2023, 2, 23, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 392L, new DateTime(2023, 2, 23, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L, "Orphan_First_Kill" },
                    { 387L, new DateTime(2023, 2, 23, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 377L, new DateTime(2023, 2, 23, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 593L, new DateTime(2023, 2, 28, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L, "The_Northman" },
                    { 588L, new DateTime(2023, 2, 28, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 583L, new DateTime(2023, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 283L, new DateTime(2023, 2, 21, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 288L, new DateTime(2023, 2, 21, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L, "The_Northman" },
                    { 293L, new DateTime(2023, 2, 21, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 298L, new DateTime(2023, 2, 21, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 303L, new DateTime(2023, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 308L, new DateTime(2023, 2, 21, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 313L, new DateTime(2023, 2, 21, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L, "Morbius" },
                    { 318L, new DateTime(2023, 2, 21, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L, "Nope" },
                    { 323L, new DateTime(2023, 2, 22, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 328L, new DateTime(2023, 2, 22, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 333L, new DateTime(2023, 2, 22, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L, "The_Infernal_Machine" },
                    { 338L, new DateTime(2023, 2, 22, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 343L, new DateTime(2023, 2, 22, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 348L, new DateTime(2023, 2, 22, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 353L, new DateTime(2023, 2, 22, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L, "Bullet_Train" },
                    { 358L, new DateTime(2023, 2, 22, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 363L, new DateTime(2023, 2, 23, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L, "The_Black_Phone" },
                    { 278L, new DateTime(2023, 2, 20, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 368L, new DateTime(2023, 2, 23, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 273L, new DateTime(2023, 2, 20, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L, "Nope" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 263L, new DateTime(2023, 2, 20, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 178L, new DateTime(2023, 2, 18, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 183L, new DateTime(2023, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 188L, new DateTime(2023, 2, 18, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L, "My_Sweet_Monster" },
                    { 193L, new DateTime(2023, 2, 18, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L, "The_Black_Phone" },
                    { 198L, new DateTime(2023, 2, 18, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 203L, new DateTime(2023, 2, 19, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L, "The_Northman" },
                    { 208L, new DateTime(2023, 2, 19, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 213L, new DateTime(2023, 2, 19, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 218L, new DateTime(2023, 2, 19, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L, "Last_Seen_Alive" },
                    { 223L, new DateTime(2023, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 228L, new DateTime(2023, 2, 19, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 233L, new DateTime(2023, 2, 19, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L, "The_Black_Phone" },
                    { 238L, new DateTime(2023, 2, 19, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L, "Last_Seen_Alive" },
                    { 243L, new DateTime(2023, 2, 20, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 248L, new DateTime(2023, 2, 20, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 253L, new DateTime(2023, 2, 20, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 258L, new DateTime(2023, 2, 20, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 268L, new DateTime(2023, 2, 20, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 373L, new DateTime(2023, 2, 23, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L, "The_Infernal_Machine" },
                    { 378L, new DateTime(2023, 2, 23, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 383L, new DateTime(2023, 2, 23, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 498L, new DateTime(2023, 2, 26, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L, "Morbius" },
                    { 503L, new DateTime(2023, 2, 26, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 508L, new DateTime(2023, 2, 26, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 513L, new DateTime(2023, 2, 26, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 518L, new DateTime(2023, 2, 26, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 523L, new DateTime(2023, 2, 27, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L, "After_Ever_Happy" },
                    { 528L, new DateTime(2023, 2, 27, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 533L, new DateTime(2023, 2, 27, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L, "Drifting_Home" },
                    { 538L, new DateTime(2023, 2, 27, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 543L, new DateTime(2023, 2, 27, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 548L, new DateTime(2023, 2, 27, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 553L, new DateTime(2023, 2, 27, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 558L, new DateTime(2023, 2, 27, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 563L, new DateTime(2023, 2, 28, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L, "Morbius" },
                    { 568L, new DateTime(2023, 2, 28, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L, "Nope" },
                    { 573L, new DateTime(2023, 2, 28, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 578L, new DateTime(2023, 2, 28, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L, "The_Northman" },
                    { 493L, new DateTime(2023, 2, 26, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L, "Beast" },
                    { 488L, new DateTime(2023, 2, 26, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 483L, new DateTime(2023, 2, 26, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L, "Drifting_Home" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 478L, new DateTime(2023, 2, 25, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L, "Bullet_Train" },
                    { 388L, new DateTime(2023, 2, 23, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L, "The_Northman" },
                    { 393L, new DateTime(2023, 2, 23, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L, "My_Sweet_Monster" },
                    { 398L, new DateTime(2023, 2, 23, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 403L, new DateTime(2023, 2, 24, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L, "The_Infernal_Machine" },
                    { 408L, new DateTime(2023, 2, 24, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L, "My_Sweet_Monster" },
                    { 413L, new DateTime(2023, 2, 24, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 418L, new DateTime(2023, 2, 24, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L, "Bullet_Train" },
                    { 423L, new DateTime(2023, 2, 24, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L, "Bullet_Train" },
                    { 277L, new DateTime(2023, 2, 20, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 428L, new DateTime(2023, 2, 24, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L, "Last_Seen_Alive" },
                    { 438L, new DateTime(2023, 2, 24, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L, "Drifting_Home" },
                    { 443L, new DateTime(2023, 2, 25, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 448L, new DateTime(2023, 2, 25, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 453L, new DateTime(2023, 2, 25, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 458L, new DateTime(2023, 2, 25, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 463L, new DateTime(2023, 2, 25, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 468L, new DateTime(2023, 2, 25, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 473L, new DateTime(2023, 2, 25, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L, "Beast" },
                    { 433L, new DateTime(2023, 2, 24, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 272L, new DateTime(2023, 2, 20, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L, "Orphan_First_Kill" },
                    { 267L, new DateTime(2023, 2, 20, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 262L, new DateTime(2023, 2, 20, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L, "Nope" },
                    { 14L, new DateTime(2023, 2, 14, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 19L, new DateTime(2023, 2, 14, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 24L, new DateTime(2023, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 29L, new DateTime(2023, 2, 14, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" },
                    { 34L, new DateTime(2023, 2, 14, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 39L, new DateTime(2023, 2, 14, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L, "Smile" },
                    { 44L, new DateTime(2023, 2, 15, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L, "The_Northman" },
                    { 49L, new DateTime(2023, 2, 15, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" },
                    { 54L, new DateTime(2023, 2, 15, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 59L, new DateTime(2023, 2, 15, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L, "Bullet_Train" },
                    { 64L, new DateTime(2023, 2, 15, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L, "Bullet_Train" },
                    { 69L, new DateTime(2023, 2, 15, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 74L, new DateTime(2023, 2, 15, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L, "The_Northman" },
                    { 79L, new DateTime(2023, 2, 15, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L, "Orphan_First_Kill" },
                    { 84L, new DateTime(2023, 2, 16, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 89L, new DateTime(2023, 2, 16, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" },
                    { 94L, new DateTime(2023, 2, 16, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L, "After_Ever_Happy" },
                    { 9L, new DateTime(2023, 2, 14, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 99L, new DateTime(2023, 2, 16, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 4L, new DateTime(2023, 2, 14, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 536L, new DateTime(2023, 2, 27, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 621L, new DateTime(2023, 3, 1, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L, "Smile" },
                    { 616L, new DateTime(2023, 3, 1, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L, "Beast" },
                    { 611L, new DateTime(2023, 3, 1, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 606L, new DateTime(2023, 3, 1, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L, "After_Ever_Happy" },
                    { 601L, new DateTime(2023, 3, 1, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L, "Orphan_First_Kill" },
                    { 596L, new DateTime(2023, 2, 28, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L, "Nope" },
                    { 591L, new DateTime(2023, 2, 28, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L, "Nope" },
                    { 586L, new DateTime(2023, 2, 28, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L, "Nope" },
                    { 581L, new DateTime(2023, 2, 28, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 576L, new DateTime(2023, 2, 28, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L, "Last_Seen_Alive" },
                    { 571L, new DateTime(2023, 2, 28, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L, "Beast" },
                    { 566L, new DateTime(2023, 2, 28, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 561L, new DateTime(2023, 2, 28, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L, "Avatar" },
                    { 556L, new DateTime(2023, 2, 27, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 551L, new DateTime(2023, 2, 27, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 546L, new DateTime(2023, 2, 27, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L, "My_Sweet_Monster" },
                    { 541L, new DateTime(2023, 2, 27, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L, "Avatar" },
                    { 531L, new DateTime(2023, 2, 27, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L, "Stowaway" },
                    { 104L, new DateTime(2023, 2, 16, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L, "Stowaway" },
                    { 109L, new DateTime(2023, 2, 16, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 114L, new DateTime(2023, 2, 16, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L, "Fall" },
                    { 229L, new DateTime(2023, 2, 19, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 234L, new DateTime(2023, 2, 19, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L, "Fall" },
                    { 239L, new DateTime(2023, 2, 19, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 244L, new DateTime(2023, 2, 20, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L, "Orphan_First_Kill" },
                    { 249L, new DateTime(2023, 2, 20, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 254L, new DateTime(2023, 2, 20, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 259L, new DateTime(2023, 2, 20, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" },
                    { 264L, new DateTime(2023, 2, 20, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 269L, new DateTime(2023, 2, 20, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 274L, new DateTime(2023, 2, 20, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" },
                    { 279L, new DateTime(2023, 2, 20, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 284L, new DateTime(2023, 2, 21, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 289L, new DateTime(2023, 2, 21, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L, "Avatar" },
                    { 294L, new DateTime(2023, 2, 21, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 299L, new DateTime(2023, 2, 21, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L, "Smile" },
                    { 304L, new DateTime(2023, 2, 21, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L, "Bullet_Train" },
                    { 309L, new DateTime(2023, 2, 21, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L, "My_Sweet_Monster" },
                    { 224L, new DateTime(2023, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L, "After_Ever_Happy" },
                    { 219L, new DateTime(2023, 2, 19, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L, "Last_Seen_Alive" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 214L, new DateTime(2023, 2, 19, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L, "Fall" },
                    { 209L, new DateTime(2023, 2, 19, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L, "The_Northman" },
                    { 119L, new DateTime(2023, 2, 16, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 124L, new DateTime(2023, 2, 17, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L, "Morbius" },
                    { 129L, new DateTime(2023, 2, 17, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L, "Fall" },
                    { 134L, new DateTime(2023, 2, 17, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 139L, new DateTime(2023, 2, 17, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L, "Nope" },
                    { 13L, new DateTime(2023, 2, 14, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L, "Last_Seen_Alive" },
                    { 149L, new DateTime(2023, 2, 17, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" },
                    { 154L, new DateTime(2023, 2, 17, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 626L, new DateTime(2023, 3, 1, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L, "Wire_Room" },
                    { 159L, new DateTime(2023, 2, 17, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L, "Wire_Room" },
                    { 169L, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L, "The_Northman" },
                    { 174L, new DateTime(2023, 2, 18, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L, "The_Infernal_Machine" },
                    { 179L, new DateTime(2023, 2, 18, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L, "Morbius" },
                    { 184L, new DateTime(2023, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L, "Morbius" },
                    { 189L, new DateTime(2023, 2, 18, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L, "The_Infernal_Machine" },
                    { 194L, new DateTime(2023, 2, 18, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 199L, new DateTime(2023, 2, 18, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 204L, new DateTime(2023, 2, 19, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 164L, new DateTime(2023, 2, 18, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L, "Drifting_Home" },
                    { 319L, new DateTime(2023, 2, 21, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L, "The_Black_Phone" },
                    { 631L, new DateTime(2023, 3, 1, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L, "Stowaway" },
                    { 18L, new DateTime(2023, 2, 14, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 152L, new DateTime(2023, 2, 17, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L, "Nope" },
                    { 147L, new DateTime(2023, 2, 17, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 142L, new DateTime(2023, 2, 17, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 137L, new DateTime(2023, 2, 17, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L, "Orphan_First_Kill" },
                    { 132L, new DateTime(2023, 2, 17, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 127L, new DateTime(2023, 2, 17, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 122L, new DateTime(2023, 2, 17, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 117L, new DateTime(2023, 2, 16, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L, "After_Ever_Happy" },
                    { 112L, new DateTime(2023, 2, 16, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 107L, new DateTime(2023, 2, 16, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 102L, new DateTime(2023, 2, 16, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L, "Stowaway" },
                    { 97L, new DateTime(2023, 2, 16, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L, "Stowaway" },
                    { 92L, new DateTime(2023, 2, 16, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 87L, new DateTime(2023, 2, 16, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L, "Orphan_First_Kill" },
                    { 82L, new DateTime(2023, 2, 16, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 77L, new DateTime(2023, 2, 15, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L, "Nope" },
                    { 72L, new DateTime(2023, 2, 15, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L, "Nope" },
                    { 157L, new DateTime(2023, 2, 17, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 67L, new DateTime(2023, 2, 15, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 162L, new DateTime(2023, 2, 18, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 172L, new DateTime(2023, 2, 18, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 257L, new DateTime(2023, 2, 20, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 252L, new DateTime(2023, 2, 20, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 247L, new DateTime(2023, 2, 20, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L, "Avatar" },
                    { 242L, new DateTime(2023, 2, 20, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L, "Beast" },
                    { 237L, new DateTime(2023, 2, 19, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 232L, new DateTime(2023, 2, 19, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 227L, new DateTime(2023, 2, 19, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 222L, new DateTime(2023, 2, 19, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 217L, new DateTime(2023, 2, 19, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L, "Bullet_Train" },
                    { 212L, new DateTime(2023, 2, 19, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L, "My_Sweet_Monster" },
                    { 207L, new DateTime(2023, 2, 19, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L, "Last_Seen_Alive" },
                    { 202L, new DateTime(2023, 2, 19, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 197L, new DateTime(2023, 2, 18, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L, "The_Infernal_Machine" },
                    { 192L, new DateTime(2023, 2, 18, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 187L, new DateTime(2023, 2, 18, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L, "Beast" },
                    { 182L, new DateTime(2023, 2, 18, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L, "After_Ever_Happy" },
                    { 177L, new DateTime(2023, 2, 18, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 167L, new DateTime(2023, 2, 18, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 62L, new DateTime(2023, 2, 15, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L, "Drifting_Home" },
                    { 57L, new DateTime(2023, 2, 15, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 52L, new DateTime(2023, 2, 15, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L, "Fall" },
                    { 103L, new DateTime(2023, 2, 16, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L, "Bullet_Train" },
                    { 98L, new DateTime(2023, 2, 16, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 93L, new DateTime(2023, 2, 16, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 88L, new DateTime(2023, 2, 16, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 83L, new DateTime(2023, 2, 16, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 78L, new DateTime(2023, 2, 15, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 73L, new DateTime(2023, 2, 15, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 68L, new DateTime(2023, 2, 15, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 63L, new DateTime(2023, 2, 15, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L, "Orphan_First_Kill" },
                    { 58L, new DateTime(2023, 2, 15, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L, "Beast" },
                    { 53L, new DateTime(2023, 2, 15, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L, "My_Sweet_Monster" },
                    { 48L, new DateTime(2023, 2, 15, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L, "Beast" },
                    { 43L, new DateTime(2023, 2, 15, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L, "Drifting_Home" },
                    { 38L, new DateTime(2023, 2, 14, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 33L, new DateTime(2023, 2, 14, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L, "Dragon_Ball_Super_Super_Hero" },
                    { 28L, new DateTime(2023, 2, 14, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L, "Wire_Room" },
                    { 23L, new DateTime(2023, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L, "My_Sweet_Monster" },
                    { 108L, new DateTime(2023, 2, 16, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L, "Last_Seen_Alive" }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId", "MovieTitle" },
                values: new object[,]
                {
                    { 113L, new DateTime(2023, 2, 16, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L, "Avatar" },
                    { 118L, new DateTime(2023, 2, 16, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L, "Bullet_Train" },
                    { 123L, new DateTime(2023, 2, 17, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L, "Smile" },
                    { 47L, new DateTime(2023, 2, 15, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 42L, new DateTime(2023, 2, 15, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 37L, new DateTime(2023, 2, 14, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 32L, new DateTime(2023, 2, 14, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L, "Smile" },
                    { 27L, new DateTime(2023, 2, 14, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 22L, new DateTime(2023, 2, 14, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L, "The_Northman" },
                    { 17L, new DateTime(2023, 2, 14, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L, "Beast" },
                    { 12L, new DateTime(2023, 2, 14, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L, "Morbius" },
                    { 636L, new DateTime(2023, 3, 1, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L, "Drifting_Home" },
                    { 7L, new DateTime(2023, 2, 14, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L, "The_Black_Phone" },
                    { 163L, new DateTime(2023, 2, 18, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L, "Fall" },
                    { 158L, new DateTime(2023, 2, 17, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L, "The_Northman" },
                    { 153L, new DateTime(2023, 2, 17, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L, "The_Infernal_Machine" },
                    { 148L, new DateTime(2023, 2, 17, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L, "Nope" },
                    { 143L, new DateTime(2023, 2, 17, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L, "Drifting_Home" },
                    { 138L, new DateTime(2023, 2, 17, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L, "Spider_Man_No_Way_Home" },
                    { 133L, new DateTime(2023, 2, 17, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L, "Stowaway" },
                    { 128L, new DateTime(2023, 2, 17, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L, "Beast" },
                    { 2L, new DateTime(2023, 2, 14, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L, "DC_League_of_Super_Pets" },
                    { 144L, new DateTime(2023, 2, 17, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L, "Beast" }
                });

            migrationBuilder.InsertData(
                table: "MovieComments",
                columns: new[] { "Id", "DateTime", "IsDeleted", "MovieId", "ParentCommentId", "ProfileId", "Text" },
                values: new object[] { 15L, new DateTime(2023, 2, 15, 19, 31, 52, 665, DateTimeKind.Local).AddTicks(9514), false, 526896L, 14L, 1L, "I have to agree with the previous comment, the acting was definitely one of the strengths of this film." });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 270L, 3L, 238L, 34L },
                    { 271L, 3L, 239L, 34L },
                    { 385L, 2L, 296L, 34L },
                    { 476L, 3L, 287L, 34L },
                    { 477L, 3L, 288L, 34L },
                    { 577L, 2L, 215L, 34L },
                    { 209L, 1L, 153L, 34L },
                    { 578L, 1L, 216L, 34L },
                    { 591L, 1L, 254L, 34L },
                    { 530L, 1L, 164L, 39L },
                    { 531L, 3L, 165L, 39L },
                    { 266L, 1L, 266L, 44L },
                    { 267L, 1L, 267L, 44L },
                    { 339L, 3L, 174L, 44L },
                    { 579L, 2L, 217L, 34L },
                    { 208L, 2L, 152L, 34L },
                    { 78L, 3L, 236L, 34L },
                    { 77L, 2L, 235L, 34L },
                    { 586L, 2L, 235L, 14L },
                    { 587L, 1L, 236L, 14L },
                    { 155L, 1L, 327L, 19L },
                    { 214L, 3L, 207L, 19L },
                    { 215L, 3L, 208L, 19L },
                    { 396L, 3L, 289L, 19L },
                    { 515L, 2L, 280L, 19L },
                    { 516L, 2L, 281L, 19L },
                    { 101L, 1L, 209L, 24L },
                    { 323L, 3L, 175L, 24L },
                    { 347L, 2L, 192L, 24L },
                    { 348L, 3L, 193L, 24L },
                    { 99L, 2L, 269L, 29L },
                    { 100L, 2L, 270L, 29L },
                    { 104L, 1L, 150L, 29L },
                    { 340L, 1L, 175L, 44L },
                    { 53L, 3L, 159L, 49L },
                    { 54L, 1L, 160L, 49L },
                    { 55L, 2L, 161L, 49L },
                    { 445L, 2L, 206L, 59L },
                    { 446L, 2L, 207L, 59L },
                    { 557L, 3L, 265L, 59L },
                    { 50L, 1L, 185L, 64L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 51L, 3L, 186L, 64L },
                    { 52L, 3L, 187L, 64L },
                    { 302L, 2L, 222L, 64L },
                    { 568L, 3L, 301L, 64L },
                    { 569L, 1L, 302L, 64L },
                    { 570L, 2L, 303L, 64L },
                    { 183L, 2L, 264L, 69L },
                    { 184L, 2L, 265L, 69L },
                    { 185L, 1L, 266L, 69L },
                    { 216L, 1L, 169L, 69L },
                    { 217L, 3L, 170L, 69L },
                    { 426L, 1L, 258L, 59L },
                    { 567L, 3L, 160L, 14L },
                    { 425L, 3L, 257L, 59L },
                    { 49L, 1L, 251L, 59L },
                    { 242L, 2L, 182L, 49L },
                    { 243L, 2L, 183L, 49L },
                    { 447L, 2L, 164L, 49L },
                    { 448L, 1L, 165L, 49L },
                    { 449L, 2L, 166L, 49L },
                    { 565L, 2L, 181L, 49L },
                    { 8L, 2L, 191L, 54L },
                    { 9L, 2L, 192L, 54L },
                    { 10L, 1L, 193L, 54L },
                    { 206L, 3L, 298L, 54L },
                    { 207L, 1L, 299L, 54L },
                    { 522L, 1L, 216L, 54L },
                    { 523L, 2L, 217L, 54L },
                    { 524L, 1L, 218L, 54L },
                    { 48L, 1L, 250L, 59L },
                    { 424L, 1L, 256L, 59L },
                    { 282L, 1L, 328L, 69L },
                    { 566L, 2L, 159L, 14L },
                    { 276L, 2L, 230L, 14L },
                    { 490L, 1L, 96L, 73L },
                    { 491L, 2L, 97L, 73L },
                    { 125L, 3L, 126L, 78L },
                    { 126L, 2L, 127L, 78L },
                    { 218L, 1L, 94L, 78L },
                    { 219L, 2L, 95L, 78L },
                    { 379L, 2L, 120L, 73L },
                    { 502L, 1L, 97L, 78L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 593L, 3L, 124L, 78L },
                    { 594L, 3L, 125L, 78L },
                    { 344L, 1L, 98L, 83L },
                    { 400L, 3L, 128L, 83L },
                    { 401L, 3L, 129L, 83L },
                    { 533L, 3L, 73L, 88L },
                    { 503L, 2L, 98L, 78L },
                    { 229L, 1L, 119L, 73L },
                    { 228L, 1L, 118L, 73L },
                    { 540L, 2L, 128L, 63L },
                    { 156L, 3L, 148L, 58L },
                    { 225L, 1L, 93L, 58L },
                    { 226L, 2L, 94L, 58L },
                    { 227L, 2L, 95L, 58L },
                    { 381L, 3L, 73L, 58L },
                    { 382L, 2L, 74L, 58L },
                    { 532L, 3L, 133L, 58L },
                    { 592L, 2L, 134L, 58L },
                    { 147L, 3L, 90L, 63L },
                    { 148L, 3L, 91L, 63L },
                    { 149L, 2L, 92L, 63L },
                    { 237L, 3L, 84L, 63L },
                    { 238L, 2L, 85L, 63L },
                    { 239L, 3L, 86L, 63L },
                    { 539L, 3L, 127L, 63L },
                    { 534L, 2L, 74L, 88L },
                    { 575L, 2L, 141L, 88L },
                    { 576L, 3L, 142L, 88L },
                    { 440L, 2L, 119L, 93L },
                    { 272L, 3L, 218L, 4L },
                    { 273L, 1L, 219L, 4L },
                    { 278L, 3L, 196L, 4L },
                    { 279L, 1L, 197L, 4L },
                    { 280L, 3L, 198L, 4L },
                    { 293L, 3L, 225L, 4L },
                    { 60L, 2L, 232L, 9L },
                    { 61L, 2L, 233L, 9L },
                    { 91L, 2L, 297L, 9L },
                    { 92L, 2L, 298L, 9L },
                    { 93L, 1L, 299L, 9L },
                    { 268L, 3L, 182L, 9L },
                    { 269L, 3L, 183L, 9L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 507L, 1L, 259L, 9L },
                    { 508L, 1L, 260L, 9L },
                    { 244L, 2L, 290L, 4L },
                    { 277L, 1L, 231L, 14L },
                    { 224L, 1L, 294L, 4L },
                    { 222L, 3L, 292L, 4L },
                    { 441L, 3L, 120L, 93L },
                    { 442L, 3L, 121L, 93L },
                    { 15L, 2L, 128L, 98L },
                    { 16L, 3L, 129L, 98L },
                    { 17L, 2L, 130L, 98L },
                    { 504L, 1L, 104L, 98L },
                    { 505L, 2L, 105L, 98L },
                    { 506L, 2L, 106L, 98L },
                    { 525L, 3L, 73L, 98L },
                    { 526L, 3L, 74L, 98L },
                    { 527L, 2L, 75L, 98L },
                    { 554L, 1L, 109L, 98L },
                    { 555L, 2L, 110L, 98L },
                    { 73L, 2L, 314L, 4L },
                    { 74L, 1L, 315L, 4L },
                    { 223L, 3L, 293L, 4L },
                    { 362L, 1L, 323L, 69L },
                    { 369L, 1L, 315L, 69L },
                    { 492L, 2L, 257L, 69L },
                    { 167L, 3L, 371L, 50L },
                    { 168L, 2L, 372L, 50L },
                    { 220L, 2L, 429L, 50L },
                    { 221L, 3L, 430L, 50L },
                    { 281L, 2L, 387L, 50L },
                    { 254L, 3L, 423L, 55L },
                    { 262L, 2L, 391L, 45L },
                    { 255L, 2L, 424L, 55L },
                    { 334L, 2L, 463L, 55L },
                    { 417L, 3L, 429L, 60L },
                    { 418L, 2L, 430L, 60L },
                    { 419L, 3L, 431L, 60L },
                    { 109L, 1L, 345L, 65L },
                    { 110L, 2L, 346L, 65L },
                    { 333L, 3L, 462L, 55L },
                    { 261L, 2L, 390L, 45L },
                    { 260L, 3L, 389L, 45L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 172L, 3L, 398L, 45L },
                    { 353L, 2L, 387L, 30L },
                    { 25L, 2L, 335L, 35L },
                    { 26L, 2L, 336L, 35L },
                    { 284L, 3L, 460L, 35L },
                    { 285L, 2L, 461L, 35L },
                    { 286L, 3L, 462L, 35L },
                    { 291L, 1L, 358L, 40L },
                    { 292L, 1L, 359L, 40L },
                    { 83L, 3L, 430L, 45L },
                    { 84L, 1L, 431L, 45L },
                    { 89L, 3L, 459L, 45L },
                    { 90L, 3L, 460L, 45L },
                    { 164L, 2L, 400L, 45L },
                    { 165L, 2L, 401L, 45L },
                    { 166L, 3L, 402L, 45L },
                    { 120L, 3L, 404L, 65L },
                    { 121L, 3L, 405L, 65L },
                    { 122L, 2L, 406L, 65L },
                    { 144L, 1L, 442L, 65L },
                    { 561L, 3L, 432L, 80L },
                    { 176L, 3L, 434L, 85L },
                    { 177L, 2L, 435L, 85L },
                    { 178L, 1L, 436L, 85L },
                    { 456L, 1L, 469L, 85L },
                    { 457L, 3L, 470L, 85L },
                    { 584L, 1L, 428L, 85L },
                    { 585L, 3L, 429L, 85L },
                    { 33L, 1L, 441L, 90L },
                    { 34L, 1L, 442L, 90L },
                    { 35L, 3L, 443L, 90L },
                    { 94L, 1L, 405L, 95L },
                    { 95L, 1L, 406L, 95L },
                    { 359L, 2L, 428L, 95L },
                    { 360L, 3L, 429L, 95L },
                    { 560L, 2L, 431L, 80L },
                    { 352L, 2L, 386L, 30L },
                    { 559L, 1L, 430L, 80L },
                    { 258L, 1L, 377L, 80L },
                    { 145L, 3L, 443L, 65L },
                    { 146L, 2L, 444L, 65L },
                    { 406L, 1L, 400L, 65L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 407L, 1L, 401L, 65L },
                    { 408L, 2L, 402L, 65L },
                    { 142L, 2L, 470L, 70L },
                    { 143L, 2L, 471L, 70L },
                    { 186L, 1L, 354L, 70L },
                    { 96L, 1L, 444L, 75L },
                    { 97L, 1L, 445L, 75L },
                    { 98L, 1L, 446L, 75L },
                    { 240L, 3L, 385L, 75L },
                    { 241L, 2L, 386L, 75L },
                    { 318L, 3L, 443L, 75L },
                    { 257L, 3L, 376L, 80L },
                    { 259L, 2L, 378L, 80L },
                    { 351L, 3L, 385L, 30L },
                    { 301L, 3L, 364L, 30L },
                    { 300L, 1L, 363L, 30L },
                    { 88L, 1L, 268L, 84L },
                    { 123L, 2L, 271L, 84L },
                    { 124L, 2L, 272L, 84L },
                    { 157L, 1L, 317L, 84L },
                    { 158L, 2L, 318L, 84L },
                    { 337L, 3L, 198L, 84L },
                    { 338L, 1L, 199L, 84L },
                    { 520L, 2L, 214L, 84L },
                    { 521L, 3L, 215L, 84L },
                    { 193L, 1L, 196L, 89L },
                    { 194L, 2L, 197L, 89L },
                    { 386L, 2L, 207L, 89L },
                    { 387L, 3L, 208L, 89L },
                    { 327L, 1L, 264L, 94L },
                    { 354L, 3L, 263L, 94L },
                    { 87L, 1L, 267L, 84L },
                    { 562L, 1L, 165L, 94L },
                    { 86L, 1L, 266L, 84L },
                    { 494L, 1L, 212L, 79L },
                    { 493L, 2L, 258L, 69L },
                    { 41L, 1L, 199L, 74L },
                    { 42L, 3L, 200L, 74L },
                    { 181L, 2L, 318L, 74L },
                    { 182L, 2L, 319L, 74L },
                    { 201L, 1L, 300L, 74L },
                    { 202L, 1L, 301L, 74L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 203L, 1L, 302L, 74L },
                    { 18L, 3L, 257L, 79L },
                    { 19L, 3L, 258L, 79L },
                    { 20L, 2L, 259L, 79L },
                    { 380L, 1L, 184L, 79L },
                    { 434L, 2L, 185L, 79L },
                    { 435L, 3L, 186L, 79L },
                    { 436L, 2L, 187L, 79L },
                    { 495L, 2L, 213L, 79L },
                    { 590L, 1L, 137L, 53L },
                    { 563L, 3L, 166L, 94L },
                    { 283L, 1L, 329L, 69L },
                    { 249L, 2L, 405L, 20L },
                    { 250L, 3L, 406L, 20L },
                    { 309L, 3L, 389L, 20L },
                    { 310L, 2L, 390L, 20L },
                    { 321L, 2L, 375L, 20L },
                    { 322L, 3L, 376L, 20L },
                    { 388L, 3L, 374L, 20L },
                    { 498L, 3L, 356L, 20L },
                    { 499L, 1L, 357L, 20L },
                    { 500L, 2L, 358L, 20L },
                    { 501L, 3L, 401L, 20L },
                    { 245L, 2L, 383L, 25L },
                    { 246L, 3L, 384L, 25L },
                    { 247L, 2L, 385L, 25L },
                    { 299L, 1L, 362L, 30L },
                    { 248L, 3L, 404L, 20L },
                    { 564L, 3L, 167L, 94L },
                    { 372L, 3L, 340L, 15L },
                    { 370L, 3L, 338L, 15L },
                    { 79L, 2L, 368L, 5L },
                    { 80L, 1L, 369L, 5L },
                    { 152L, 2L, 394L, 5L },
                    { 153L, 2L, 395L, 5L },
                    { 304L, 2L, 466L, 5L },
                    { 305L, 2L, 467L, 5L },
                    { 383L, 2L, 456L, 5L },
                    { 384L, 1L, 457L, 5L },
                    { 537L, 1L, 424L, 5L },
                    { 538L, 2L, 425L, 5L },
                    { 392L, 1L, 458L, 10L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 393L, 2L, 459L, 10L },
                    { 29L, 2L, 330L, 15L },
                    { 30L, 3L, 331L, 15L },
                    { 31L, 2L, 332L, 15L },
                    { 371L, 1L, 339L, 15L },
                    { 290L, 2L, 101L, 53L },
                    { 289L, 2L, 100L, 53L },
                    { 163L, 3L, 131L, 48L },
                    { 580L, 2L, 37L, 76L },
                    { 581L, 2L, 38L, 76L },
                    { 169L, 1L, 1L, 81L },
                    { 170L, 3L, 2L, 81L },
                    { 171L, 2L, 3L, 81L },
                    { 195L, 1L, 17L, 81L },
                    { 549L, 3L, 6L, 76L },
                    { 196L, 1L, 18L, 81L },
                    { 544L, 2L, 26L, 81L },
                    { 545L, 1L, 27L, 81L },
                    { 546L, 1L, 28L, 81L },
                    { 571L, 2L, 9L, 81L },
                    { 572L, 1L, 10L, 81L },
                    { 573L, 1L, 11L, 81L },
                    { 543L, 3L, 25L, 81L },
                    { 548L, 1L, 5L, 76L },
                    { 547L, 2L, 4L, 76L },
                    { 298L, 1L, 10L, 76L },
                    { 463L, 1L, 29L, 61L },
                    { 468L, 1L, 9L, 61L },
                    { 469L, 2L, 10L, 61L },
                    { 470L, 3L, 11L, 61L },
                    { 45L, 3L, 36L, 66L },
                    { 46L, 2L, 37L, 66L },
                    { 47L, 2L, 38L, 66L },
                    { 150L, 1L, 33L, 71L },
                    { 151L, 1L, 34L, 71L },
                    { 432L, 1L, 40L, 71L },
                    { 443L, 1L, 26L, 71L },
                    { 444L, 1L, 27L, 71L },
                    { 197L, 1L, 19L, 76L },
                    { 198L, 3L, 20L, 76L },
                    { 297L, 3L, 9L, 76L },
                    { 574L, 1L, 29L, 81L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 66L, 2L, 21L, 86L },
                    { 67L, 2L, 22L, 86L },
                    { 68L, 3L, 23L, 86L },
                    { 319L, 3L, 3L, 96L },
                    { 320L, 3L, 4L, 96L },
                    { 232L, 1L, 68L, 2L },
                    { 233L, 3L, 69L, 2L },
                    { 234L, 3L, 70L, 2L },
                    { 512L, 2L, 66L, 2L },
                    { 513L, 3L, 67L, 2L },
                    { 27L, 3L, 55L, 7L },
                    { 28L, 3L, 56L, 7L },
                    { 210L, 1L, 41L, 7L },
                    { 211L, 2L, 42L, 7L },
                    { 212L, 1L, 43L, 7L },
                    { 213L, 3L, 44L, 7L },
                    { 450L, 1L, 61L, 7L },
                    { 451L, 2L, 62L, 7L },
                    { 236L, 1L, 22L, 96L },
                    { 462L, 3L, 28L, 61L },
                    { 235L, 2L, 21L, 96L },
                    { 595L, 1L, 26L, 91L },
                    { 69L, 2L, 24L, 86L },
                    { 204L, 1L, 19L, 86L },
                    { 205L, 3L, 20L, 86L },
                    { 405L, 3L, 40L, 86L },
                    { 496L, 1L, 31L, 86L },
                    { 497L, 1L, 32L, 86L },
                    { 3L, 2L, 37L, 91L },
                    { 4L, 2L, 38L, 91L },
                    { 75L, 1L, 32L, 91L },
                    { 76L, 2L, 33L, 91L },
                    { 312L, 1L, 4L, 91L },
                    { 313L, 1L, 5L, 91L },
                    { 487L, 1L, 22L, 91L },
                    { 488L, 2L, 23L, 91L },
                    { 489L, 1L, 24L, 91L },
                    { 596L, 1L, 27L, 91L },
                    { 461L, 3L, 27L, 61L },
                    { 411L, 3L, 19L, 56L },
                    { 410L, 1L, 18L, 56L },
                    { 481L, 3L, 29L, 11L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 58L, 3L, 12L, 16L },
                    { 59L, 1L, 13L, 16L },
                    { 294L, 3L, 36L, 16L },
                    { 295L, 3L, 37L, 16L },
                    { 296L, 2L, 38L, 16L },
                    { 402L, 3L, 7L, 16L },
                    { 403L, 1L, 8L, 16L },
                    { 404L, 3L, 9L, 16L },
                    { 478L, 2L, 14L, 16L },
                    { 479L, 2L, 15L, 16L },
                    { 480L, 1L, 16L, 16L },
                    { 600L, 2L, 20L, 16L },
                    { 601L, 1L, 21L, 16L },
                    { 130L, 1L, 3L, 21L },
                    { 231L, 1L, 22L, 11L },
                    { 131L, 2L, 4L, 21L },
                    { 230L, 3L, 21L, 11L },
                    { 188L, 2L, 9L, 11L },
                    { 116L, 3L, 27L, 1L },
                    { 117L, 3L, 28L, 1L },
                    { 127L, 1L, 18L, 1L },
                    { 128L, 3L, 19L, 1L },
                    { 129L, 1L, 20L, 1L },
                    { 140L, 1L, 24L, 1L },
                    { 141L, 2L, 25L, 1L },
                    { 253L, 2L, 16L, 1L },
                    { 374L, 2L, 4L, 1L },
                    { 375L, 1L, 5L, 1L },
                    { 376L, 1L, 6L, 1L },
                    { 5L, 1L, 9L, 6L },
                    { 6L, 1L, 10L, 6L },
                    { 7L, 1L, 11L, 6L },
                    { 187L, 1L, 8L, 11L },
                    { 189L, 1L, 10L, 11L },
                    { 514L, 3L, 49L, 7L },
                    { 132L, 2L, 5L, 21L },
                    { 363L, 2L, 16L, 21L },
                    { 324L, 3L, 36L, 51L },
                    { 325L, 2L, 37L, 51L },
                    { 326L, 2L, 38L, 51L },
                    { 335L, 2L, 20L, 51L },
                    { 336L, 2L, 21L, 51L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 422L, 3L, 16L, 51L },
                    { 482L, 1L, 33L, 51L },
                    { 483L, 2L, 34L, 51L },
                    { 23L, 2L, 32L, 56L },
                    { 24L, 3L, 33L, 56L },
                    { 118L, 3L, 38L, 56L },
                    { 119L, 2L, 39L, 56L },
                    { 345L, 1L, 13L, 56L },
                    { 346L, 1L, 14L, 56L },
                    { 409L, 2L, 17L, 56L },
                    { 265L, 2L, 26L, 51L },
                    { 133L, 2L, 6L, 21L },
                    { 264L, 3L, 25L, 51L },
                    { 399L, 1L, 18L, 46L },
                    { 364L, 2L, 17L, 21L },
                    { 365L, 3L, 18L, 21L },
                    { 551L, 1L, 7L, 21L },
                    { 394L, 1L, 39L, 26L },
                    { 395L, 1L, 40L, 26L },
                    { 423L, 3L, 22L, 26L },
                    { 154L, 1L, 40L, 31L },
                    { 341L, 2L, 3L, 31L },
                    { 342L, 2L, 4L, 31L },
                    { 343L, 3L, 5L, 31L },
                    { 414L, 2L, 6L, 31L },
                    { 1L, 2L, 4L, 41L },
                    { 2L, 1L, 5L, 41L },
                    { 397L, 2L, 16L, 46L },
                    { 398L, 3L, 17L, 46L },
                    { 263L, 3L, 24L, 51L },
                    { 361L, 2L, 430L, 95L },
                    { 535L, 2L, 51L, 7L },
                    { 303L, 3L, 70L, 12L },
                    { 112L, 1L, 137L, 18L },
                    { 190L, 3L, 97L, 18L },
                    { 191L, 3L, 98L, 18L },
                    { 192L, 3L, 99L, 18L },
                    { 430L, 3L, 123L, 18L },
                    { 431L, 3L, 124L, 18L },
                    { 111L, 1L, 136L, 18L },
                    { 588L, 3L, 139L, 18L },
                    { 72L, 3L, 148L, 23L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 102L, 3L, 102L, 23L },
                    { 103L, 1L, 103L, 23L },
                    { 159L, 2L, 114L, 23L },
                    { 160L, 3L, 115L, 23L },
                    { 161L, 3L, 116L, 23L },
                    { 589L, 3L, 140L, 18L },
                    { 106L, 1L, 101L, 18L },
                    { 105L, 1L, 100L, 18L },
                    { 599L, 2L, 108L, 13L },
                    { 256L, 3L, 70L, 92L },
                    { 415L, 3L, 57L, 97L },
                    { 416L, 2L, 58L, 97L },
                    { 21L, 2L, 129L, 3L },
                    { 22L, 3L, 130L, 3L },
                    { 412L, 2L, 138L, 8L },
                    { 413L, 2L, 139L, 8L },
                    { 14L, 3L, 121L, 13L },
                    { 349L, 2L, 93L, 13L },
                    { 350L, 1L, 94L, 13L },
                    { 471L, 3L, 71L, 13L },
                    { 472L, 1L, 72L, 13L },
                    { 473L, 1L, 73L, 13L },
                    { 597L, 1L, 106L, 13L },
                    { 598L, 3L, 107L, 13L },
                    { 314L, 2L, 117L, 23L },
                    { 438L, 3L, 124L, 23L },
                    { 439L, 2L, 125L, 23L },
                    { 484L, 1L, 143L, 23L },
                    { 467L, 3L, 73L, 38L },
                    { 509L, 1L, 102L, 38L },
                    { 510L, 1L, 103L, 38L },
                    { 511L, 3L, 104L, 38L },
                    { 70L, 3L, 97L, 43L },
                    { 71L, 3L, 98L, 43L },
                    { 134L, 2L, 75L, 43L },
                    { 135L, 3L, 76L, 43L },
                    { 136L, 1L, 77L, 43L },
                    { 287L, 2L, 102L, 43L },
                    { 288L, 3L, 103L, 43L },
                    { 517L, 2L, 106L, 43L },
                    { 518L, 3L, 107L, 43L },
                    { 519L, 2L, 108L, 43L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 162L, 2L, 130L, 48L },
                    { 466L, 1L, 72L, 38L },
                    { 63L, 1L, 68L, 92L },
                    { 317L, 3L, 96L, 38L },
                    { 315L, 1L, 94L, 38L },
                    { 485L, 1L, 144L, 23L },
                    { 486L, 2L, 145L, 23L },
                    { 356L, 3L, 146L, 28L },
                    { 357L, 1L, 147L, 28L },
                    { 358L, 2L, 148L, 28L },
                    { 433L, 1L, 85L, 28L },
                    { 541L, 3L, 81L, 28L },
                    { 542L, 1L, 82L, 28L },
                    { 427L, 1L, 95L, 33L },
                    { 428L, 2L, 96L, 33L },
                    { 429L, 1L, 97L, 33L },
                    { 56L, 2L, 141L, 38L },
                    { 57L, 3L, 142L, 38L },
                    { 64L, 2L, 99L, 38L },
                    { 65L, 2L, 100L, 38L },
                    { 316L, 1L, 95L, 38L },
                    { 62L, 2L, 67L, 92L },
                    { 465L, 3L, 46L, 87L },
                    { 464L, 1L, 45L, 87L },
                    { 108L, 3L, 53L, 37L },
                    { 373L, 1L, 56L, 37L },
                    { 454L, 3L, 59L, 42L },
                    { 455L, 1L, 60L, 42L },
                    { 137L, 2L, 65L, 47L },
                    { 138L, 1L, 66L, 47L },
                    { 139L, 2L, 67L, 47L },
                    { 328L, 3L, 53L, 47L },
                    { 329L, 3L, 54L, 47L },
                    { 330L, 2L, 55L, 47L },
                    { 331L, 1L, 56L, 47L },
                    { 332L, 1L, 57L, 47L },
                    { 437L, 1L, 52L, 47L },
                    { 179L, 2L, 51L, 52L },
                    { 180L, 3L, 52L, 52L },
                    { 107L, 1L, 52L, 37L },
                    { 389L, 2L, 62L, 52L },
                    { 32L, 1L, 57L, 37L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 275L, 3L, 53L, 32L },
                    { 366L, 1L, 41L, 17L },
                    { 367L, 3L, 42L, 17L },
                    { 368L, 2L, 43L, 17L },
                    { 420L, 1L, 69L, 17L },
                    { 421L, 3L, 70L, 17L },
                    { 311L, 2L, 42L, 22L },
                    { 36L, 1L, 55L, 27L },
                    { 37L, 3L, 56L, 27L },
                    { 199L, 1L, 51L, 27L },
                    { 200L, 3L, 52L, 27L },
                    { 474L, 3L, 46L, 27L },
                    { 475L, 2L, 47L, 27L },
                    { 113L, 3L, 58L, 32L },
                    { 114L, 2L, 59L, 32L },
                    { 274L, 3L, 52L, 32L },
                    { 558L, 2L, 47L, 32L },
                    { 536L, 2L, 52L, 7L },
                    { 390L, 2L, 63L, 52L },
                    { 556L, 3L, 70L, 52L },
                    { 173L, 2L, 43L, 77L },
                    { 174L, 2L, 44L, 77L },
                    { 175L, 2L, 45L, 77L },
                    { 355L, 1L, 42L, 77L },
                    { 528L, 1L, 59L, 82L },
                    { 529L, 2L, 60L, 82L },
                    { 11L, 1L, 50L, 87L },
                    { 12L, 2L, 51L, 87L },
                    { 13L, 3L, 52L, 87L },
                    { 85L, 3L, 44L, 87L },
                    { 306L, 2L, 47L, 87L },
                    { 307L, 1L, 48L, 87L },
                    { 308L, 1L, 49L, 87L },
                    { 452L, 3L, 53L, 87L },
                    { 453L, 1L, 54L, 87L },
                    { 44L, 2L, 60L, 77L },
                    { 391L, 1L, 64L, 52L },
                    { 43L, 1L, 59L, 77L },
                    { 459L, 3L, 48L, 72L },
                    { 251L, 1L, 56L, 57L },
                    { 252L, 1L, 57L, 57L },
                    { 582L, 2L, 54L, 57L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 583L, 1L, 55L, 57L },
                    { 552L, 1L, 54L, 62L },
                    { 553L, 3L, 55L, 62L },
                    { 38L, 2L, 56L, 67L },
                    { 39L, 3L, 57L, 67L },
                    { 40L, 1L, 58L, 67L },
                    { 81L, 3L, 44L, 67L },
                    { 82L, 2L, 45L, 67L },
                    { 550L, 2L, 47L, 67L },
                    { 377L, 3L, 54L, 72L },
                    { 378L, 2L, 55L, 72L },
                    { 458L, 1L, 47L, 72L },
                    { 460L, 1L, 49L, 72L },
                    { 115L, 3L, 26L, 1L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "FAQs",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "FavoriteMovies",
                keyColumn: "Id",
                keyValue: 10L);

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
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 15L);

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
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 35L);

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
                keyValue: 122L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 149L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 151L);

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
                keyValue: 162L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 163L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 168L);

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
                keyValue: 194L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 195L);

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
                keyValue: 210L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 211L);

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
                keyValue: 223L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 224L);

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
                keyValue: 234L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 237L);

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
                keyValue: 261L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 262L);

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
                keyValue: 291L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 295L);

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
                keyValue: 316L);

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
                keyValue: 333L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 334L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 337L);

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
                keyValue: 355L);

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
                keyValue: 370L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 373L);

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
                keyValue: 388L);

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
                keyValue: 396L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 397L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 399L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 403L);

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
                keyValue: 426L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 427L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 433L);

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
                keyValue: 464L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 465L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 468L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 472L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 36L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 68L);

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
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 601L);

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
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 14L);

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
                keyValue: 81L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 82L);

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
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 134L);

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
                keyValue: 150L);

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
                keyValue: 161L);

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
                keyValue: 169L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 170L);

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
                keyValue: 222L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 225L);

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
                keyValue: 235L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 236L);

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
                keyValue: 250L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 251L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 254L);

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
                keyValue: 280L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 281L);

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
                keyValue: 314L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 315L);

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
                keyValue: 335L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 336L);

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
                keyValue: 345L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 346L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 354L);

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
                keyValue: 368L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 369L);

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
                keyValue: 394L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 395L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 398L);

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
                keyValue: 466L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 467L);

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
                keyValue: 5L);

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
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 35L);

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
                keyValue: 74L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 75L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 76L);

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
                keyValue: 92L);

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
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 1L);

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

            migrationBuilder.DeleteData(
                table: "Profile",
                keyColumn: "Id",
                keyValue: 2L);
        }
    }
}
