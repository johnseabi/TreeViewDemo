using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeViewDemo
{
    public partial class Form1 : Form
    {
        
        private ArrayList customerArray = new ArrayList();
        private ArrayList orderArray = new ArrayList();


        public Form1()
        {
            InitializeComponent();
            InitializeTreeView();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e){}
        private void InitializeTreeView()
        {
            //simple way of adding to the treeview

            //treeView1.BeginUpdate();
            //treeView1.Nodes.Add("Parent");
            //treeView1.Nodes[0].Nodes.Add("Child 1");
            //treeView1.Nodes[0].Nodes.Add("Child 2");
            //treeView1.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            //treeView1.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            //treeView1.EndUpdate();


            //adding to treeview using cmplex datatypes

            
            // Add customers to the ArrayList of Customer objects.
            for (int x = 1; x <= 100; x++)
            {
                customerArray.Add(new Customer("Customer" + x.ToString()));
            }

            // Add orders to each Customer object in the ArrayList.
            foreach (Customer customer1 in customerArray)
            {
                for (int y = 1; y<= 15; y++)
                {
                    customer1.CustomerOrders.Add(new Order("Order" + y.ToString()));
     
                }
            }

            //add orderItems to the each Order object in the array list
            //for some reason this doesnt work ;)
            foreach (Order order in orderArray)
            {
                for (int z = 1; z <= 5; z++)
                {
                    order.OrderItems.Add(new Order("OrderItem" + z.ToString()));
                }
            }


            // Suppress repainting the TreeView until all the objects have been created.
            treeView1.BeginUpdate();

            // Clear the TreeView each time the method is called.
            treeView1.Nodes.Clear();

            // Add a root TreeNode for each Customer object in the ArrayList.
            foreach (Customer customer2 in customerArray)
            {
                //Parent treenode
                treeView1.Nodes.Add(new TreeNode(customer2.CustomerName));

                // Add a child treenode for each Order object in the current Customer object.
                foreach (Order order1 in customer2.CustomerOrders)
                {
                    treeView1.Nodes[customerArray.IndexOf(customer2)].Nodes.Add(new TreeNode(customer2.CustomerName + "--" + order1.OrderID));
                    
                    //Add a child treenoode for the each order object in the current Order object
                    //this node is also granchild to the Customer node
                    //this code does not display :-) ;)
                    foreach (OredeItem orderItem in order1.OrderItems)
                    {
                        treeView1.Nodes[customerArray.IndexOf(customer2)].Nodes[orderArray.IndexOf(order1)].Nodes.Add(new TreeNode(order1.OrderID + "--" + orderItem.OrdeItemName));
                    }
                }
            }


            // Begin repainting the TreeView.
            treeView1.EndUpdate();
        }
    }
}
