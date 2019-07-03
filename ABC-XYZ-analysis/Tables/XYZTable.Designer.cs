namespace ABC_XYZ_analysis
{
    partial class XYZTable
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
            this.listBoxGroupX = new System.Windows.Forms.ListBox();
            this.listBoxGroupY = new System.Windows.Forms.ListBox();
            this.listBoxGroupZ = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.показатьРасчетнуюТаблицуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGroupX
            // 
            this.listBoxGroupX.FormattingEnabled = true;
            this.listBoxGroupX.Location = new System.Drawing.Point(25, 44);
            this.listBoxGroupX.Name = "listBoxGroupX";
            this.listBoxGroupX.Size = new System.Drawing.Size(202, 238);
            this.listBoxGroupX.TabIndex = 0;
            // 
            // listBoxGroupY
            // 
            this.listBoxGroupY.FormattingEnabled = true;
            this.listBoxGroupY.Location = new System.Drawing.Point(252, 44);
            this.listBoxGroupY.Name = "listBoxGroupY";
            this.listBoxGroupY.Size = new System.Drawing.Size(202, 238);
            this.listBoxGroupY.TabIndex = 1;
            // 
            // listBoxGroupZ
            // 
            this.listBoxGroupZ.FormattingEnabled = true;
            this.listBoxGroupZ.Location = new System.Drawing.Point(478, 44);
            this.listBoxGroupZ.Name = "listBoxGroupZ";
            this.listBoxGroupZ.Size = new System.Drawing.Size(202, 238);
            this.listBoxGroupZ.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Группа X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Группа Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(559, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Группа Z";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьРасчетнуюТаблицуToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // показатьРасчетнуюТаблицуToolStripMenuItem
            // 
            this.показатьРасчетнуюТаблицуToolStripMenuItem.Name = "показатьРасчетнуюТаблицуToolStripMenuItem";
            this.показатьРасчетнуюТаблицуToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.показатьРасчетнуюТаблицуToolStripMenuItem.Text = "Показать расчетную таблицу";
            this.показатьРасчетнуюТаблицуToolStripMenuItem.Click += new System.EventHandler(this.показатьРасчетнуюТаблицуToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // XYZTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGroupZ);
            this.Controls.Add(this.listBoxGroupY);
            this.Controls.Add(this.listBoxGroupX);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "XYZTable";
            this.Text = "Таблица XYZ-анализа";
            this.Load += new System.EventHandler(this.XYZTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxGroupX;
        private System.Windows.Forms.ListBox listBoxGroupY;
        private System.Windows.Forms.ListBox listBoxGroupZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьРасчетнуюТаблицуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}