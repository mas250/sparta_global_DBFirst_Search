using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASDOTNET_DBFirst.Models
{
    public class Laptop
    {
        private int id;
        private string color;
        private string make;
        private DateTime purchaseDate;

        public int Id { get => id; set => id = value; }
        public string Color { get => color; set => color = value; }
        public string Make { get => make; set => make = value; }
        public DateTime PurchaseDate { get => purchaseDate; set => purchaseDate = value; }
    }
}