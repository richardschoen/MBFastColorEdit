namespace MbFastColorEdit
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboLanguage = new System.Windows.Forms.ComboBox();
            this.buttonNewFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonCloseFile = new System.Windows.Forms.Button();
            this.buttonDecreaseFontSize = new System.Windows.Forms.Button();
            this.buttonIncreaseFontSize = new System.Windows.Forms.Button();
            this.buttonReplaceText = new System.Windows.Forms.Button();
            this.buttonFindText = new System.Windows.Forms.Button();
            this.buttonSaveLocalSourceMemberFile = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fastText1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastText1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            this.toolStripSeparator1.Visible = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Visible = false;
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPreviewToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 22);
            this.toolsToolStripMenuItem.Text = "&Tools";
            this.toolsToolStripMenuItem.Visible = false;
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Visible = false;
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            this.indexToolStripMenuItem.Visible = false;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            this.searchToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            this.toolStripSeparator5.Visible = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboLanguage);
            this.panel1.Controls.Add(this.buttonNewFile);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Controls.Add(this.buttonCloseFile);
            this.panel1.Controls.Add(this.buttonDecreaseFontSize);
            this.panel1.Controls.Add(this.buttonIncreaseFontSize);
            this.panel1.Controls.Add(this.buttonReplaceText);
            this.panel1.Controls.Add(this.buttonFindText);
            this.panel1.Controls.Add(this.buttonSaveLocalSourceMemberFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 61);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Language";
            // 
            // comboLanguage
            // 
            this.comboLanguage.FormattingEnabled = true;
            this.comboLanguage.Items.AddRange(new object[] {
            "Custom",
            "CS",
            "HTML",
            "JSON",
            "JS",
            "LUA",
            "PHP",
            "SQL",
            "VB",
            "XML"});
            this.comboLanguage.Location = new System.Drawing.Point(393, 21);
            this.comboLanguage.Name = "comboLanguage";
            this.comboLanguage.Size = new System.Drawing.Size(121, 23);
            this.comboLanguage.TabIndex = 9;
            this.comboLanguage.TabStop = false;
            this.comboLanguage.Text = "Custom";
            this.comboLanguage.SelectedValueChanged += new System.EventHandler(this.comboLanguage_SelectedValueChanged);
            this.comboLanguage.TextChanged += new System.EventHandler(this.comboLanguage_TextChanged);
            // 
            // buttonNewFile
            // 
            this.buttonNewFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonNewFile.Image")));
            this.buttonNewFile.Location = new System.Drawing.Point(10, 14);
            this.buttonNewFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonNewFile.Name = "buttonNewFile";
            this.buttonNewFile.Size = new System.Drawing.Size(41, 33);
            this.buttonNewFile.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonNewFile, "Save file");
            this.buttonNewFile.UseVisualStyleBackColor = true;
            this.buttonNewFile.Click += new System.EventHandler(this.buttonNewFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(56, 14);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(41, 33);
            this.buttonOpenFile.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Save file");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonCloseFile
            // 
            this.buttonCloseFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseFile.Image")));
            this.buttonCloseFile.Location = new System.Drawing.Point(102, 14);
            this.buttonCloseFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonCloseFile.Name = "buttonCloseFile";
            this.buttonCloseFile.Size = new System.Drawing.Size(41, 33);
            this.buttonCloseFile.TabIndex = 3;
            this.toolTip1.SetToolTip(this.buttonCloseFile, "Save file");
            this.buttonCloseFile.UseVisualStyleBackColor = true;
            this.buttonCloseFile.Click += new System.EventHandler(this.buttonCloseFile_Click);
            // 
            // buttonDecreaseFontSize
            // 
            this.buttonDecreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecreaseFontSize.Image")));
            this.buttonDecreaseFontSize.Location = new System.Drawing.Point(333, 14);
            this.buttonDecreaseFontSize.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonDecreaseFontSize.Name = "buttonDecreaseFontSize";
            this.buttonDecreaseFontSize.Size = new System.Drawing.Size(41, 33);
            this.buttonDecreaseFontSize.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buttonDecreaseFontSize, "Decrease font size");
            this.buttonDecreaseFontSize.UseVisualStyleBackColor = true;
            this.buttonDecreaseFontSize.Click += new System.EventHandler(this.buttonDecreaseFontSize_Click);
            // 
            // buttonIncreaseFontSize
            // 
            this.buttonIncreaseFontSize.Image = ((System.Drawing.Image)(resources.GetObject("buttonIncreaseFontSize.Image")));
            this.buttonIncreaseFontSize.Location = new System.Drawing.Point(287, 14);
            this.buttonIncreaseFontSize.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonIncreaseFontSize.Name = "buttonIncreaseFontSize";
            this.buttonIncreaseFontSize.Size = new System.Drawing.Size(41, 33);
            this.buttonIncreaseFontSize.TabIndex = 7;
            this.toolTip1.SetToolTip(this.buttonIncreaseFontSize, "Increase font size");
            this.buttonIncreaseFontSize.UseVisualStyleBackColor = true;
            this.buttonIncreaseFontSize.Click += new System.EventHandler(this.buttonIncreaseFontSize_Click);
            // 
            // buttonReplaceText
            // 
            this.buttonReplaceText.Image = ((System.Drawing.Image)(resources.GetObject("buttonReplaceText.Image")));
            this.buttonReplaceText.Location = new System.Drawing.Point(241, 14);
            this.buttonReplaceText.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonReplaceText.Name = "buttonReplaceText";
            this.buttonReplaceText.Size = new System.Drawing.Size(41, 33);
            this.buttonReplaceText.TabIndex = 6;
            this.toolTip1.SetToolTip(this.buttonReplaceText, "Replace text");
            this.buttonReplaceText.UseVisualStyleBackColor = true;
            this.buttonReplaceText.Click += new System.EventHandler(this.buttonReplaceText_Click);
            // 
            // buttonFindText
            // 
            this.buttonFindText.Image = ((System.Drawing.Image)(resources.GetObject("buttonFindText.Image")));
            this.buttonFindText.Location = new System.Drawing.Point(195, 14);
            this.buttonFindText.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonFindText.Name = "buttonFindText";
            this.buttonFindText.Size = new System.Drawing.Size(41, 33);
            this.buttonFindText.TabIndex = 5;
            this.toolTip1.SetToolTip(this.buttonFindText, "Find text ");
            this.buttonFindText.UseVisualStyleBackColor = true;
            this.buttonFindText.Click += new System.EventHandler(this.buttonFindText_Click);
            // 
            // buttonSaveLocalSourceMemberFile
            // 
            this.buttonSaveLocalSourceMemberFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveLocalSourceMemberFile.Image")));
            this.buttonSaveLocalSourceMemberFile.Location = new System.Drawing.Point(149, 14);
            this.buttonSaveLocalSourceMemberFile.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.buttonSaveLocalSourceMemberFile.Name = "buttonSaveLocalSourceMemberFile";
            this.buttonSaveLocalSourceMemberFile.Size = new System.Drawing.Size(41, 33);
            this.buttonSaveLocalSourceMemberFile.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonSaveLocalSourceMemberFile, "Save file");
            this.buttonSaveLocalSourceMemberFile.UseVisualStyleBackColor = true;
            this.buttonSaveLocalSourceMemberFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 707);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 85);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 622);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fastText1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPage1.Size = new System.Drawing.Size(1000, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fastText1
            // 
            this.fastText1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastText1.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastText1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastText1.BackBrush = null;
            this.fastText1.CharHeight = 14;
            this.fastText1.CharWidth = 8;
            this.fastText1.DefaultMarkerSize = 8;
            this.fastText1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastText1.IsReplaceMode = false;
            this.fastText1.Location = new System.Drawing.Point(2, 1);
            this.fastText1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.fastText1.Name = "fastText1";
            this.fastText1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastText1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastText1.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastText1.ServiceColors")));
            this.fastText1.Size = new System.Drawing.Size(996, 592);
            this.fastText1.TabIndex = 1;
            this.fastText1.Zoom = 100;
            this.fastText1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastText1_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fast Colored Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastText1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Button buttonDecreaseFontSize;
        private Button buttonIncreaseFontSize;
        private Button buttonReplaceText;
        private Button buttonFindText;
        private Button buttonSaveLocalSourceMemberFile;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private FastColoredTextBoxNS.FastColoredTextBox fastText1;
        private Button buttonNewFile;
        private Button buttonOpenFile;
        private Button buttonCloseFile;
        private Label label1;
        private ComboBox comboLanguage;
    }
}