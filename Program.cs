using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5Lec22DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2D array - type rectangular

            int[,] twoDarr = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i = 0; i < twoDarr.GetLength(0); i++)
            {
                for (int j = 0; j < twoDarr.GetLength(1); j++)
                {
                    Console.Write(twoDarr[i, j]);

                }
                

            }

            int[,] twoDarrB = new int[8, 8];
            int[,] twoDarrC = new int[8, 8];
            int[,] twoDarrD = new int[8, 8];

            //Declaring 3D arrays
            //int[,,] threeDarr = new int[2, 2, 2];
            Random r = new Random();
            for (int i = 0; i< twoDarrB.GetLength(0); i++)
            {

                for(int j = 0; j< twoDarrB.GetLength(1); j++)
                {
                    twoDarrB[i, j] = r.Next(0, 101);
                    twoDarrC[i, j] = r.Next(0, 101);
                    twoDarrC[i,j] = twoDarrB[i,j] + twoDarrC[i,j];

                }

            }    


        }
    }
}
