using System;
using SearchDigits.Models;
using System.Collections.Generic;

namespace SearchDigits.Search
{
    public class DFS
    {
        static State Start = new State();
        static State Goal = new State();
        static Stack<State> Open = new Stack<State>();
        static Dictionary<string, State> Closed = new Dictionary<string, State>();

        public static void RandomState()
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Operator op = new Operator(rand.Next(4));
                State newState = op.Move(Start);
                if (newState != null)
                    Start = newState;
            }
            Console.Write("Start State:\n");
            Start.Print();
        }
        public static void PrintResult(State state)
        {
            if (state.preState != null)
            {
                PrintResult(state.preState);
                switch (state.preOp.dir)
                {
                    case 0:
                        Console.WriteLine("UP");
                        break;
                    case 1:
                        Console.WriteLine("DOWN");
                        break;
                    case 2:
                        Console.WriteLine("LEFT");
                        break;
                    case 3:
                        Console.WriteLine("DOWN");
                        break;
                }
            }
            state.Print();
        }
        public static bool Equal(State state1, State state2)
        {
            if (state1 == null || state2 == null)
                return false;
            int length = state2.d.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (state1.d[i, j] != state2.d[i, j])
                        return false;
                }
            }
            PrintResult(state1);
            return true;
        }
        public void Search()
        {
            //B1: Cho dinh xuat phat vao Open
            RandomState();
            Open.Push(Start);
            Closed.Add(Start.GetKey(), Start);

            int step = 0;
            while (true)
            {
                //B2: Neu Open rong thi ket thuc
                if (Open.Count == 0)
                    break;

                //B3: Lay dinh day cua Open ra, goi do la O
                step++;
                State O = Open.Pop();

                //B4: Neu O la dich thi tim kiem thanh cong
                if (Equal(O, Goal))
                    break;

                //B5: Tim tat ca cac dinh con cua O khong thuoc Closed va cho vao Open
                for (int dir = 0; dir < 4; dir++)
                {
                    Operator op = new Operator(dir);
                    State childState = op.Move(O);
                    if (childState == null)
                        continue;
                    if (Closed.ContainsKey(childState.GetKey()))
                        continue;
                    if (Open.Contains(childState))
                        continue;
                    childState.preState = O;
                    childState.preOp = op;
                    Open.Push(childState);
                    Closed.Add(childState.GetKey(), childState);
                }

                //B6: Quay lai buoc 2
            }
            Console.WriteLine("Step: " + step);
        }
    }
}