using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        private string productID;
        private string productTypeID;
        private string productName;
        private string pictureLink;
        private string description;
        private int quantity;
        private int price;
        private string exp;
        private string origin;
        private string soleAmount;

        public Product()
        {

        }

        public Product(string productID, string productTypeID, string productName, string pictureLink, string description, int quantity, int price, string exp, string origin, string soleAmount)
        {
            this.ProductID = productID;
            this.ProductTypeID = productTypeID;
            this.ProductName = productName;
            this.PictureLink = pictureLink;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = price;
            this.Exp = exp;
            this.Origin = origin;
            this.SoleAmount = soleAmount;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string ProductTypeID { get => productTypeID; set => productTypeID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string PictureLink { get => pictureLink; set => pictureLink = value; }
        public string Description { get => description; set => description = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public string Exp { get => exp; set => exp = value; }
        public string Origin { get => origin; set => origin = value; }
        public string SoleAmount { get => soleAmount; set => soleAmount = value; }
    }
}
