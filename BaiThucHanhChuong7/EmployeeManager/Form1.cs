using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EmployeeManager
{
    public partial class Form1 : Form
    {
        ArrayList arrEmp = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAge.Text == "" || txtAddress.Text == "")
                return;
            Employee emp = new Employee(txtName.Text,txtAddress.Text,int.Parse(txtAge.Text));
            arrEmp.Add(emp);
            txtName.Text =txtAddress.Text = txtAge.Text = "";
            txtName.Focus();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabEmployee.SelectedIndex == 1)
                ShowList();
        }
        void ShowList()
        {
            ListViewItem item = null;
            foreach(Employee emp in arrEmp)
            {
                item = new ListViewItem(emp.Name);
                item.SubItems.Add(emp.Age.ToString());
                item.SubItems.Add(emp.Address);
                listEmployee.Items.Add(item); 
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Employee file|*.empl";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = null;
                BinaryFormatter bin = new BinaryFormatter();
                try
                {
                    stream = new FileStream(dlg.FileName, FileMode.Create, FileAccess.Write);
                    foreach(Employee emp in arrEmp)
                        bin.Serialize(stream, emp);
                }
                catch{ }
                finally
                {
                    stream.Close();
                }
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {

           OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Employee file|*.empl";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                arrEmp.Clear();
                FileStream stream = null;
                BinaryFormatter bin = new BinaryFormatter();
                try
                {
                    stream = new FileStream(dlg.FileName, FileMode.Open, FileAccess.Read);
                    while(true)
                    {
                        Employee emp = new Employee();
                        emp = (Employee)bin.Deserialize(stream);
                        arrEmp.Add(emp);
                    }
                }
                catch { }
                finally
                {
                    stream.Close();
                    tabEmployee.SelectedIndex = 1;
                }
            }
        }
    }
}
