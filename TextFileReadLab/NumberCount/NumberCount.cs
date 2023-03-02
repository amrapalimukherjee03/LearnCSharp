using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NumberCount
{
    public static class NumberCount
    {
        static readonly string numberfile = @"C:\Users\amrapalimukherjee\Desktop\TestNumberCount\TestNumberCount.txt";

        public static void PrintHighestNumber()
        {
            try
            {
                if (File.Exists(path: numberfile))
                {
                    using var fs = new FileStream(numberfile, FileMode.Open, FileAccess.Read);
                    using (var sr = new StreamReader(fs, Encoding.UTF8))
                    {
                        string content = sr.ReadToEnd();
                        //Console.WriteLine(content);
                        int[] numberstofind = content.Split('\n').Select(n => Convert.ToInt32(n)).ToArray();
                        int length = numberstofind.Length;
                        Printnumbers(numberstofind, length);
                    }
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.ToString()}");
            }
        }

        static void Printnumbers(int[] numberstofind, int length)
        {
            try
            {
                Dictionary<int,
                      int> numberdict = new Dictionary<int,
                                               int>();
                for (int i = 0; i < length; i++)
                {
                    if (numberdict.ContainsKey(numberstofind[i]))
                    {
                        numberdict[numberstofind[i]]++;
                    }
                    else
                    {
                        numberdict[numberstofind[i]] = 1;
                    }
                }

                foreach (KeyValuePair<int,
                                     int> x in numberdict.OrderByDescending(key => key.Value).Take(5))
                {
                    Console.Write(x.Key + "\n");
                    // Console.Write(x.Key + " " + x.Value + "\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.ToString()}");
            }
        }
    }
}
