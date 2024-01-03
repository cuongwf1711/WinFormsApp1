namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            NewTab1 = new TabPage();
            TabPlus = new TabPage();
            adminToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            deleteTabToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(NewTab1);
            tabControl1.Controls.Add(TabPlus);
            tabControl1.Location = new Point(12, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1208, 757);
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // NewTab1
            // 
            NewTab1.Location = new Point(4, 32);
            NewTab1.Name = "NewTab1";
            NewTab1.Size = new Size(1200, 721);
            NewTab1.Text = "New tab 1";
            // 
            // TabPlus
            // 
            TabPlus.Location = new Point(4, 32);
            TabPlus.Name = "TabPlus";
            TabPlus.Size = new Size(1200, 721);
            TabPlus.Text = "+";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, historyToolStripMenuItem, logoutToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(74, 27);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(148, 28);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(148, 28);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(148, 28);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, deleteTabToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1232, 31);
            menuStrip1.Text = "menuStrip1";
            // 
            // deleteTabToolStripMenuItem
            // 
            deleteTabToolStripMenuItem.BackColor = SystemColors.GradientActiveCaption;
            deleteTabToolStripMenuItem.Name = "deleteTabToolStripMenuItem";
            deleteTabToolStripMenuItem.Size = new Size(103, 27);
            deleteTabToolStripMenuItem.Text = "Delete tab";
            deleteTabToolStripMenuItem.Click += deleteTabToolStripMenuItem_Click;
            // 
            // Form1
            // 
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1232, 803);
            Controls.Add(menuStrip1);
            Controls.Add(tabControl1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            FormClosed += Form1_FormClosed;
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TabPlus;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private TabPage NewTab1;
        private ToolStripMenuItem deleteTabToolStripMenuItem;
    }
}