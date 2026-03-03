using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SimpleGIS
{
    public partial class Form_table : Form
    {
        #region 字段
        public int Windows_index;
        public MyMapObjects.moMapLayer layer_show;
        public int select_index;
        private int field_delete_index;
        public string newfieldname;
        public MyMapObjects.moValueTypeConstant newfieldtype;
        private bool EnablechangeArribute;
        public bool EnableaddField;
        private bool Select_delete_able;
        private bool Arributesave;
        private bool Fieldaddsave;
        private bool Fielddelsave;
        private bool Show_select;
        public bool Addfieldsucess;
        private DataTable dataTable;
        private DataTable dataTable_select;
        frmMain father_form = new frmMain();
        private delegate void myInvoke();
        #endregion
        #region 构造函数
        public Form_table(frmMain temp,int index)
        {
            InitializeComponent();
            select_index = index;
            layer_show = temp.moMapControl1.Layers.GetItem(index);
            this.father_form = temp;
            EnablechangeArribute = false;
            EnableaddField = false;
            attributeView.ReadOnly = true;
            Select_delete_able = false;
            Arributesave = false;
            Fieldaddsave = false;
            Fielddelsave = false;
            EnableaddField = false;
            field_delete_index = -1;
            Load_frame();
            this.Nameshow.Text = layer_show.Name;
        }
        public Form_table()
        {
            InitializeComponent();
        }
        #endregion
        #region 方法
        //
        /// <summary>
        /// 每次调用都开一个全新线程
        /// </summary>
        public void refresh()
        {
            Thread thread = new Thread(Invokework);
            thread.Start();
        }

        /// <summary>
        /// 合理使用invoke的函数
        /// </summary>
        public void Invokework()
        {
            myInvoke mission = new myInvoke(Load_frame);
            this.BeginInvoke(mission);
        }

        /// <summary>
        /// 加载图表的方法，每次刷新图层都需要重新调用一下这个方法
        /// </summary>
        public void Load_frame()
        {
            if (Show_select)
            {
                dataTable_select = new DataTable();
                attributeView.DataSource = null;
                attributeView.DataSource = dataTable_select;
                for (Int32 i = 0; i < layer_show.AttributeFields.Count; i++)
                {
                    if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dDouble)
                        dataTable_select.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(double));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt16)
                        dataTable_select.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Int16));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt32)
                        dataTable_select.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Int32));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt64)
                        dataTable_select.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Int64));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dSingle)
                        dataTable_select.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Single));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dText)
                        dataTable_select.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(string));
                    attributeView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                for (Int32 i = layer_show.SelectedFeatures.Count - 1; i >= 0; i--)
                    dataTable_select.Rows.Add(layer_show.SelectedFeatures.GetItem(i).Attributes.ToArray());
                attributeView.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                attributeView.DefaultCellStyle.SelectionForeColor = Color.LightGoldenrodYellow;
            }
            else
            {
                dataTable = new DataTable();
                attributeView.DataSource = null;
                attributeView.DataSource = dataTable;
                for (Int32 i = 0; i < layer_show.AttributeFields.Count; i++)
                {
                    if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dDouble)
                        dataTable.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(double));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt16)
                        dataTable.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Int16));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt32)
                        dataTable.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Int32));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dInt64)
                        dataTable.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Int64));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dSingle)
                        dataTable.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(Single));
                    else if (layer_show.AttributeFields.GetItem(i).ValueType == MyMapObjects.moValueTypeConstant.dText)
                        dataTable.Columns.Add(layer_show.AttributeFields.GetItem(i).Name, typeof(string));
                    attributeView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                for (Int32 i = 0; i < layer_show.Features.Count; i++)
                    dataTable.Rows.Add(layer_show.Features.GetItem(i).Attributes.ToArray());
                attributeView.DefaultCellStyle.BackColor = Color.White;
                attributeView.DefaultCellStyle.SelectionForeColor = Color.LightGoldenrodYellow;
                Refresh_dataform_select();
            }
        }


        /// <summary>
        /// 添加字段的方法
        /// </summary>
        public void Add_field()
        {
            if (EnableaddField == false)
                return;
            MyMapObjects.moField moFieldtemp = new MyMapObjects.moField(newfieldname, newfieldtype);
            MyMapObjects.moAttributes moAttributestemp = new MyMapObjects.moAttributes();
            List<object> temp_array = new List<object>();
            for (int i = 0; i < this.father_form.moMapControl1.Layers.GetItem(select_index).Features.Count; i++)
                temp_array.Add(0);
            moAttributestemp.FromArray(temp_array.ToArray());
            this.father_form.mDBFFiles[select_index].CreateField(moFieldtemp, moAttributestemp);
            layer_show = this.father_form.moMapControl1.Layers.GetItem(select_index);
            Fieldaddsave = true;
            refresh();
            EnableaddField = false;
        }
        /// <summary>
        /// 更新标签
        /// </summary>
        public void Refresh_scaletext_select()
        {
            this.Scaleshow.Text = (attributeView.SelectedRows.Count.ToString() + " / " + attributeView.Rows.Count.ToString() + "已选择");
        }


        /// <summary>
        /// 更新本窗体内的显示，由图表更改属性表
        /// </summary>
        public void Refresh_dataform_select()
        {
            int index = -1;
            int[] selected = new int[layer_show.Features.Count];
            for (int i = 0; i < layer_show.Features.Count; i++) 
            {
                selected[i] = -1;
            }
            for (int i = 0; i < layer_show.SelectedFeatures.Count; i++)
            {
                index = layer_show.Features.Find(layer_show.SelectedFeatures.GetItem(i));
                selected[index] = 0;
                //attributeView.Rows[index].Selected = true;
            }
            for(int i=0;i<layer_show.Features.Count;i++)
            {
                if (selected[i] == 0)
                {
                    attributeView.Rows[i].Selected = true;
                }
                else
                {
                    attributeView.Rows[i].Selected = false;
                }
            }
            Refresh_scaletext_select();
        }

        /// <summary>
        /// 更新main窗体内的显示,由选中行更改图标
        /// </summary>
        public void Refresh_mainform_select()
        {
            layer_show.SelectedFeatures.Clear();
            for (int i = 0; i < attributeView.SelectedRows.Count; i++)
                layer_show.SelectedFeatures.Add(layer_show.Features.GetItem(attributeView.SelectedRows[i].HeaderCell.RowIndex));
            this.father_form.moMapControl1.RedrawTrackingShapes();
            Refresh_scaletext_select();
        }
        #endregion
        #region 窗体和按钮处理
        private void 开始编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Show_select)
            {
                MessageBox.Show("部分字段显示模式下不可编辑");
                return;
            }
            if (EnablechangeArribute == true)
                return;
            EnablechangeArribute = true;
            attributeView.ReadOnly = false;
            MessageBox.Show("您已经可以开始编辑属性数据，单击选择需要修改的属性数据后，双击即可开始编辑");
        }

        private void 停止编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Show_select)
            {
                MessageBox.Show("部分字段显示模式下不可编辑");
                return;
            }
            if (EnablechangeArribute == false)
                return;
            EnablechangeArribute = false;
            attributeView.ReadOnly = true;
            MessageBox.Show("编辑已停止，但是如果不进行保存则无法保存至文件");
        }

        private void 增加字段ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Show_select)
            {
                MessageBox.Show("部分字段显示模式下不可添加字段");
                return;
            }
            if (EnablechangeArribute == true)
            {
                MessageBox.Show("请退出属性编辑模式后再进行尝试");
                return;
            }
            Add_field add_Field = new Add_field(this);
            add_Field.Show();
        }

        private void 全部选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Show_select)
            {
                MessageBox.Show("部分字段显示模式下不可操作");
                return;
            }
            for (int i = 0; i < attributeView.Rows.Count; i++)
                attributeView.Rows[i].Selected = true;
            this.Refresh_mainform_select();
        }

        private void 取消选择ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Show_select)
            {
                MessageBox.Show("部分字段显示模式下不可操作");
                return;
            }
            else
            {
                for (int i = 0; i < attributeView.Rows.Count; i++)
                    attributeView.Rows[i].Selected = false;
                this.Refresh_mainform_select();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Show_select == false)
                return;
            Show_select = false;
            refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Show_select == true)
                return;
            Show_select = true;
            refresh();
        }

        private void 保存编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Arributesave == true)
            {
                List<MyMapObjects.moAttributes> newattributeslist = new List<MyMapObjects.moAttributes>();
                for (int i = 0; i < this.father_form.moMapControl1.Layers.GetItem(select_index).Features.Count; i++)
                    newattributeslist.Add(layer_show.Features.GetItem(i).Attributes);
                this.father_form.mDBFFiles[select_index].UpdateAttributesList(newattributeslist);
            }
            this.father_form.mDBFFiles[select_index].SaveToFile();
            MessageBox.Show("保存成功");
        }

        private void 删除字段ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Show_select)
            {
                MessageBox.Show("部分字段显示模式下不可删除字段");
                return;
            }
            if (EnablechangeArribute == true)
            {
                MessageBox.Show("请退出属性编辑模式后再进行尝试");
                return;
            }
            if (Select_delete_able == false)
            {
                MessageBox.Show("请选择需要删除的字段");
                return;
            }
            this.father_form.mDBFFiles[select_index].DeleteField(field_delete_index);
            layer_show = this.father_form.moMapControl1.Layers.GetItem(select_index);
            Select_delete_able = false;
            field_delete_index = -1;
            MessageBox.Show("字段已成功删除");
            refresh();
        }

        private void attributeView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (EnablechangeArribute == true)
            {
                if (field_delete_index >= 0)
                    attributeView.Columns[field_delete_index].DefaultCellStyle.BackColor = Color.White;
                attributeView.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                field_delete_index = e.ColumnIndex;
                return;
            }
            if (field_delete_index != e.ColumnIndex && field_delete_index >= 0)
            {
                attributeView.Columns[field_delete_index].DefaultCellStyle.BackColor = Color.White;
                attributeView.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                field_delete_index = e.ColumnIndex;
                Select_delete_able = true;
            }
            else if (field_delete_index < 0)
            {
                attributeView.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
                field_delete_index = e.ColumnIndex;
                Select_delete_able = true;
            }
        }

        private void attributeView_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            this.father_form.moMapControl1.Layers.GetItem(select_index).Features.GetItem(row).Attributes.SetItem(col, e.Value);
            layer_show = this.father_form.moMapControl1.Layers.GetItem(select_index);
            Arributesave = true;
            refresh();
        }

        private void attributeView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Show_select)
                return;
            attributeView.Rows[e.RowIndex].Selected = true;
            this.Refresh_mainform_select();
        }

        private void attributeView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Show_select)
                return;
            if (e.ColumnIndex < 0)
                this.Refresh_mainform_select();
        }

        private void Form_table_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < this.father_form.All_tables.Count; i++)
            {
                if (this.father_form.All_tables[i].Windows_index == this.Windows_index)
                {
                    father_form.All_tables.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion
    }
}
