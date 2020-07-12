using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewDemo
{
    public class Order
    {
        private string ordID = "";
        protected ArrayList orderItems = new ArrayList();
        public Order(string orderid)
        {
            this.ordID = orderid;
        }

        public string OrderID
        {
            get { return this.ordID; }
            set { this.ordID = value; }
        }
        public ArrayList OrderItems
        {
            get { return this.orderItems; }
        }
    }
}
