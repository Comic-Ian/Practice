namespace Demo2
{
    partial class DemoForm2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbSex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbCardNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbBirthDay = new System.Windows.Forms.TextBox();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtSelect = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(123, 58);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 21);
            this.TbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "性别";
            // 
            // TbSex
            // 
            this.TbSex.Location = new System.Drawing.Point(123, 131);
            this.TbSex.Name = "TbSex";
            this.TbSex.Size = new System.Drawing.Size(100, 21);
            this.TbSex.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "身份证号";
            // 
            // TbCardNum
            // 
            this.TbCardNum.Location = new System.Drawing.Point(318, 58);
            this.TbCardNum.Name = "TbCardNum";
            this.TbCardNum.Size = new System.Drawing.Size(100, 21);
            this.TbCardNum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "出生年月";
            // 
            // TbBirthDay
            // 
            this.TbBirthDay.Location = new System.Drawing.Point(318, 131);
            this.TbBirthDay.Name = "TbBirthDay";
            this.TbBirthDay.Size = new System.Drawing.Size(100, 21);
            this.TbBirthDay.TabIndex = 7;
            // 
            // BtInsert
            // 
            this.BtInsert.Location = new System.Drawing.Point(123, 236);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(75, 23);
            this.BtInsert.TabIndex = 8;
            this.BtInsert.Text = "登记";
            this.BtInsert.UseVisualStyleBackColor = true;
            this.BtInsert.Click += new System.EventHandler(this.BtInsert_Click);
            // 
            // BtSelect
            // 
            this.BtSelect.Location = new System.Drawing.Point(284, 236);
            this.BtSelect.Name = "BtSelect";
            this.BtSelect.Size = new System.Drawing.Size(75, 23);
            this.BtSelect.TabIndex = 9;
            this.BtSelect.Text = "查询";
            this.BtSelect.UseVisualStyleBackColor = true;
            this.BtSelect.Click += new System.EventHandler(this.BtSelect_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(123, 302);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtUpdate.TabIndex = 10;
            this.BtUpdate.Text = "修改";
            this.BtUpdate.UseVisualStyleBackColor = true;
            // 
            // BtDelete
            // 
            this.BtDelete.Location = new System.Drawing.Point(284, 302);
            this.BtDelete.Name = "BtDelete";
            this.BtDelete.Size = new System.Drawing.Size(75, 23);
            this.BtDelete.TabIndex = 11;
            this.BtDelete.Text = "删除";
            this.BtDelete.UseVisualStyleBackColor = true;
            this.BtDelete.Click += new System.EventHandler(this.BtDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(54, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(412, 208);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "姓名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "性别";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "身份证号";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "出生年月";
            this.Column4.Name = "Column4";
            // 
            // DemoForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 630);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtSelect);
            this.Controls.Add(this.BtInsert);
            this.Controls.Add(this.TbBirthDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbCardNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label1);
            this.Name = "DemoForm2";
            this.Text = "人口登记";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbCardNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbBirthDay;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtSelect;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

