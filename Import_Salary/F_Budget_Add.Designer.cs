namespace Import_Salary
{
    partial class F_Budget_Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Budget_Add));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.查找部门 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.FDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FSourceFunds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FSumPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FProjectCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FBillNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预算科目编码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预算科目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.预算金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton4,
            this.查找部门,
            this.toolStripButton6,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1213, 32);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(116, 29);
            this.toolStripButton1.Text = "查找项目";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(116, 29);
            this.toolStripButton4.Text = "资金来源";
            this.toolStripButton4.Click += new System.EventHandler(this.资金来源);
            // 
            // 查找部门
            // 
            this.查找部门.Image = ((System.Drawing.Image)(resources.GetObject("查找部门.Image")));
            this.查找部门.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查找部门.Name = "查找部门";
            this.查找部门.Size = new System.Drawing.Size(116, 29);
            this.查找部门.Text = "查找部门";
            this.查找部门.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(76, 29);
            this.toolStripButton6.Text = "保存";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(76, 29);
            this.toolStripButton3.Text = "退出";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FDepartment);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FSourceFunds);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FSumPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FProjectCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FBillNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 122);
            this.panel1.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(649, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(157, 25);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(872, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "部门";
            // 
            // FDepartment
            // 
            this.FDepartment.Location = new System.Drawing.Point(977, 22);
            this.FDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FDepartment.Name = "FDepartment";
            this.FDepartment.Size = new System.Drawing.Size(157, 25);
            this.FDepartment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(563, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = " 资金来源";
            // 
            // FSourceFunds
            // 
            this.FSourceFunds.Location = new System.Drawing.Point(649, 22);
            this.FSourceFunds.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FSourceFunds.Name = "FSourceFunds";
            this.FSourceFunds.Size = new System.Drawing.Size(157, 25);
            this.FSourceFunds.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "总金额";
            // 
            // FSumPrice
            // 
            this.FSumPrice.Location = new System.Drawing.Point(977, 76);
            this.FSumPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FSumPrice.Name = "FSumPrice";
            this.FSumPrice.ReadOnly = true;
            this.FSumPrice.Size = new System.Drawing.Size(157, 25);
            this.FSumPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "工程项目";
            // 
            // FProjectCode
            // 
            this.FProjectCode.Location = new System.Drawing.Point(383, 26);
            this.FProjectCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FProjectCode.Name = "FProjectCode";
            this.FProjectCode.Size = new System.Drawing.Size(157, 25);
            this.FProjectCode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "单据编号";
            // 
            // FBillNo
            // 
            this.FBillNo.Location = new System.Drawing.Point(119, 26);
            this.FBillNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FBillNo.Name = "FBillNo";
            this.FBillNo.ReadOnly = true;
            this.FBillNo.Size = new System.Drawing.Size(157, 25);
            this.FBillNo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.预算科目编码,
            this.预算科目,
            this.预算金额});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1213, 497);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // 预算科目编码
            // 
            this.预算科目编码.HeaderText = "预算科目编码";
            this.预算科目编码.Name = "预算科目编码";
            // 
            // 预算科目
            // 
            this.预算科目.HeaderText = "预算科目";
            this.预算科目.Name = "预算科目";
            // 
            // 预算金额
            // 
            this.预算金额.HeaderText = "预算金额";
            this.预算金额.Name = "预算金额";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "金额单位：万元";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "项目时间";
            // 
            // F_Budget_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F_Budget_Add";
            this.Text = "预算工程款";
            this.Load += new System.EventHandler(this.F_Budget_Add_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FSumPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FProjectCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FBillNo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预算科目编码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预算科目;
        private System.Windows.Forms.DataGridViewTextBoxColumn 预算金额;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton 查找部门;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FSourceFunds;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}