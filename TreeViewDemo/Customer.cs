using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewDemo
{
    public class Customer
    {
        private string custName = "";
        protected ArrayList custOrders = new ArrayList();

        public Customer(string customername)
        {
            this.custName = customername;
        }

        public string CustomerName
        {
            get { return this.custName; }
            set { this.custName = value; }
        }

        public ArrayList CustomerOrders
        {
            get { return this.custOrders; }
        }
    }
}
