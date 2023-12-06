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
            tabControl1.Controls.Add(NewTab1);
            tabControl1.Controls.Add(TabPlus);
            tabControl1.Location = new Point(20, 90);
            tabControl1.Margin = new Padding(5, 5, 5, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1950, 1416);
            tabControl1.TabIndex = 0;
            tabControl1.Selecting += tabControl1_Selecting;
            // 
            // NewTab1
            // 
            NewTab1.Location = new Point(8, 46);
            NewTab1.Margin = new Padding(5, 5, 5, 5);
            NewTab1.Name = "NewTab1";
            NewTab1.Padding = new Padding(5, 5, 5, 5);
            NewTab1.Size = new Size(1934, 1362);
            NewTab1.TabIndex = 0;
            NewTab1.Text = "New tab 1";
            NewTab1.UseVisualStyleBackColor = true;
            // 
            // TabPlus
            // 
            TabPlus.Location = new Point(8, 46);
            TabPlus.Margin = new Padding(5, 5, 5, 5);
            TabPlus.Name = "TabPlus";
            TabPlus.Size = new Size(1934, 1362);
            TabPlus.TabIndex = 0;
            TabPlus.Text = "+";
            TabPlus.UseVisualStyleBackColor = true;
            // 
            // btnDelTab
            // 
            btnDelTab.Location = new Point(1810, 50);
            btnDelTab.Margin = new Padding(5, 5, 5, 5);
            btnDelTab.Name = "btnDelTab";
            btnDelTab.Size = new Size(153, 46);
            btnDelTab.TabIndex = 1;
            btnDelTab.Text = "Delete tab";
            btnDelTab.UseVisualStyleBackColor = true;
            btnDelTab.Click += btnDelTab_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { infoToolStripMenuItem, historyToolStripMenuItem, logoutToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(104, 36);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(222, 44);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(222, 44);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(222, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(2002, 42);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2002, 1399);
            Controls.Add(menuStrip1);
            Controls.Add(btnDelTab);
            Controls.Add(tabControl1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
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