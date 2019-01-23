namespace SWMM.NET
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.vS2005Theme1 = new WeifenLuo.WinFormsUI.Docking.VS2005Theme();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolBar = new System.Windows.Forms.ToolStrip();
            this.mainStatusBar = new System.Windows.Forms.StatusStrip();
            this.vsToolStripExtender1 = new WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender(this.components);
            this.vS2015BlueTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.dockPanel = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tActionList1 = new SWMM.Components.TActionList();
            this.tActionNew = new SWMM.Components.TAction();
            this.tActionOpen = new SWMM.Components.TAction();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tActionList1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(627, 25);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(39, 21);
            this.mnuFile.Text = "&File";
            // 
            // mainToolBar
            // 
            this.mainToolBar.Location = new System.Drawing.Point(0, 25);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.Size = new System.Drawing.Size(627, 25);
            this.mainToolBar.TabIndex = 2;
            this.mainToolBar.Text = "toolStrip1";
            // 
            // mainStatusBar
            // 
            this.mainStatusBar.Location = new System.Drawing.Point(0, 374);
            this.mainStatusBar.Name = "mainStatusBar";
            this.mainStatusBar.Size = new System.Drawing.Size(627, 22);
            this.mainStatusBar.TabIndex = 3;
            this.mainStatusBar.Text = "statusStrip1";
            // 
            // vsToolStripExtender1
            // 
            this.vsToolStripExtender1.DefaultRenderer = null;
            // 
            // dockPanel
            // 
            this.dockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockPanel.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dockPanel.DockBottomPortion = 150D;
            this.dockPanel.DockLeftPortion = 200D;
            this.dockPanel.DockRightPortion = 200D;
            this.dockPanel.DockTopPortion = 150D;
            this.dockPanel.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.dockPanel.Location = new System.Drawing.Point(0, 50);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.RightToLeftLayout = true;
            this.dockPanel.ShowAutoHideContentOnHover = false;
            this.dockPanel.Size = new System.Drawing.Size(627, 324);
            this.dockPanel.TabIndex = 8;
            // 
            // mnuNew
            // 
            this.tActionList1.SetAction(this.mnuNew, this.tActionNew);
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(108, 22);
            this.mnuNew.Text = "&New";
            // 
            // mnuOpen
            // 
            this.tActionList1.SetAction(this.mnuOpen, this.tActionOpen);
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(108, 22);
            this.mnuOpen.Text = "&Open";
            // 
            // tActionList1
            // 
            this.tActionList1.Actions.Add(this.tActionNew);
            this.tActionList1.Actions.Add(this.tActionOpen);
            this.tActionList1.ContainerControl = this;
            // 
            // tActionNew
            // 
            this.tActionNew.Text = "&New";
            // 
            // tActionOpen
            // 
            this.tActionOpen.Text = "&Open";
            this.tActionOpen.Execute += new System.EventHandler(this.tActionOpen_Execute);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 396);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainToolBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tActionList1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WeifenLuo.WinFormsUI.Docking.VS2005Theme vS2005Theme1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip mainToolBar;
        private System.Windows.Forms.StatusStrip mainStatusBar;
        private WeifenLuo.WinFormsUI.Docking.VisualStudioToolStripExtender vsToolStripExtender1;
        private WeifenLuo.WinFormsUI.Docking.VS2015BlueTheme vS2015BlueTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private Components.TActionList tActionList1;
        private Components.TAction tActionNew;
        private Components.TAction tActionOpen;
    }
}

