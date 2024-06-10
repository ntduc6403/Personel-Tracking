using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace Personal_Tracking
{
    public partial class FrmPosition : Form
    {
        public FrmPosition()
        {
            InitializeComponent();
        }
        List<DEPARTMENT> departmentlist = new List<DEPARTMENT>();

        private void FrmPosition_Load(object sender, EventArgs e)
        {
            departmentlist = DepartmentBLL.GetDepartment();
            comboBox1.DataSource = departmentlist;
            comboBox1.DisplayMember = "DepartmentName";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the position !");
            }
            else if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a department !");
            }
            else
            {
                POSITION position = new POSITION();
                position.PositionName = txtPosition.Text;
                position.DepartmentID = Convert.ToInt32(comboBox1.SelectedValue);
                BLL.PositionBLL.AddPosition(position);
                MessageBox.Show("Position was added");
                txtPosition.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }
    }
}
