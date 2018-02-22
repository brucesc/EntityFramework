using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroDbContext db = new IntroDbContext();

            Order[] orders = db.Orders.ToArray();
            foreach (Order order in orders)
            {
                string message = $"Id = {order.Id}, total = {order.Total}, customer = {order.customer.Name}, date = {order.OrderDate}, description = {order.OrderDescription}";
                Console.WriteLine(message);
            }   
         
            //Customer[] customers = db.Customers.OrderByDescending(cust => cust.Name).ToArray();
            //foreach (Customer customer in customers)
            //{
            //    string message = $"Id={customer.Id}, Name={customer.Name}";
            //    Console.WriteLine(message);

            //}

            //Customer cust = new Customer();
            //cust.Name = "Bob";
            //cust.State = "OH";
            //cust.City = "Cincinnati";
            //db.Customers.Add(cust);
            //db.SaveChanges();


            //Customer[] custs = db.Customers.Where(cust => cust.State == "OH").OrderByDescending(cust => cust.Name).ToArray(); // pull customers from OH out of the db and store them in an array of type Customer
            //foreach (Customer cust in custs.Where(cust => cust.Name != "Bob"))
            //{
            //    string message = $"Id={cust.Id}, Name={cust.Name}, City={cust.City}, State={cust.State}";
            //    Console.WriteLine(message);                
            //}
            //Console.WriteLine("Your move Bob...");
            //Console.ReadLine();

            // James, Cincinnati
            //List<Customer> custs = db.Customers.Where(cust => cust.Name == "James" && cust.City == "Cincinnati").ToList();
            //foreach (Customer cust in custs)
            //{                
            //    string message = $"Id={cust.Id}, Name={cust.Name}, City={cust.City}, State={cust.State}";
            //    Console.WriteLine(message);
            //}

            //Customer steven = db.Customers.Find(1);
            //if (steven == null)
            //{
            //    Console.WriteLine("Couldn't find Steven");
            //}
            //else
            //{
            //    string message = $"Id={steven.Id}, Name={steven.Name}, City={steven.City}, State={steven.State}";
            //    Console.WriteLine(message);
            //}

            Console.ReadKey();

        }
    }
}
