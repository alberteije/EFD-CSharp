namespace SpedFiscal.View
{
    partial class FPreview
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BotaoConfigurarImpressora = new System.Windows.Forms.ToolStripButton();
            this.BotaoImprimir = new System.Windows.Forms.ToolStripButton();
            this.BotaoSalvar = new System.Windows.Forms.ToolStripButton();
            this.BotaoSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(21, 21);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BotaoConfigurarImpressora,
            this.BotaoImprimir,
            this.BotaoSalvar,
            this.toolStripSeparator1,
            this.BotaoSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(730, 28);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(730, 333);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // BotaoConfigurarImpressora
            // 
            this.BotaoConfigurarImpressora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotaoConfigurarImpressora.Image = global::SpedFiscal.Properties.Resources._21botaoMenuFiscal;
            this.BotaoConfigurarImpressora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotaoConfigurarImpressora.Name = "BotaoConfigurarImpressora";
            this.BotaoConfigurarImpressora.Size = new System.Drawing.Size(25, 25);
            this.BotaoConfigurarImpressora.Text = "Configurar Impressora";
            this.BotaoConfigurarImpressora.Click += new System.EventHandler(this.BotaoConfigurarImpressora_Click);
            // 
            // BotaoImprimir
            // 
            this.BotaoImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotaoImprimir.Image = global::SpedFiscal.Properties.Resources._21botaoGaveta;
            this.BotaoImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotaoImprimir.Name = "BotaoImprimir";
            this.BotaoImprimir.Size = new System.Drawing.Size(25, 25);
            this.BotaoImprimir.Text = "Imprimir";
            this.BotaoImprimir.Click += new System.EventHandler(this.BotaoImprimir_Click);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotaoSalvar.Image = global::SpedFiscal.Properties.Resources._21botaoMenuPrincipal;
            this.BotaoSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(25, 25);
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // BotaoSair
            // 
            this.BotaoSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BotaoSair.Image = global::SpedFiscal.Properties.Resources._21botaoSair1;
            this.BotaoSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BotaoSair.Name = "BotaoSair";
            this.BotaoSair.Size = new System.Drawing.Size(25, 25);
            this.BotaoSair.Text = "Sair";
            this.BotaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // FPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 361);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.KeyPreview = true;
            this.Name = "FPreview";
            this.Text = "Preview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BotaoConfigurarImpressora;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripButton BotaoImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripButton BotaoSalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BotaoSair;

    }
}