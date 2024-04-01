using System;
using PizzaDeliveryService.Models;

namespace PizzaDeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaService = new PizzaDeliveryService();
            pizzaService.NewOrderReceived += HandleNewOrder;

            // Заказ
            var order = new OrderModel
            {
                OrderId = 1,
                CustomerName = "John Doe",
                PizzaType = "Pepperoni",
                DeliveryAddress = "123 Main St"
            };
            pizzaService.AddOrder(order);

            // Другие действия с заказами и сист. лояльности
        }

        private static void HandleNewOrder(OrderModel order)
        {
            Console.WriteLine($"New order received: OrderId {order.OrderId}, Customer: {order.CustomerName}, Pizza: {order.PizzaType}");
        }
    }
}
