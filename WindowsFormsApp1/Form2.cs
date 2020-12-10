using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        DataTable dt1 = new DataTable();
        Select select = new Select();

        public Form2()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)//查询
        {
            this.dataGridView1.AutoGenerateColumns = false;
            dt1 = select.From2_select(0,T_select.Text).Tables[0];
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["id"].DataPropertyName = dt1.Columns["ID"].ToString();
            dataGridView1.Columns["billnum"].DataPropertyName = dt1.Columns["BILLNUM"].ToString();
            dataGridView1.Columns["project"].DataPropertyName = dt1.Columns["FDATAVALUE"].ToString();
            dataGridView1.Columns["totalmoney"].DataPropertyName = dt1.Columns["TOTALMONEY"].ToString();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//新增
        {
            WindowsFormsApp1.Add f2 = new WindowsFormsApp1.Add(0);
            f2.ShowDialog();
        }


        private void toolStripButton3_Click(object sender, EventArgs e)//编辑
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)//删除
        {

        }

        private void Form2_Load(object sender, EventArgs e)//主界面加载时显示所有数据
        {
            this.dataGridView1.AutoGenerateColumns = false;
            dt1 = select.From2_select(0, "").Tables[0];
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["id"].DataPropertyName = dt1.Columns["ID"].ToString();
            dataGridView1.Columns["billnum"].DataPropertyName = dt1.Columns["BILLNUM"].ToString();
            dataGridView1.Columns["project"].DataPropertyName = dt1.Columns["FDATAVALUE"].ToString();
            dataGridView1.Columns["totalmoney"].DataPropertyName = dt1.Columns["TOTALMONEY"].ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
