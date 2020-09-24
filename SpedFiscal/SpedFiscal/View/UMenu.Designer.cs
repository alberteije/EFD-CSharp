namespace SpedFiscal.View
{
	partial class FMenu
    {
		private System.Windows.Forms.StatusStrip LinhaStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		// Required designer variable.
		private System.ComponentModel.IContainer components = null;

		// Clean up any resources being used.
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.LinhaStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.botaoSpedFiscal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.botaoSair = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinhaStatus
            // 
            this.LinhaStatus.BackColor = System.Drawing.Color.White;
            this.LinhaStatus.Location = new System.Drawing.Point(0, 408);
            this.LinhaStatus.Name = "LinhaStatus";
            this.LinhaStatus.Size = new System.Drawing.Size(688, 22);
            this.LinhaStatus.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botaoSpedFiscal,
            this.toolStripSeparator1,
            this.botaoSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(688, 55);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // botaoSpedFiscal
            // 
            this.botaoSpedFiscal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoSpedFiscal.Image = global::SpedFiscal.Properties.Resources.SpedFiscal48;
            this.botaoSpedFiscal.Name = "botaoSpedFiscal";
            this.botaoSpedFiscal.Size = new System.Drawing.Size(52, 52);
            this.botaoSpedFiscal.Text = "Emissão do Sped Fiscal";
            this.botaoSpedFiscal.Click += new System.EventHandler(this.botaoSpedFiscal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // botaoSair
            // 
            this.botaoSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.botaoSair.Image = global::SpedFiscal.Properties.Resources.telaSair01;
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.Size = new System.Drawing.Size(52, 52);
            this.botaoSair.Text = "Sair do Sistema";
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(688, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dAVToolStripMenuItem});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // dAVToolStripMenuItem
            // 
            this.dAVToolStripMenuItem.Name = "dAVToolStripMenuItem";
            this.dAVToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dAVToolStripMenuItem.Text = "Sped Fiscal";
            this.dAVToolStripMenuItem.Click += new System.EventHandler(this.botaoSpedFiscal_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // FMenu
            // 
            this.ClientSize = new System.Drawing.Size(688, 430);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LinhaStatus);
            this.Controls.Add(this.menuStrip1);
            this.Location = new System.Drawing.Point(187, 375);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMenu";
            this.Text = "AlbertEije ERP - Sped Fiscal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton botaoSpedFiscal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton botaoSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dAVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;

	}
}
