using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;


namespace Paths
{
    static class Storage
    {

        private const string fileName = "Path3D.txt";
        public static void Write()
        {
            StreamWriter sw = null;
            try
            {
                string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, Storage.fileName); ;
                sw = new StreamWriter(filePath);
                Path3D points = new Path3D();
                
                foreach (string x in points.Points)
                {
                    sw.WriteLine(x);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close(); 

                }
            }
        }
        public static void Read()
        {
            String line;
            StreamReader sr = null;
            try
            {

                string filePath = System.IO.Path.Combine(Environment.CurrentDirectory, Storage.fileName);
                sr = new StreamReader(filePath);
                line = sr.ReadLine();
                Console.WriteLine("Start reading the file: " + Storage.fileName);
                while (line != null)
                {

                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("End of file");
            }
        }
    }

}

