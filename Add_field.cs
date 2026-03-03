using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleGIS
{
    public partial class Add_field : Form
    {
        Form_table form_Table = new Form_table();
        public Add_field()
        {
            InitializeComponent();
        }
        public Add_field(Form_table temp)
        {
            InitializeComponent();
            this.form_Table = temp;
        }

        private void 确认添加_Click(object sender, EventArgs e)
        {
            string type_str = this.comboBox1.SelectedItem.ToString();
            switch (type_str)
            {
                case "Int16":
                    this.form_Table.newfieldtype = MyMapObjects.moValueTypeConstant.dInt16;
                    break;
                case "Int32":
                    this.form_Table.newfieldtype = MyMapObjects.moValueTypeConstant.dInt32;
                    break;
                case "Int64":
                    this.form_Table.newfieldtype = MyMapObjects.moValueTypeConstant.dInt64;
                    break;
                case "Single":
                    this.form_Table.newfieldtype = MyMapObjects.moValueTypeConstant.dSingle;
                    break;
                case "Double":
                    this.form_Table.newfieldtype = MyMapObjects.moValueTypeConstant.dDouble;
                    break;
                case "Text(文本)":
                    this.form_Table.newfieldtype = MyMapObjects.moValueTypeConstant.dText;
                    break;
            }
            this.form_Table.newfieldname = this.textBox1.Text;
            this.form_Table.EnableaddField = true;
            this.form_Table.Addfieldsucess = true;
            this.form_Table.Add_field();
            this.Close();
        }
    }
}
