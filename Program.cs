using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the simplifiedChessEngine function below.
     */
    static string[] simplifiedChessEngine(char[][] whites, char[][] blacks, int moves)
    {
        for (int i = 0; i < whites.Length; i++)
        {
            for (int j = 0; j < whites[i].Length; j++)
            {
                switch (whites[i][j])
                {
                    case 'Q':
                        whites[i][j] = '';
                        break;
                    case 'N':
                    case 'B':
                    case 'R':
                    default: break;
                 }
            }
        }
        string[] s = new string[whites.Length];
        return s;
    }

    static ArrayList rook(int h, int v, int field)
    {
        ArrayList move = new ArrayList();
        //right
        for (int i = h+1; i < field; i++)
        {
            ArrayList cell = new ArrayList();
            cell.Add(v);
            cell.Add(i);
            move.Add(cell);
        }
        //top
        for (int i = v+1; i < field; i++)
        {
            ArrayList cell = new ArrayList();
            cell.Add(i);
            cell.Add(h);
            move.Add(cell);
        }
        //bottom
        for (int i = v-1; i > 0; i--)
        {
            ArrayList cell = new ArrayList();
            cell.Add(v);
            cell.Add(i);
            move.Add(cell);
        }
        //left
        for (int i = h - 1; i > 0; i--)
        {
            ArrayList cell = new ArrayList();
            cell.Add(i);
            cell.Add(h);
            move.Add(cell);
        }
        return move;
    }

    static ArrayList queen(int h, int v, int field)
    { 
        ArrayList move = new ArrayList();
        //right
        for (int i = h + 1; i < field; i++)
        {
            ArrayList cell = new ArrayList();
            cell.Add(v);
            cell.Add(i);
            move.Add(cell);
        }
        //top
        for (int i = v + 1; i < field; i++)
        {
            ArrayList cell = new ArrayList();
            cell.Add(i);
            cell.Add(h);
            move.Add(cell);
        }
        //bottom
        for (int i = v - 1; i > 0; i--)
        {
            ArrayList cell = new ArrayList();
            cell.Add(v);
            cell.Add(i);
            move.Add(cell);
        }
        //left
        for (int i = h - 1; i > 0; i--)
        {
            ArrayList cell = new ArrayList();
            cell.Add(i);
            cell.Add(h);
            move.Add(cell);
        }
        return move;
    }

    static void Main(string[] args)
    {

        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int j = 1;
        double p = 3.14;
        string st = "MyTest";
        // Read and save an integer, double, and String to your variables.
        j = int.Parse(Console.ReadLine());
        p = double.Parse(Console.ReadLine());
        st = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine((i + j).ToString());
        // Print the sum of the double variables on a new line.
        Console.WriteLine(string.Format("{0:0.0}", d + p));
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + st);


        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int g = Convert.ToInt32(Console.ReadLine());

        for (int gItr = 0; gItr < g; gItr++)
        {
            string[] wbm = Console.ReadLine().Split(' ');

            int w = Convert.ToInt32(wbm[0]);

            int b = Convert.ToInt32(wbm[1]);

            int m = Convert.ToInt32(wbm[2]);

            char[][] whites = new char[w][];

            for (int whitesRowItr = 0; whitesRowItr < w; whitesRowItr++)
            {
                whites[whitesRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), whitesTemp => whitesTemp[0]);
            }

            char[][] blacks = new char[b][];

            for (int blacksRowItr = 0; blacksRowItr < b; blacksRowItr++)
            {
                blacks[blacksRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), blacksTemp => blacksTemp[0]);
            }

            string[] result = simplifiedChessEngine(whites, blacks, m);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
