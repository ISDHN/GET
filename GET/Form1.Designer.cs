namespace GET
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Patch = new System.Windows.Forms.Button();
            this.Bits = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.OnlyNumber = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.Bits)).BeginInit();
            this.SuspendLayout();
            // 
            // Patch
            // 
            this.Patch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Patch.FlatAppearance.BorderSize = 2;
            this.Patch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patch.ForeColor = System.Drawing.Color.White;
            this.Patch.Location = new System.Drawing.Point(145, 55);
            this.Patch.Name = "Patch";
            this.Patch.Size = new System.Drawing.Size(68, 27);
            this.Patch.TabIndex = 0;
            this.Patch.Text = "破解";
            this.toolTip1.SetToolTip(this.Patch, "开始破解");
            this.Patch.UseVisualStyleBackColor = true;
            this.Patch.Click += new System.EventHandler(this.Patch_Click);
            // 
            // Bits
            // 
            this.Bits.BackColor = System.Drawing.Color.Black;
            this.Bits.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Bits.ForeColor = System.Drawing.Color.White;
            this.Bits.Location = new System.Drawing.Point(55, 55);
            this.Bits.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Bits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Bits.Name = "Bits";
            this.Bits.ReadOnly = true;
            this.Bits.Size = new System.Drawing.Size(58, 27);
            this.Bits.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Bits, "密码位数");
            this.Bits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OnlyNumber
            // 
            this.OnlyNumber.AutoSize = true;
            this.OnlyNumber.ForeColor = System.Drawing.Color.White;
            this.OnlyNumber.Location = new System.Drawing.Point(55, 98);
            this.OnlyNumber.Name = "OnlyNumber";
            this.OnlyNumber.Size = new System.Drawing.Size(60, 16);
            this.OnlyNumber.TabIndex = 2;
            this.OnlyNumber.Text = "仅数字";
            this.OnlyNumber.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(268, 137);
            this.Controls.Add(this.OnlyNumber);
            this.Controls.Add(this.Bits);
            this.Controls.Add(this.Patch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Bits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Patch;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.NumericUpDown Bits;
        private System.Windows.Forms.CheckBox OnlyNumber;
    }
}

