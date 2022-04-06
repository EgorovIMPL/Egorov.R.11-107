using System;
using System.Collections.Generic;
using System.Linq;

namespace Egorov.R._11_107.HomeWork_ASD_31._03._2022
{
    public class BellFordAlg
    {
        public static void Run()
        {
            var graph = GetGraph();
            var vCount = graph.GetLength(0);
            var vForVisit = new List<int>() {0};
            var vVisited = new List<int>();
            var distances = new int[vCount];
            for (int i = 1; i < vCount; i++)
                distances[i] = Int32.MaxValue;

            while (vForVisit.Count > 0)
            {
                var currentV = vForVisit.First();
                vForVisit.Remove(currentV);
                vVisited.Add(currentV);
                for (int i = 0; i < vCount; i++)
                {
                    if (vVisited.Contains(i) || graph[currentV, i] == 0)
                        continue;
                    vForVisit.Add(i);
                    distances[i] = distances[i] < distances[currentV] + graph[currentV, i] ? distances[i] : distances[currentV] + graph[currentV, i];
                }
            }

            foreach (var i in distances)
            {
                Console.WriteLine(i);
            }

        }
        public static int[,] GetGraph()
        {
            return new int[,]
            {
                {0, 7, 9, 0, 0, -3},
                {7, 0, 10, 15, 0, 0},
                {-9, 10, 0, 11, 0, 2},
                {0, 15, 11, 0, 6, 0},
                {0, 0, 0, 6, 0, 9},
                {4, 0, -12, 0, 9, 0}
            };
        }
    }
}