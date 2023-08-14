using Market.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Entities
{
    public class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }

        public Order(/*DateTime moment,*/ OrderStatus stauts, Client client)
        {
            //Moment = moment;
            Status = stauts;
            Client = client;
        }


        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total() 
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.Quantity * item.Price;
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order Status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate}) - {Client.Email}");
            sb.AppendLine("Order Items: ");

            foreach (var item in Items)
            {
                sb.Append(item.Product.Name + ", ");
                sb.Append(item.Product.Price + ", ");
                sb.Append("Quantity: " + item.Quantity + ", ");
                sb.Append("Subtotal: " + item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }

            sb.AppendLine($"Total Price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
