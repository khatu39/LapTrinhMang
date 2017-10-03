using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;


namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry ipHostEntry = new IPHostEntry();
            Console.Write("Enter hostname/IP: ");
            string input = Console.ReadLine();
            ipHostEntry = Dns.GetHostEntry(input);

            try
            {
                Console.WriteLine("Hostname: " + ipHostEntry.HostName);
                Console.WriteLine("IPs: ");
                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    Console.WriteLine(ip.ToString());
                }
                Console.WriteLine("Aliases: ");
                if (ipHostEntry.Aliases.Length == 0)
                {
                    Console.WriteLine("No aliases");
                }
                else
                {
                    foreach (string alias in ipHostEntry.Aliases)
                    {
                        Console.WriteLine(alias);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}