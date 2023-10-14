using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Tests.UnitTests
{
    public class OrderServiceUnitTests
    {
       private readonly IOrderService _orderService;

        public OrderServiceUnitTests(ApplicationDbContext dbContext, IOrderService productService) : base(dbContext)
        {
            _orderService = orderService;
        }

        [Fact]
        public void GeOrderTest()
        {
            var order = _orderService.GetOrder(p => p.TrackingNumber == 123456789);
            Assert.NotNull(order);
        }

        [Fact]
        public void GetMultipleProductsTest()
        {
            var orders = _orderService.GetOrders(p => p.Id >= 1 && p.Id <= 2);
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);
            Assert.Equal(2, orders.Count());
        }

        [Fact]
        public void GetAllProductsTest()
        {
            var orders = _orderService.GetOrders();
            Assert.NotNull(orders);
            Assert.NotEmpty(orders);
            Assert.Equal(orders.Count(), orders.Count());
        }

        [Fact]
        public void AddNewProductTest()
        {
            var newOrderVm = new AddOrUpdateOrderVm()
            {
                DeliveryDate = new DateTime(2023,10,1),
                OrderDate = new DateTime(2023,9,30),
                CustomerId = 3,
                TotalAmount = 100.000,
                TrackingNumber = 123456789,
            };
            var createdOrder = _orderService.AddOrUpdateOrder(newOrderVm);
            Assert.NotNull(createdOrder);
            Assert.Equal(123456789, createdProduct.TrackingAmount);
        }

        [Fact]
        public void UpdateProductTest()
        {
            var updateOrderVm = new AddOrUpdateOrderVm()
            {
                Id = 1,
                DeliveryDate = new DateTime(2023,10,1),
                OrderDate = new DateTime(2023,9,30),
                CustomerId = 3,
                TotalAmount = 50.000,
                TrackingNumber = 123456789,
            };
            var editedOrderVm = _orderService.AddOrUpdateOrder(updateProductVm);
            Assert.NotNull(editedOrderVm);
            Assert.Equal(123456789, createdProduct.TrackingAmount);
            Assert.Equal(50.000, editedProductVm.TotalAmount);
        } 
    }
}