using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\Practices Exercise\.net\MyProject2\Studentdata.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writing = new StreamWriter(fs);
            try
            {
                writing.WriteLine("Student Details :");
                writing.WriteLine("StudName: Thota Sailakshmi");
                writing.WriteLine("StudID : A23");

                writing.WriteLine("Grade : A  ");
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writing.Flush();
                writing.Close();
                writing.Dispose();
                fs.Close();
                fs.Dispose();
            }





            bool ans = File.Exists(@"D:\Practices Exercise\.net\MyProject2\Studentdata.txt");
            if (ans == true)
            {
                try
                {
                    FileStream ds = new FileStream(@"D:\Practices Exercise\.net\MyProject2\Studentdata.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reading = null;
                    //this try catch block used to if there any exceptions catch block executed otherwise try executed
                    try
                    {
                        reading = new StreamReader(ds);
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        ds.Close();
                        ds.Dispose();
                        reading.Close();
                        reading.Dispose();

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("File does'nt exist on the given location");

            }


            Console.Read();


        }


    }
}

