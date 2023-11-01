using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algortytmy_Sortowania
{
    public partial class Form1 : Form
    {


        int[] tab;
        public Form1()
        {
            InitializeComponent();
        }


        void BubbleSort(int[] tab)
        {
            bool wasSorted = true; 
            do
            {
                wasSorted = false;
                for (int i = 0; i < tab.Length-1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int sawp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = sawp;
                        wasSorted = true;
                    }
                }

            }while(wasSorted);
        }


        void SelectionSort(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[index])
                    {
                        index = j;
                    }
                }
                int swap = tab[i];
                tab[i] = tab[index];
                tab[index] = swap;
            }
        }


        void InsertionSort(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = i; j >= 0 ; j--)
                {
                    if (tab[i] < tab[j])
                    {
                        int swap = tab[i];
                        tab[i] = tab[j];
                        tab[j] = swap;
                        i--;
                    }
                }
            }
        }

        void Merge(int[] leftTab, int[] rightTab, int[] tab)
        {
            int leftSize = leftTab.Length;
            int rightSize = tab.Length - leftSize;

            int i = 0, l=0, r=0;

            while(l<leftSize && r < rightSize)
            {
                if (leftTab[l] < rightTab[r])
                {
                    tab[i] = leftTab[l];
                    i++;
                    l++;
                }
                else
                {
                    tab[i] = rightTab[r];
                    i++;
                    r++;
                }
            }

            while (l < leftSize)
            {
                tab[i]=leftTab[l];
                i++;
                l++;
            }

            while (r < rightSize)
            {
                tab[i] = rightTab[r];
                r++;
                i++;
            }
        }

        void MergeSort(int[] tab)
        {
            int length = tab.Length;
            if (length <= 1) return;

            int middle = length / 2;

            int[] leftTab = new int[middle];
            int[] rightTab = new int[length - middle];

            int r = 0;

            for (int l = 0; l < length; l++)
            {
                if (l < middle)
                {
                    leftTab[l] = tab[l];
                }
                else
                {
                    rightTab[r] = tab[l];
                    r++;
                }
            }

            MergeSort(leftTab);
            MergeSort(rightTab);
            Merge(leftTab, rightTab, tab);
        }


        int Partition(int[] tab, int start, int end)
        {
            int pivot = tab[end];
            int i = start - 1;
            for (int j = start; j < end; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;
                    int swap = tab[i];
                    tab[i] = tab[j];
                    tab[j] = swap;
                }
            }
            i++;
            int temp = tab[i];
            tab[i] = tab[end];
            tab[end] = temp;

            return i;
        }

        void QuickSort(int[] tab, int start, int end)
        {
            if(end <= start) return;
            
            int pivot = Partition(tab, start, end);
            QuickSort(tab, start, pivot-1);
            QuickSort(tab, pivot+1, end);

        }


        int[] Convert(String input)
        {
            var temp = input.Trim().Split(' ');
            int[] tab = new int[temp.Length];
            for(int i = 0; i < temp.Length; i++)
            {
                tab[i] = int.Parse(temp[i]);
            }
            return tab;
        }


        void SetTab()
        {
            if (TxtBoxInput.Text.Length > 0 && checkBox_RNG_OnOff.Checked == false)
            {
                tab = Convert(TxtBoxInput.Text);
            }
        }
        

        private void checkBox_RNG_OnOff_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtBoxInput.Text.Length > 0 && checkBox_RNG_OnOff.Checked == false)
                {
                    TxtBoxOutput.Text = "";
                    TxtBoxOutput.ForeColor = Color.White;
                    tab = Convert(TxtBoxInput.Text);
                }
            }
            catch (Exception)
            {
                TxtBoxOutput.Text = "Something went wrong :(";
            }
        }


        private void btnRNG_Start_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkBox_RNG_OnOff.Checked && numericUpDown_NumOfElements.Value > 0)
                {
                    labelError1.Text = "";
                    int[] tabX = new int[(int)numericUpDown_NumOfElements.Value];
                    Random random = new Random();
                    for (int i = 0; i < (int)numericUpDown_NumOfElements.Value; i++)
                    {
                        int RNG = random.Next(0, 1000);
                        tabX[i] = RNG;
                    }
                    tab = tabX;
                    labelRNG.Text = "generated successfully";
                }
            }
            catch (Exception)
            {

                labelTime.Text = "Something went wrong :(";
                labelTime.ForeColor = Color.Red;
            }
        }

        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                labelRNG.Text = "";
                labelError1.Text = "";
                TxtBoxOutput.Text = "";
                TxtBoxOutput.ForeColor = Color.White;
                SetTab();
                if (tab == null || tab.Length == 0)
                {
                    return;
                }

                int[] Copied_tab = new int[tab.Length];
                tab.CopyTo(Copied_tab, 0);

                timer.Start();
                BubbleSort(Copied_tab);
                timer.Stop();

                string output = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    output += Copied_tab[i].ToString() + ", ";
                }
                if (checkBox_RNG_OnOff.Checked==false) TxtBoxOutput.Text    = output;
                if (checkBox_RNG_OnOff.Checked==true) labelTime.Text        = timer.Elapsed.ToString();
            }
            catch (Exception)
            {
                labelError1.Text = "You might use comma instead of SPACE";
                TxtBoxOutput.Text = "Something went wrong :(";
                TxtBoxOutput.ForeColor = Color.Red;
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                labelRNG.Text = "";
                labelError1.Text = "";
                TxtBoxOutput.Text = "";
                TxtBoxOutput.ForeColor = Color.White;
                SetTab();
                if (tab == null || tab.Length == 0)
                {
                    return;
                }

                int[] Copied_tab = new int[tab.Length];
                tab.CopyTo(Copied_tab, 0);

                timer.Start();
                SelectionSort(Copied_tab);
                timer.Stop();

                string output = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    output += Copied_tab[i].ToString() + ", ";
                }
                if (checkBox_RNG_OnOff.Checked == false) TxtBoxOutput.Text = output;
                if (checkBox_RNG_OnOff.Checked == true) labelTime.Text = timer.Elapsed.ToString();
            }
            catch (Exception)
            {
                labelError1.Text = "You might use comma instead of SPACE";
                TxtBoxOutput.Text = "Something went wrong :(";
                TxtBoxOutput.ForeColor = Color.Red;
            }
        }

        private void btnInsertion_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                labelRNG.Text = "";
                TxtBoxOutput.Text = "";
                labelError1.Text = "";
                TxtBoxOutput.ForeColor = Color.White;
                SetTab();
                if (tab == null || tab.Length == 0)
                {
                    return;
                }

                int[] Copied_tab = new int[tab.Length];
                tab.CopyTo(Copied_tab, 0);

                timer.Start();
                InsertionSort(Copied_tab);
                timer.Stop();

                string output = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    output += Copied_tab[i].ToString() + ", ";
                }
                if (checkBox_RNG_OnOff.Checked == false) TxtBoxOutput.Text = output;
                if (checkBox_RNG_OnOff.Checked == true) labelTime.Text = timer.Elapsed.ToString();
            }
            catch (Exception)
            {
                labelError1.Text = "You might use comma instead of SPACE";
                TxtBoxOutput.Text = "Something went wrong :(";
                TxtBoxOutput.ForeColor = Color.Red;
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                labelRNG.Text = "";
                TxtBoxOutput.Text = "";
                labelError1.Text = "";
                TxtBoxOutput.ForeColor = Color.White;
                SetTab();
                if (tab == null || tab.Length == 0)
                {
                    return;
                }

                int[] Copied_tab = new int[tab.Length];
                tab.CopyTo(Copied_tab, 0);

                timer.Start();
                MergeSort(Copied_tab);
                timer.Stop();

                string output = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    output += Copied_tab[i].ToString() + ", ";
                }
                if (checkBox_RNG_OnOff.Checked == false) TxtBoxOutput.Text = output;
                if (checkBox_RNG_OnOff.Checked == true) labelTime.Text = timer.Elapsed.ToString();
            }
            catch (Exception)
            {
                labelError1.Text = "You might use comma instead of SPACE";
                TxtBoxOutput.Text = "Something went wrong :(";
                TxtBoxOutput.ForeColor = Color.Red;
            }
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            try
            {
                Stopwatch timer = new Stopwatch();
                labelRNG.Text = "";
                TxtBoxOutput.Text = "";
                labelError1.Text = "";
                TxtBoxOutput.ForeColor = Color.White;
                SetTab();
                if (tab == null || tab.Length == 0)
                {
                    return;
                }

                int[] Copied_tab = new int[tab.Length];
                tab.CopyTo(Copied_tab, 0);

                timer.Start();
                QuickSort(Copied_tab, 0, Copied_tab.Length-1);
                timer.Stop();

                string output = "";
                for (int i = 0; i < tab.Length; i++)
                {
                    output += Copied_tab[i].ToString() + ", ";
                }
                if (checkBox_RNG_OnOff.Checked == false) TxtBoxOutput.Text = output;
                if (checkBox_RNG_OnOff.Checked == true) labelTime.Text = timer.Elapsed.ToString();
            }
            catch (Exception)
            {
                labelError1.Text = "You might use comma instead of SPACE";
                TxtBoxOutput.Text = "Something went wrong :(";
                TxtBoxOutput.ForeColor = Color.Red;
            }
        }
    }
}
