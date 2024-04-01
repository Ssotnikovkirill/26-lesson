using System;
using System.Collections.Generic;
using PizzaDeliveryService.Models;

namespace PizzaDeliveryService
{
    public class PizzaDeliveryService
    {
        private List<OrderModel> orders = new List<OrderModel>();

        // Событие для обработки новых заказов
        public event Action<OrderModel> NewOrderReceived;

        // Метод для добавления заказа
        public void AddOrder(OrderModel order)
        {
            orders.Add(order);
            NewOrderReceived?.Invoke(order); // Вызов события
        }

        // Другие методы для обработки заказов и системы лояльности
    }
}
