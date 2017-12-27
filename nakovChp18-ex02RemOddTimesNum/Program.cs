using System;
using System.Collections.Generic;
using System.Text;

namespace RemoveNumbers
{
    public class DelOddTimesAppearingNum
    {
        public static void Main(string[] args)
        {
            string inputSeq = Console.ReadLine();
            string[] inpNumStrArr = inputSeq.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<int, int> numSeqDict = new Dictionary<int, int>();

            List<int> numList = new List<int>();

            for (int i = 0; i < inpNumStrArr.Length; i++)
            {
                int currNum = Convert.ToInt32(inpNumStrArr[i]);
                numList.Add(currNum);
                if (!numSeqDict.ContainsKey(currNum))
                {
                    numSeqDict.Add(currNum, 0);
                }
                else
                {
                    numSeqDict[currNum]++;
                }
            }       

            StringBuilder filter = new StringBuilder();
            for (int i = 0; i < numList.Count; i++)
            {
                if (numSeqDict[numList[i]] % 2 != 0)
                {
                    filter.AppendFormat("{0} ", numList[i]);  
                }
            }

            if (filter.Length != 0)
            {
                Console.WriteLine(filter.ToString().TrimEnd());
            }
        }
    }
}