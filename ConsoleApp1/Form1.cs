using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] array;
        private void buttonInitialize_Click(object sender, EventArgs e)
        {
            array = new int[Convert.ToInt32(textBoxLength.Text)];
            ArrayInitialize(array, Convert.ToInt32(textBoxMin.Text), Convert.ToInt32(textBoxMax.Text));
            string str = "";
            foreach (int i in array)
                str += i + "\n";
            richTextBox1.Text = str;
        }


        private void buttonBubbleSort_Click(object sender, EventArgs e)
        {
            int[] array_new1 = new int[array.Length];
            Array.Copy(array, array_new1, array.Length);
            ulong Counter = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            BubbleSort(array_new1, ref Counter);
            stopwatch.Stop();
            string str = "";
            foreach (int i in array_new1)
                str += i + "\n";
            richTextBox2.Text = str;
            timeBubbleSort.Text = stopwatch.ElapsedTicks.ToString();
            permutationBubbleSort.Text = Counter.ToString();
        }

        private void buttonQuickSort_Click(object sender, EventArgs e)
        {
            int[] array_new2 = new int[array.Length];
            Array.Copy(array, array_new2, array.Length);
            ulong Counter = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QuickSort(array_new2, 0, array_new2.Length - 1, ref Counter);
            stopwatch.Stop();
            string str = "";
            foreach (int i in array_new2)
                str += i + "\n";
            richTextBox3.Text = str;
            timeQuickSort.Text = stopwatch.ElapsedTicks.ToString();
            permutationQuickSort.Text = Counter.ToString();
        }

        private void buttonCombSort_Click(object sender, EventArgs e)
        {
            int[] array_new3 = new int[array.Length];
            Array.Copy(array, array_new3, array.Length);
            ulong Counter = 0;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CombSort(array_new3, ref Counter);
            stopwatch.Stop();
            string str = "";
            foreach (int i in array_new3)
                str += i + "\n";
            richTextBox4.Text = str;
            timeCombSort.Text = stopwatch.ElapsedTicks.ToString();
            permutationCombSort.Text = Counter.ToString();
        }




        static void ArrayInitialize(int[] arr, int min, int max)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(min, max + 1);
        }




        static int[] BubbleSort(int[] array, ref ulong Counter)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        var t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                        Counter++;
                    }
            return array;
        }



        static int[] QuickSort(int[] array, int leftIndex, int rightIndex, ref ulong Counter)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }

                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    var t = array[i];
                    array[i] = array[j];
                    array[j] = t;
                    i++;
                    j--;
                    Counter++;
                }
            }

            if (leftIndex < j)
                QuickSort(array, leftIndex, j, ref Counter);
            if (i < rightIndex)
                QuickSort(array, i, rightIndex, ref Counter);
            return array;
        }



        public static void CombSort(int[] input, ref ulong Counter)
        {
            double gap = input.Length;
            bool swaps = true;
            while (gap > 1 || swaps)
            {
                gap /= 1.247330950103979;
                if (gap < 1) { gap = 1; }
                int i = 0;
                swaps = false;
                while (i + gap < input.Length)
                {
                    int igap = i + (int)gap;
                    if (input[i] > input[igap])
                    {
                        int swap = input[i];
                        input[i] = input[igap];
                        input[igap] = swap;
                        swaps = true;
                        Counter++;
                    }
                    i++;
                }
            }

        }
    }
}
