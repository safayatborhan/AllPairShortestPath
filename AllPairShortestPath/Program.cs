using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPairShortestPath
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] dist = new int[5, 5];
            int[,] pred = new int[5, 5];

            //for (int u = 0; u < 5; u++)
            //{
            //    for (int v = 0; v < 5; v++)
            //    {
            //        //dist[u, v] = Convert.ToInt32(Console.ReadLine());
            //        dist[u, v] = 1000;
            //        pred[u, v] = -1;
            //    }
            //    dist[u, u] = 0;
            //}
            for (int u = 0; u < 5; u++)
            {
                for (int v = 0; v < 5; v++)
                {
                    dist[u, v] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int u = 0; u < 5; u++)
            {
                for (int v = 0; v < 5; v++)
                {
                    pred[u, v] = -1;

                }
            }
            //for (int u = 0; u < 5; u++)
            //{
            //    for (int v = 0; v < 5; v++)
            //    {
            //        Console.Write(dist[u, v] + " ");
            //    }
            //    Console.WriteLine();
            //}
            int newLen;
            for(int t=0;t<5;t++)
            {
                for(int u=0;u<5;u++)
                {
                    for(int v=0;v<5;v++)
                    {
                        newLen = dist[u, t] + dist[t, v];
                        if(newLen<dist[u,v])
                        {
                            dist[u, v] = newLen;
                            pred[u, v] = pred[u, v];
                        }
                    }
                }
            }
            for (int u = 0; u < 5; u++)
            {
                for (int v = 0; v < 5; v++)
                {
                    Console.Write(dist[u, v] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
