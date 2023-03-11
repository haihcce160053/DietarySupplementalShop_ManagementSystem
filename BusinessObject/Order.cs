using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order
    {
        private string orderID;
        private string userName;
        private string deliveryAddress;
        private DateTime orderTime;
        private string orderStatusID;
        private string totalBill;

        public Order()
        {

        }

        public Order(string orderID, string userName, string deliveryAddress, DateTime orderTime, string orderStatusID, string totalBill)
        {
            this.orderID = orderID;
            this.userName = userName;
            this.deliveryAddress = deliveryAddress;
            this.orderTime = orderTime;
            this.orderStatusID = orderStatusID;
            this.totalBill = totalBill;
        }

        public string OrderID { get => orderID; set => orderID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string DeliveryAddress { get => deliveryAddress; set => deliveryAddress = value; }
        public DateTime OrderTime { get => orderTime; set => orderTime = value; }
        public string OrderStatusID { get => orderStatusID; set => orderStatusID = value; }
        public string TotalBill { get => totalBill; set => totalBill = value; }
    }
}
