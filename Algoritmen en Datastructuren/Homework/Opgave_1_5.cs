using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Opgave_1_5
    {
        private Stopwatch stopwatch;
        private delegate void Fragment(int n);
        private StreamWriter streamWriter;

        public void StartTest()
        {
            string Filename = @"D:\TestResult_" + DateTime.Now.ToString("yyyy-M-dd-HH-mm-ss") + ".txt";
            stopwatch = new Stopwatch();
            try
            {
                using (streamWriter = new StreamWriter(Filename))
                {
                    ExecuteFragments(1,0);
                    ExecuteFragments(5,0);
                    ExecuteFragments(10,0);
                    ExecuteFragments(20,0);
                    ExecuteFragments(40,0);
                    ExecuteFragments(60,0);
                    ExecuteFragments(80,0);
                    ExecuteFragments(100,0);
                    ExecuteFragments(125,0);
                    ExecuteFragments(150,0);

                    ExecuteFragments(175, 1);
                    ExecuteFragments(200, 1);
                    ExecuteFragments(400, 1);
                    ExecuteFragments(600, 1);
                    ExecuteFragments(800, 1);
                    ExecuteFragments(1000, 1);
                    ExecuteFragments(1250, 1);
                    ExecuteFragments(1500, 1);
                    ExecuteFragments(1750, 1);
                    ExecuteFragments(2000, 1);

                    ExecuteFragments(2500, 2);
                    ExecuteFragments(3000, 2);
                    ExecuteFragments(3500, 2);
                    ExecuteFragments(4000, 2);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

        private void ExecuteFragments(int n, int fase)
        {
            ExecuteFragment(n, Fragment1, 1);
            ExecuteFragment(n, Fragment2, 2);
            ExecuteFragment(n, Fragment3, 3);
            ExecuteFragment(n, Fragment4, 4);
            if(fase<2) ExecuteFragment(n, Fragment5, 5);
            ExecuteFragment(n, Fragment6, 6);
            if(fase<1) ExecuteFragment(n, Fragment7, 7);
            ExecuteFragment(n, Fragment8, 8);
        }

        private void ExecuteFragment(int n, Fragment fragment, int fragmentnummer)
        {
            streamWriter.Write($"{DateTime.Now} Starting {fragmentnummer} with n={n}...");
            stopwatch.Reset();
            stopwatch.Start();
            fragment(n);
            stopwatch.Stop();
            streamWriter.WriteLine($" Elapsed time: {stopwatch.ElapsedMilliseconds} ms.");
        }

        private void Fragment1(int n)
        {
            int sum = 0;
            // Fragment 1
            for (int i = 0; i < n; i++)
                sum++;

        }

        private void Fragment2(int n)
        {
            int sum = 0;
            // Fragment 2
            for (int i = 0; i < n; i += 2)
                sum++;

        }

        private void Fragment3(int n)
        {
            int sum = 0;
            // Fragment 3
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    sum++;

        }

        private void Fragment4(int n)
        {
            int sum = 0;
            // Fragment 4
            for (int i = 0; i < n; i++)
                sum++;
            for (int j = 0; j < n; j++)
                sum++;

        }

        private void Fragment5(int n)
        {
            int sum = 0;
            // Fragment 5
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n * n; j++)
                    sum++;

        }

        private void Fragment6(int n)
        {
            int sum = 0;
            // Fragment 6
            for (int i = 0; i < n; i++)
                for (int j = 0; j < i; j++)
                    sum++;

        }

        private void Fragment7(int n)
        {
            int sum = 0;
            // Fragment 7
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n * n; j++)
                    for (int k = 0; k < j; k++)
                        sum++;

        }

        private void Fragment8(int n)
        {
            int sum = 0;
            // Fragment 8
            for (int i = 1; i < n; i = i * 2)
                sum++;
        }
    }
}
