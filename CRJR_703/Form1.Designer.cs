namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.técnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escritorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portátilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenDeTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoOrdenTrabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTécnicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.transaccionalesToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.técnicosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.pcToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // técnicosToolStripMenuItem
            // 
            this.técnicosToolStripMenuItem.Name = "técnicosToolStripMenuItem";
            this.técnicosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.técnicosToolStripMenuItem.Text = "Técnicos";
            this.técnicosToolStripMenuItem.Click += new System.EventHandler(this.técnicosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // pcToolStripMenuItem
            // 
            this.pcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escritorioToolStripMenuItem,
            this.portátilToolStripMenuItem});
            this.pcToolStripMenuItem.Name = "pcToolStripMenuItem";
            this.pcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pcToolStripMenuItem.Text = "Pc ";
            this.pcToolStripMenuItem.Click += new System.EventHandler(this.pcToolStripMenuItem_Click);
            // 
            // escritorioToolStripMenuItem
            // 
            this.escritorioToolStripMenuItem.Name = "escritorioToolStripMenuItem";
            this.escritorioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.escritorioToolStripMenuItem.Text = "Escritorio";
            this.escritorioToolStripMenuItem.Click += new System.EventHandler(this.escritorioToolStripMenuItem_Click);
            // 
            // portátilToolStripMenuItem
            // 
            this.portátilToolStripMenuItem.Name = "portátilToolStripMenuItem";
            this.portátilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.portátilToolStripMenuItem.Text = "Portátil";
            this.portátilToolStripMenuItem.Click += new System.EventHandler(this.portátilToolStripMenuItem_Click);
            // 
            // transaccionalesToolStripMenuItem
            // 
            this.transaccionalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenDeTrabajoToolStripMenuItem});
            this.transaccionalesToolStripMenuItem.Name = "transaccionalesToolStripMenuItem";
            this.transaccionalesToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.transaccionalesToolStripMenuItem.Text = "Transaccionales";
            // 
            // ordenDeTrabajoToolStripMenuItem
            // 
            this.ordenDeTrabajoToolStripMenuItem.Name = "ordenDeTrabajoToolStripMenuItem";
            this.ordenDeTrabajoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ordenDeTrabajoToolStripMenuItem.Text = "Orden de Trabajo";
            this.ordenDeTrabajoToolStripMenuItem.Click += new System.EventHandler(this.ordenDeTrabajoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoOrdenTrabajoToolStripMenuItem,
            this.listadoDeTécnicosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoOrdenTrabajoToolStripMenuItem
            // 
            this.listadoOrdenTrabajoToolStripMenuItem.Name = "listadoOrdenTrabajoToolStripMenuItem";
            this.listadoOrdenTrabajoToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoOrdenTrabajoToolStripMenuItem.Text = "Listado orden trabajo";
            this.listadoOrdenTrabajoToolStripMenuItem.Click += new System.EventHandler(this.listadoOrdenTrabajoToolStripMenuItem_Click);
            // 
            // listadoDeTécnicosToolStripMenuItem
            // 
            this.listadoDeTécnicosToolStripMenuItem.Name = "listadoDeTécnicosToolStripMenuItem";
            this.listadoDeTécnicosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.listadoDeTécnicosToolStripMenuItem.Text = "Listado de técnicos";
            this.listadoDeTécnicosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTécnicosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 480);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Página principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem técnicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escritorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portátilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenDeTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoOrdenTrabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTécnicosToolStripMenuItem;
    }
}

