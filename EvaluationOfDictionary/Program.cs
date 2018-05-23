using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EvaluationOfDictionary
{
    class Program
    {
        static int NumOfDate = 300000;
        static int NumOfTrials = 1000000;
        static Dictionary<Tmp, int> Dic = new Dictionary<Tmp, int>();
        static Dictionary<int, Tmp> SearchStack = new Dictionary<int, Tmp>();
        static void Main(string[] args)
        {
            //Hash collision hasn't occurred.
            Console.WriteLine("Class1!");
            Eval(0);    //400ms
            //Hash collision.
            Console.WriteLine("Class2!");
            Eval(1);    //?
        }

        static void Eval(int type)
        {
            Dic.Clear();
            SearchStack.Clear();
            Random cRandom = new System.Random();
            for (int i = 0; i < NumOfDate; i++)
            {
                Tmp c = Factory(type);
                Dic[c] = i;
                int iResult1 = cRandom.Next();
                SearchStack[i] = c;
            }

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Start!");
            sw.Start();
            for (int i = 0; i < NumOfTrials; i++)
            {
                int keyNum = cRandom.Next() % NumOfDate;
                var key = SearchStack[keyNum];
                var dat = Dic[key];
            }
            Console.WriteLine("Stop!");
            Console.WriteLine("Time:" + sw.Elapsed.ToString());
        }

        static Tmp Factory(int type)
        {
            if (type == 0)
            {
                return new Class1();
            }
            else
                return new Class2();
        }
    }
}
