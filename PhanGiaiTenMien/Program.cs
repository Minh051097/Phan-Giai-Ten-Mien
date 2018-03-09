using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace PhanGiaiTenMien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("NHap ten mien hoac dia chi ip:");
            string host = Console.ReadLine();

            IPHostEntry iphentry = Dns.GetHostEntry(host);
            Console.WriteLine("HostName:{0}", iphentry.HostName);

            foreach (string s in iphentry.Aliases)
            {
                Console.WriteLine("\t+ Alias: {0} \n", s);
            }
            foreach (IPAddress i in iphentry.AddressList)
            {
                Console.WriteLine("\t +IP:" + i);
            }
        }
    }
}
