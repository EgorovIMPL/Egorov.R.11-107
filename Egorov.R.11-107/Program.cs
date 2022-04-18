using System;
using Egorov.R._11_107.HomeWork_INF_04._04._2022;
using Egorov.R._11_107.HomeWork_INF_18._04._2022;

namespace Egorov.R._11_107
{
    class Program
    {
        static void Main(string[] args)
        {
            AvlTree<string> tree = new AvlTree<string>("keyboard", 8);
            tree.Add("ght",3);
            tree.Add("ert",14);
            tree.Add("why",12);
            tree.Add("try",15);
            tree.Add("because",17);
            tree.PrintDepth();
            
        }
    }
}