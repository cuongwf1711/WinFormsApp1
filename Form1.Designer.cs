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
            tabControl1 = new TabControl();
            NewTab1 = new TabPage();
            TabPlus = new TabPage();
            btnDelTab = new Button();
            adminToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tabControl1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(NewTab1);
            tabControl1.Controls.Add(TabPlus);
            tabControl1.Location = new Point(10, 42);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1050, 664);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // NewTab1
            // 
            NewTab1.Location = new Point(4, 24);
            NewTab1.Margin = new Padding(3, 2, 3, 2);
            NewTab1.Name = "NewTab1";
            NewTab1.Padding = new Padding(3, 2, 3, 2);
            NewTab1.Size = new Size(1042, 636);
            NewTab1.TabIndex = 0;
            NewTab1.Text = "New tab 1";
            NewTab1.UseVisualStyleBackColor = true;
            // 
            // TabPlus
            // 
            TabPlus.Location = new Point(4, 24);
            TabPlus.Margin = new Padding(3, 2, 3, 2);
            TabPlus.Name = "TabPlus";
            TabPlus.Size = new Size(1042, 636);
            TabPlus.TabIndex = 0;
            TabPlus.Text = "+";
            TabPlus.UseVisualStyleBackColor = true;
            // 
            // btnDelTab
            // 
            btnDelTab.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelTab.Location = new Point(975, 34);
            btnDelTab.Margin = new Padding(3, 2, 3, 2);
            btnDelTab.Name = "btnDelTab";
            btnDelTab.Size = new Size(82, 22);
            btnDelTab.TabIndex = 2;
            btnDelTab.Text = "Delete tab";
            btnDelTab.UseVisualStyleBackColor = true;
            btnDelTab.Click += btnDelTab_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, historyToolStripMenuItem, logoutToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(57, 21);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(117, 22);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(117, 22);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(117, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.MediumTurquoise;
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1069, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1069, 790);
            Controls.Add(menuStrip1);
            Controls.Add(btnDelTab);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Download Booster";
            FormClosed += Form1_FormClosed;
            tabControl1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage NewTab1;
        private TabPage TabPlus;
        private Button btnDelTab;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}