using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Import_Salary
{
    public partial class F_Budget : Form
    {
        SJX_Kingdee_Select _BLL_POP_Select = new SJX_Kingdee_Select();
        SJX_Kingdee_Delete _BLL_POP_Delete = new SJX_Kingdee_Delete();
        public F_Budget()
        {
            InitializeComponent();
            select();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
                panel1.Visible = false;
            else
                panel1.Visible = true;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            F_Budget_Add f2 = new F_Budget_Add(0);
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select();

        }
        public void select()
        {
            //(decimal(18, 2), T_JX_Budget.FSumPrice)
            this.dataGridView1.AutoGenerateColumns = false;
            DataTable  dt1 = _BLL_POP_Select.Client_Select_by_Kingdee(textBox1.Text,"",2).Tables[0];
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["id"].DataPropertyName = dt1.Columns["ID"].ToString();
            dataGridView1.Columns["单据编码"].DataPropertyName = dt1.Columns["单据编码"].ToString();
            dataGridView1.Columns["工程名称"].DataPropertyName = dt1.Columns["工程名称"].ToString();
            dataGridView1.Columns["单据预算总价"].DataPropertyName = dt1.Columns["单据预算总价"].ToString();
            dataGridView1.Columns["工程编码"].DataPropertyName = dt1.Columns["工程编码"].ToString();
            dataGridView1.Columns["资金来源"].DataPropertyName = dt1.Columns["资金来源"].ToString();
            dataGridView1.Columns["部门"].DataPropertyName = dt1.Columns["部门"].ToString();
            dataGridView1.Columns["项目时间"].DataPropertyName = dt1.Columns["项目时间"].ToString();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index; //获取选中行的行号
            F_Budget_Add f2 = new F_Budget_Add(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()));
            f2.ShowDialog();
            select();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            select();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index; //获取选中行的行号
            _BLL_POP_Delete.Client_Delete_Kingdee(int.Parse(dataGridView1.Rows[index].Cells[0].Value.ToString()),0);
            MessageBox.Show("删除成功");
            select();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
