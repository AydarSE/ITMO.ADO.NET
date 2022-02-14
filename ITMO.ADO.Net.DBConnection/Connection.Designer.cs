namespace ITMO.ADO.Net.DBConnection
{
    partial class Connection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.подключитьсяКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключитьсяОтБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.асинхронноеПодключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключитьсяКБДToolStripMenuItem,
            this.отключитьсяОтБДToolStripMenuItem,
            this.асинхронноеПодключениеКБДToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(215, 29);
            this.toolStripMenuItem1.Text = "Работа с базой данных";
            // 
            // подключитьсяКБДToolStripMenuItem
            // 
            this.подключитьсяКБДToolStripMenuItem.Name = "подключитьсяКБДToolStripMenuItem";
            this.подключитьсяКБДToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.подключитьсяКБДToolStripMenuItem.Text = "Подключиться к БД";
            this.подключитьсяКБДToolStripMenuItem.Click += new System.EventHandler(this.подключитьсяКБДToolStripMenuItem_Click);
            // 
            // отключитьсяОтБДToolStripMenuItem
            // 
            this.отключитьсяОтБДToolStripMenuItem.Name = "отключитьсяОтБДToolStripMenuItem";
            this.отключитьсяОтБДToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.отключитьсяОтБДToolStripMenuItem.Text = "Отключиться от БД";
            this.отключитьсяОтБДToolStripMenuItem.Click += new System.EventHandler(this.отключитьсяОтБДToolStripMenuItem_Click);
            // 
            // асинхронноеПодключениеКБДToolStripMenuItem
            // 
            this.асинхронноеПодключениеКБДToolStripMenuItem.Name = "асинхронноеПодключениеКБДToolStripMenuItem";
            this.асинхронноеПодключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.асинхронноеПодключениеКБДToolStripMenuItem.Text = "Асинхронное подключение к БД";
            this.асинхронноеПодключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.асинхронноеПодключениеКБДToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(382, 34);
            this.списокПодключенийToolStripMenuItem.Text = "Список Подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Connection";
            this.Text = "Connection";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem подключитьсяКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключитьсяОтБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem асинхронноеПодключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
    }
}

