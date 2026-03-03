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
    public partial class Form_Select : Form
    {
        #region 字段

        frmMain father_form = new frmMain();    //父窗口
        private int layer_selectindex;          //第一个列表选中的图层
        private int field_selectindex;          //被选中的字段
        private DataTable dataTable;            //数据表

        #endregion

        #region 构造函数
        public Form_Select(frmMain form)
        {
            InitializeComponent();
            father_form = form;         //连接父窗口
            Load_Layerlist();         //加载图层选择下拉框
            layer_selectindex = -1;     
            field_selectindex = -1;     
        }
        #endregion

        #region 方法
        //重新加载LayerList
        public void Load_Layerlist()
        {
            for(int i=0;i<father_form.moMapControl1.Layers.Count;i++)
            {
                this.LayerList.Items.Add(father_form.moMapControl1.Layers.GetItem(i).Name);
            }
        }

        //重新加载字段显示窗口
        //双引号："\""
        //单引号："\'"
        public void Load_Fieldslist()
        {
            for(int i=0;i<this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).AttributeFields.Count;i++)
            {
                this.FieldsList.Items.Add(this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).AttributeFields.GetItem(i).Name);
            }
        }

        //加载数据表
        public void Load_Database()
        {
            if (layer_selectindex < 0)
            {
                return;
            }
            dataTable = new DataTable();
            MyMapObjects.moMapLayer layer_temp = this.father_form.moMapControl1.Layers.GetItem(layer_selectindex);
            //建立字段
            for (int i = 0; i < layer_temp.AttributeFields.Count; i++) 
            {
                if(layer_temp.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dDouble)
                {
                    dataTable.Columns.Add(layer_temp.AttributeFields.GetItem(i).Name, typeof(double));
                }
                else if(layer_temp.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt16)
                {
                    dataTable.Columns.Add(layer_temp.AttributeFields.GetItem(i).Name, typeof(Int16));
                }
                else if (layer_temp.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt32)
                {
                    dataTable.Columns.Add(layer_temp.AttributeFields.GetItem(i).Name, typeof(Int32));
                }
                else if (layer_temp.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt64)
                {
                    dataTable.Columns.Add(layer_temp.AttributeFields.GetItem(i).Name, typeof(Int64));
                }
                else if (layer_temp.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dSingle)
                {
                    dataTable.Columns.Add(layer_temp.AttributeFields.GetItem(i).Name, typeof(Single));
                }
                else if (layer_temp.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dText)
                {
                    dataTable.Columns.Add(layer_temp.AttributeFields.GetItem(i).Name, typeof(string));
                }
            }
            //按行读取字段数据
            for(int i =0;i<layer_temp.Features.Count;i++)
            {
                dataTable.Rows.Add(layer_temp.Features.GetItem(i).Attributes.ToArray());
            }
        }

        #endregion

        #region 控件事件
        //选中某个图层后
        private void LayerList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            layer_selectindex = this.LayerList.SelectedIndex;   //获取选中图层的索引
            this.UniqueValueList.Items.Clear();                 //清空唯一值框
            this.FieldsList.Items.Clear();                      //清空字段框
            Load_Fieldslist();                                  //重新加载下拉框
            Load_Database();                                    //重新建立数据表
            field_selectindex = -1;                             //清除上次选中字段
        }

        //单击FieldsList,单击一次选中，第二次将字段投到下方SQL语句框
        private void FieldsList_MouseClick(object sender, MouseEventArgs e)
        {
            int index = this.FieldsList.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
                return;
            if (index == field_selectindex)
            {
                //如果第二次选中，则将字段添加到SQL语句框
                this.SQLTextBox.AppendText(this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).AttributeFields.GetItem(field_selectindex).Name + " ");
            }
            else
            {
                //点击第一次选中
                field_selectindex = index;
            }
            this.FieldsList.SelectedIndex = index;
        }

        //双击FieldsList，将字段投到下方SQL语句框
        private void FieldsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.FieldsList.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
            {
                return;
            }
            this.SQLTextBox.AppendText(this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).AttributeFields.GetItem(field_selectindex).Name + " ");
            field_selectindex = index;
            this.FieldsList.SelectedIndex = index;
        }

        //双击唯一值，将文本投到SQL语句框
        private void UniqueValueList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.UniqueValueList.IndexFromPoint(e.Location);
            if (index == System.Windows.Forms.ListBox.NoMatches)
            {
                return;
            }
            this.UniqueValueList.SelectedIndex = index;
            string name = this.UniqueValueList.Items[index].ToString();
            int num = name.LastIndexOf("\"");
            if (num < 0)
            {
                this.SQLTextBox.AppendText(name + " ");
            }
            else
            {
                this.SQLTextBox.AppendText("\'" + name.Substring(1, name.LastIndexOf("\"") - 1) + "\' ");
            }
        }

        #endregion

        #region 按钮
        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("=".ToString() + " ");
        }

        private void btnNotEqual_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("<>".ToString() + " ");
        }

        private void like_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("Like".ToString() + " ");
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText(">".ToString() + " ");
        }

        private void btnMoreOrEqual_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText(">=".ToString() + " ");
        }

        private void and_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("And".ToString() + " ");
        }

        private void btnLess_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("<".ToString() + " ");
        }

        private void btnLessOrMore_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("<=".ToString() + " ");
        }

        private void or_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("Or".ToString() + " ");
        }

        private void btn_char_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("_".ToString() + " ");
        }

        private void btn_string_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("%".ToString() + " ");
        }

        private void btn_leftbracket_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("(".ToString() + " ");
        }

        private void btn_rightbracket_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText(")".ToString() + " ");
        }

        private void not_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("Not".ToString() + " ");
        }

        private void btn_is_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("Is".ToString() + " ");
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("In".ToString() + " ");
        }

        private void btn_null_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.AppendText("Null".ToString() + " ");
        }

        //获取唯一值
        private void btn_getValue_Click(object sender, EventArgs e)
        {
            if (field_selectindex < 0)
                return;
            this.UniqueValueList.Items.Clear();
            MyMapObjects.moMapLayer layer_temp = this.father_form.moMapControl1.Layers.GetItem(layer_selectindex);
            for (int i = 0; i < layer_temp.Features.Count;i++)
            {
                if(layer_temp.AttributeFields.GetItem(field_selectindex).ValueType == MyMapObjects.moValueTypeConstant.dText)
                {
                    UniqueValueList.Items.Add("\"".ToString() + layer_temp.Features.GetItem(i).Attributes.GetItem(field_selectindex).ToString() + "\"");
                }
                else
                {
                    UniqueValueList.Items.Add(layer_temp.Features.GetItem(i).Attributes.GetItem(field_selectindex).ToString());
                }
            }
            for(int i=0;i<UniqueValueList.Items.Count;i++)
            {
                for(int j=i+1;j<UniqueValueList.Items.Count;j++)
                {
                    if (UniqueValueList.Items[i].Equals(UniqueValueList.Items[j]))
                    {
                        UniqueValueList.Items.RemoveAt(j);
                        j--;
                    }
                }
            }
        }

        //清除
        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.SQLTextBox.Clear();
        }

        //验证
        private void btn_Check_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dataRows = dataTable.Select(SQLTextBox.Text.ToString());
                MessageBox.Show("已成功验证表达式");
            }
            catch
            {
                MessageBox.Show("表达式有错误，使用了无效的SQL语句");
            }
        }

        //确定
        private void bt_OK_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dataRows = dataTable.Select(SQLTextBox.Text.ToString());
                this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).SelectedFeatures.Clear();  //清除被选择要素
                if(dataRows.Length>0)
                {
                    for(int i=0;i<dataRows.Length;i++)
                    {
                        //更新被选中数据
                        this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).SelectedFeatures.Add(this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).Features.GetItem(dataTable.Rows.IndexOf(dataRows[i])));
                    }
                    //重新选择绘制要素图层
                    this.father_form.moMapControl1.RedrawTrackingShapes();
                    //更新数据表（未实现）
                    //this.father_form.RedrawAttribute();
                }
                else
                {
                    MessageBox.Show("未查询到任何记录");
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("表达式有错误，使用了无效的SQL语句，请重新输入");
            }
        }
        //应用
        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dataRows = dataTable.Select(SQLTextBox.Text.ToString());
                this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).SelectedFeatures.Clear();  //清除被选择要素
                if (dataRows.Length > 0)
                {
                    for (int i = 0; i < dataRows.Length; i++)
                    {
                        //更新被选中数据
                        this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).SelectedFeatures.Add(this.father_form.moMapControl1.Layers.GetItem(layer_selectindex).Features.GetItem(dataTable.Rows.IndexOf(dataRows[i])));
                    }
                    //重新选择绘制要素图层
                    this.father_form.moMapControl1.RedrawTrackingShapes();
                    //更新数据表（未实现）
                    //this.father_form.RedrawAttribute();
                }
                else
                {
                    MessageBox.Show("未查询到任何记录");
                }
            }
            catch
            {
                MessageBox.Show("表达式有错误，使用了无效的SQL语句，请重新输入");
            }
        }

        //取消
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
