using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData
            (
                new Food()
                {
                    Id = 0,
                    Name = "Small Plain Popcorn",
                    Description = "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.",
                    UrlPicture = "https://i.pinimg.com/564x/27/54/4b/27544b30e1f053ef55aefc2758184445.jpg",
                    Price = 3
                },
                new Food()
                {
                    Id = 1,
                    Name = "Medium Plain Popcorn",
                    Description = "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.",
                    UrlPicture = "https://i.pinimg.com/564x/fc/cf/dc/fccfdcbe5355ba1b2662d92c305b6402.jpg",
                    Price = 4.5m
                },
                new Food()
                {
                    Id = 2,
                    Name = "Large Plain Popcorn",
                    Description = "Plain popcorn is a 100% whole-grain, plant-based snack filled with fiber. You can eat a high volume for few calories, but watch out for sugary or saturated fat-filled toppings.",
                    UrlPicture = "https://i.pinimg.com/564x/ad/0b/be/ad0bbe7809102011d85f2e9bc87b7b90.jpg",
                    Price = 6
                },
                new Food()
                {
                    Id = 3,
                    Name = "Nachos",
                    Description = "A tortilla chip or nacho chips is a snack food made from corn tortillas, which are cut into wedges and then fried.",
                    UrlPicture = "https://i.pinimg.com/564x/d5/fa/fd/d5fafd4b3e1812c233fcff9412080601.jpg",
                    Price = 3
                },
                new Food()
                {
                    Id = 4,
                    Name = "Pretzel Bites",
                    Description = "A pretzel is a handheld yeast bread that's usually shaped into a twisted knot.",
                    UrlPicture = "https://i.pinimg.com/564x/15/ed/22/15ed22eb6702c520995a7f146c088505.jpg",
                    Price = 4
                },
                new Food()
                {
                    Id = 5,
                    Name = "Curcly Fries",
                    Description = "A kind of fries characterized by their spring-like shape, being cut from whole potatoes using a specialized spiral slicer.",
                    UrlPicture = "https://i.pinimg.com/564x/67/63/26/6763268fae390dfae890e73eeb96b51c.jpg",
                    Price = 4
                },
                new Food()
                {
                    Id = 6,
                    Name = "Fries",
                    Description = "French fries are long, thin pieces of potato fried in oil or fat. The French fries were thin and crispy. To cook the French fries, put them into a deep pan of oil.",
                    UrlPicture = "https://i.pinimg.com/564x/7b/a7/f6/7ba7f65ae13d844bd26289b7ee8b8d8f.jpg",
                    Price = 3
                },
                new Food()
                {
                    Id = 7,
                    Name = "Chicken Tenders",
                    Description = "A deep-fried strip of chicken without bones or skin. A flap of chicken meat found on, and easily detached from, the breast.",
                    UrlPicture = "https://i.pinimg.com/564x/f1/e6/1c/f1e61c6808735b1b69a4b28d83417382.jpg",
                    Price = 5
                },
                new Food()
                {
                    Id = 8,
                    Name = "Mozzarella Sticks",
                    Description = "Mozerella sticks are typically eaten with Marinara. However, ranch, Thai sweet chili, cocktail sauce, BBQ, hot sauce, regular mayonnaise, garlic aioli, buffalo sauce, ketchup, tzatziki, donair, alfredo, salsa, and hollandaise are all good sauces to try.",
                    UrlPicture = "https://i.pinimg.com/564x/b0/46/31/b046315f129b2b1e002b5c8183c893c7.jpg",
                    Price = 5
                },
                new Food()
                {
                    Id = 9,
                    Name = "Hot Dog",
                    Description = "A hot dog is a food consisting of a grilled or steamed sausage served in the slit of a partially sliced bun. The term hot dog can also refer to the sausage itself.",
                    UrlPicture = "https://i.pinimg.com/564x/6d/7c/9e/6d7c9e6e15e8206339eaa91c3b810ce7.jpg",
                    Price = 3
                },
                new Food()
                {
                    Id = 10,
                    Name = "Butter Topping",
                    Description = "A sauce made of butter, water or broth, and seasonings, thickened with flour, and used also as a basis for the making of other sauces (such as caper sauce or shrimp sauce) by the addition of special ingredients.",
                    UrlPicture = "https://i.pinimg.com/564x/78/2d/c1/782dc1b23a49df94690528e9f355c477.jpg",
                    Price = 4
                },
                new Food()
                {
                    Id = 11,
                    Name = "Nacho Cheese",
                    Description = "Melted cheese garnished with sliced chile peppers that is traditionally served with tortilla chips.",
                    UrlPicture = "https://i.pinimg.com/564x/97/c4/ac/97c4ac886aa8731e8ccf3e689be6a226.jpg",
                    Price = 5
                }
            );
        }
    }
}

