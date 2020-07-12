using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewDemo
{
    public class OredeItem
    {
        private string ordeItemName = "";

        public OredeItem(string orderItemName)
        {
            this.ordeItemName = orderItemName;
        }

        public string OrdeItemName
        {
            get { return this.ordeItemName; }
            set { this.ordeItemName = value; }
        }

    }
}
