using System;
using System.Collections.Generic;
using WebStore.Model;

namespace WebStore.Tests
{
    public static class Extensions
    {
        // Create sample data
        public static void SeedData(this IServiceCollection services)
        {
            var serviceProvider = services.BuildServiceProvider();
            var dbContext = serviceProvider.GetRequiredService<ApplicationDbContext>();
            var userManager = serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole<int>>();

            // Other seed data...

            // Customers
            var customer1 = new Customer()
            {
                Id = 3,
                FirstName = "Jan",
                LastName = "Adamski",
                UserName = "cust1@eg.eg",
                Email = "cust1@eg.eg",
                RegistrationDate = new DateTime(2012, 1, 1),
                BillingAddress = new Address()
                {
                    City = "Czestochowa",
                    Street = "Dabrowskiego",
                    StreetNumber = 32,
                    PostalCode = "42-283"
                },
                ShippingAddress = new Address()
                {
                    City = "Czestochowa",
                    Street = "Dabrowskiego",
                    StreetNumber = 32,
                    PostalCode = "42-283"
                },
                Orders = new List<Order>()
            };

            await userManager.CreateAsync(customer1, "User1235");

            // Orders
            var order1 = new Order()
            {
                Customer = customer1,
                DeliveryDate = new DateTime(2023,10,1),
                Id = 1, // You can set a unique ID for each order
                OrderDate = new DateTime(2023,9,30),
                TotalAmount = 100.00, // Set the total amount as needed
                TrackingNumber = 123456789, // Set the tracking number as needed
                Products = new List<OrderProduct>() // Create an empty list of products
            };

            var order2 = new Order()
            {
                Customer = customer1,
                DeliveryDate = new DateTime(2023,10,1),
                Id = 2, // You can set a unique ID for each order
                OrderDate = new DateTime(2023,9,30),
                TotalAmount = 150.00, // Set the total amount as needed
                TrackingNumber = 987654321, // Set the tracking number as needed
                Products = new List<OrderProduct>() // Create an empty list of products
            };

            customer1.Orders.Add(order1);
            customer1.Orders.Add(order2);

            // Add the orders to the database
            await dbContext.AddRangeAsync(order1, order2);

            // Save changes
            await dbContext.SaveChangesAsync();
        }
    }
}
