using SJX_Form;
using SJX_Model;
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
    public partial class F_Budget_Add : Form
    {
        SJX_Kingdee_Select _BLL_POP_Select = new SJX_Kingdee_Select();
        M_JX_Budget mBudget = new M_JX_Budget();
        M_JX_Budget_Entry mBudgetEntry = new M_JX_Budget_Entry();
        SJX_Kingdee_Insert _BLL_POP_Insert = new SJX_Kingdee_Insert();

        public F_Budget_Add(int id)
        {
            InitializeComponent();
            if (id != 0)
            {
                mBudget.ID = id;
                DataTable dt3 = _BLL_POP_Select.Client_Select_by_Kingdee(id.ToString(), "", 3).Tables[0];//工程项目,资金来源，部门名称及编码取出
                FBillNo.Text = dt3.Rows[0][0].ToString();
                mBudget.FProjectNumber= dt3.Rows[0][1].ToString();//工程项目编码
                FProjectCode.Text= dt3.Rows[0][3].ToString();//工程项目名称
                FSumPrice.Text=dt3.Rows[0][2].ToString();
                FSourceFunds.Text = dt3.Rows[0][4].ToString();//资金来源名称
                FDepartment.Text = dt3.Rows[0][5].ToString();//部门名称
                mBudget.FSourceFunds = dt3.Rows[0][6].ToString();//资金来源编码
                mBudget.FDepartment = dt3.Rows[0][7].ToString();//部门编码
                mBudget.FCreateTime = dt3.Rows[0][8].ToString();//创建时间
                dateTimePicker1.Value = Convert.ToDateTime(dt3.Rows[0][9].ToString());//
                DataTable dt4 = _BLL_POP_Select.Client_Select_by_Kingdee(id.ToString(), "", 4).Tables[0];
                this.dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt4;
                dataGridView1.Columns["预算科目编码"].DataPropertyName = dt4.Columns["预算科目编码"].ToString();
                dataGridView1.Columns["预算科目"].DataPropertyName = dt4.Columns["预算科目"].ToString();
                dataGridView1.Columns["预算金额"].DataPropertyName = dt4.Columns["预算金额"].ToString(); ;
            }
            else
            {
                mBudget.ID = 0;
                DataTable dt1 = _BLL_POP_Select.Client_Select_Max(0).Tables[0];
                FBillNo.Text = dt1.Rows[0][0].ToString();
                DataTable dt = _BLL_POP_Select.Client_Select_by_Kingdee("", "", 1).Tables[0];
                this.dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["预算科目编码"].DataPropertyName = dt.Columns["预算科目编码"].ToString();
                dataGridView1.Columns["预算科目"].DataPropertyName = dt.Columns["预算科目"].ToString();
                dataGridView1.Columns["预算金额"].DataPropertyName ="0";
            }
        }

        private void F_Budget_Add_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//查找项目
        {
            DataTable ds = _BLL_POP_Select.Client_Select_by_Kingdee(FProjectCode.Text,"",0).Tables[0];
            Select_Operation f2 = new Select_Operation(ds, "工程项目编码;工程项目名称", "选择工程项目");
            f2.ShowDialog();
            if (f2.DialogResult == DialogResult.OK)
            {
                string[] a = f2.str.Split(';');
                FProjectCode.Text = a[1];
                mBudget.FProjectNumber = a[0];


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)//保存
        {
            FBillNo.Select();
            FBillNo.Focus();
            mBudget.FBillNo = FBillNo.Text;
            mBudget.FInsertTime = dateTimePicker1.Value;
            mBudget.FSumPrice =decimal.Parse(FSumPrice.Text);
          

            DataTable ds = _BLL_POP_Insert.Client_Insert_Budget(mBudget).Tables[0];
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value != null)
                {

                    mBudgetEntry.FInterId = int.Parse(ds.Rows[0][0].ToString());
                    mBudgetEntry.FBudgetNumber = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if(dataGridView1.Rows[i].Cells[3].Value is null)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = "0";
                    }
                    mBudgetEntry.FPrice= decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    _BLL_POP_Insert.Client_Insert_BudgetEntry(mBudgetEntry);
                    mBudget.FCreateTime = null;
                }
            }
            MessageBox.Show("保存成功");
            this.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)//总金额计算
        {
            FSumPrice.Text = "0";
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {


                    FSumPrice.Text = (decimal.Parse(FSumPrice.Text)+ decimal.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString())).ToString();
                   
                }
            }
        }

        private void 资金来源(object sender, EventArgs e)//资金来源
        {
            DataTable ds = _BLL_POP_Select.Client_Select_by_Kingdee(FSourceFunds.Text, "", 6).Tables[0];
            Select_Operation f3 = new Select_Operation(ds, "资金来源编码;资金来源名称", "选择资金来源");
            f3.ShowDialog();
            if (f3.DialogResult == DialogResult.OK)
            {
                string[] a = f3.str.Split(';');
                FSourceFunds.Text = a[1];
                mBudget.FSourceFunds = a[0];
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//查找部门
        {
            DataTable ds = _BLL_POP_Select.Client_Select_by_Kingdee(FDepartment.Text, "", 5).Tables[0];
            Select_Operation f4 = new Select_Operation(ds, "部门编码;部门名称", "部门来源");
            f4.ShowDialog();
            if (f4.DialogResult == DialogResult.OK)
            {
                string[] a = f4.str.Split(';');
                FDepartment.Text = a[1];
                mBudget.FDepartment = a[0];
            }
        }
    }
}
