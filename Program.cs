using System;
using System.IO;
using System.Threading;

namespace AppRezervCopy_CrownBD
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                int cc = DateTime.Now.Hour;
                try
                {
                    if (File.Exists(@"D:\crownrezerv\" + cc + @"h\crownBD.mdb"))
                    {
                        File.Delete(@"D:\crownrezerv\" + cc + @"h\crownBD.mdb");
                        File.Copy(@"D:\Crown2021\crownBD.mdb", @"D:\crownrezerv\" + cc + @"h\crownBD.mdb");
                    }
                    else
                    {
                        File.Copy(@"D:\Crown2021\crownBD.mdb", @"D:\crownrezerv\" + cc + @"h\crownBD.mdb");
                    }
                }
                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                }
                Thread.Sleep(3600 * 1000);
            }
        }
    }
}
