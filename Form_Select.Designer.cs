namespace SimpleGIS
{
    partial class Form_Select
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
            this.or = new System.Windows.Forms.Button();
            this.and = new System.Windows.Forms.Button();
            this.like = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btnLessOrMore = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnMoreOrEqual = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnNotEqual = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UniqueValueList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FieldsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LayerList = new System.Windows.Forms.ComboBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.btn_char = new System.Windows.Forms.Button();
            this.btn_string = new System.Windows.Forms.Button();
            this.btn_leftbracket = new System.Windows.Forms.Button();
            this.btn_rightbracket = new System.Windows.Forms.Button();
            this.not = new System.Windows.Forms.Button();
            this.btn_is = new System.Windows.Forms.Button();
            this.btn_in = new System.Windows.Forms.Button();
            this.btn_null = new System.Windows.Forms.Button();
            this.btn_getValue = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // or
            // 
            this.or.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.or.Location = new System.Drawing.Point(137, 295);
            this.or.Margin = new System.Windows.Forms.Padding(2);
            this.or.Name = "or";
            this.or.Size = new System.Drawing.Size(55, 27);
            this.or.TabIndex = 47;
            this.or.Text = "Or(R)";
            this.or.UseVisualStyleBackColor = true;
            this.or.Click += new System.EventHandler(this.or_Click);
            // 
            // and
            // 
            this.and.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.and.Location = new System.Drawing.Point(137, 264);
            this.and.Margin = new System.Windows.Forms.Padding(2);
            this.and.Name = "and";
            this.and.Size = new System.Drawing.Size(55, 27);
            this.and.TabIndex = 46;
            this.and.Text = "And(A)";
            this.and.UseVisualStyleBackColor = true;
            this.and.Click += new System.EventHandler(this.and_Click);
            // 
            // like
            // 
            this.like.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.like.Location = new System.Drawing.Point(137, 233);
            this.like.Margin = new System.Windows.Forms.Padding(2);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(55, 27);
            this.like.TabIndex = 45;
            this.like.Text = "Like(K)";
            this.like.UseVisualStyleBackColor = true;
            this.like.Click += new System.EventHandler(this.like_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.Location = new System.Drawing.Point(273, 492);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(67, 27);
            this.btn_Apply.TabIndex = 44;
            this.btn_Apply.Text = "应用";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // btnLessOrMore
            // 
            this.btnLessOrMore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLessOrMore.Location = new System.Drawing.Point(88, 295);
            this.btnLessOrMore.Margin = new System.Windows.Forms.Padding(2);
            this.btnLessOrMore.Name = "btnLessOrMore";
            this.btnLessOrMore.Size = new System.Drawing.Size(39, 27);
            this.btnLessOrMore.TabIndex = 43;
            this.btnLessOrMore.Text = "<=";
            this.btnLessOrMore.UseVisualStyleBackColor = true;
            this.btnLessOrMore.Click += new System.EventHandler(this.btnLessOrMore_Click);
            // 
            // btnLess
            // 
            this.btnLess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLess.Location = new System.Drawing.Point(35, 295);
            this.btnLess.Margin = new System.Windows.Forms.Padding(2);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(39, 27);
            this.btnLess.TabIndex = 42;
            this.btnLess.Text = "<";
            this.btnLess.UseVisualStyleBackColor = true;
            this.btnLess.Click += new System.EventHandler(this.btnLess_Click);
            // 
            // btnMoreOrEqual
            // 
            this.btnMoreOrEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoreOrEqual.Location = new System.Drawing.Point(88, 264);
            this.btnMoreOrEqual.Margin = new System.Windows.Forms.Padding(2);
            this.btnMoreOrEqual.Name = "btnMoreOrEqual";
            this.btnMoreOrEqual.Size = new System.Drawing.Size(39, 27);
            this.btnMoreOrEqual.TabIndex = 41;
            this.btnMoreOrEqual.Text = ">=";
            this.btnMoreOrEqual.UseVisualStyleBackColor = true;
            this.btnMoreOrEqual.Click += new System.EventHandler(this.btnMoreOrEqual_Click);
            // 
            // btnMore
            // 
            this.btnMore.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMore.Location = new System.Drawing.Point(35, 264);
            this.btnMore.Margin = new System.Windows.Forms.Padding(2);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(39, 27);
            this.btnMore.TabIndex = 40;
            this.btnMore.Text = ">";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnNotEqual
            // 
            this.btnNotEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnNotEqual.Location = new System.Drawing.Point(88, 233);
            this.btnNotEqual.Margin = new System.Windows.Forms.Padding(2);
            this.btnNotEqual.Name = "btnNotEqual";
            this.btnNotEqual.Size = new System.Drawing.Size(39, 27);
            this.btnNotEqual.TabIndex = 39;
            this.btnNotEqual.Text = "≠";
            this.btnNotEqual.UseVisualStyleBackColor = true;
            this.btnNotEqual.Click += new System.EventHandler(this.btnNotEqual_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEqual.Location = new System.Drawing.Point(35, 233);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(2);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(39, 27);
            this.btnEqual.TabIndex = 38;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "Select * From Where";
            // 
            // SQLTextBox
            // 
            this.SQLTextBox.Location = new System.Drawing.Point(35, 411);
            this.SQLTextBox.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.SQLTextBox.Multiline = true;
            this.SQLTextBox.Name = "SQLTextBox";
            this.SQLTextBox.Size = new System.Drawing.Size(373, 65);
            this.SQLTextBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 35;
            this.label3.Text = "唯一值";
            // 
            // UniqueValueList
            // 
            this.UniqueValueList.FormattingEnabled = true;
            this.UniqueValueList.ItemHeight = 12;
            this.UniqueValueList.Location = new System.Drawing.Point(202, 233);
            this.UniqueValueList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.UniqueValueList.Name = "UniqueValueList";
            this.UniqueValueList.Size = new System.Drawing.Size(209, 124);
            this.UniqueValueList.TabIndex = 34;
            this.UniqueValueList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UniqueValueList_MouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "字段";
            // 
            // FieldsList
            // 
            this.FieldsList.FormattingEnabled = true;
            this.FieldsList.ItemHeight = 12;
            this.FieldsList.Location = new System.Drawing.Point(35, 66);
            this.FieldsList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.FieldsList.Name = "FieldsList";
            this.FieldsList.Size = new System.Drawing.Size(376, 136);
            this.FieldsList.TabIndex = 32;
            this.FieldsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FieldsList_MouseClick);
            this.FieldsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FieldsList_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = "图层：";
            // 
            // LayerList
            // 
            this.LayerList.FormattingEnabled = true;
            this.LayerList.Location = new System.Drawing.Point(81, 15);
            this.LayerList.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.LayerList.Name = "LayerList";
            this.LayerList.Size = new System.Drawing.Size(330, 20);
            this.LayerList.TabIndex = 30;
            this.LayerList.SelectionChangeCommitted += new System.EventHandler(this.LayerList_SelectionChangeCommitted);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(344, 492);
            this.bt_cancel.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(67, 27);
            this.bt_cancel.TabIndex = 29;
            this.bt_cancel.Text = "取消";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.Location = new System.Drawing.Point(202, 492);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(67, 27);
            this.bt_OK.TabIndex = 28;
            this.bt_OK.Text = "确定";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // btn_char
            // 
            this.btn_char.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_char.Location = new System.Drawing.Point(35, 326);
            this.btn_char.Margin = new System.Windows.Forms.Padding(2);
            this.btn_char.Name = "btn_char";
            this.btn_char.Size = new System.Drawing.Size(18, 29);
            this.btn_char.TabIndex = 48;
            this.btn_char.Text = "_";
            this.btn_char.UseVisualStyleBackColor = true;
            this.btn_char.Click += new System.EventHandler(this.btn_char_Click);
            // 
            // btn_string
            // 
            this.btn_string.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_string.Location = new System.Drawing.Point(56, 326);
            this.btn_string.Margin = new System.Windows.Forms.Padding(2);
            this.btn_string.Name = "btn_string";
            this.btn_string.Size = new System.Drawing.Size(18, 29);
            this.btn_string.TabIndex = 49;
            this.btn_string.Text = "%";
            this.btn_string.UseVisualStyleBackColor = true;
            this.btn_string.Click += new System.EventHandler(this.btn_string_Click);
            // 
            // btn_leftbracket
            // 
            this.btn_leftbracket.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_leftbracket.Location = new System.Drawing.Point(87, 326);
            this.btn_leftbracket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_leftbracket.Name = "btn_leftbracket";
            this.btn_leftbracket.Size = new System.Drawing.Size(18, 29);
            this.btn_leftbracket.TabIndex = 50;
            this.btn_leftbracket.Text = "(";
            this.btn_leftbracket.UseVisualStyleBackColor = true;
            this.btn_leftbracket.Click += new System.EventHandler(this.btn_leftbracket_Click);
            // 
            // btn_rightbracket
            // 
            this.btn_rightbracket.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_rightbracket.Location = new System.Drawing.Point(109, 326);
            this.btn_rightbracket.Margin = new System.Windows.Forms.Padding(2);
            this.btn_rightbracket.Name = "btn_rightbracket";
            this.btn_rightbracket.Size = new System.Drawing.Size(18, 29);
            this.btn_rightbracket.TabIndex = 51;
            this.btn_rightbracket.Text = ")";
            this.btn_rightbracket.UseVisualStyleBackColor = true;
            this.btn_rightbracket.Click += new System.EventHandler(this.btn_rightbracket_Click);
            // 
            // not
            // 
            this.not.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.not.Location = new System.Drawing.Point(138, 326);
            this.not.Margin = new System.Windows.Forms.Padding(2);
            this.not.Name = "not";
            this.not.Size = new System.Drawing.Size(54, 29);
            this.not.TabIndex = 52;
            this.not.Text = "Not(T)";
            this.not.UseVisualStyleBackColor = true;
            this.not.Click += new System.EventHandler(this.not_Click);
            // 
            // btn_is
            // 
            this.btn_is.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_is.Location = new System.Drawing.Point(35, 359);
            this.btn_is.Margin = new System.Windows.Forms.Padding(2);
            this.btn_is.Name = "btn_is";
            this.btn_is.Size = new System.Drawing.Size(39, 27);
            this.btn_is.TabIndex = 53;
            this.btn_is.Text = "Is(I)";
            this.btn_is.UseVisualStyleBackColor = true;
            this.btn_is.Click += new System.EventHandler(this.btn_is_Click);
            // 
            // btn_in
            // 
            this.btn_in.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_in.Location = new System.Drawing.Point(78, 359);
            this.btn_in.Margin = new System.Windows.Forms.Padding(2);
            this.btn_in.Name = "btn_in";
            this.btn_in.Size = new System.Drawing.Size(49, 27);
            this.btn_in.TabIndex = 54;
            this.btn_in.Text = "In(N)";
            this.btn_in.UseVisualStyleBackColor = true;
            this.btn_in.Click += new System.EventHandler(this.btn_in_Click);
            // 
            // btn_null
            // 
            this.btn_null.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_null.Location = new System.Drawing.Point(131, 359);
            this.btn_null.Margin = new System.Windows.Forms.Padding(2);
            this.btn_null.Name = "btn_null";
            this.btn_null.Size = new System.Drawing.Size(61, 27);
            this.btn_null.TabIndex = 55;
            this.btn_null.Text = "Null(U)";
            this.btn_null.UseVisualStyleBackColor = true;
            this.btn_null.Click += new System.EventHandler(this.btn_null_Click);
            // 
            // btn_getValue
            // 
            this.btn_getValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_getValue.Location = new System.Drawing.Point(202, 369);
            this.btn_getValue.Margin = new System.Windows.Forms.Padding(2);
            this.btn_getValue.Name = "btn_getValue";
            this.btn_getValue.Size = new System.Drawing.Size(209, 27);
            this.btn_getValue.TabIndex = 56;
            this.btn_getValue.Text = "获取唯一值";
            this.btn_getValue.UseVisualStyleBackColor = true;
            this.btn_getValue.Click += new System.EventHandler(this.btn_getValue_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Location = new System.Drawing.Point(131, 492);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(67, 27);
            this.btn_Check.TabIndex = 57;
            this.btn_Check.Text = "验证";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(60, 492);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(67, 27);
            this.btn_clear.TabIndex = 58;
            this.btn_clear.Text = "清除";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 529);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_getValue);
            this.Controls.Add(this.btn_null);
            this.Controls.Add(this.btn_in);
            this.Controls.Add(this.btn_is);
            this.Controls.Add(this.not);
            this.Controls.Add(this.btn_rightbracket);
            this.Controls.Add(this.btn_leftbracket);
            this.Controls.Add(this.btn_string);
            this.Controls.Add(this.btn_char);
            this.Controls.Add(this.or);
            this.Controls.Add(this.and);
            this.Controls.Add(this.like);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.btnLessOrMore);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnMoreOrEqual);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnNotEqual);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SQLTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UniqueValueList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FieldsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LayerList);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_OK);
            this.Name = "Form_Select";
            this.Text = "查找";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button or;
        private System.Windows.Forms.Button and;
        private System.Windows.Forms.Button like;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btnLessOrMore;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnMoreOrEqual;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnNotEqual;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SQLTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox UniqueValueList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FieldsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LayerList;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button btn_char;
        private System.Windows.Forms.Button btn_string;
        private System.Windows.Forms.Button btn_leftbracket;
        private System.Windows.Forms.Button btn_rightbracket;
        private System.Windows.Forms.Button not;
        private System.Windows.Forms.Button btn_is;
        private System.Windows.Forms.Button btn_in;
        private System.Windows.Forms.Button btn_null;
        private System.Windows.Forms.Button btn_getValue;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Button btn_clear;
    }
}