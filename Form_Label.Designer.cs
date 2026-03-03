namespace SimpleGIS
{
    partial class Form_Label
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFontSize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chbVisible = new System.Windows.Forms.CheckBox();
            this.chbMask = new System.Windows.Forms.CheckBox();
            this.labelFontDialog = new System.Windows.Forms.FontDialog();
            this.cldLabel = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 372);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 29);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(103, 372);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 29);
            this.btnConfirm.TabIndex = 43;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnFont
            // 
            this.btnFont.BackColor = System.Drawing.Color.Transparent;
            this.btnFont.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFont.Location = new System.Drawing.Point(171, 191);
            this.btnFont.Margin = new System.Windows.Forms.Padding(4);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(161, 30);
            this.btnFont.TabIndex = 42;
            this.btnFont.Text = "宋体";
            this.btnFont.UseVisualStyleBackColor = false;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(99, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "字体:";
            // 
            // btnFontColor
            // 
            this.btnFontColor.BackColor = System.Drawing.Color.Black;
            this.btnFontColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFontColor.Location = new System.Drawing.Point(171, 126);
            this.btnFontColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(161, 30);
            this.btnFontColor.TabIndex = 40;
            this.btnFontColor.UseVisualStyleBackColor = false;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(99, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "颜色:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(99, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "字段:";
            // 
            // cboField
            // 
            this.cboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(171, 63);
            this.cboField.Margin = new System.Windows.Forms.Padding(4);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(160, 23);
            this.cboField.TabIndex = 37;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFontSize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chbVisible);
            this.groupBox1.Controls.Add(this.chbMask);
            this.groupBox1.Location = new System.Drawing.Point(42, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 311);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // labelFontSize
            // 
            this.labelFontSize.AutoSize = true;
            this.labelFontSize.Font = new System.Drawing.Font("宋体", 12F);
            this.labelFontSize.Location = new System.Drawing.Point(167, 219);
            this.labelFontSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFontSize.Name = "labelFontSize";
            this.labelFontSize.Size = new System.Drawing.Size(29, 20);
            this.labelFontSize.TabIndex = 37;
            this.labelFontSize.Text = "12";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(57, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "字体大小:";
            // 
            // chbVisible
            // 
            this.chbVisible.AutoSize = true;
            this.chbVisible.Font = new System.Drawing.Font("宋体", 12F);
            this.chbVisible.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbVisible.Location = new System.Drawing.Point(171, 262);
            this.chbVisible.Margin = new System.Windows.Forms.Padding(4);
            this.chbVisible.Name = "chbVisible";
            this.chbVisible.Size = new System.Drawing.Size(111, 24);
            this.chbVisible.TabIndex = 37;
            this.chbVisible.Text = "显示注记";
            this.chbVisible.UseVisualStyleBackColor = true;
            this.chbVisible.CheckedChanged += new System.EventHandler(this.chbVisible_CheckedChanged);
            // 
            // chbMask
            // 
            this.chbMask.AutoSize = true;
            this.chbMask.Font = new System.Drawing.Font("宋体", 12F);
            this.chbMask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chbMask.Location = new System.Drawing.Point(61, 262);
            this.chbMask.Margin = new System.Windows.Forms.Padding(4);
            this.chbMask.Name = "chbMask";
            this.chbMask.Size = new System.Drawing.Size(71, 24);
            this.chbMask.TabIndex = 32;
            this.chbMask.Text = "描边";
            this.chbMask.UseVisualStyleBackColor = true;
            this.chbMask.CheckedChanged += new System.EventHandler(this.chbMask_CheckedChanged);
            // 
            // Form_Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 433);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Label";
            this.Text = "注记";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelFontSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chbVisible;
        private System.Windows.Forms.CheckBox chbMask;
        private System.Windows.Forms.FontDialog labelFontDialog;
        private System.Windows.Forms.ColorDialog cldLabel;
    }
}