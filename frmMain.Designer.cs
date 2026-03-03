namespace SimpleGIS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            MyMapObjects.moLayers moLayers1 = new MyMapObjects.moLayers();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出地图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.按属性选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除所选要素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddLayer = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ZoomIn = new System.Windows.Forms.ToolStripButton();
            this.ZoomOut = new System.Windows.Forms.ToolStripButton();
            this.Pan = new System.Windows.Forms.ToolStripButton();
            this.FullExtent = new System.Windows.Forms.ToolStripButton();
            this.SelectFeatures = new System.Windows.Forms.ToolStripButton();
            this.ClearSelectedFeatures = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.EditSpBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.BeginEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EndEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoveFeatureBtn = new System.Windows.Forms.ToolStripButton();
            this.EditPointBtn = new System.Windows.Forms.ToolStripButton();
            this.CreateFeatureBtn = new System.Windows.Forms.ToolStripButton();
            this.SelectLayer = new System.Windows.Forms.ToolStripComboBox();
            this.btnIdentify = new System.Windows.Forms.ToolStripButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssMapScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView_RigthMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移至顶层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移一层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下一一层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移至底层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缩放至图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开属性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为SPGLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图层渲染ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示注记ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moMapRightMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditPointStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.AddPointBtn = new System.Windows.Forms.ToolStripButton();
            this.DelPointBtn = new System.Windows.Forms.ToolStripButton();
            this.MovPointBtn = new System.Windows.Forms.ToolStripButton();
            this.moMapControl1 = new MyMapObjects.moMapControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.treeView_RigthMenu.SuspendLayout();
            this.EditPointStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.选择ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1869, 46);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "菜单栏";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.添加数据ToolStripMenuItem,
            this.导出地图ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(62, 42);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建ToolStripMenuItem.Image")));
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 添加数据ToolStripMenuItem
            // 
            this.添加数据ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加数据ToolStripMenuItem.Image")));
            this.添加数据ToolStripMenuItem.Name = "添加数据ToolStripMenuItem";
            this.添加数据ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.添加数据ToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.添加数据ToolStripMenuItem.Text = "添加数据";
            this.添加数据ToolStripMenuItem.Click += new System.EventHandler(this.添加数据ToolStripMenuItem_Click);
            // 
            // 导出地图ToolStripMenuItem
            // 
            this.导出地图ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导出地图ToolStripMenuItem.Image")));
            this.导出地图ToolStripMenuItem.Name = "导出地图ToolStripMenuItem";
            this.导出地图ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.导出地图ToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.导出地图ToolStripMenuItem.Text = "导出地图";
            this.导出地图ToolStripMenuItem.Click += new System.EventHandler(this.导出地图ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.按属性选择ToolStripMenuItem,
            this.清除所选要素ToolStripMenuItem});
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(62, 42);
            this.选择ToolStripMenuItem.Text = "选择";
            // 
            // 按属性选择ToolStripMenuItem
            // 
            this.按属性选择ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("按属性选择ToolStripMenuItem.Image")));
            this.按属性选择ToolStripMenuItem.Name = "按属性选择ToolStripMenuItem";
            this.按属性选择ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.按属性选择ToolStripMenuItem.Text = "按属性选择";
            this.按属性选择ToolStripMenuItem.Click += new System.EventHandler(this.按属性选择ToolStripMenuItem_Click);
            // 
            // 清除所选要素ToolStripMenuItem
            // 
            this.清除所选要素ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("清除所选要素ToolStripMenuItem.Image")));
            this.清除所选要素ToolStripMenuItem.Name = "清除所选要素ToolStripMenuItem";
            this.清除所选要素ToolStripMenuItem.Size = new System.Drawing.Size(218, 34);
            this.清除所选要素ToolStripMenuItem.Text = "清除所选要素";
            this.清除所选要素ToolStripMenuItem.Click += new System.EventHandler(this.清除所选要素ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(62, 42);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(146, 34);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddLayer,
            this.Save,
            this.toolStripSeparator1,
            this.ZoomIn,
            this.ZoomOut,
            this.Pan,
            this.FullExtent,
            this.SelectFeatures,
            this.ClearSelectedFeatures});
            this.toolStrip1.Location = new System.Drawing.Point(0, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(532, 46);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddLayer
            // 
            this.AddLayer.AutoSize = false;
            this.AddLayer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddLayer.Image = ((System.Drawing.Image)(resources.GetObject("AddLayer.Image")));
            this.AddLayer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddLayer.Name = "AddLayer";
            this.AddLayer.Size = new System.Drawing.Size(26, 20);
            this.AddLayer.Text = "打开（Crtl+O）";
            this.AddLayer.Click += new System.EventHandler(this.AddLayer_Click);
            // 
            // Save
            // 
            this.Save.AutoSize = false;
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(26, 20);
            this.Save.Text = "导出地图（Ctrl+S）";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // ZoomIn
            // 
            this.ZoomIn.AutoSize = false;
            this.ZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("ZoomIn.Image")));
            this.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomIn.Name = "ZoomIn";
            this.ZoomIn.Size = new System.Drawing.Size(26, 20);
            this.ZoomIn.Text = "放大";
            this.ZoomIn.Click += new System.EventHandler(this.ZoomIn_Click);
            // 
            // ZoomOut
            // 
            this.ZoomOut.AutoSize = false;
            this.ZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ZoomOut.Image")));
            this.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomOut.Name = "ZoomOut";
            this.ZoomOut.Size = new System.Drawing.Size(26, 20);
            this.ZoomOut.Text = "缩小";
            this.ZoomOut.Click += new System.EventHandler(this.ZoomOut_Click);
            // 
            // Pan
            // 
            this.Pan.AutoSize = false;
            this.Pan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pan.Image = ((System.Drawing.Image)(resources.GetObject("Pan.Image")));
            this.Pan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pan.Name = "Pan";
            this.Pan.Size = new System.Drawing.Size(26, 20);
            this.Pan.Text = "漫游";
            this.Pan.Click += new System.EventHandler(this.Pan_Click);
            // 
            // FullExtent
            // 
            this.FullExtent.AutoSize = false;
            this.FullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FullExtent.Image = ((System.Drawing.Image)(resources.GetObject("FullExtent.Image")));
            this.FullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FullExtent.Name = "FullExtent";
            this.FullExtent.Size = new System.Drawing.Size(26, 20);
            this.FullExtent.Text = "缩放至全图";
            this.FullExtent.Click += new System.EventHandler(this.FullExtent_Click);
            // 
            // SelectFeatures
            // 
            this.SelectFeatures.AutoSize = false;
            this.SelectFeatures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectFeatures.Image = ((System.Drawing.Image)(resources.GetObject("SelectFeatures.Image")));
            this.SelectFeatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectFeatures.Name = "SelectFeatures";
            this.SelectFeatures.Size = new System.Drawing.Size(26, 20);
            this.SelectFeatures.Text = "选择要素";
            this.SelectFeatures.Click += new System.EventHandler(this.SelectFeatures_Click);
            // 
            // ClearSelectedFeatures
            // 
            this.ClearSelectedFeatures.AutoSize = false;
            this.ClearSelectedFeatures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearSelectedFeatures.Image = ((System.Drawing.Image)(resources.GetObject("ClearSelectedFeatures.Image")));
            this.ClearSelectedFeatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearSelectedFeatures.Name = "ClearSelectedFeatures";
            this.ClearSelectedFeatures.Size = new System.Drawing.Size(26, 20);
            this.ClearSelectedFeatures.Text = "清除所选要素";
            this.ClearSelectedFeatures.Click += new System.EventHandler(this.ClearSelectedFeatures_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditSpBtn,
            this.MoveFeatureBtn,
            this.EditPointBtn,
            this.CreateFeatureBtn,
            this.SelectLayer,
            this.btnIdentify});
            this.toolStrip2.Location = new System.Drawing.Point(412, 46);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip2.Size = new System.Drawing.Size(1456, 46);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // EditSpBtn
            // 
            this.EditSpBtn.AutoSize = false;
            this.EditSpBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BeginEditItem,
            this.EndEditItem,
            this.SaveEditItem});
            this.EditSpBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditSpBtn.Name = "EditSpBtn";
            this.EditSpBtn.Size = new System.Drawing.Size(66, 27);
            this.EditSpBtn.Text = "编辑器";
            // 
            // BeginEditItem
            // 
            this.BeginEditItem.Name = "BeginEditItem";
            this.BeginEditItem.Size = new System.Drawing.Size(182, 34);
            this.BeginEditItem.Text = "开始编辑";
            this.BeginEditItem.Click += new System.EventHandler(this.BeginEditItem_Click);
            // 
            // EndEditItem
            // 
            this.EndEditItem.Name = "EndEditItem";
            this.EndEditItem.Size = new System.Drawing.Size(182, 34);
            this.EndEditItem.Text = "停止编辑";
            this.EndEditItem.Click += new System.EventHandler(this.EndEditItem_Click);
            // 
            // SaveEditItem
            // 
            this.SaveEditItem.Name = "SaveEditItem";
            this.SaveEditItem.Size = new System.Drawing.Size(182, 34);
            this.SaveEditItem.Text = "保存编辑";
            this.SaveEditItem.Click += new System.EventHandler(this.SaveEditItem_Click);
            // 
            // MoveFeatureBtn
            // 
            this.MoveFeatureBtn.AutoSize = false;
            this.MoveFeatureBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MoveFeatureBtn.Enabled = false;
            this.MoveFeatureBtn.Image = ((System.Drawing.Image)(resources.GetObject("MoveFeatureBtn.Image")));
            this.MoveFeatureBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MoveFeatureBtn.Name = "MoveFeatureBtn";
            this.MoveFeatureBtn.Size = new System.Drawing.Size(26, 20);
            this.MoveFeatureBtn.Text = "编辑工具";
            this.MoveFeatureBtn.Click += new System.EventHandler(this.MoveFeatureBtn_Click);
            // 
            // EditPointBtn
            // 
            this.EditPointBtn.AutoSize = false;
            this.EditPointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditPointBtn.Enabled = false;
            this.EditPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("EditPointBtn.Image")));
            this.EditPointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditPointBtn.Name = "EditPointBtn";
            this.EditPointBtn.Size = new System.Drawing.Size(36, 20);
            this.EditPointBtn.Text = "编辑节点";
            this.EditPointBtn.CheckedChanged += new System.EventHandler(this.EditPointBtn_CheckedChanged);
            this.EditPointBtn.Click += new System.EventHandler(this.EditPointBtn_Click);
            // 
            // CreateFeatureBtn
            // 
            this.CreateFeatureBtn.AutoSize = false;
            this.CreateFeatureBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateFeatureBtn.Enabled = false;
            this.CreateFeatureBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateFeatureBtn.Image")));
            this.CreateFeatureBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateFeatureBtn.Name = "CreateFeatureBtn";
            this.CreateFeatureBtn.Size = new System.Drawing.Size(26, 20);
            this.CreateFeatureBtn.Text = "创建要素";
            this.CreateFeatureBtn.Click += new System.EventHandler(this.CreateFeatureBtn_Click);
            // 
            // SelectLayer
            // 
            this.SelectLayer.Enabled = false;
            this.SelectLayer.Name = "SelectLayer";
            this.SelectLayer.Size = new System.Drawing.Size(180, 46);
            this.SelectLayer.Text = "选择图层";
            this.SelectLayer.SelectedIndexChanged += new System.EventHandler(this.SelectLayer_SelectedIndexChanged);
            // 
            // btnIdentify
            // 
            this.btnIdentify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIdentify.Image = ((System.Drawing.Image)(resources.GetObject("btnIdentify.Image")));
            this.btnIdentify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIdentify.Name = "btnIdentify";
            this.btnIdentify.Size = new System.Drawing.Size(34, 41);
            this.btnIdentify.Text = "toolStripButton3";
            this.btnIdentify.Click += new System.EventHandler(this.btnIdentify_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.CheckBoxes = true;
            this.treeView1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView1.Location = new System.Drawing.Point(14, 96);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(386, 950);
            this.treeView1.TabIndex = 5;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCoordinate,
            this.tssMapScale});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1028);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1896, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssCoordinate
            // 
            this.tssCoordinate.AutoSize = false;
            this.tssCoordinate.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssCoordinate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tssCoordinate.Name = "tssCoordinate";
            this.tssCoordinate.Size = new System.Drawing.Size(200, 15);
            // 
            // tssMapScale
            // 
            this.tssMapScale.AutoSize = false;
            this.tssMapScale.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.tssMapScale.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tssMapScale.Name = "tssMapScale";
            this.tssMapScale.Size = new System.Drawing.Size(200, 15);
            // 
            // treeView_RigthMenu
            // 
            this.treeView_RigthMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.treeView_RigthMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移除ToolStripMenuItem,
            this.上移至顶层ToolStripMenuItem,
            this.上移一层ToolStripMenuItem,
            this.下一一层ToolStripMenuItem,
            this.下移至底层ToolStripMenuItem,
            this.缩放至图层ToolStripMenuItem,
            this.打开属性表ToolStripMenuItem,
            this.另存为SPGLToolStripMenuItem,
            this.图层渲染ToolStripMenuItem,
            this.显示注记ToolStripMenuItem});
            this.treeView_RigthMenu.Name = "contextMenuStrip1";
            this.treeView_RigthMenu.Size = new System.Drawing.Size(182, 304);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("移除ToolStripMenuItem.Image")));
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.移除ToolStripMenuItem.Text = "移除";
            this.移除ToolStripMenuItem.Click += new System.EventHandler(this.移除ToolStripMenuItem_Click);
            // 
            // 上移至顶层ToolStripMenuItem
            // 
            this.上移至顶层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上移至顶层ToolStripMenuItem.Image")));
            this.上移至顶层ToolStripMenuItem.Name = "上移至顶层ToolStripMenuItem";
            this.上移至顶层ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.上移至顶层ToolStripMenuItem.Text = "上移至顶层";
            this.上移至顶层ToolStripMenuItem.Click += new System.EventHandler(this.上移至顶层ToolStripMenuItem_Click);
            // 
            // 上移一层ToolStripMenuItem
            // 
            this.上移一层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上移一层ToolStripMenuItem.Image")));
            this.上移一层ToolStripMenuItem.Name = "上移一层ToolStripMenuItem";
            this.上移一层ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.上移一层ToolStripMenuItem.Text = "上移一层";
            this.上移一层ToolStripMenuItem.Click += new System.EventHandler(this.上移一层ToolStripMenuItem_Click);
            // 
            // 下一一层ToolStripMenuItem
            // 
            this.下一一层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("下一一层ToolStripMenuItem.Image")));
            this.下一一层ToolStripMenuItem.Name = "下一一层ToolStripMenuItem";
            this.下一一层ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.下一一层ToolStripMenuItem.Text = "下移一层";
            this.下一一层ToolStripMenuItem.Click += new System.EventHandler(this.下一一层ToolStripMenuItem_Click);
            // 
            // 下移至底层ToolStripMenuItem
            // 
            this.下移至底层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("下移至底层ToolStripMenuItem.Image")));
            this.下移至底层ToolStripMenuItem.Name = "下移至底层ToolStripMenuItem";
            this.下移至底层ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.下移至底层ToolStripMenuItem.Text = "下移至底层";
            this.下移至底层ToolStripMenuItem.Click += new System.EventHandler(this.下移至底层ToolStripMenuItem_Click);
            // 
            // 缩放至图层ToolStripMenuItem
            // 
            this.缩放至图层ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("缩放至图层ToolStripMenuItem.Image")));
            this.缩放至图层ToolStripMenuItem.Name = "缩放至图层ToolStripMenuItem";
            this.缩放至图层ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.缩放至图层ToolStripMenuItem.Text = "缩放至图层";
            this.缩放至图层ToolStripMenuItem.Click += new System.EventHandler(this.缩放至图层ToolStripMenuItem_Click);
            // 
            // 打开属性表ToolStripMenuItem
            // 
            this.打开属性表ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开属性表ToolStripMenuItem.Image")));
            this.打开属性表ToolStripMenuItem.Name = "打开属性表ToolStripMenuItem";
            this.打开属性表ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.打开属性表ToolStripMenuItem.Text = "打开属性表";
            this.打开属性表ToolStripMenuItem.Click += new System.EventHandler(this.打开属性表ToolStripMenuItem_Click);
            // 
            // 另存为SPGLToolStripMenuItem
            // 
            this.另存为SPGLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("另存为SPGLToolStripMenuItem.Image")));
            this.另存为SPGLToolStripMenuItem.Name = "另存为SPGLToolStripMenuItem";
            this.另存为SPGLToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.另存为SPGLToolStripMenuItem.Text = "另存为SPGL";
            this.另存为SPGLToolStripMenuItem.Click += new System.EventHandler(this.另存为SPGLToolStripMenuItem_Click);
            // 
            // 图层渲染ToolStripMenuItem
            // 
            this.图层渲染ToolStripMenuItem.Name = "图层渲染ToolStripMenuItem";
            this.图层渲染ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.图层渲染ToolStripMenuItem.Text = "图层渲染";
            this.图层渲染ToolStripMenuItem.Click += new System.EventHandler(this.图层渲染ToolStripMenuItem_Click);
            // 
            // 显示注记ToolStripMenuItem
            // 
            this.显示注记ToolStripMenuItem.Name = "显示注记ToolStripMenuItem";
            this.显示注记ToolStripMenuItem.Size = new System.Drawing.Size(181, 30);
            this.显示注记ToolStripMenuItem.Text = "显示注记";
            this.显示注记ToolStripMenuItem.Click += new System.EventHandler(this.显示注记ToolStripMenuItem_Click);
            // 
            // moMapRightMenu
            // 
            this.moMapRightMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.moMapRightMenu.Name = "moMapRightMenu";
            this.moMapRightMenu.Size = new System.Drawing.Size(61, 4);
            this.moMapRightMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.moMapRightMenu_ItemClicked);
            this.moMapRightMenu.VisibleChanged += new System.EventHandler(this.moMapRightMenu_VisibleChanged);
            // 
            // EditPointStrip
            // 
            this.EditPointStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.EditPointStrip.Enabled = false;
            this.EditPointStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.EditPointStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.EditPointStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.AddPointBtn,
            this.DelPointBtn,
            this.MovPointBtn});
            this.EditPointStrip.Location = new System.Drawing.Point(956, 46);
            this.EditPointStrip.Name = "EditPointStrip";
            this.EditPointStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.EditPointStrip.Size = new System.Drawing.Size(87, 29);
            this.EditPointStrip.TabIndex = 8;
            this.EditPointStrip.Text = "toolStrip3";
            this.EditPointStrip.Visible = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(82, 24);
            this.toolStripLabel1.Text = "编辑节点";
            // 
            // AddPointBtn
            // 
            this.AddPointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddPointBtn.Enabled = false;
            this.AddPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddPointBtn.Image")));
            this.AddPointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddPointBtn.Name = "AddPointBtn";
            this.AddPointBtn.Size = new System.Drawing.Size(34, 24);
            this.AddPointBtn.Text = "增加节点";
            this.AddPointBtn.Visible = false;
            this.AddPointBtn.Click += new System.EventHandler(this.AddPointBtn_Click);
            // 
            // DelPointBtn
            // 
            this.DelPointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelPointBtn.Enabled = false;
            this.DelPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("DelPointBtn.Image")));
            this.DelPointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelPointBtn.Name = "DelPointBtn";
            this.DelPointBtn.Size = new System.Drawing.Size(34, 24);
            this.DelPointBtn.Text = "删除节点";
            this.DelPointBtn.Visible = false;
            this.DelPointBtn.Click += new System.EventHandler(this.DeletePointBtn_Click);
            // 
            // MovPointBtn
            // 
            this.MovPointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MovPointBtn.Enabled = false;
            this.MovPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("MovPointBtn.Image")));
            this.MovPointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MovPointBtn.Name = "MovPointBtn";
            this.MovPointBtn.Size = new System.Drawing.Size(34, 24);
            this.MovPointBtn.Text = "移动节点";
            this.MovPointBtn.Visible = false;
            this.MovPointBtn.Click += new System.EventHandler(this.MovePointBtn_Click);
            // 
            // moMapControl1
            // 
            this.moMapControl1.BackColor = System.Drawing.Color.White;
            this.moMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.moMapControl1.ContextMenuStrip = this.moMapRightMenu;
            this.moMapControl1.FlashColor = System.Drawing.Color.Green;
            this.moMapControl1.Layers = moLayers1;
            this.moMapControl1.Location = new System.Drawing.Point(412, 96);
            this.moMapControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.moMapControl1.Name = "moMapControl1";
            this.moMapControl1.SelectionColor = System.Drawing.Color.Cyan;
            this.moMapControl1.Size = new System.Drawing.Size(1454, 950);
            this.moMapControl1.TabIndex = 6;
            this.moMapControl1.MapScaleChanged += new MyMapObjects.moMapControl.MapScaleChangedHandle(this.moMapControl1_MapScaleChanged);
            this.moMapControl1.AfterTrackingLayerDraw += new MyMapObjects.moMapControl.AfterTrackingLayerDrawHandle(this.moMapControl1_AfterTrackingLayerDraw);
            this.moMapControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.moMapControl1_MouseClick);
            this.moMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.moMapControl1_MouseDoubleClick);
            this.moMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moMapControl1_MouseDown);
            this.moMapControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.moMapControl1_MouseMove);
            this.moMapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.moMapControl1_MouseUp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1050);
            this.Controls.Add(this.EditPointStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.moMapControl1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "SimpleGIS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.treeView_RigthMenu.ResumeLayout(false);
            this.EditPointStrip.ResumeLayout(false);
            this.EditPointStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddLayer;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ZoomIn;
        private System.Windows.Forms.ToolStripButton ZoomOut;
        private System.Windows.Forms.ToolStripButton Pan;
        private System.Windows.Forms.ToolStripButton FullExtent;
        private System.Windows.Forms.ToolStripButton SelectFeatures;
        private System.Windows.Forms.ToolStripButton ClearSelectedFeatures;
        private System.Windows.Forms.ToolStripSplitButton EditSpBtn;
        private System.Windows.Forms.ToolStripButton MoveFeatureBtn;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出地图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 按属性选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除所选要素ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssCoordinate;
        private System.Windows.Forms.ToolStripStatusLabel tssMapScale;
        private System.Windows.Forms.ContextMenuStrip treeView_RigthMenu;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移至顶层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上移一层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下一一层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移至底层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缩放至图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开属性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为SPGLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BeginEditItem;
        private System.Windows.Forms.ToolStripMenuItem EndEditItem;
        private System.Windows.Forms.ToolStripButton CreateFeatureBtn;
        private System.Windows.Forms.ToolStripComboBox SelectLayer;
        private System.Windows.Forms.ToolStripButton btnIdentify;
        private System.Windows.Forms.ToolStripMenuItem SaveEditItem;
        private System.Windows.Forms.ToolStripMenuItem 图层渲染ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示注记ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip moMapRightMenu;
        private System.Windows.Forms.ToolStrip EditPointStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton AddPointBtn;
        private System.Windows.Forms.ToolStripButton DelPointBtn;
        private System.Windows.Forms.ToolStripButton MovPointBtn;
        private System.Windows.Forms.ToolStripButton EditPointBtn;
        public MyMapObjects.moMapControl moMapControl1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}

