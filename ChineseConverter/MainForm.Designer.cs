﻿namespace SimplifiedTraditionalConverter
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpConvertMethod = new System.Windows.Forms.GroupBox();
            this.chkIsConvertFileName = new System.Windows.Forms.CheckBox();
            this.cboConvertMethod = new System.Windows.Forms.ComboBox();
            this.grpConvertType = new System.Windows.Forms.GroupBox();
            this.cboConvertType = new System.Windows.Forms.ComboBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFileExt = new System.Windows.Forms.TextBox();
            this.lblFileExt = new System.Windows.Forms.Label();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.grpDest = new System.Windows.Forms.GroupBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestoreConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.grpSaveEncoding = new System.Windows.Forms.GroupBox();
            this.cboSaveEncoding = new System.Windows.Forms.ComboBox();
            this.chkIsTopMost = new System.Windows.Forms.CheckBox();
            this.chkIsExclude = new System.Windows.Forms.CheckBox();
            this.grpRegex = new System.Windows.Forms.GroupBox();
            this.btnRegexClear = new System.Windows.Forms.Button();
            this.cboRegex = new System.Windows.Forms.ComboBox();
            this.btnRegexHelp = new System.Windows.Forms.Button();
            this.ttpCommon = new System.Windows.Forms.ToolTip(this.components);
            this.cboReadEncoding = new System.Windows.Forms.ComboBox();
            this.lblFileEncoding = new System.Windows.Forms.Label();
            this.lblReadEncoding = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.grpConvertMethod.SuspendLayout();
            this.grpConvertType.SuspendLayout();
            this.grpDest.SuspendLayout();
            this.grpSource.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.grpSaveEncoding.SuspendLayout();
            this.grpRegex.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConvertMethod
            // 
            this.grpConvertMethod.Controls.Add(this.chkIsConvertFileName);
            this.grpConvertMethod.Controls.Add(this.cboConvertMethod);
            this.grpConvertMethod.Location = new System.Drawing.Point(140, 28);
            this.grpConvertMethod.Name = "grpConvertMethod";
            this.grpConvertMethod.Size = new System.Drawing.Size(197, 44);
            this.grpConvertMethod.TabIndex = 2;
            this.grpConvertMethod.TabStop = false;
            this.grpConvertMethod.Text = "转换方式";
            // 
            // chkIsConvertFileName
            // 
            this.chkIsConvertFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsConvertFileName.AutoSize = true;
            this.chkIsConvertFileName.Location = new System.Drawing.Point(107, 19);
            this.chkIsConvertFileName.Name = "chkIsConvertFileName";
            this.chkIsConvertFileName.Size = new System.Drawing.Size(84, 16);
            this.chkIsConvertFileName.TabIndex = 1;
            this.chkIsConvertFileName.Text = "转换文件名";
            this.ttpCommon.SetToolTip(this.chkIsConvertFileName, "设置是否对文件名进行简繁转换");
            this.chkIsConvertFileName.UseVisualStyleBackColor = true;
            this.chkIsConvertFileName.CheckedChanged += new System.EventHandler(this.chkIsConvertFileName_CheckedChanged);
            // 
            // cboConvertMethod
            // 
            this.cboConvertMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboConvertMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvertMethod.FormattingEnabled = true;
            this.cboConvertMethod.Items.AddRange(new object[] {
            "转换文档",
            "转换文本"});
            this.cboConvertMethod.Location = new System.Drawing.Point(6, 17);
            this.cboConvertMethod.Name = "cboConvertMethod";
            this.cboConvertMethod.Size = new System.Drawing.Size(95, 20);
            this.cboConvertMethod.TabIndex = 0;
            this.cboConvertMethod.SelectedIndexChanged += new System.EventHandler(this.cboConvertMethod_SelectedIndexChanged);
            // 
            // grpConvertType
            // 
            this.grpConvertType.Controls.Add(this.cboConvertType);
            this.grpConvertType.Location = new System.Drawing.Point(12, 28);
            this.grpConvertType.Name = "grpConvertType";
            this.grpConvertType.Size = new System.Drawing.Size(122, 44);
            this.grpConvertType.TabIndex = 1;
            this.grpConvertType.TabStop = false;
            this.grpConvertType.Text = "转换类型";
            // 
            // cboConvertType
            // 
            this.cboConvertType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboConvertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConvertType.FormattingEnabled = true;
            this.cboConvertType.Items.AddRange(new object[] {
            "转换为简体",
            "转换为繁体",
            "转换为火星文"});
            this.cboConvertType.Location = new System.Drawing.Point(6, 17);
            this.cboConvertType.Name = "cboConvertType";
            this.cboConvertType.Size = new System.Drawing.Size(110, 20);
            this.cboConvertType.TabIndex = 0;
            this.ttpCommon.SetToolTip(this.cboConvertType, "设置转换类型 (简繁互转、简繁转换为火星文)");
            this.cboConvertType.SelectedIndexChanged += new System.EventHandler(this.cboConvertType_SelectedIndexChanged);
            // 
            // lblFilePath
            // 
            this.lblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFilePath.AutoEllipsis = true;
            this.lblFilePath.Location = new System.Drawing.Point(12, 582);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(761, 12);
            this.lblFilePath.TabIndex = 16;
            // 
            // txtFileExt
            // 
            this.txtFileExt.Location = new System.Drawing.Point(693, 80);
            this.txtFileExt.MaxLength = 255;
            this.txtFileExt.Name = "txtFileExt";
            this.txtFileExt.Size = new System.Drawing.Size(80, 21);
            this.txtFileExt.TabIndex = 11;
            this.txtFileExt.Text = ".convert";
            this.ttpCommon.SetToolTip(this.txtFileExt, "另存为时，在原文件名和扩展名之间添加指定的后缀名");
            // 
            // lblFileExt
            // 
            this.lblFileExt.AutoSize = true;
            this.lblFileExt.Location = new System.Drawing.Point(634, 83);
            this.lblFileExt.Name = "lblFileExt";
            this.lblFileExt.Size = new System.Drawing.Size(53, 12);
            this.lblFileExt.TabIndex = 10;
            this.lblFileExt.Text = "后缀名：";
            this.ttpCommon.SetToolTip(this.lblFileExt, "另存为时，在原文件名和扩展名之间添加指定的后缀名");
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(545, 77);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(83, 25);
            this.btnSaveAs.TabIndex = 9;
            this.btnSaveAs.Text = "另存为";
            this.ttpCommon.SetToolTip(this.btnSaveAs, "快捷键：Ctrl+Shift+S");
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(456, 77);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存(覆盖)";
            this.ttpCommon.SetToolTip(this.btnSave, "快捷键：Ctrl+S");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(378, 303);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(29, 45);
            this.btnConvert.TabIndex = 13;
            this.btnConvert.Text = ">>";
            this.ttpCommon.SetToolTip(this.btnConvert, "简繁转换，快捷键：Ctrl+T");
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // grpDest
            // 
            this.grpDest.Controls.Add(this.txtDest);
            this.grpDest.Location = new System.Drawing.Point(413, 108);
            this.grpDest.Name = "grpDest";
            this.grpDest.Size = new System.Drawing.Size(360, 467);
            this.grpDest.TabIndex = 14;
            this.grpDest.TabStop = false;
            this.grpDest.Text = "转换文本";
            // 
            // txtDest
            // 
            this.txtDest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDest.Location = new System.Drawing.Point(3, 17);
            this.txtDest.MaxLength = 0;
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDest.Size = new System.Drawing.Size(354, 447);
            this.txtDest.TabIndex = 0;
            this.txtDest.WordWrap = false;
            this.txtDest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.txtSource);
            this.grpSource.Location = new System.Drawing.Point(12, 108);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(360, 467);
            this.grpSource.TabIndex = 12;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "源文本";
            // 
            // txtSource
            // 
            this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSource.Location = new System.Drawing.Point(3, 17);
            this.txtSource.MaxLength = 0;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSource.Size = new System.Drawing.Size(354, 447);
            this.txtSource.TabIndex = 0;
            this.txtSource.WordWrap = false;
            this.txtSource.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContent_KeyDown);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(785, 25);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenFile,
            this.tsmiSaveFile,
            this.tsmiRestoreConfig,
            this.tsmiQuit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(&F)";
            // 
            // tsmiOpenFile
            // 
            this.tsmiOpenFile.Name = "tsmiOpenFile";
            this.tsmiOpenFile.Size = new System.Drawing.Size(164, 22);
            this.tsmiOpenFile.Text = "打开(&O)";
            this.tsmiOpenFile.Click += new System.EventHandler(this.tsmiOpenFile_Click);
            // 
            // tsmiSaveFile
            // 
            this.tsmiSaveFile.Name = "tsmiSaveFile";
            this.tsmiSaveFile.Size = new System.Drawing.Size(164, 22);
            this.tsmiSaveFile.Text = "保存结果(&S)";
            this.tsmiSaveFile.Click += new System.EventHandler(this.tsmiSaveFile_Click);
            // 
            // tsmiRestoreConfig
            // 
            this.tsmiRestoreConfig.Name = "tsmiRestoreConfig";
            this.tsmiRestoreConfig.Size = new System.Drawing.Size(164, 22);
            this.tsmiRestoreConfig.Text = "恢复默认设置(&R)";
            this.tsmiRestoreConfig.Click += new System.EventHandler(this.tsmiRestoreConfig_Click);
            // 
            // tsmiQuit
            // 
            this.tsmiQuit.Name = "tsmiQuit";
            this.tsmiQuit.Size = new System.Drawing.Size(164, 22);
            this.tsmiQuit.Text = "退出(&Q)";
            this.tsmiQuit.Click += new System.EventHandler(this.tsmiQuit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(&H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(116, 22);
            this.tsmiAbout.Text = "关于(&A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.Filter = "文本文件|*.txt;*.log;*.lrc;*.cue|所有文件|*.*";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.Filter = "文本文件|*.txt;*.log;*.lrc;*.cue|所有文件|*.*";
            // 
            // grpSaveEncoding
            // 
            this.grpSaveEncoding.Controls.Add(this.cboSaveEncoding);
            this.grpSaveEncoding.Location = new System.Drawing.Point(343, 28);
            this.grpSaveEncoding.Name = "grpSaveEncoding";
            this.grpSaveEncoding.Size = new System.Drawing.Size(145, 44);
            this.grpSaveEncoding.TabIndex = 3;
            this.grpSaveEncoding.TabStop = false;
            this.grpSaveEncoding.Text = "保存编码";
            // 
            // cboSaveEncoding
            // 
            this.cboSaveEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSaveEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaveEncoding.FormattingEnabled = true;
            this.cboSaveEncoding.Items.AddRange(new object[] {
            "UTF-8",
            "Unicode",
            "GBK",
            "BIG5",
            "Default"});
            this.cboSaveEncoding.Location = new System.Drawing.Point(6, 17);
            this.cboSaveEncoding.Name = "cboSaveEncoding";
            this.cboSaveEncoding.Size = new System.Drawing.Size(133, 20);
            this.cboSaveEncoding.TabIndex = 0;
            this.ttpCommon.SetToolTip(this.cboSaveEncoding, "设置保存文件时使用的编码");
            this.cboSaveEncoding.SelectedIndexChanged += new System.EventHandler(this.cboSaveEncoding_SelectedIndexChanged);
            // 
            // chkIsTopMost
            // 
            this.chkIsTopMost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsTopMost.AutoSize = true;
            this.chkIsTopMost.Location = new System.Drawing.Point(701, 601);
            this.chkIsTopMost.Name = "chkIsTopMost";
            this.chkIsTopMost.Size = new System.Drawing.Size(72, 16);
            this.chkIsTopMost.TabIndex = 15;
            this.chkIsTopMost.Text = "总在最前";
            this.ttpCommon.SetToolTip(this.chkIsTopMost, "窗口是否保持最前");
            this.chkIsTopMost.UseVisualStyleBackColor = true;
            this.chkIsTopMost.CheckedChanged += new System.EventHandler(this.chkIsTopMost_CheckedChanged);
            // 
            // chkIsExclude
            // 
            this.chkIsExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsExclude.AutoSize = true;
            this.chkIsExclude.Location = new System.Drawing.Point(225, 19);
            this.chkIsExclude.Name = "chkIsExclude";
            this.chkIsExclude.Size = new System.Drawing.Size(48, 16);
            this.chkIsExclude.TabIndex = 3;
            this.chkIsExclude.Text = "排除";
            this.ttpCommon.SetToolTip(this.chkIsExclude, "设置符合指定模式的字符串是否不参与简繁转换");
            this.chkIsExclude.UseVisualStyleBackColor = true;
            this.chkIsExclude.CheckedChanged += new System.EventHandler(this.chkIsExclude_CheckedChanged);
            // 
            // grpRegex
            // 
            this.grpRegex.Controls.Add(this.btnRegexClear);
            this.grpRegex.Controls.Add(this.cboRegex);
            this.grpRegex.Controls.Add(this.btnRegexHelp);
            this.grpRegex.Controls.Add(this.chkIsExclude);
            this.grpRegex.Location = new System.Drawing.Point(494, 28);
            this.grpRegex.Name = "grpRegex";
            this.grpRegex.Size = new System.Drawing.Size(279, 44);
            this.grpRegex.TabIndex = 4;
            this.grpRegex.TabStop = false;
            this.grpRegex.Text = "正则表达式";
            // 
            // btnRegexClear
            // 
            this.btnRegexClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegexClear.Location = new System.Drawing.Point(171, 15);
            this.btnRegexClear.Name = "btnRegexClear";
            this.btnRegexClear.Size = new System.Drawing.Size(23, 23);
            this.btnRegexClear.TabIndex = 1;
            this.btnRegexClear.Text = "X";
            this.ttpCommon.SetToolTip(this.btnRegexClear, "清除正则表达式");
            this.btnRegexClear.UseVisualStyleBackColor = true;
            this.btnRegexClear.Click += new System.EventHandler(this.btnRegexClear_Click);
            // 
            // cboRegex
            // 
            this.cboRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRegex.FormattingEnabled = true;
            this.cboRegex.Location = new System.Drawing.Point(6, 17);
            this.cboRegex.Name = "cboRegex";
            this.cboRegex.Size = new System.Drawing.Size(159, 20);
            this.cboRegex.TabIndex = 0;
            this.ttpCommon.SetToolTip(this.cboRegex, "使用正则表达式，可在符合指定模式的字符串中(或之外)进行简繁转换");
            this.cboRegex.SelectedIndexChanged += new System.EventHandler(this.cboRegex_SelectedIndexChanged);
            this.cboRegex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboRegex_KeyDown);
            // 
            // btnRegexHelp
            // 
            this.btnRegexHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegexHelp.Location = new System.Drawing.Point(196, 15);
            this.btnRegexHelp.Name = "btnRegexHelp";
            this.btnRegexHelp.Size = new System.Drawing.Size(23, 23);
            this.btnRegexHelp.TabIndex = 2;
            this.btnRegexHelp.Text = "?";
            this.ttpCommon.SetToolTip(this.btnRegexHelp, "查看正则表达式帮助");
            this.btnRegexHelp.UseVisualStyleBackColor = true;
            this.btnRegexHelp.Click += new System.EventHandler(this.btnRegexHelp_Click);
            // 
            // cboReadEncoding
            // 
            this.cboReadEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReadEncoding.FormattingEnabled = true;
            this.cboReadEncoding.Items.AddRange(new object[] {
            "自动选择",
            "UTF-8",
            "Unicode",
            "GBK",
            "BIG5",
            "HZ",
            "Shift-JIS",
            "EUC-KR(Korean)",
            "Default"});
            this.cboReadEncoding.Location = new System.Drawing.Point(81, 80);
            this.cboReadEncoding.Name = "cboReadEncoding";
            this.cboReadEncoding.Size = new System.Drawing.Size(133, 20);
            this.cboReadEncoding.TabIndex = 6;
            this.ttpCommon.SetToolTip(this.cboReadEncoding, "设置读取文件时使用的编码 (自动选择可识别前四种编码)");
            this.cboReadEncoding.SelectedIndexChanged += new System.EventHandler(this.cboReadEncoding_SelectedIndexChanged);
            // 
            // lblFileEncoding
            // 
            this.lblFileEncoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileEncoding.Location = new System.Drawing.Point(12, 602);
            this.lblFileEncoding.Name = "lblFileEncoding";
            this.lblFileEncoding.Size = new System.Drawing.Size(360, 12);
            this.lblFileEncoding.TabIndex = 17;
            // 
            // lblReadEncoding
            // 
            this.lblReadEncoding.AutoSize = true;
            this.lblReadEncoding.Location = new System.Drawing.Point(10, 83);
            this.lblReadEncoding.Name = "lblReadEncoding";
            this.lblReadEncoding.Size = new System.Drawing.Size(65, 12);
            this.lblReadEncoding.TabIndex = 5;
            this.lblReadEncoding.Text = "读取编码：";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(220, 77);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 25);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "重新载入";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 622);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.lblReadEncoding);
            this.Controls.Add(this.cboReadEncoding);
            this.Controls.Add(this.lblFileEncoding);
            this.Controls.Add(this.grpRegex);
            this.Controls.Add(this.chkIsTopMost);
            this.Controls.Add(this.grpSaveEncoding);
            this.Controls.Add(this.grpConvertMethod);
            this.Controls.Add(this.grpConvertType);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.txtFileExt);
            this.Controls.Add(this.lblFileExt);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.grpDest);
            this.Controls.Add(this.grpSource);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(801, 661);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "简繁转换器";
            this.ttpCommon.SetToolTip(this, "可将文件拖拽到窗口上");
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.grpConvertMethod.ResumeLayout(false);
            this.grpConvertMethod.PerformLayout();
            this.grpConvertType.ResumeLayout(false);
            this.grpDest.ResumeLayout(false);
            this.grpDest.PerformLayout();
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpSaveEncoding.ResumeLayout(false);
            this.grpRegex.ResumeLayout(false);
            this.grpRegex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        /// <summary>转换方式组合框</summary>
        private System.Windows.Forms.GroupBox grpConvertMethod;
        /// <summary>转换类型组合框</summary>
        private System.Windows.Forms.GroupBox grpConvertType;
        /// <summary>文件路径标签</summary>
        private System.Windows.Forms.Label lblFilePath;
        /// <summary>文件后缀名文本框</summary>
        private System.Windows.Forms.TextBox txtFileExt;
        /// <summary>文件后缀名标签</summary>
        private System.Windows.Forms.Label lblFileExt;
        /// <summary>另存为按钮</summary>
        private System.Windows.Forms.Button btnSaveAs;
        /// <summary>保存按钮</summary>
        private System.Windows.Forms.Button btnSave;
        /// <summary>简繁转换按钮</summary>
        private System.Windows.Forms.Button btnConvert;
        /// <summary>转换文本组合框</summary>
        private System.Windows.Forms.GroupBox grpDest;
        /// <summary>转换文本文本框</summary>
        private System.Windows.Forms.TextBox txtDest;
        /// <summary>源文本组合框</summary>
        private System.Windows.Forms.GroupBox grpSource;
        /// <summary>源文本文本框</summary>
        private System.Windows.Forms.TextBox txtSource;
        /// <summary>主菜单</summary>
        private System.Windows.Forms.MenuStrip menuMain;
        /// <summary>文件菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        /// <summary>帮助菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        /// <summary>打开菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenFile;
        /// <summary>保存结果菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveFile;
        /// <summary>退出菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiQuit;
        /// <summary>关于菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        /// <summary>打开文件对话框</summary>
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        /// <summary>保存文件对话框</summary>
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        /// <summary>保存编码组合框</summary>
        private System.Windows.Forms.GroupBox grpSaveEncoding;
        /// <summary>保存编码下拉列表</summary>
        private System.Windows.Forms.ComboBox cboSaveEncoding;
        /// <summary>总在最前复选框</summary>
        private System.Windows.Forms.CheckBox chkIsTopMost;
        /// <summary>排除(正则表达式)复选框</summary>
        private System.Windows.Forms.CheckBox chkIsExclude;
        /// <summary>正则表达式组合框</summary>
        private System.Windows.Forms.GroupBox grpRegex;
        /// <summary>公共消息提醒控件</summary>
        private System.Windows.Forms.ToolTip ttpCommon;
        /// <summary>查看正则表达式帮助按钮</summary>
        private System.Windows.Forms.Button btnRegexHelp;
        /// <summary>正则表达式下拉列表</summary>
        private System.Windows.Forms.ComboBox cboRegex;
        /// <summary>文件编码标签</summary>
        private System.Windows.Forms.Label lblFileEncoding;
        /// <summary>读取编码下拉列表</summary>
        private System.Windows.Forms.ComboBox cboReadEncoding;
        /// <summary>读取编码标签</summary>
        private System.Windows.Forms.Label lblReadEncoding;
        /// <summary>恢复默认设置菜单项</summary>
        private System.Windows.Forms.ToolStripMenuItem tsmiRestoreConfig;
        /// <summary>重新载入按钮</summary>
        private System.Windows.Forms.Button btnReload;
        /// <summary>是否转换文件名复选框</summary>
        private System.Windows.Forms.CheckBox chkIsConvertFileName;
        /// <summary>转换方式下拉列表</summary>
        private System.Windows.Forms.ComboBox cboConvertMethod;
        /// <summary>转换类型下拉列表</summary>
        private System.Windows.Forms.ComboBox cboConvertType;
        /// <summary>清除正则表达式按钮</summary>
        private System.Windows.Forms.Button btnRegexClear;
    }
}

