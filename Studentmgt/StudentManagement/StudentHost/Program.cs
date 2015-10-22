using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace StudentHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(StudentManagement.StudentMgt)))
            {
                host.Open();
                Console.WriteLine("service started @ " + Convert.ToString(DateTime.Now));
                Console.Read();               
            }
        }
    }
}
