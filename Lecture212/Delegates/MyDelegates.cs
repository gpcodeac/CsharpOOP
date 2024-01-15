using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture212.Delegates
{
    internal static class MyDelegates
    {
        public delegate string StrDelegate(string par1, string par2, int par3);
        
        public static string PrintInfo(string par1, string par2, int par3)
        {
            return $"PrintInfo: {par1} {par2} {par3}";
        }

        public static string MultiplyInfo(string par1, string par2, int par3)
        {
            string joined = par1 + par2;
            string result = "";
            for (int i = 0; i < par3; i++)
            {
                result += joined;
            }
            return result;
        }



        public delegate int IntDelegate(int par1, int par2);
        
        public static int Add(int par1, int par2)
        {
            return par1 + par2;
        }
        
        public static int Subtract(int par1, int par2)
        {
            return par1 - par2;
        }

        public static int BitXOR(int par1, int par2)
        {
            return par1 ^ par2;
        }

        public static int BitAND(int par1, int par2)
        {
            return par1 & par2;
        }



        public delegate bool BoolDelegate(bool b1, bool b2);

        public static bool BoolXOR(bool b1, bool b2)
        {
            return b1 ^ b2;
        }

        public static bool BoolAND(bool b1, bool b2)
        {
            return b1 & b2;
        }

        public static bool BoolOR(bool b1, bool b2)
        {
            return b1 | b2;
        }



        public delegate List<int> ListDelegate(List<int> list, int step);

        public static List<int> ListEveryOther(List<int> list, int step)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < list.Count; i += step)
            {
                result.Add(list[i]);
            }
            return result;
        }

    }
}
