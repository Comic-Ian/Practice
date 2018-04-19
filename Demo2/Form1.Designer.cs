namespace Demo2
{
    partial class Form1
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
            this.TbAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtInsert = new System.Windows.Forms.Button();
            this.BtSelect = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.BtDelete = new System.Windows.Forms.Button();
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
            // TbAge
            // 
            this.TbAge.Location = new System.Drawing.Point(123, 131);
            this.TbAge.Name = "TbAge";
            this.TbAge.Size = new System.Drawing.Size(100, 21);
            this.TbAge.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // BtInsert
            // 
            this.BtInsert.Location = new System.Drawing.Point(123, 236);
            this.BtInsert.Name = "BtInsert";
            this.BtInsert.Size = new System.Drawing.Size(75, 23);
            this.BtInsert.TabIndex = 8;
            this.BtInsert.Text = "登记";
            this.BtInsert.UseVisualStyleBackColor = true;
            // 
            // BtSelect
            // 
            this.BtSelect.Location = new System.Drawing.Point(284, 236);
            this.BtSelect.Name = "BtSelect";
            this.BtSelect.Size = new System.Drawing.Size(75, 23);
            this.BtSelect.TabIndex = 9;
            this.BtSelect.Text = "查询";
            this.BtSelect.UseVisualStyleBackColor = true;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 375);
            this.Controls.Add(this.BtDelete);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.BtSelect);
            this.Controls.Add(this.BtInsert);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "人口登记";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtInsert;
        private System.Windows.Forms.Button BtSelect;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.Button BtDelete;
    }
}

