using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapXepMang
{
    public partial class Form1 : Form
    {
        int[] arrInt;
        int[] arrTang;
        int[] arrGiam;
        int[] arrDao;
        int[] arrChanLe;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btRandom_Click(object sender, EventArgs e)
        {
            txtArray.Text = txtArrayChanLe.Text = txtArrayDao.Text = txtArrayDown.Text = txtArrayHigh.Text = "";
            try
            {
                int soPhanTu = Int32.Parse(txtNumber.Text);
                arrInt = new int[soPhanTu];
                for (int i = 0; i < soPhanTu; i++)
                    arrInt[i] = r.Next(0, 100);
                ShowArray(arrInt, txtArray);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ShowArray(int []arr,TextBox textBox)
        {
            textBox.Text = String.Join(", ", arr);

            //textBox.Text = String.Empty;
            //for (int i = 0; i < arr.Length; i++)
            //    textBox.Text += arr[i].ToString() +",";
            //textBox.Text = textBox.Text.TrimEnd(',');

        }

        private void btSapXep_Click(object sender, EventArgs e)
        {
            Sort();
            SortSpecial();
        }
        void Sort()
        {
            arrTang =arrGiam = arrDao = new int[arrInt.Length];
            try
            {
                Array.Copy(arrInt,arrTang,arrInt.Length);
                Array.Sort(arrTang);
                ShowArray(arrTang, txtArrayHigh);

                Array.Copy(arrTang, arrGiam, arrTang.Length);
                Array.Reverse(arrGiam);
                ShowArray(arrGiam, txtArrayDown);

                Array.Copy(arrInt, arrDao, arrTang.Length);
                Array.Reverse(arrDao);
                ShowArray(arrDao, txtArrayDao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void SortSpecial()
        {
            arrChanLe = new int[arrInt.Length];
            Array.Copy(arrInt, arrChanLe, arrInt.Length);
            int i = 0, j = arrChanLe.Length - 1;
            while(i<j)
            {
                if (arrChanLe[i] % 2 == 0)
                    i++;
                if (arrChanLe[j] % 2 != 0)
                    j--;
                if(i<j)
                {
                    if(arrChanLe[i]%2!=0 && arrChanLe[j]%2==0)
                    {
                        swap(ref arrChanLe[i], ref arrChanLe[j]);
                        i++;
                        j--;
                    }
                }
            }

            int mid = arrChanLe[i] % 2 != 0 ? i - 1 : i;
            for(i=0;i<mid; i++)
            {
                for(j=i+1;j<mid+1;j++)
                    if (arrChanLe[i] > arrChanLe[j])
                        swap(ref arrChanLe[i], ref arrChanLe[j]);
            }

            for(i=mid+1;i<arrChanLe.Length-1;i++)
            {
                for (j = i + 1; j < arrChanLe.Length ; j++)
                    if (arrChanLe[i] < arrChanLe[j])
                        swap(ref arrChanLe[i], ref arrChanLe[j]);
            }

            ShowArray(arrChanLe, txtArrayChanLe);
        }
        void swap(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }

    }
}
