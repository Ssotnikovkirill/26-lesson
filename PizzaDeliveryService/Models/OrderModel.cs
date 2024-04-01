using System;

namespace PizzaDeliveryService.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string PizzaType { get; set; }
        public string DeliveryAddress { get; set; }
        // Другие свойства заказа
    }
}
