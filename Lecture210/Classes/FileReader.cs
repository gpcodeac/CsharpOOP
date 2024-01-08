using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture210.Classes
{
    internal class FileReader 
    {
        //file not found
        //file is empty
        //cant open file (pasw)
        //open
        //read
        //close
        //readbackwards


        public static FileStream OpenFile(string path)
        {
            try
            {
                FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read);
                return fs;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Path is invalid or null.");
            }
            catch (IOException e)
            {
                Console.WriteLine($"{e.GetType().Name}. {e.Message}.");
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Not authorised to open the file.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception openning the file. {e.GetType().Name}. {e.Message}.");
            }
            //finally
            //{
            //    return null;
            //}
            return null;
        }

        public static void ReadFile(string path)
        {
            Console.WriteLine("Reading file...");
        }
    }
}
