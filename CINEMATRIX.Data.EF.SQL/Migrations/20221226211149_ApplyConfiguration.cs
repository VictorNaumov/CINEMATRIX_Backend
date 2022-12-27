﻿using System;
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
                    { 1L, new DateTime(2002, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "Admin", "+375291111111", "Admin" },
                    { 2L, new DateTime(2001, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "Staff", "+375291111112", "Staff" },
                    { 3L, new DateTime(2000, 12, 27, 0, 0, 0, 0, DateTimeKind.Local), "https://i.pinimg.com/564x/4c/50/87/4c50870fef410d14ff495ea1f532565a.jpg", "User", "+375291111113", "User" }
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
                    { 14L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6327), false, 526896L, 14L, 2L, "I disagree, I thought the acting was top notch and really brought the characters to life." },
                    { 12L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6324), false, 526896L, null, 2L, "I thought the acting was a bit weak, but the plot was intriguing." },
                    { 7L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6313), false, 19995L, null, 2L, "I thought the plot was a bit predictable, but the action scenes were great." },
                    { 5L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6310), false, 19995L, null, 2L, "I was blown away by the visuals in this film. The story was a bit weak, but overall it was a great movie experience." },
                    { 3L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6306), false, 19995L, null, 2L, "I was really disappointed in this movie. The plot was too predictable and the acting was subpar." },
                    { 15L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6328), false, 526896L, 15L, 1L, "I have to agree with the previous comment, the acting was definitely one of the strengths of this film." },
                    { 11L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6322), false, 526896L, null, 1L, "This movie was really good! I really enjoyed the action and special effects." },
                    { 10L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6320), false, 19995L, null, 1L, "I wasn't a huge fan of the movie overall. It was okay, but not one of my favorites." },
                    { 8L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6315), false, 19995L, null, 1L, "I totally agree about the special effects, they were some of the best I've ever seen in a movie." },
                    { 6L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6312), false, 19995L, null, 1L, "This movie was amazing! The special effects were unbelievable." },
                    { 4L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6308), false, 19995L, null, 1L, "I thought the plot was interesting and the acting was solid. Definitely worth a watch!" },
                    { 1L, new DateTime(2022, 12, 27, 0, 11, 48, 83, DateTimeKind.Local).AddTicks(8586), false, 19995L, null, 1L, "I absolutely loved this movie! The visual effects were stunning and the story was captivating." },
                    { 2L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6274), false, 19995L, null, 2L, "I agree, the special effects in this movie were groundbreaking. The plot was a bit predictable, but overall it was an enjoyable film." }
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
                    { 13L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6325), false, 526896L, 11L, 3L, "I agree, the action scenes were definitely a highlight of the film." },
                    { 9L, new DateTime(2022, 12, 27, 0, 11, 48, 84, DateTimeKind.Local).AddTicks(6319), false, 19995L, 8L, 2L, "I thought the plot was actually really interesting and kept me engaged throughout the movie." }
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
                    { 226L, 4L, 6, 5, 1L },
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
                    { 221L, 4L, 1, 5, 1L },
                    { 222L, 4L, 2, 5, 1L }
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
                    { 202L, 4L, 18, 3, 1L },
                    { 201L, 4L, 17, 3, 1L },
                    { 200L, 4L, 16, 3, 1L },
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
                    { 122L, 3L, 4, 5, 1L },
                    { 123L, 3L, 5, 5, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
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
                    { 290L, 4L, 16, 8, 1L },
                    { 179L, 4L, 13, 2, 1L },
                    { 177L, 4L, 11, 2, 1L },
                    { 157L, 4L, 9, 1, 1L },
                    { 158L, 4L, 10, 1, 1L },
                    { 159L, 4L, 11, 1, 1L },
                    { 160L, 4L, 12, 1, 1L },
                    { 161L, 4L, 13, 1, 1L },
                    { 162L, 4L, 14, 1, 1L },
                    { 163L, 4L, 15, 1, 1L },
                    { 164L, 4L, 16, 1, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 165L, 4L, 17, 1, 1L },
                    { 166L, 4L, 18, 1, 1L },
                    { 167L, 4L, 1, 2, 1L },
                    { 168L, 4L, 2, 2, 1L },
                    { 169L, 4L, 3, 2, 1L },
                    { 170L, 4L, 4, 2, 1L },
                    { 171L, 4L, 5, 2, 1L },
                    { 172L, 4L, 6, 2, 1L },
                    { 174L, 4L, 8, 2, 1L },
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
                    { 450L, 5L, 10, 8, 2L },
                    { 431L, 5L, 7, 7, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
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
                    { 110L, 3L, 4, 4, 1L },
                    { 173L, 4L, 7, 2, 1L },
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
                    { 109L, 3L, 3, 4, 1L },
                    { 40L, 1L, 8, 5, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
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
                    { 17L, 1L, 1, 3, 2L },
                    { 19L, 1L, 3, 3, 2L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
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
                    { 97L, 3L, 3, 3, 1L },
                    { 81L, 3L, 11, 1, 1L },
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
                    { 96L, 3L, 2, 3, 1L },
                    { 98L, 3L, 4, 3, 1L },
                    { 99L, 3L, 5, 3, 1L },
                    { 100L, 3L, 6, 3, 1L },
                    { 101L, 3L, 7, 3, 1L },
                    { 102L, 3L, 8, 3, 1L },
                    { 103L, 3L, 9, 3, 1L },
                    { 104L, 3L, 10, 3, 1L },
                    { 105L, 3L, 11, 3, 1L },
                    { 106L, 3L, 12, 3, 1L }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "HallId", "Number", "Row", "SeatTypeId" },
                values: new object[,]
                {
                    { 107L, 3L, 1, 4, 1L },
                    { 80L, 3L, 10, 1, 1L },
                    { 79L, 3L, 9, 1, 1L },
                    { 82L, 3L, 12, 1, 1L },
                    { 77L, 3L, 7, 1, 1L },
                    { 76L, 3L, 6, 1, 1L },
                    { 78L, 3L, 8, 1, 1L },
                    { 75L, 3L, 5, 1, 1L },
                    { 74L, 3L, 4, 1, 1L },
                    { 73L, 3L, 3, 1, 1L },
                    { 72L, 3L, 2, 1, 1L },
                    { 71L, 3L, 1, 1, 1L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 346L, new DateTime(2023, 1, 3, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 351L, new DateTime(2023, 1, 3, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 356L, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 361L, new DateTime(2023, 1, 4, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 256L, new DateTime(2023, 1, 1, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 266L, new DateTime(2023, 1, 1, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 261L, new DateTime(2023, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 341L, new DateTime(2023, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 251L, new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 246L, new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 366L, new DateTime(2023, 1, 4, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 336L, new DateTime(2023, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 271L, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 326L, new DateTime(2023, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 321L, new DateTime(2023, 1, 3, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 316L, new DateTime(2023, 1, 2, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 311L, new DateTime(2023, 1, 2, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 306L, new DateTime(2023, 1, 2, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 301L, new DateTime(2023, 1, 2, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 296L, new DateTime(2023, 1, 2, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 291L, new DateTime(2023, 1, 2, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 286L, new DateTime(2023, 1, 2, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 281L, new DateTime(2023, 1, 2, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 276L, new DateTime(2023, 1, 1, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 241L, new DateTime(2023, 1, 1, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 331L, new DateTime(2023, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 236L, new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 168L, new DateTime(2022, 12, 30, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 226L, new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 106L, new DateTime(2022, 12, 28, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 111L, new DateTime(2022, 12, 28, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 116L, new DateTime(2022, 12, 28, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 999205L },
                    { 121L, new DateTime(2022, 12, 29, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 126L, new DateTime(2022, 12, 29, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 131L, new DateTime(2022, 12, 29, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 136L, new DateTime(2022, 12, 29, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 141L, new DateTime(2022, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 146L, new DateTime(2022, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 151L, new DateTime(2022, 12, 29, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 156L, new DateTime(2022, 12, 29, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 161L, new DateTime(2022, 12, 30, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 166L, new DateTime(2022, 12, 30, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 171L, new DateTime(2022, 12, 30, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 176L, new DateTime(2022, 12, 30, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 181L, new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 186L, new DateTime(2022, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 191L, new DateTime(2022, 12, 30, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 196L, new DateTime(2022, 12, 30, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 371L, new DateTime(2023, 1, 4, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 201L, new DateTime(2022, 12, 31, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 206L, new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 211L, new DateTime(2022, 12, 31, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 216L, new DateTime(2022, 12, 31, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 221L, new DateTime(2022, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 231L, new DateTime(2022, 12, 31, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 101L, new DateTime(2022, 12, 28, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 376L, new DateTime(2023, 1, 4, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 386L, new DateTime(2023, 1, 4, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 449L, new DateTime(2023, 1, 6, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 454L, new DateTime(2023, 1, 6, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 459L, new DateTime(2023, 1, 6, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 464L, new DateTime(2023, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 469L, new DateTime(2023, 1, 6, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 474L, new DateTime(2023, 1, 6, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 479L, new DateTime(2023, 1, 6, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 484L, new DateTime(2023, 1, 7, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 489L, new DateTime(2023, 1, 7, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 494L, new DateTime(2023, 1, 7, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 499L, new DateTime(2023, 1, 7, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 504L, new DateTime(2023, 1, 7, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 509L, new DateTime(2023, 1, 7, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 514L, new DateTime(2023, 1, 7, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 519L, new DateTime(2023, 1, 7, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 524L, new DateTime(2023, 1, 8, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 529L, new DateTime(2023, 1, 8, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 534L, new DateTime(2023, 1, 8, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 539L, new DateTime(2023, 1, 8, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 444L, new DateTime(2023, 1, 6, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 439L, new DateTime(2023, 1, 5, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 434L, new DateTime(2023, 1, 5, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 429L, new DateTime(2023, 1, 5, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 329L, new DateTime(2023, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 334L, new DateTime(2023, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 339L, new DateTime(2023, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 344L, new DateTime(2023, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 349L, new DateTime(2023, 1, 3, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 354L, new DateTime(2023, 1, 3, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 359L, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 364L, new DateTime(2023, 1, 4, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 369L, new DateTime(2023, 1, 4, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 544L, new DateTime(2023, 1, 8, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 374L, new DateTime(2023, 1, 4, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 384L, new DateTime(2023, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 389L, new DateTime(2023, 1, 4, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 394L, new DateTime(2023, 1, 4, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 399L, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 404L, new DateTime(2023, 1, 5, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 409L, new DateTime(2023, 1, 5, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 414L, new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 419L, new DateTime(2023, 1, 5, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 424L, new DateTime(2023, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 379L, new DateTime(2023, 1, 4, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 381L, new DateTime(2023, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 549L, new DateTime(2023, 1, 8, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 559L, new DateTime(2023, 1, 8, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 481L, new DateTime(2023, 1, 7, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 476L, new DateTime(2023, 1, 6, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 471L, new DateTime(2023, 1, 6, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 466L, new DateTime(2023, 1, 6, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 461L, new DateTime(2023, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 456L, new DateTime(2023, 1, 6, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 451L, new DateTime(2023, 1, 6, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 446L, new DateTime(2023, 1, 6, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 441L, new DateTime(2023, 1, 6, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 436L, new DateTime(2023, 1, 5, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 431L, new DateTime(2023, 1, 5, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 426L, new DateTime(2023, 1, 5, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 421L, new DateTime(2023, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 416L, new DateTime(2023, 1, 5, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 411L, new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 985939L },
                    { 406L, new DateTime(2023, 1, 5, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 401L, new DateTime(2023, 1, 5, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 396L, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 391L, new DateTime(2023, 1, 4, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 486L, new DateTime(2023, 1, 7, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 491L, new DateTime(2023, 1, 7, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 496L, new DateTime(2023, 1, 7, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 501L, new DateTime(2023, 1, 7, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 564L, new DateTime(2023, 1, 9, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 569L, new DateTime(2023, 1, 9, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 574L, new DateTime(2023, 1, 9, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 579L, new DateTime(2023, 1, 9, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 584L, new DateTime(2023, 1, 9, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 589L, new DateTime(2023, 1, 9, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 594L, new DateTime(2023, 1, 9, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 599L, new DateTime(2023, 1, 9, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 604L, new DateTime(2023, 1, 10, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 554L, new DateTime(2023, 1, 8, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 609L, new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 619L, new DateTime(2023, 1, 10, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 624L, new DateTime(2023, 1, 10, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 629L, new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 634L, new DateTime(2023, 1, 10, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 639L, new DateTime(2023, 1, 10, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 521L, new DateTime(2023, 1, 8, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 516L, new DateTime(2023, 1, 7, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 511L, new DateTime(2023, 1, 7, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 506L, new DateTime(2023, 1, 7, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 614L, new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 96L, new DateTime(2022, 12, 28, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 1L, new DateTime(2022, 12, 26, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 86L, new DateTime(2022, 12, 28, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 385L, new DateTime(2023, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 390L, new DateTime(2023, 1, 4, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 395L, new DateTime(2023, 1, 4, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 400L, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 405L, new DateTime(2023, 1, 5, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 410L, new DateTime(2023, 1, 5, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 380L, new DateTime(2023, 1, 4, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 415L, new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 425L, new DateTime(2023, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 430L, new DateTime(2023, 1, 5, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 435L, new DateTime(2023, 1, 5, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 440L, new DateTime(2023, 1, 5, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 445L, new DateTime(2023, 1, 6, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 450L, new DateTime(2023, 1, 6, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 420L, new DateTime(2023, 1, 5, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 375L, new DateTime(2023, 1, 4, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 370L, new DateTime(2023, 1, 4, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 365L, new DateTime(2023, 1, 4, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 290L, new DateTime(2023, 1, 2, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 295L, new DateTime(2023, 1, 2, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 300L, new DateTime(2023, 1, 2, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 305L, new DateTime(2023, 1, 2, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 310L, new DateTime(2023, 1, 2, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 315L, new DateTime(2023, 1, 2, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 320L, new DateTime(2023, 1, 2, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 325L, new DateTime(2023, 1, 3, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 330L, new DateTime(2023, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 335L, new DateTime(2023, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 340L, new DateTime(2023, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 345L, new DateTime(2023, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 350L, new DateTime(2023, 1, 3, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 355L, new DateTime(2023, 1, 3, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 360L, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 455L, new DateTime(2023, 1, 6, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 460L, new DateTime(2023, 1, 6, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 465L, new DateTime(2023, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 470L, new DateTime(2023, 1, 6, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 570L, new DateTime(2023, 1, 9, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 575L, new DateTime(2023, 1, 9, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 580L, new DateTime(2023, 1, 9, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 585L, new DateTime(2023, 1, 9, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 590L, new DateTime(2023, 1, 9, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 595L, new DateTime(2023, 1, 9, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 600L, new DateTime(2023, 1, 9, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 605L, new DateTime(2023, 1, 10, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 610L, new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 615L, new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 620L, new DateTime(2023, 1, 10, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 625L, new DateTime(2023, 1, 10, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 630L, new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 635L, new DateTime(2023, 1, 10, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 640L, new DateTime(2023, 1, 10, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 565L, new DateTime(2023, 1, 9, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 285L, new DateTime(2023, 1, 2, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L },
                    { 560L, new DateTime(2023, 1, 8, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 550L, new DateTime(2023, 1, 8, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 475L, new DateTime(2023, 1, 6, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 480L, new DateTime(2023, 1, 6, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 526896L },
                    { 485L, new DateTime(2023, 1, 7, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 490L, new DateTime(2023, 1, 7, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 495L, new DateTime(2023, 1, 7, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 500L, new DateTime(2023, 1, 7, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 505L, new DateTime(2023, 1, 7, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 510L, new DateTime(2023, 1, 7, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 515L, new DateTime(2023, 1, 7, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 520L, new DateTime(2023, 1, 7, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 525L, new DateTime(2023, 1, 8, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 530L, new DateTime(2023, 1, 8, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 535L, new DateTime(2023, 1, 8, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 540L, new DateTime(2023, 1, 8, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 545L, new DateTime(2023, 1, 8, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 555L, new DateTime(2023, 1, 8, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 280L, new DateTime(2023, 1, 1, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 275L, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 270L, new DateTime(2023, 1, 1, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 5L, new DateTime(2022, 12, 26, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 10L, new DateTime(2022, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 15L, new DateTime(2022, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 20L, new DateTime(2022, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 25L, new DateTime(2022, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 30L, new DateTime(2022, 12, 26, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 35L, new DateTime(2022, 12, 26, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 718930L },
                    { 40L, new DateTime(2022, 12, 26, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 45L, new DateTime(2022, 12, 27, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 50L, new DateTime(2022, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 55L, new DateTime(2022, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 60L, new DateTime(2022, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 65L, new DateTime(2022, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 70L, new DateTime(2022, 12, 27, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 75L, new DateTime(2022, 12, 27, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 637L, new DateTime(2023, 1, 10, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 80L, new DateTime(2022, 12, 27, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 3L, new DateTime(2022, 12, 26, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 6L, new DateTime(2022, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 81L, new DateTime(2022, 12, 28, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 76L, new DateTime(2022, 12, 27, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 71L, new DateTime(2022, 12, 27, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 66L, new DateTime(2022, 12, 27, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 61L, new DateTime(2022, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 56L, new DateTime(2022, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 51L, new DateTime(2022, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 46L, new DateTime(2022, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 634649L },
                    { 41L, new DateTime(2022, 12, 27, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 36L, new DateTime(2022, 12, 26, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 31L, new DateTime(2022, 12, 26, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 26L, new DateTime(2022, 12, 26, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 21L, new DateTime(2022, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 16L, new DateTime(2022, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 11L, new DateTime(2022, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 576925L },
                    { 324L, new DateTime(2023, 1, 3, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 91L, new DateTime(2022, 12, 28, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 762504L },
                    { 85L, new DateTime(2022, 12, 28, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 95L, new DateTime(2022, 12, 28, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 195L, new DateTime(2022, 12, 30, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 610150L },
                    { 200L, new DateTime(2022, 12, 30, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 205L, new DateTime(2022, 12, 31, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 210L, new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 215L, new DateTime(2022, 12, 31, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 744276L },
                    { 220L, new DateTime(2022, 12, 31, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 961484L },
                    { 225L, new DateTime(2022, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 230L, new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 916605L },
                    { 235L, new DateTime(2022, 12, 31, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 240L, new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 245L, new DateTime(2023, 1, 1, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 250L, new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 255L, new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 260L, new DateTime(2023, 1, 1, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 265L, new DateTime(2023, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 190L, new DateTime(2022, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 90L, new DateTime(2022, 12, 28, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 760161L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 185L, new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 576925L },
                    { 175L, new DateTime(2022, 12, 30, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 882598L },
                    { 100L, new DateTime(2022, 12, 28, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 105L, new DateTime(2022, 12, 28, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 110L, new DateTime(2022, 12, 28, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 921360L },
                    { 115L, new DateTime(2022, 12, 28, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 120L, new DateTime(2022, 12, 28, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 762504L },
                    { 125L, new DateTime(2022, 12, 29, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 19995L },
                    { 130L, new DateTime(2022, 12, 29, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 135L, new DateTime(2022, 12, 29, 12, 0, 0, 0, DateTimeKind.Local), 5L, true, 760741L },
                    { 140L, new DateTime(2022, 12, 29, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 877957L },
                    { 145L, new DateTime(2022, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 5L, true, 756999L },
                    { 150L, new DateTime(2022, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 5L, true, 634649L },
                    { 155L, new DateTime(2022, 12, 29, 20, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 160L, new DateTime(2022, 12, 29, 22, 0, 0, 0, DateTimeKind.Local), 5L, true, 999205L },
                    { 165L, new DateTime(2022, 12, 30, 8, 0, 0, 0, DateTimeKind.Local), 5L, true, 539681L },
                    { 170L, new DateTime(2022, 12, 30, 10, 0, 0, 0, DateTimeKind.Local), 5L, true, 639933L },
                    { 180L, new DateTime(2022, 12, 30, 14, 0, 0, 0, DateTimeKind.Local), 5L, true, 985939L },
                    { 163L, new DateTime(2022, 12, 30, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 319L, new DateTime(2023, 1, 2, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 309L, new DateTime(2023, 1, 2, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 572L, new DateTime(2023, 1, 9, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 567L, new DateTime(2023, 1, 9, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 562L, new DateTime(2023, 1, 9, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 557L, new DateTime(2023, 1, 8, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 552L, new DateTime(2023, 1, 8, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 547L, new DateTime(2023, 1, 8, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 542L, new DateTime(2023, 1, 8, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 537L, new DateTime(2023, 1, 8, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 532L, new DateTime(2023, 1, 8, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 527L, new DateTime(2023, 1, 8, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 522L, new DateTime(2023, 1, 8, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 517L, new DateTime(2023, 1, 7, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 512L, new DateTime(2023, 1, 7, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 507L, new DateTime(2023, 1, 7, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 502L, new DateTime(2023, 1, 7, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 497L, new DateTime(2023, 1, 7, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 492L, new DateTime(2023, 1, 7, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 577L, new DateTime(2023, 1, 9, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 487L, new DateTime(2023, 1, 7, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 582L, new DateTime(2023, 1, 9, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 592L, new DateTime(2023, 1, 9, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 598L, new DateTime(2023, 1, 9, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 603L, new DateTime(2023, 1, 10, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 608L, new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 613L, new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 618L, new DateTime(2023, 1, 10, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 623L, new DateTime(2023, 1, 10, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 628L, new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 633L, new DateTime(2023, 1, 10, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 638L, new DateTime(2023, 1, 10, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 632L, new DateTime(2023, 1, 10, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 627L, new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 622L, new DateTime(2023, 1, 10, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 617L, new DateTime(2023, 1, 10, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 612L, new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 607L, new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 602L, new DateTime(2023, 1, 10, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 597L, new DateTime(2023, 1, 9, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 587L, new DateTime(2023, 1, 9, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 593L, new DateTime(2023, 1, 9, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 482L, new DateTime(2023, 1, 7, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 472L, new DateTime(2023, 1, 6, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 362L, new DateTime(2023, 1, 4, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 357L, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 352L, new DateTime(2023, 1, 3, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 347L, new DateTime(2023, 1, 3, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 342L, new DateTime(2023, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 337L, new DateTime(2023, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 332L, new DateTime(2023, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 327L, new DateTime(2023, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 322L, new DateTime(2023, 1, 3, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 317L, new DateTime(2023, 1, 2, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 312L, new DateTime(2023, 1, 2, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 307L, new DateTime(2023, 1, 2, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 302L, new DateTime(2023, 1, 2, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 297L, new DateTime(2023, 1, 2, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 292L, new DateTime(2023, 1, 2, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 287L, new DateTime(2023, 1, 2, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 282L, new DateTime(2023, 1, 2, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 367L, new DateTime(2023, 1, 4, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 477L, new DateTime(2023, 1, 6, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 372L, new DateTime(2023, 1, 4, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 382L, new DateTime(2023, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 467L, new DateTime(2023, 1, 6, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 462L, new DateTime(2023, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 457L, new DateTime(2023, 1, 6, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 452L, new DateTime(2023, 1, 6, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 447L, new DateTime(2023, 1, 6, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 442L, new DateTime(2023, 1, 6, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 437L, new DateTime(2023, 1, 5, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 432L, new DateTime(2023, 1, 5, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 427L, new DateTime(2023, 1, 5, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 422L, new DateTime(2023, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 417L, new DateTime(2023, 1, 5, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 762504L },
                    { 412L, new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 407L, new DateTime(2023, 1, 5, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 402L, new DateTime(2023, 1, 5, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 397L, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 392L, new DateTime(2023, 1, 4, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 387L, new DateTime(2023, 1, 4, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 377L, new DateTime(2023, 1, 4, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 588L, new DateTime(2023, 1, 9, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 583L, new DateTime(2023, 1, 9, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 578L, new DateTime(2023, 1, 9, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 278L, new DateTime(2023, 1, 1, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 283L, new DateTime(2023, 1, 2, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 288L, new DateTime(2023, 1, 2, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 293L, new DateTime(2023, 1, 2, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 298L, new DateTime(2023, 1, 2, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 303L, new DateTime(2023, 1, 2, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 308L, new DateTime(2023, 1, 2, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 313L, new DateTime(2023, 1, 2, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 318L, new DateTime(2023, 1, 2, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 323L, new DateTime(2023, 1, 3, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 328L, new DateTime(2023, 1, 3, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 333L, new DateTime(2023, 1, 3, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 338L, new DateTime(2023, 1, 3, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 343L, new DateTime(2023, 1, 3, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 348L, new DateTime(2023, 1, 3, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 353L, new DateTime(2023, 1, 3, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 358L, new DateTime(2023, 1, 3, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 273L, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 363L, new DateTime(2023, 1, 4, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 268L, new DateTime(2023, 1, 1, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 258L, new DateTime(2023, 1, 1, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 173L, new DateTime(2022, 12, 30, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 178L, new DateTime(2022, 12, 30, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 183L, new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 188L, new DateTime(2022, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 193L, new DateTime(2022, 12, 30, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 198L, new DateTime(2022, 12, 30, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 203L, new DateTime(2022, 12, 31, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 208L, new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 213L, new DateTime(2022, 12, 31, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 539681L },
                    { 218L, new DateTime(2022, 12, 31, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 223L, new DateTime(2022, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 228L, new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 233L, new DateTime(2022, 12, 31, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 238L, new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 243L, new DateTime(2023, 1, 1, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 248L, new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 253L, new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 263L, new DateTime(2023, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 368L, new DateTime(2023, 1, 4, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 373L, new DateTime(2023, 1, 4, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 378L, new DateTime(2023, 1, 4, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 985939L },
                    { 493L, new DateTime(2023, 1, 7, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 498L, new DateTime(2023, 1, 7, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 503L, new DateTime(2023, 1, 7, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 508L, new DateTime(2023, 1, 7, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 513L, new DateTime(2023, 1, 7, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 518L, new DateTime(2023, 1, 7, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 523L, new DateTime(2023, 1, 8, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 528L, new DateTime(2023, 1, 8, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 533L, new DateTime(2023, 1, 8, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 538L, new DateTime(2023, 1, 8, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 543L, new DateTime(2023, 1, 8, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 548L, new DateTime(2023, 1, 8, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 553L, new DateTime(2023, 1, 8, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 558L, new DateTime(2023, 1, 8, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 563L, new DateTime(2023, 1, 9, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 568L, new DateTime(2023, 1, 9, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 573L, new DateTime(2023, 1, 9, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 488L, new DateTime(2023, 1, 7, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 483L, new DateTime(2023, 1, 7, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 478L, new DateTime(2023, 1, 6, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 473L, new DateTime(2023, 1, 6, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 383L, new DateTime(2023, 1, 4, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 388L, new DateTime(2023, 1, 4, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 393L, new DateTime(2023, 1, 4, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 398L, new DateTime(2023, 1, 4, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 403L, new DateTime(2023, 1, 5, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 408L, new DateTime(2023, 1, 5, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 413L, new DateTime(2023, 1, 5, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 418L, new DateTime(2023, 1, 5, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 277L, new DateTime(2023, 1, 1, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 423L, new DateTime(2023, 1, 5, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 433L, new DateTime(2023, 1, 5, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 438L, new DateTime(2023, 1, 5, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 443L, new DateTime(2023, 1, 6, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 448L, new DateTime(2023, 1, 6, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 453L, new DateTime(2023, 1, 6, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 458L, new DateTime(2023, 1, 6, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 463L, new DateTime(2023, 1, 6, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 468L, new DateTime(2023, 1, 6, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 428L, new DateTime(2023, 1, 5, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 916605L },
                    { 272L, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 267L, new DateTime(2023, 1, 1, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 262L, new DateTime(2023, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 9L, new DateTime(2022, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 744276L },
                    { 14L, new DateTime(2022, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 19L, new DateTime(2022, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 24L, new DateTime(2022, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 29L, new DateTime(2022, 12, 26, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 34L, new DateTime(2022, 12, 26, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 756999L },
                    { 39L, new DateTime(2022, 12, 26, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 44L, new DateTime(2022, 12, 27, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 49L, new DateTime(2022, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 54L, new DateTime(2022, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 59L, new DateTime(2022, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 64L, new DateTime(2022, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 69L, new DateTime(2022, 12, 27, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 74L, new DateTime(2022, 12, 27, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 79L, new DateTime(2022, 12, 27, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 84L, new DateTime(2022, 12, 28, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 89L, new DateTime(2022, 12, 28, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 4L, new DateTime(2022, 12, 26, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 94L, new DateTime(2022, 12, 28, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 639933L },
                    { 526L, new DateTime(2023, 1, 8, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 536L, new DateTime(2023, 1, 8, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 882598L },
                    { 621L, new DateTime(2023, 1, 10, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 616L, new DateTime(2023, 1, 10, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 611L, new DateTime(2023, 1, 10, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 606L, new DateTime(2023, 1, 10, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 601L, new DateTime(2023, 1, 10, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 639933L },
                    { 596L, new DateTime(2023, 1, 9, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 916605L },
                    { 591L, new DateTime(2023, 1, 9, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 586L, new DateTime(2023, 1, 9, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 756999L },
                    { 581L, new DateTime(2023, 1, 9, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 610150L },
                    { 576L, new DateTime(2023, 1, 9, 14, 0, 0, 0, DateTimeKind.Local), 1L, true, 760741L },
                    { 571L, new DateTime(2023, 1, 9, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 539681L },
                    { 566L, new DateTime(2023, 1, 9, 10, 0, 0, 0, DateTimeKind.Local), 1L, true, 744276L },
                    { 561L, new DateTime(2023, 1, 9, 8, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 556L, new DateTime(2023, 1, 8, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 551L, new DateTime(2023, 1, 8, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 526896L },
                    { 546L, new DateTime(2023, 1, 8, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 921360L },
                    { 541L, new DateTime(2023, 1, 8, 16, 0, 0, 0, DateTimeKind.Local), 1L, true, 961484L },
                    { 531L, new DateTime(2023, 1, 8, 12, 0, 0, 0, DateTimeKind.Local), 1L, true, 877957L },
                    { 99L, new DateTime(2022, 12, 28, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 104L, new DateTime(2022, 12, 28, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 109L, new DateTime(2022, 12, 28, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 224L, new DateTime(2022, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 229L, new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 234L, new DateTime(2022, 12, 31, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 239L, new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 244L, new DateTime(2023, 1, 1, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 249L, new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 254L, new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 259L, new DateTime(2023, 1, 1, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 264L, new DateTime(2023, 1, 1, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 576925L },
                    { 269L, new DateTime(2023, 1, 1, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 921360L },
                    { 274L, new DateTime(2023, 1, 1, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 760161L },
                    { 279L, new DateTime(2023, 1, 1, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 916605L },
                    { 284L, new DateTime(2023, 1, 2, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 289L, new DateTime(2023, 1, 2, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 294L, new DateTime(2023, 1, 2, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 299L, new DateTime(2023, 1, 2, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 304L, new DateTime(2023, 1, 2, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 760741L },
                    { 219L, new DateTime(2022, 12, 31, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 214L, new DateTime(2022, 12, 31, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 209L, new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 204L, new DateTime(2022, 12, 31, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 114L, new DateTime(2022, 12, 28, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 119L, new DateTime(2022, 12, 28, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 124L, new DateTime(2022, 12, 29, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 718930L },
                    { 129L, new DateTime(2022, 12, 29, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 134L, new DateTime(2022, 12, 29, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 539681L },
                    { 8L, new DateTime(2022, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 144L, new DateTime(2022, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 149L, new DateTime(2022, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 634649L },
                    { 626L, new DateTime(2023, 1, 10, 18, 0, 0, 0, DateTimeKind.Local), 1L, true, 718930L },
                    { 154L, new DateTime(2022, 12, 29, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 877957L },
                    { 164L, new DateTime(2022, 12, 30, 8, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 169L, new DateTime(2022, 12, 30, 10, 0, 0, 0, DateTimeKind.Local), 4L, true, 526896L },
                    { 174L, new DateTime(2022, 12, 30, 12, 0, 0, 0, DateTimeKind.Local), 4L, true, 610150L },
                    { 179L, new DateTime(2022, 12, 30, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 184L, new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), 4L, true, 882598L },
                    { 189L, new DateTime(2022, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), 4L, true, 19995L },
                    { 194L, new DateTime(2022, 12, 30, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L },
                    { 199L, new DateTime(2022, 12, 30, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 961484L },
                    { 159L, new DateTime(2022, 12, 29, 22, 0, 0, 0, DateTimeKind.Local), 4L, true, 985939L },
                    { 314L, new DateTime(2023, 1, 2, 20, 0, 0, 0, DateTimeKind.Local), 4L, true, 762504L },
                    { 631L, new DateTime(2023, 1, 10, 20, 0, 0, 0, DateTimeKind.Local), 1L, true, 760161L },
                    { 13L, new DateTime(2022, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 152L, new DateTime(2022, 12, 29, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 147L, new DateTime(2022, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 610150L },
                    { 142L, new DateTime(2022, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 137L, new DateTime(2022, 12, 29, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 132L, new DateTime(2022, 12, 29, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 127L, new DateTime(2022, 12, 29, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 744276L },
                    { 122L, new DateTime(2022, 12, 29, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 117L, new DateTime(2022, 12, 28, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 112L, new DateTime(2022, 12, 28, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 760741L },
                    { 107L, new DateTime(2022, 12, 28, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 102L, new DateTime(2022, 12, 28, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 97L, new DateTime(2022, 12, 28, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 576925L },
                    { 92L, new DateTime(2022, 12, 28, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 87L, new DateTime(2022, 12, 28, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 82L, new DateTime(2022, 12, 28, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 77L, new DateTime(2022, 12, 27, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 72L, new DateTime(2022, 12, 27, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 157L, new DateTime(2022, 12, 29, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 67L, new DateTime(2022, 12, 27, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 162L, new DateTime(2022, 12, 30, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 172L, new DateTime(2022, 12, 30, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 718930L },
                    { 257L, new DateTime(2023, 1, 1, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 252L, new DateTime(2023, 1, 1, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 247L, new DateTime(2023, 1, 1, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 242L, new DateTime(2023, 1, 1, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 237L, new DateTime(2022, 12, 31, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 232L, new DateTime(2022, 12, 31, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 227L, new DateTime(2022, 12, 31, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 985939L },
                    { 222L, new DateTime(2022, 12, 31, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 882598L },
                    { 217L, new DateTime(2022, 12, 31, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 212L, new DateTime(2022, 12, 31, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 634649L },
                    { 207L, new DateTime(2022, 12, 31, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 202L, new DateTime(2022, 12, 31, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 539681L },
                    { 197L, new DateTime(2022, 12, 30, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 192L, new DateTime(2022, 12, 30, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 187L, new DateTime(2022, 12, 30, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 182L, new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 177L, new DateTime(2022, 12, 30, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 167L, new DateTime(2022, 12, 30, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 62L, new DateTime(2022, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 526896L },
                    { 57L, new DateTime(2022, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 52L, new DateTime(2022, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 639933L },
                    { 98L, new DateTime(2022, 12, 28, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 93L, new DateTime(2022, 12, 28, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 999205L },
                    { 88L, new DateTime(2022, 12, 28, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 83L, new DateTime(2022, 12, 28, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 78L, new DateTime(2022, 12, 27, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 73L, new DateTime(2022, 12, 27, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 921360L },
                    { 68L, new DateTime(2022, 12, 27, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 63L, new DateTime(2022, 12, 27, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 756999L },
                    { 58L, new DateTime(2022, 12, 27, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 53L, new DateTime(2022, 12, 27, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 48L, new DateTime(2022, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 43L, new DateTime(2022, 12, 27, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 576925L },
                    { 38L, new DateTime(2022, 12, 26, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 33L, new DateTime(2022, 12, 26, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 760741L },
                    { 28L, new DateTime(2022, 12, 26, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 961484L },
                    { 23L, new DateTime(2022, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 18L, new DateTime(2022, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 762504L },
                    { 103L, new DateTime(2022, 12, 28, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 744276L },
                    { 108L, new DateTime(2022, 12, 28, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L }
                });

            migrationBuilder.InsertData(
                table: "Sessions",
                columns: new[] { "Id", "DateTime", "HallId", "IsPublic", "MovieId" },
                values: new object[,]
                {
                    { 113L, new DateTime(2022, 12, 28, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 634649L },
                    { 118L, new DateTime(2022, 12, 28, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 877957L },
                    { 47L, new DateTime(2022, 12, 27, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 42L, new DateTime(2022, 12, 27, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 877957L },
                    { 37L, new DateTime(2022, 12, 26, 22, 0, 0, 0, DateTimeKind.Local), 2L, true, 921360L },
                    { 32L, new DateTime(2022, 12, 26, 20, 0, 0, 0, DateTimeKind.Local), 2L, true, 756999L },
                    { 27L, new DateTime(2022, 12, 26, 18, 0, 0, 0, DateTimeKind.Local), 2L, true, 961484L },
                    { 22L, new DateTime(2022, 12, 26, 16, 0, 0, 0, DateTimeKind.Local), 2L, true, 19995L },
                    { 17L, new DateTime(2022, 12, 26, 14, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 12L, new DateTime(2022, 12, 26, 12, 0, 0, 0, DateTimeKind.Local), 2L, true, 760161L },
                    { 636L, new DateTime(2023, 1, 10, 22, 0, 0, 0, DateTimeKind.Local), 1L, true, 19995L },
                    { 7L, new DateTime(2022, 12, 26, 10, 0, 0, 0, DateTimeKind.Local), 2L, true, 999205L },
                    { 158L, new DateTime(2022, 12, 29, 22, 0, 0, 0, DateTimeKind.Local), 3L, true, 19995L },
                    { 153L, new DateTime(2022, 12, 29, 20, 0, 0, 0, DateTimeKind.Local), 3L, true, 882598L },
                    { 148L, new DateTime(2022, 12, 29, 18, 0, 0, 0, DateTimeKind.Local), 3L, true, 639933L },
                    { 143L, new DateTime(2022, 12, 29, 16, 0, 0, 0, DateTimeKind.Local), 3L, true, 526896L },
                    { 138L, new DateTime(2022, 12, 29, 14, 0, 0, 0, DateTimeKind.Local), 3L, true, 718930L },
                    { 133L, new DateTime(2022, 12, 29, 12, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 128L, new DateTime(2022, 12, 29, 10, 0, 0, 0, DateTimeKind.Local), 3L, true, 760161L },
                    { 123L, new DateTime(2022, 12, 29, 8, 0, 0, 0, DateTimeKind.Local), 3L, true, 610150L },
                    { 2L, new DateTime(2022, 12, 26, 8, 0, 0, 0, DateTimeKind.Local), 2L, true, 916605L },
                    { 139L, new DateTime(2022, 12, 29, 14, 0, 0, 0, DateTimeKind.Local), 4L, true, 999205L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 132L, 2L, 3L, 6L },
                    { 338L, 3L, 201L, 29L },
                    { 339L, 3L, 202L, 29L },
                    { 340L, 1L, 269L, 29L },
                    { 444L, 3L, 265L, 29L },
                    { 445L, 3L, 266L, 29L },
                    { 446L, 1L, 267L, 29L },
                    { 337L, 2L, 200L, 29L },
                    { 33L, 2L, 240L, 34L },
                    { 210L, 2L, 164L, 34L },
                    { 419L, 2L, 305L, 44L },
                    { 420L, 3L, 306L, 44L },
                    { 520L, 1L, 255L, 44L },
                    { 521L, 2L, 256L, 44L },
                    { 522L, 1L, 257L, 44L },
                    { 34L, 3L, 241L, 34L },
                    { 213L, 3L, 186L, 29L },
                    { 212L, 2L, 185L, 29L },
                    { 211L, 3L, 184L, 29L },
                    { 192L, 3L, 265L, 14L },
                    { 292L, 2L, 212L, 14L },
                    { 293L, 1L, 213L, 14L },
                    { 294L, 3L, 214L, 14L },
                    { 414L, 2L, 187L, 14L },
                    { 415L, 1L, 188L, 14L },
                    { 161L, 3L, 161L, 19L },
                    { 162L, 3L, 162L, 19L },
                    { 300L, 1L, 242L, 19L },
                    { 301L, 1L, 243L, 19L },
                    { 394L, 2L, 320L, 19L },
                    { 395L, 1L, 321L, 19L },
                    { 545L, 1L, 217L, 24L },
                    { 566L, 3L, 241L, 24L },
                    { 567L, 2L, 242L, 24L },
                    { 93L, 3L, 288L, 49L },
                    { 94L, 2L, 289L, 49L },
                    { 95L, 2L, 290L, 49L },
                    { 166L, 1L, 321L, 49L },
                    { 5L, 1L, 166L, 64L },
                    { 280L, 2L, 280L, 64L },
                    { 281L, 3L, 281L, 64L },
                    { 555L, 2L, 262L, 64L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 556L, 2L, 263L, 64L },
                    { 557L, 2L, 264L, 64L },
                    { 42L, 1L, 259L, 69L },
                    { 43L, 2L, 260L, 69L },
                    { 44L, 1L, 261L, 69L },
                    { 509L, 2L, 239L, 69L },
                    { 510L, 3L, 240L, 69L },
                    { 28L, 3L, 250L, 74L },
                    { 45L, 3L, 164L, 74L },
                    { 46L, 3L, 165L, 74L },
                    { 63L, 3L, 242L, 74L },
                    { 4L, 2L, 165L, 64L },
                    { 191L, 2L, 264L, 14L },
                    { 599L, 2L, 304L, 59L },
                    { 597L, 1L, 302L, 59L },
                    { 167L, 2L, 322L, 49L },
                    { 176L, 1L, 238L, 49L },
                    { 486L, 2L, 246L, 49L },
                    { 487L, 3L, 247L, 49L },
                    { 146L, 2L, 183L, 54L },
                    { 147L, 1L, 184L, 54L },
                    { 431L, 2L, 150L, 54L },
                    { 318L, 2L, 327L, 59L },
                    { 319L, 1L, 328L, 59L },
                    { 335L, 2L, 166L, 59L },
                    { 336L, 3L, 167L, 59L },
                    { 380L, 3L, 241L, 59L },
                    { 381L, 3L, 242L, 59L },
                    { 450L, 1L, 199L, 59L },
                    { 451L, 2L, 200L, 59L },
                    { 598L, 3L, 303L, 59L },
                    { 64L, 1L, 243L, 74L },
                    { 528L, 2L, 244L, 9L },
                    { 526L, 1L, 242L, 9L },
                    { 163L, 2L, 139L, 68L },
                    { 246L, 3L, 106L, 68L },
                    { 247L, 1L, 107L, 68L },
                    { 396L, 2L, 135L, 68L },
                    { 397L, 2L, 136L, 68L },
                    { 568L, 1L, 137L, 68L },
                    { 245L, 1L, 97L, 63L },
                    { 258L, 1L, 86L, 73L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 260L, 3L, 88L, 73L },
                    { 308L, 1L, 106L, 73L },
                    { 309L, 1L, 107L, 73L },
                    { 310L, 3L, 108L, 73L },
                    { 466L, 3L, 76L, 78L },
                    { 467L, 3L, 77L, 78L },
                    { 259L, 3L, 87L, 73L },
                    { 244L, 2L, 96L, 63L },
                    { 219L, 3L, 136L, 63L },
                    { 218L, 1L, 135L, 63L },
                    { 410L, 3L, 125L, 48L },
                    { 411L, 2L, 126L, 48L },
                    { 74L, 2L, 75L, 53L },
                    { 75L, 1L, 76L, 53L },
                    { 476L, 3L, 122L, 53L },
                    { 477L, 3L, 123L, 53L },
                    { 55L, 1L, 78L, 58L },
                    { 56L, 1L, 79L, 58L },
                    { 543L, 3L, 112L, 58L },
                    { 544L, 2L, 113L, 58L },
                    { 583L, 1L, 103L, 58L },
                    { 584L, 3L, 104L, 58L },
                    { 585L, 3L, 105L, 58L },
                    { 92L, 1L, 127L, 63L },
                    { 217L, 2L, 134L, 63L },
                    { 285L, 1L, 105L, 83L },
                    { 286L, 2L, 106L, 83L },
                    { 287L, 2L, 107L, 83L },
                    { 382L, 2L, 73L, 83L },
                    { 239L, 1L, 87L, 98L },
                    { 240L, 1L, 88L, 98L },
                    { 35L, 2L, 234L, 4L },
                    { 36L, 3L, 235L, 4L },
                    { 52L, 2L, 199L, 4L },
                    { 53L, 3L, 200L, 4L },
                    { 54L, 3L, 201L, 4L },
                    { 575L, 2L, 262L, 4L },
                    { 576L, 2L, 263L, 4L },
                    { 577L, 2L, 264L, 4L },
                    { 139L, 1L, 290L, 9L },
                    { 140L, 1L, 291L, 9L },
                    { 149L, 3L, 257L, 9L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 150L, 1L, 258L, 9L },
                    { 525L, 3L, 241L, 9L },
                    { 238L, 2L, 86L, 98L },
                    { 527L, 3L, 243L, 9L },
                    { 194L, 3L, 134L, 98L },
                    { 591L, 2L, 127L, 93L },
                    { 383L, 1L, 74L, 83L },
                    { 578L, 3L, 78L, 83L },
                    { 579L, 3L, 79L, 83L },
                    { 195L, 2L, 129L, 88L },
                    { 196L, 1L, 130L, 88L },
                    { 209L, 2L, 93L, 88L },
                    { 326L, 1L, 71L, 88L },
                    { 327L, 1L, 72L, 88L },
                    { 468L, 3L, 99L, 88L },
                    { 469L, 2L, 100L, 88L },
                    { 470L, 3L, 101L, 88L },
                    { 546L, 1L, 89L, 88L },
                    { 387L, 3L, 80L, 93L },
                    { 388L, 1L, 81L, 93L },
                    { 590L, 3L, 126L, 93L },
                    { 193L, 1L, 133L, 98L },
                    { 328L, 1L, 201L, 74L },
                    { 358L, 3L, 184L, 74L },
                    { 20L, 3L, 328L, 79L },
                    { 39L, 2L, 417L, 70L },
                    { 254L, 1L, 356L, 70L },
                    { 344L, 1L, 332L, 70L },
                    { 345L, 1L, 333L, 70L },
                    { 569L, 2L, 418L, 70L },
                    { 570L, 3L, 419L, 70L },
                    { 38L, 3L, 416L, 70L },
                    { 571L, 1L, 420L, 70L },
                    { 2L, 3L, 416L, 75L },
                    { 3L, 1L, 417L, 75L },
                    { 78L, 1L, 362L, 75L },
                    { 79L, 2L, 363L, 75L },
                    { 80L, 3L, 364L, 75L },
                    { 151L, 1L, 427L, 75L },
                    { 1L, 3L, 415L, 75L },
                    { 37L, 3L, 415L, 70L },
                    { 403L, 2L, 393L, 65L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 402L, 3L, 392L, 65L },
                    { 82L, 3L, 358L, 55L },
                    { 83L, 2L, 359L, 55L },
                    { 107L, 2L, 368L, 60L },
                    { 108L, 3L, 369L, 60L },
                    { 283L, 3L, 359L, 60L },
                    { 284L, 2L, 360L, 60L },
                    { 416L, 2L, 376L, 60L },
                    { 417L, 3L, 377L, 60L },
                    { 418L, 3L, 378L, 60L },
                    { 98L, 3L, 409L, 65L },
                    { 99L, 2L, 410L, 65L },
                    { 100L, 1L, 411L, 65L },
                    { 204L, 3L, 425L, 65L },
                    { 205L, 2L, 426L, 65L },
                    { 401L, 3L, 391L, 65L },
                    { 152L, 1L, 428L, 75L },
                    { 153L, 2L, 429L, 75L },
                    { 298L, 2L, 421L, 75L },
                    { 299L, 2L, 422L, 75L },
                    { 481L, 2L, 382L, 85L },
                    { 137L, 3L, 382L, 90L },
                    { 138L, 2L, 383L, 90L },
                    { 190L, 2L, 362L, 90L },
                    { 248L, 1L, 373L, 90L },
                    { 249L, 2L, 374L, 90L },
                    { 251L, 2L, 465L, 90L },
                    { 252L, 3L, 466L, 90L },
                    { 253L, 3L, 467L, 90L },
                    { 29L, 2L, 363L, 95L },
                    { 30L, 2L, 364L, 95L },
                    { 31L, 1L, 365L, 95L },
                    { 350L, 1L, 379L, 95L },
                    { 351L, 1L, 380L, 95L },
                    { 552L, 1L, 465L, 95L },
                    { 480L, 3L, 381L, 85L },
                    { 81L, 1L, 357L, 55L },
                    { 479L, 3L, 380L, 85L },
                    { 582L, 1L, 342L, 80L },
                    { 6L, 2L, 450L, 80L },
                    { 7L, 3L, 451L, 80L },
                    { 8L, 2L, 452L, 80L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 125L, 3L, 349L, 80L },
                    { 126L, 1L, 350L, 80L },
                    { 127L, 3L, 351L, 80L },
                    { 229L, 3L, 426L, 80L },
                    { 230L, 2L, 427L, 80L },
                    { 282L, 1L, 411L, 80L },
                    { 432L, 3L, 421L, 80L },
                    { 433L, 1L, 422L, 80L },
                    { 434L, 3L, 423L, 80L },
                    { 535L, 3L, 420L, 80L },
                    { 580L, 3L, 340L, 80L },
                    { 581L, 1L, 341L, 80L },
                    { 478L, 2L, 379L, 85L },
                    { 390L, 1L, 353L, 50L },
                    { 389L, 1L, 352L, 50L },
                    { 374L, 1L, 441L, 50L },
                    { 311L, 2L, 150L, 94L },
                    { 312L, 1L, 151L, 94L },
                    { 21L, 2L, 329L, 79L },
                    { 233L, 1L, 362L, 10L },
                    { 234L, 2L, 363L, 10L },
                    { 428L, 2L, 380L, 10L },
                    { 429L, 1L, 381L, 10L },
                    { 430L, 3L, 382L, 10L },
                    { 491L, 2L, 352L, 10L },
                    { 492L, 2L, 353L, 10L },
                    { 547L, 1L, 415L, 10L },
                    { 548L, 1L, 416L, 10L },
                    { 549L, 3L, 417L, 10L },
                    { 76L, 2L, 367L, 15L },
                    { 77L, 1L, 368L, 15L },
                    { 291L, 3L, 302L, 94L },
                    { 518L, 1L, 426L, 15L },
                    { 290L, 1L, 301L, 94L },
                    { 90L, 2L, 315L, 94L },
                    { 505L, 1L, 182L, 79L },
                    { 412L, 2L, 261L, 84L },
                    { 413L, 1L, 262L, 84L },
                    { 220L, 3L, 163L, 89L },
                    { 221L, 1L, 164L, 89L },
                    { 222L, 1L, 165L, 89L },
                    { 361L, 3L, 287L, 89L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 362L, 2L, 288L, 89L },
                    { 363L, 2L, 289L, 89L },
                    { 595L, 2L, 320L, 89L },
                    { 596L, 3L, 321L, 89L },
                    { 600L, 1L, 260L, 89L },
                    { 601L, 1L, 261L, 89L },
                    { 602L, 1L, 262L, 89L },
                    { 89L, 2L, 314L, 94L },
                    { 91L, 2L, 316L, 94L },
                    { 409L, 1L, 124L, 48L },
                    { 519L, 2L, 427L, 15L },
                    { 165L, 1L, 417L, 20L },
                    { 186L, 2L, 373L, 40L },
                    { 484L, 3L, 468L, 40L },
                    { 485L, 1L, 469L, 40L },
                    { 183L, 3L, 407L, 45L },
                    { 184L, 3L, 408L, 45L },
                    { 377L, 1L, 331L, 45L },
                    { 378L, 2L, 332L, 45L },
                    { 379L, 1L, 333L, 45L },
                    { 515L, 2L, 352L, 45L },
                    { 516L, 1L, 353L, 45L },
                    { 517L, 3L, 354L, 45L },
                    { 155L, 2L, 378L, 50L },
                    { 156L, 2L, 379L, 50L },
                    { 157L, 3L, 380L, 50L },
                    { 373L, 3L, 440L, 50L },
                    { 185L, 3L, 372L, 40L },
                    { 164L, 2L, 416L, 20L },
                    { 10L, 3L, 427L, 40L },
                    { 465L, 1L, 375L, 35L },
                    { 302L, 3L, 341L, 20L },
                    { 303L, 3L, 342L, 20L },
                    { 87L, 1L, 386L, 25L },
                    { 88L, 2L, 387L, 25L },
                    { 15L, 3L, 413L, 30L },
                    { 16L, 2L, 414L, 30L },
                    { 231L, 3L, 459L, 30L },
                    { 232L, 3L, 460L, 30L },
                    { 370L, 1L, 374L, 30L },
                    { 371L, 2L, 375L, 30L },
                    { 372L, 3L, 376L, 30L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 25L, 1L, 331L, 35L },
                    { 26L, 3L, 332L, 35L },
                    { 27L, 3L, 333L, 35L },
                    { 464L, 1L, 374L, 35L },
                    { 9L, 2L, 426L, 40L },
                    { 551L, 3L, 97L, 43L },
                    { 534L, 3L, 127L, 43L },
                    { 533L, 2L, 126L, 43L },
                    { 237L, 2L, 7L, 66L },
                    { 323L, 1L, 31L, 66L },
                    { 324L, 3L, 32L, 66L },
                    { 325L, 1L, 33L, 66L },
                    { 512L, 3L, 38L, 66L },
                    { 513L, 3L, 39L, 66L },
                    { 236L, 2L, 6L, 66L },
                    { 514L, 1L, 40L, 66L },
                    { 277L, 2L, 6L, 71L },
                    { 278L, 2L, 7L, 71L },
                    { 279L, 1L, 8L, 71L },
                    { 586L, 2L, 38L, 71L },
                    { 587L, 3L, 39L, 71L },
                    { 17L, 3L, 15L, 76L },
                    { 148L, 1L, 31L, 71L },
                    { 235L, 3L, 5L, 66L },
                    { 228L, 2L, 10L, 66L },
                    { 129L, 2L, 9L, 66L },
                    { 504L, 1L, 11L, 56L },
                    { 561L, 2L, 18L, 56L },
                    { 562L, 3L, 19L, 56L },
                    { 563L, 3L, 20L, 56L },
                    { 49L, 1L, 1L, 61L },
                    { 50L, 1L, 2L, 61L },
                    { 51L, 1L, 3L, 61L },
                    { 206L, 1L, 13L, 61L },
                    { 207L, 3L, 14L, 61L },
                    { 208L, 2L, 15L, 61L },
                    { 471L, 1L, 33L, 61L },
                    { 472L, 1L, 34L, 61L },
                    { 473L, 2L, 35L, 61L },
                    { 109L, 1L, 1L, 66L },
                    { 128L, 1L, 8L, 66L },
                    { 18L, 3L, 16L, 76L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 19L, 3L, 17L, 76L },
                    { 330L, 3L, 2L, 76L },
                    { 331L, 1L, 3L, 76L },
                    { 182L, 1L, 2L, 91L },
                    { 274L, 3L, 9L, 91L },
                    { 275L, 2L, 10L, 91L },
                    { 276L, 1L, 11L, 91L },
                    { 297L, 1L, 40L, 91L },
                    { 32L, 2L, 21L, 96L },
                    { 266L, 1L, 5L, 96L },
                    { 267L, 2L, 6L, 96L },
                    { 442L, 1L, 43L, 2L },
                    { 443L, 3L, 44L, 2L },
                    { 57L, 2L, 63L, 7L },
                    { 58L, 3L, 64L, 7L },
                    { 59L, 2L, 65L, 7L },
                    { 65L, 3L, 61L, 7L },
                    { 66L, 2L, 62L, 7L },
                    { 181L, 1L, 1L, 91L },
                    { 503L, 3L, 10L, 56L },
                    { 177L, 3L, 28L, 91L },
                    { 421L, 2L, 2L, 86L },
                    { 558L, 2L, 23L, 76L },
                    { 559L, 3L, 24L, 76L },
                    { 101L, 3L, 23L, 81L },
                    { 102L, 3L, 24L, 81L },
                    { 103L, 1L, 25L, 81L },
                    { 214L, 2L, 36L, 81L },
                    { 215L, 2L, 37L, 81L },
                    { 216L, 3L, 38L, 81L },
                    { 225L, 2L, 4L, 81L },
                    { 226L, 1L, 5L, 81L },
                    { 227L, 1L, 6L, 81L },
                    { 346L, 1L, 39L, 81L },
                    { 439L, 2L, 1L, 81L },
                    { 440L, 3L, 2L, 81L },
                    { 441L, 1L, 3L, 81L },
                    { 422L, 3L, 3L, 86L },
                    { 320L, 3L, 25L, 56L },
                    { 265L, 1L, 9L, 56L },
                    { 264L, 3L, 8L, 56L },
                    { 307L, 2L, 34L, 16L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 321L, 3L, 9L, 16L },
                    { 322L, 2L, 10L, 16L },
                    { 347L, 1L, 36L, 21L },
                    { 348L, 3L, 37L, 21L },
                    { 349L, 1L, 38L, 21L },
                    { 447L, 3L, 16L, 21L },
                    { 448L, 2L, 17L, 21L },
                    { 449L, 1L, 18L, 21L },
                    { 295L, 3L, 39L, 26L },
                    { 296L, 3L, 40L, 26L },
                    { 158L, 3L, 27L, 31L },
                    { 60L, 2L, 34L, 36L },
                    { 61L, 3L, 13L, 36L },
                    { 62L, 1L, 14L, 36L },
                    { 306L, 2L, 33L, 16L },
                    { 154L, 2L, 9L, 36L },
                    { 305L, 1L, 29L, 16L },
                    { 173L, 3L, 38L, 16L },
                    { 133L, 1L, 4L, 6L },
                    { 134L, 1L, 5L, 6L },
                    { 175L, 3L, 39L, 6L },
                    { 96L, 3L, 17L, 11L },
                    { 97L, 1L, 18L, 11L },
                    { 352L, 1L, 28L, 11L },
                    { 353L, 1L, 29L, 11L },
                    { 354L, 2L, 30L, 11L },
                    { 375L, 2L, 14L, 11L },
                    { 376L, 3L, 15L, 11L },
                    { 592L, 2L, 20L, 11L },
                    { 593L, 3L, 21L, 11L },
                    { 594L, 2L, 22L, 11L },
                    { 171L, 3L, 36L, 16L },
                    { 172L, 1L, 37L, 16L },
                    { 304L, 1L, 28L, 16L },
                    { 40L, 1L, 61L, 12L },
                    { 13L, 1L, 39L, 41L },
                    { 47L, 1L, 30L, 41L },
                    { 114L, 1L, 14L, 51L },
                    { 115L, 1L, 15L, 51L },
                    { 116L, 2L, 16L, 51L },
                    { 141L, 1L, 28L, 51L },
                    { 142L, 2L, 29L, 51L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 143L, 3L, 30L, 51L },
                    { 313L, 1L, 1L, 51L },
                    { 314L, 3L, 2L, 51L },
                    { 315L, 1L, 3L, 51L },
                    { 493L, 2L, 32L, 51L },
                    { 494L, 1L, 33L, 51L },
                    { 495L, 3L, 34L, 51L },
                    { 22L, 3L, 22L, 56L },
                    { 23L, 1L, 23L, 56L },
                    { 24L, 3L, 24L, 56L },
                    { 113L, 2L, 13L, 51L },
                    { 14L, 3L, 40L, 41L },
                    { 458L, 1L, 23L, 46L },
                    { 456L, 1L, 21L, 46L },
                    { 48L, 1L, 31L, 41L },
                    { 271L, 2L, 5L, 41L },
                    { 272L, 1L, 6L, 41L },
                    { 273L, 3L, 7L, 41L },
                    { 341L, 1L, 1L, 41L },
                    { 342L, 3L, 2L, 41L },
                    { 343L, 1L, 3L, 41L },
                    { 366L, 2L, 9L, 41L },
                    { 367L, 3L, 10L, 41L },
                    { 84L, 3L, 33L, 46L },
                    { 85L, 1L, 34L, 46L },
                    { 86L, 2L, 35L, 46L },
                    { 437L, 1L, 28L, 46L },
                    { 438L, 3L, 29L, 46L },
                    { 455L, 2L, 20L, 46L },
                    { 457L, 1L, 22L, 46L },
                    { 553L, 1L, 466L, 95L },
                    { 41L, 3L, 62L, 12L },
                    { 392L, 3L, 66L, 12L },
                    { 73L, 2L, 100L, 3L },
                    { 122L, 2L, 138L, 3L },
                    { 123L, 3L, 139L, 3L },
                    { 124L, 3L, 140L, 3L },
                    { 268L, 1L, 120L, 3L },
                    { 269L, 1L, 121L, 3L },
                    { 72L, 3L, 99L, 3L },
                    { 435L, 2L, 93L, 3L },
                    { 550L, 2L, 137L, 3L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 120L, 3L, 122L, 8L },
                    { 121L, 3L, 123L, 8L },
                    { 261L, 2L, 93L, 8L },
                    { 262L, 2L, 94L, 8L },
                    { 263L, 1L, 95L, 8L },
                    { 436L, 3L, 94L, 3L },
                    { 71L, 1L, 98L, 3L },
                    { 524L, 2L, 54L, 97L },
                    { 523L, 1L, 53L, 97L },
                    { 255L, 2L, 48L, 82L },
                    { 256L, 2L, 49L, 82L },
                    { 257L, 2L, 50L, 82L },
                    { 529L, 1L, 63L, 82L },
                    { 530L, 1L, 64L, 82L },
                    { 531L, 3L, 65L, 82L },
                    { 368L, 2L, 69L, 87L },
                    { 369L, 3L, 70L, 87L },
                    { 67L, 2L, 61L, 97L },
                    { 68L, 1L, 62L, 97L },
                    { 69L, 3L, 63L, 97L },
                    { 70L, 2L, 64L, 97L },
                    { 355L, 2L, 49L, 97L },
                    { 356L, 2L, 50L, 97L },
                    { 357L, 3L, 51L, 97L },
                    { 384L, 1L, 135L, 8L },
                    { 385L, 3L, 136L, 8L },
                    { 386L, 3L, 137L, 8L },
                    { 482L, 1L, 86L, 8L },
                    { 398L, 2L, 132L, 33L },
                    { 399L, 2L, 133L, 33L },
                    { 400L, 3L, 134L, 33L },
                    { 110L, 1L, 88L, 38L },
                    { 111L, 1L, 89L, 38L },
                    { 112L, 3L, 90L, 38L },
                    { 144L, 1L, 103L, 38L },
                    { 145L, 2L, 104L, 38L },
                    { 540L, 1L, 98L, 38L },
                    { 541L, 2L, 99L, 38L },
                    { 542L, 2L, 100L, 38L },
                    { 104L, 2L, 91L, 43L },
                    { 105L, 3L, 92L, 43L },
                    { 106L, 3L, 93L, 43L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 532L, 2L, 125L, 43L },
                    { 539L, 3L, 105L, 28L },
                    { 170L, 2L, 54L, 82L },
                    { 538L, 1L, 104L, 28L },
                    { 460L, 1L, 99L, 28L },
                    { 483L, 1L, 87L, 8L },
                    { 536L, 3L, 107L, 13L },
                    { 537L, 2L, 108L, 13L },
                    { 130L, 1L, 108L, 18L },
                    { 131L, 3L, 109L, 18L },
                    { 223L, 2L, 120L, 18L },
                    { 224L, 2L, 121L, 18L },
                    { 250L, 1L, 144L, 18L },
                    { 425L, 3L, 142L, 18L },
                    { 426L, 2L, 143L, 18L },
                    { 427L, 3L, 145L, 18L },
                    { 560L, 1L, 122L, 18L },
                    { 588L, 3L, 117L, 23L },
                    { 589L, 3L, 118L, 23L },
                    { 459L, 1L, 98L, 28L },
                    { 461L, 3L, 100L, 28L },
                    { 169L, 3L, 53L, 82L },
                    { 168L, 3L, 52L, 82L },
                    { 475L, 3L, 64L, 77L },
                    { 119L, 2L, 58L, 37L },
                    { 316L, 2L, 50L, 42L },
                    { 317L, 2L, 51L, 42L },
                    { 359L, 2L, 48L, 42L },
                    { 360L, 1L, 49L, 42L },
                    { 404L, 2L, 53L, 42L },
                    { 405L, 3L, 54L, 42L },
                    { 506L, 1L, 45L, 42L },
                    { 507L, 2L, 46L, 42L },
                    { 508L, 1L, 47L, 42L },
                    { 241L, 3L, 60L, 47L },
                    { 242L, 2L, 61L, 47L },
                    { 243L, 3L, 62L, 47L },
                    { 488L, 2L, 56L, 47L },
                    { 187L, 2L, 50L, 52L },
                    { 118L, 1L, 57L, 37L },
                    { 188L, 2L, 51L, 52L },
                    { 117L, 3L, 56L, 37L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 202L, 1L, 45L, 32L },
                    { 393L, 1L, 67L, 12L },
                    { 135L, 1L, 67L, 22L },
                    { 136L, 2L, 68L, 22L },
                    { 406L, 3L, 56L, 22L },
                    { 407L, 2L, 57L, 22L },
                    { 408L, 3L, 58L, 22L },
                    { 496L, 2L, 59L, 22L },
                    { 497L, 1L, 60L, 22L },
                    { 159L, 1L, 58L, 27L },
                    { 160L, 3L, 59L, 27L },
                    { 564L, 3L, 67L, 27L },
                    { 565L, 1L, 68L, 27L },
                    { 573L, 3L, 64L, 27L },
                    { 574L, 1L, 65L, 27L },
                    { 201L, 3L, 44L, 32L },
                    { 203L, 2L, 46L, 32L },
                    { 391L, 3L, 65L, 12L },
                    { 189L, 3L, 52L, 52L },
                    { 462L, 1L, 69L, 52L },
                    { 11L, 1L, 47L, 67L },
                    { 12L, 1L, 48L, 67L },
                    { 288L, 3L, 67L, 67L },
                    { 289L, 2L, 68L, 67L },
                    { 332L, 1L, 62L, 72L },
                    { 333L, 2L, 63L, 72L },
                    { 334L, 1L, 64L, 72L },
                    { 489L, 1L, 47L, 72L },
                    { 490L, 3L, 48L, 72L },
                    { 174L, 3L, 60L, 77L },
                    { 364L, 1L, 45L, 77L },
                    { 365L, 2L, 46L, 77L },
                    { 423L, 2L, 59L, 77L },
                    { 424L, 3L, 61L, 77L },
                    { 474L, 2L, 63L, 77L },
                    { 572L, 2L, 62L, 62L },
                    { 270L, 1L, 49L, 52L },
                    { 200L, 3L, 47L, 62L },
                    { 198L, 3L, 45L, 62L },
                    { 463L, 3L, 70L, 52L },
                    { 511L, 3L, 55L, 52L },
                    { 329L, 1L, 70L, 57L }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ProfileId", "SeatId", "SessionId" },
                values: new object[,]
                {
                    { 452L, 3L, 61L, 57L },
                    { 453L, 2L, 62L, 57L },
                    { 454L, 1L, 63L, 57L },
                    { 498L, 2L, 42L, 57L },
                    { 499L, 2L, 43L, 57L },
                    { 500L, 3L, 57L, 57L },
                    { 501L, 1L, 58L, 57L },
                    { 502L, 2L, 59L, 57L },
                    { 178L, 3L, 52L, 62L },
                    { 179L, 3L, 53L, 62L },
                    { 180L, 1L, 54L, 62L },
                    { 197L, 3L, 44L, 62L },
                    { 199L, 1L, 46L, 62L },
                    { 554L, 2L, 467L, 95L }
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
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "MovieComments",
                keyColumn: "Id",
                keyValue: 14L);

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
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 41L);

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
                keyValue: 102L);

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
                keyValue: 119L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 128L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 141L);

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
                keyValue: 215L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 216L);

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
                keyValue: 236L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 237L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 245L);

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
                keyValue: 268L);

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
                keyValue: 330L);

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
                keyValue: 355L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 361L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 366L);

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
                keyValue: 384L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 385L);

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
                keyValue: 412L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 424L);

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
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Sessions",
                keyColumn: "Id",
                keyValue: 39L);

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
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 601L);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 602L);

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
                keyValue: 11L);

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
                keyValue: 112L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 113L);

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
                keyValue: 129L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 130L);

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
                keyValue: 150L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 151L);

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
                keyValue: 217L);

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
                keyValue: 246L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 247L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 250L);

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
                keyValue: 269L);

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
                keyValue: 291L);

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
                keyValue: 386L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 387L);

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
                keyValue: 440L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 441L);

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
                keyValue: 459L);

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: 460L);

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
        }
    }
}