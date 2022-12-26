using CINEMATRIX.Data.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CINEMATRIX.Data.EF.SQL.FillingConfiguration
{
    internal class FAQConfiguration : IEntityTypeConfiguration<FAQ>
    {
        public void Configure(EntityTypeBuilder<FAQ> builder)
        {
            long id = 1;

            builder.HasData
            (
               new FAQ
               {
                   Id = id++,
                   Question = "How do I make a seat reservation??",
                   Answer = "To make a reservation for seats, you need to select a movie, the date and time of the session, as well as select seats on the cinema map. After that, you need to enter your contact details and choose a payment method. After confirming the booking, you will receive an e-ticket to the specified email address.",
                   Category = "Seat reservation"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "Can I return the ticket?",
                   Answer = "Yes, you can return the ticket within 24 hours of purchase. To do this, you need to contact the cinema box office or contact our support service. Please note that when returning a ticket, a commission is charged, the amount of which depends on the terms of sale. Some tickets (for example, promotional ones) are non-refundable.",
                   Category = "Seat reservation"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "How to download an e-ticket?",
                   Answer = "In order to download an e-ticket, you need to log in to the cinema website using your account. In the \"My reservations\" section, you need to find the session for which you need to download a ticket and click on the \"Download\" button. The ticket will be saved in PDF format, which can be printed or shown on the phone screen at the entrance to the cinema.",
                   Category = "Tickets"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "Can I change the date and time of the session?",
                   Answer = "Yes, you can change the date and time of the session if possible. To do this, you need to contact the cinema box office or contact our support service. Please note that if the date and time of the session change, the ticket price may change.",
                   Category = "Seat reservation"
               }, new FAQ
               {
                   Id = id++,
                   Question = "Can I cancel my ticket?",
                   Answer = "Yes, you can cancel your ticket if it is not yet time for the movie to start. To cancel your ticket, log in to your account on our website and go to the \"My bookings\" section. Find the booking that you want to cancel and click on the \"Cancel\" button. Please note that a cancellation fee may apply, depending on the terms and conditions of the ticket.",
                   Category = "Tickets"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "Is there an age restriction for certain movies?",
                   Answer = "Yes, some movies may have age restrictions due to their content. These age restrictions are indicated on the movie page on our website and at the ticket counter. Children under the age of 18 must be accompanied by an adult to see movies with age restrictions.",
                   Category = "Movies"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "What are the opening hours of the cinema?",
                   Answer = "Our cinema is open every day from 10:00am to 11:00pm. The ticket counter opens at 9:30am and closes at 10:30pm. The concessions stand is open from 10:00am to 10:30pm. Please note that the cinema may be closed on certain holidays.",
                   Category = "Opening hours"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "Do you offer wheelchair access?",
                   Answer = "Yes, we offer wheelchair access to all of our theaters. Please inform us in advance if you require wheelchair access so that we can reserve a suitable seat for you. You can do this by contacting our customer support or by mentioning it in the \"Special requests\" field when booking your tickets online.",
                   Category = "Accessibility"
               },
               new FAQ
               {
                   Id = id++,
                   Question = "Can I bring my own food and drinks to the cinema?",
                   Answer = "No, it is not allowed to bring your own food and drinks to the cinema. We have a concessions stand that offers a variety of snacks, drinks, and meals for you to enjoy during the movie. You are welcome to purchase food and drinks from the concessions stand or at one of our vending machines.",
                   Category = "Food and drinks"
               }
            );
        }
    }
}

