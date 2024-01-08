using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture211.Classes
{
    internal static class MyExtensions
    {


        public static string TestExtension(this TestClass testClass, string dob, string domain)
        {
            Console.WriteLine($"TestClass text: {testClass.Text}");
            Console.WriteLine($"TestClass number: {testClass.Number}");
            Console.WriteLine($"DOB: {dob}");
            Console.WriteLine($"Domain: {domain}");
            return $"{testClass.Text}{dob}@{domain}";
        }


        public static bool GTZero<T>(this T number) where T : IConvertible , IComparable
        {
            return number.ToDouble(CultureInfo.InvariantCulture) > 0;
            //return number > 0;
        }


        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }


        public static bool GreaterThan(this int number, int other)
        {
            return number > other;
        }


        public static bool HasSpaces(this string text)
        {
            return text.Contains(' ');
        }


        public static string GenerateEmail(this string name, string dob, string domain)
        {
            return $"{name}{dob}@{domain}";
        }


        public static T FindAndReturn<T>(this List<T> list, T item)
        {
            if (list.Contains(item))
            {
                return item;
            }
            return default(T);
        }


        public static List<T> EveryOtherWord<T>(this List<T> list)
        {
            List<T> newList = new List<T>();
            for (int i = 0; i < list.Count; i += 2)
            {
                newList.Add(list[i]);
            }
            return newList;
        }





        public static List<string> EveryOtherLineFI(this FileInfo file)
        {
            string[] lines = File.ReadAllLines(file.DirectoryName + file.Name);
            List<string> newList = new List<string>();
            for (int i = 0; i < lines.Length; i += 2)
            {
                newList.Add(lines[i]);
            }
            return newList;
        }


        public static List<string> EveryOtherLineSR(this FileStream file)
        {
            StreamReader sr = new StreamReader(file);
            string fulltxt = sr.ReadToEnd();
            List<string> newList = new List<string>();
            string[] lines = fulltxt.Split('\n');
            foreach (string line in lines)
            {
                newList.Add(line);
            }
            return newList;
        }


        public static List<string> EveryOtherLineSpan(this FileStream file)
        {
            byte[] buffer = new byte[file.Length];
            file.Read(buffer); // check return value
            Span<byte> span = new Span<byte>(buffer);

            List<string> newList = new();

            bool returnable = true;
            int cursor = 0;
            int lfIndex;
            while (cursor < buffer.Length)
            {
                if ((lfIndex = Array.IndexOf(buffer, (byte)'\n', cursor)) == -1)
                {
                    lfIndex = buffer.Length;
                }
                if (returnable)
                {
                    newList.Add(Encoding.Default.GetString(span.Slice(cursor, lfIndex - cursor)));
                }
                returnable = !returnable;
                cursor = lfIndex + 1;
            }

            return newList;
        }


        public static List<string> EveryOtherLineArr(this FileStream file)
        {
            byte[] buffer = new byte[file.Length];
            file.Read(buffer); // check return value

            List<string> newList = new();

            bool returnable = true;
            int cursor = 0;
            int lfIndex;
            while (cursor < buffer.Length)
            {
                if ((lfIndex = Array.IndexOf(buffer, (byte)'\n', cursor)) == -1)
                {
                    lfIndex = buffer.Length;
                }
                if (returnable)
                {
                    newList.Add(Encoding.Default.GetString(buffer.Slice(cursor, lfIndex)));
                }
                returnable = !returnable;
                cursor = lfIndex + 1;
            }

            return newList;
        }

        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            if (end < 0)
            {
                end = source.Length + end;
            }
            int len = end - start;

            T[] res = new T[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = source[i + start];
            }
            return res;
        }


    }
}
