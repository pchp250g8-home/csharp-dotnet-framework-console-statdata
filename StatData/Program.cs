using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------------------------------------
            var AData = new int[10];
            var Rnd = new Random();
            var nArrayLen = AData.Length;
            var nMediane = 0;
            var nModes = new List<int>();
            //--------------------------Data Input-----------------------------------------------------
            nModes.Clear();
            Console.WriteLine("Generating Statictic Data:");
            for (int i = 0; i < nArrayLen; i++)
            {
                AData[i] = Rnd.Next(40);
                Console.Write(AData[i] + " ");
            }
            //---------------------------Array Sorting------------------------------------------------
            Array.Sort(AData);
            Console.WriteLine();
            Console.WriteLine("Sorted Data:");
            for (int i = 0; i < nArrayLen; i++)
            {
                Console.Write(AData[i] + " ");
            }
            //--------------------------Calculate Mediana----------------------------------------------
            if (nArrayLen % 2 == 0)
            {
                var nIndex1 = nArrayLen / 2 - 1;
                var nIndex2 = nIndex1 + 1;
                nMediane = Convert.ToInt32((AData[nIndex1] + AData[nIndex2]) / 2);
            }
            else
            {
                var nIndex = Convert.ToInt32((nArrayLen + 1) / 2) - 1;
                nMediane = AData[nIndex];
            }
            for (int i = 0; i < nArrayLen; i++)
            {
                var nSameElems = 0;
                for (int j = 0; j < nArrayLen; j++)
                {
                    if (AData[i] == AData[j])
                    {
                        nSameElems++;
                    }
                }
                if (nSameElems > 1)
                {
                    nModes.Add(AData[i]);
                }
            }
            //--------------------------Data Output-------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("Statistic Charectiristics:");
            Console.WriteLine("Count:{0}", nArrayLen);
            Console.WriteLine("Minimum:{0}", AData.Min());
            Console.WriteLine("Maximum:{0}", AData.Max());
            Console.WriteLine("Amplitude:{0}", AData.Max() - AData.Min());
            Console.WriteLine("Average Value:{0}", AData.Average());
            Console.WriteLine("Mediane:{0}", nMediane);
            //----------------------------------------------------------------------------------------
            if (nModes.Count > 0)
            {
                int nModesCount = nModes.Count;
                Console.WriteLine("Mode:");
                for (int i = 0; i < nModesCount; i++)
                {
                    Console.Write(nModes[i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
