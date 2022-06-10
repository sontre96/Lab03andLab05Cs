using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Ex5Lab05
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            FileStream outStream = null;
            FileStream inSttream = null;
            try
            {
                // Mo file de ghi du lieu
                outStream = File.OpenWrite("DestiantionFile.txt");
                // Mo file de doc du lieu
                inSttream = File.OpenRead("BogusInputFile.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                if (outStream != null)
                {
                    outStream.Close();
                    Console.WriteLine("Out Stream closed.");
                }
                if (inSttream != null)
                {
                    inSttream.Close();
                    Console.WriteLine("In Stream closed.");
                }
            }

        }
    }
}

