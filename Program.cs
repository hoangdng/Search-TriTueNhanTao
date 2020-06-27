using System;
using SearchDigits.Models;
using SearchDigits.Search;

namespace SearchDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // BFS bfs = new BFS();
            // bfs.Search();
            DFS dfs = new DFS();
            dfs.Search();
        }
    }
}
