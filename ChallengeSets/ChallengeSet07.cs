using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            if (businesses == null || businesses.Count == 0)
            {
                return 0;
            }
            int count = 0;

            foreach (Business business in businesses)
            {
                if (business.TotalRevenue - business.TotalExpenses < 0)
                {

                    count++;
                }
            }
            return count;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            List<string> profitBiz = new List<string>();

            foreach (Business business in businesses)
            {
                if (business.TotalRevenue - business.TotalExpenses > 0)
                {
                    profitBiz.Add(business.Name);
                }
            }
            return String.Join(",", profitBiz);
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C



            while (business.ParentCompany != null)
            {
                business = business.ParentCompany;
            }
            return business.Name;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            int[,] whatever = new int[,] { { 1, 2 }, { 4, 5 }, { 6, 7 } };
            var backdiagonal = new List<char>();
            backdiagonal.Add(finalBoard[0, 2]);
            backdiagonal.Add(finalBoard[1, 1]);
            backdiagonal.Add(finalBoard[2, 0]);





            for (int j = 0; j < 3; j++)
            {
                var vertical = new List<char>();
                var horizontal = new List<char>();
                var frontdiagonal = new List<char>();

                


                



                for (int i = 0; i < 3; i++)


                { 
                    
                    vertical.Add(finalBoard[j, i]);
                    horizontal.Add(finalBoard[i, j]);
                    


                    frontdiagonal.Add(finalBoard[i, i]);

                    


                }

                if ((String.Join("", vertical) == "XXX") || (String.Join("", horizontal) == "XXX") || (String.Join("", frontdiagonal) == "XXX") ||
                    (String.Join("", backdiagonal) == "XXX"))
                {
                    return TicTacToeResult.X;
                }


                if ((String.Join("", vertical) == "OOO") || (String.Join("", horizontal) == "OOO") || (String.Join("", frontdiagonal) == "OOO") ||
                   (String.Join("", backdiagonal)== "OOO") )
                {
                    return TicTacToeResult.O;
                }


            }
            
            
            
                return TicTacToeResult.Draw;
            




            

        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            bool flag = true;
            foreach (var s in numbers)
            {
                if (!s.Contains(targetNumber))
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
