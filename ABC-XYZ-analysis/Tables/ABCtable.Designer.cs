namespace ABC_XYZ_analysis
{
    partial class ABCtable
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
            this.listBoxGroupA = new System.Windows.Forms.ListBox();
            this.listBoxGroupB = new System.Windows.Forms.ListBox();
            this.listBoxGroupC = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.показатьПромеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGroupA
            // 
            this.listBoxGroupA.FormattingEnabled = true;
            this.listBoxGroupA.Location = new System.Drawing.Point(22, 63);
            this.listBoxGroupA.Name = "listBoxGroupA";
            this.listBoxGroupA.Size = new System.Drawing.Size(202, 238);
            this.listBoxGroupA.TabIndex = 0;
            // 
            // listBoxGroupB
            // 
            this.listBoxGroupB.FormattingEnabled = true;
            this.listBoxGroupB.Location = new System.Drawing.Point(240, 63);
            this.listBoxGroupB.Name = "listBoxGroupB";
            this.listBoxGroupB.Size = new System.Drawing.Size(202, 238);
            this.listBoxGroupB.TabIndex = 1;
            // 
            // listBoxGroupC
            // 
            this.listBoxGroupC.FormattingEnabled = true;
            this.listBoxGroupC.Location = new System.Drawing.Point(467, 63);
            this.listBoxGroupC.Name = "listBoxGroupC";
            this.listBoxGroupC.Size = new System.Drawing.Size(202, 238);
            this.listBoxGroupC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ГРУППА A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ГРУППА B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ГРУППА C";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьПромеToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // показатьПромеToolStripMenuItem
            // 
            this.показатьПромеToolStripMenuItem.Name = "показатьПромеToolStripMenuItem";
            this.показатьПромеToolStripMenuItem.Size = new System.Drawing.Size(205, 20);
            this.показатьПромеToolStripMenuItem.Text = "Показать промежуточный расчет";
            this.показатьПромеToolStripMenuItem.Click += new System.EventHandler(this.показатьПромеToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // ABCtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGroupC);
            this.Controls.Add(this.listBoxGroupB);
            this.Controls.Add(this.listBoxGroupA);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ABCtable";
            this.Text = "Таблица ABC-анализа";
            this.Load += new System.EventHandler(this.ABCtable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroupA;
        private System.Windows.Forms.ListBox listBoxGroupB;
        private System.Windows.Forms.ListBox listBoxGroupC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьПромеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}