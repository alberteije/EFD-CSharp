namespace SpedFiscal.View
{
	partial class FSpedFiscal
    {
        private System.Windows.Forms.TabControl TabControl1;
		private System.Windows.Forms.TabPage PaginaSped;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.ComboBox ComboBoxVersaoLeiauteSped;
		internal System.Windows.Forms.ComboBox ComboBoxFinalidadeArquivoSped;
		internal System.Windows.Forms.ComboBox ComboBoxPerfilSped;
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
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.PaginaSped = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GridContador = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxInventario = new System.Windows.Forms.ComboBox();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.botaoConfirma = new System.Windows.Forms.Button();
            this.mkeDataFim = new System.Windows.Forms.MaskedTextBox();
            this.mkeDataIni = new System.Windows.Forms.MaskedTextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.ComboBoxVersaoLeiauteSped = new System.Windows.Forms.ComboBox();
            this.ComboBoxFinalidadeArquivoSped = new System.Windows.Forms.ComboBox();
            this.ComboBoxPerfilSped = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Image1 = new System.Windows.Forms.PictureBox();
            this.TabControl1.SuspendLayout();
            this.PaginaSped.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridContador)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.PaginaSped);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TabControl1.Location = new System.Drawing.Point(0, 62);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(490, 402);
            this.TabControl1.TabIndex = 0;
            // 
            // PaginaSped
            // 
            this.PaginaSped.Controls.Add(this.groupBox1);
            this.PaginaSped.Controls.Add(this.label3);
            this.PaginaSped.Controls.Add(this.ComboBoxInventario);
            this.PaginaSped.Controls.Add(this.botaoCancela);
            this.PaginaSped.Controls.Add(this.botaoConfirma);
            this.PaginaSped.Controls.Add(this.mkeDataFim);
            this.PaginaSped.Controls.Add(this.mkeDataIni);
            this.PaginaSped.Controls.Add(this.Label1);
            this.PaginaSped.Controls.Add(this.Label2);
            this.PaginaSped.Controls.Add(this.Label6);
            this.PaginaSped.Controls.Add(this.Label7);
            this.PaginaSped.Controls.Add(this.Label8);
            this.PaginaSped.Controls.Add(this.ComboBoxVersaoLeiauteSped);
            this.PaginaSped.Controls.Add(this.ComboBoxFinalidadeArquivoSped);
            this.PaginaSped.Controls.Add(this.ComboBoxPerfilSped);
            this.PaginaSped.Location = new System.Drawing.Point(4, 22);
            this.PaginaSped.Name = "PaginaSped";
            this.PaginaSped.Size = new System.Drawing.Size(482, 376);
            this.PaginaSped.TabIndex = 0;
            this.PaginaSped.Text = "Informações SPED Fiscal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GridContador);
            this.groupBox1.Location = new System.Drawing.Point(6, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 195);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contadores:";
            // 
            // GridContador
            // 
            this.GridContador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridContador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridContador.Location = new System.Drawing.Point(3, 16);
            this.GridContador.Name = "GridContador";
            this.GridContador.Size = new System.Drawing.Size(462, 176);
            this.GridContador.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Inventário:";
            // 
            // ComboBoxInventario
            // 
            this.ComboBoxInventario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInventario.FormattingEnabled = true;
            this.ComboBoxInventario.Items.AddRange(new object[] {
            "00 - Sem Inventário",
            "01 – No final no período",
            "02 – Na mudança de forma de tributação da mercadoria (ICMS)",
            "03 – Na solicitação da baixa cadastral, paralisação temporária e outras situações" +
                "",
            "04 – Na alteração de regime de pagamento – condição do contribuinte",
            "05 – Por determinação dos fiscos"});
            this.ComboBoxInventario.Location = new System.Drawing.Point(6, 115);
            this.ComboBoxInventario.Name = "ComboBoxInventario";
            this.ComboBoxInventario.Size = new System.Drawing.Size(468, 21);
            this.ComboBoxInventario.TabIndex = 28;
            // 
            // botaoCancela
            // 
            this.botaoCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botaoCancela.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoCancela.ForeColor = System.Drawing.Color.Black;
            this.botaoCancela.Image = global::SpedFiscal.Properties.Resources.cancelar16;
            this.botaoCancela.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancela.Location = new System.Drawing.Point(355, 343);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(120, 25);
            this.botaoCancela.TabIndex = 27;
            this.botaoCancela.Text = "Ca&ncela (ESC)";
            this.botaoCancela.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
            // 
            // botaoConfirma
            // 
            this.botaoConfirma.Font = new System.Drawing.Font("Tahoma", 8F);
            this.botaoConfirma.ForeColor = System.Drawing.Color.Black;
            this.botaoConfirma.Image = global::SpedFiscal.Properties.Resources.confirmar16;
            this.botaoConfirma.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoConfirma.Location = new System.Drawing.Point(229, 343);
            this.botaoConfirma.Name = "botaoConfirma";
            this.botaoConfirma.Size = new System.Drawing.Size(120, 25);
            this.botaoConfirma.TabIndex = 26;
            this.botaoConfirma.Text = "&Confirma (F12)";
            this.botaoConfirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.botaoConfirma.Click += new System.EventHandler(this.botaoConfirma_Click);
            // 
            // mkeDataFim
            // 
            this.mkeDataFim.Location = new System.Drawing.Point(399, 70);
            this.mkeDataFim.Mask = "##/##/####";
            this.mkeDataFim.Name = "mkeDataFim";
            this.mkeDataFim.Size = new System.Drawing.Size(75, 20);
            this.mkeDataFim.TabIndex = 9;
            // 
            // mkeDataIni
            // 
            this.mkeDataIni.Location = new System.Drawing.Point(318, 70);
            this.mkeDataIni.Mask = "##/##/####";
            this.mkeDataIni.Name = "mkeDataIni";
            this.mkeDataIni.Size = new System.Drawing.Size(75, 20);
            this.mkeDataIni.TabIndex = 8;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(315, 54);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(77, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Data Inicial:";
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(396, 54);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(69, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Data Final:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(6, 5);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(97, 13);
            this.Label6.TabIndex = 0;
            this.Label6.Text = "Versão do Leiaute:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(256, 6);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(114, 13);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "Finalidade do Arquivo:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(6, 53);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(175, 13);
            this.Label8.TabIndex = 2;
            this.Label8.Text = "Perfil de Apresentação do Arquivo:";
            // 
            // ComboBoxVersaoLeiauteSped
            // 
            this.ComboBoxVersaoLeiauteSped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxVersaoLeiauteSped.FormattingEnabled = true;
            this.ComboBoxVersaoLeiauteSped.Items.AddRange(new object[] {
            "001 - Versão 1.00 Ato COTEPE 01/01/2008",
            "002 - Versão 1.01 Ato COTEPE 01/01/2009",
            "003 - Versão 1.02 Ato COTEPE 01/01/2010",
            "004 - Versão 1.03 Ato COTEPE 01/01/2011",
            "005 - Versão 1.04 Ato COTEPE 01/01/2012",
            "006 - Versão 1.05 Ato COTEPE 01/07/2012",
            "007 - Versão 1.06 Ato COTEPE 01/01/2013"});
            this.ComboBoxVersaoLeiauteSped.Location = new System.Drawing.Point(6, 22);
            this.ComboBoxVersaoLeiauteSped.Name = "ComboBoxVersaoLeiauteSped";
            this.ComboBoxVersaoLeiauteSped.Size = new System.Drawing.Size(244, 21);
            this.ComboBoxVersaoLeiauteSped.TabIndex = 0;
            // 
            // ComboBoxFinalidadeArquivoSped
            // 
            this.ComboBoxFinalidadeArquivoSped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFinalidadeArquivoSped.FormattingEnabled = true;
            this.ComboBoxFinalidadeArquivoSped.Items.AddRange(new object[] {
            "0 - Remessa do arquivo original",
            "1 - Remessa do arquivo substituto"});
            this.ComboBoxFinalidadeArquivoSped.Location = new System.Drawing.Point(256, 22);
            this.ComboBoxFinalidadeArquivoSped.Name = "ComboBoxFinalidadeArquivoSped";
            this.ComboBoxFinalidadeArquivoSped.Size = new System.Drawing.Size(218, 21);
            this.ComboBoxFinalidadeArquivoSped.TabIndex = 1;
            // 
            // ComboBoxPerfilSped
            // 
            this.ComboBoxPerfilSped.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxPerfilSped.FormattingEnabled = true;
            this.ComboBoxPerfilSped.Items.AddRange(new object[] {
            "A - Perfil A",
            "B - Perfil B",
            "C - Perfil C"});
            this.ComboBoxPerfilSped.Location = new System.Drawing.Point(6, 69);
            this.ComboBoxPerfilSped.Name = "ComboBoxPerfilSped";
            this.ComboBoxPerfilSped.Size = new System.Drawing.Size(306, 21);
            this.ComboBoxPerfilSped.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Image1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 62);
            this.panel1.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 23);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sped Fiscal";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(64, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 7);
            this.panel2.TabIndex = 24;
            // 
            // Image1
            // 
            this.Image1.Image = global::SpedFiscal.Properties.Resources.SpedFiscal48;
            this.Image1.InitialImage = null;
            this.Image1.Location = new System.Drawing.Point(9, 8);
            this.Image1.Name = "Image1";
            this.Image1.Size = new System.Drawing.Size(48, 48);
            this.Image1.TabIndex = 23;
            this.Image1.TabStop = false;
            // 
            // FSpedFiscal
            // 
            this.ClientSize = new System.Drawing.Size(490, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(251, 387);
            this.Name = "FSpedFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sped Fiscal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FVendasPeriodo_KeyDown);
            this.TabControl1.ResumeLayout(false);
            this.PaginaSped.ResumeLayout(false);
            this.PaginaSped.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridContador)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Image1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mkeDataFim;
        private System.Windows.Forms.MaskedTextBox mkeDataIni;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.Button botaoConfirma;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox ComboBoxInventario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView GridContador;

	}
}
