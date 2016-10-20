namespace pgform
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabTwo = new System.Windows.Forms.TabControl();
            this.tabClient = new System.Windows.Forms.TabPage();
            this.tabOne = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabThree = new System.Windows.Forms.TabPage();
            this.tabFour = new System.Windows.Forms.TabPage();
            this.tabFive = new System.Windows.Forms.TabPage();
            this.tabTwo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTwo
            // 
            this.tabTwo.Controls.Add(this.tabClient);
            this.tabTwo.Controls.Add(this.tabOne);
            this.tabTwo.Controls.Add(this.tabPage3);
            this.tabTwo.Controls.Add(this.tabThree);
            this.tabTwo.Controls.Add(this.tabFour);
            this.tabTwo.Controls.Add(this.tabFive);
            this.tabTwo.Location = new System.Drawing.Point(0, 27);
            this.tabTwo.Name = "tabTwo";
            this.tabTwo.SelectedIndex = 0;
            this.tabTwo.Size = new System.Drawing.Size(928, 448);
            this.tabTwo.TabIndex = 0;
            // 
            // tabClient
            // 
            this.tabClient.Location = new System.Drawing.Point(4, 22);
            this.tabClient.Name = "tabClient";
            this.tabClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabClient.Size = new System.Drawing.Size(920, 422);
            this.tabClient.TabIndex = 0;
            this.tabClient.Text = "Заказчик";
            this.tabClient.UseVisualStyleBackColor = true;
            // 
            // tabOne
            // 
            this.tabOne.Location = new System.Drawing.Point(4, 22);
            this.tabOne.Name = "tabOne";
            this.tabOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabOne.Size = new System.Drawing.Size(920, 422);
            this.tabOne.TabIndex = 1;
            this.tabOne.Text = "1. Общие сведения";
            this.tabOne.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(920, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "2. Назначение и цели";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabThree
            // 
            this.tabThree.Location = new System.Drawing.Point(4, 22);
            this.tabThree.Name = "tabThree";
            this.tabThree.Padding = new System.Windows.Forms.Padding(3);
            this.tabThree.Size = new System.Drawing.Size(920, 422);
            this.tabThree.TabIndex = 3;
            this.tabThree.Text = "3. Х-ка объектов автомаизации";
            this.tabThree.UseVisualStyleBackColor = true;
            // 
            // tabFour
            // 
            this.tabFour.Location = new System.Drawing.Point(4, 22);
            this.tabFour.Name = "tabFour";
            this.tabFour.Padding = new System.Windows.Forms.Padding(3);
            this.tabFour.Size = new System.Drawing.Size(920, 422);
            this.tabFour.TabIndex = 4;
            this.tabFour.Text = "4. Требования к системе";
            this.tabFour.UseVisualStyleBackColor = true;
            // 
            // tabFive
            // 
            this.tabFive.Location = new System.Drawing.Point(4, 22);
            this.tabFive.Name = "tabFive";
            this.tabFive.Padding = new System.Windows.Forms.Padding(3);
            this.tabFive.Size = new System.Drawing.Size(920, 422);
            this.tabFive.TabIndex = 5;
            this.tabFive.Text = "5. Состав и содержание работ";
            this.tabFive.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(928, 475);
            this.Controls.Add(this.tabTwo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pgform";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabTwo.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabTwo;
        private System.Windows.Forms.TabPage tabClient;
        private System.Windows.Forms.TabPage tabOne;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabThree;
        private System.Windows.Forms.TabPage tabFour;
        private System.Windows.Forms.TabPage tabFive;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}

