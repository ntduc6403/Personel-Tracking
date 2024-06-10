using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

using DAL.DTO;

namespace Personal_Tracking
{
    public partial class FrmPositionList : Form
    {
        public FrmPositionList()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmPosition frm = new FrmPosition();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }
        List<PositionDTO> positionList = new List<PositionDTO>();
        private void FrmPositionList_Load(object sender, EventArgs e)
        {
            positionList = PositionBLL.GetPosition();
            dataGridView1.DataSource = positionList;
        }
    }
}
