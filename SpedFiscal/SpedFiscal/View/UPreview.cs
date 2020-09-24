using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace SpedFiscal.View
{
    public partial class FPreview : Form
    {
        public FPreview()
        {
            InitializeComponent();
            CarregarArquivo();
        }

        private void BotaoConfigurarImpressora_Click(object sender, EventArgs e)
        {
            //TODO: Leitor - Implemente

            // Initialize the dialog's PrinterSettings property to hold user
            // defined printer settings.
            pageSetupDialog1.PageSettings =
                new System.Drawing.Printing.PageSettings();

            // Initialize dialog's PrinterSettings property to hold user
            // set printer settings.
            pageSetupDialog1.PrinterSettings =
                new System.Drawing.Printing.PrinterSettings();

            //Do not show the network in the printer dialog.
            pageSetupDialog1.ShowNetwork = false;

            //Show the dialog storing the result.
            DialogResult result = pageSetupDialog1.ShowDialog();

            // If the result is OK, display selected settings in
            // ListBox1. These values can be used when printing the
            // document.
            if (result == DialogResult.OK)
            {
                object[] results = new object[]{ 
				pageSetupDialog1.PageSettings.Margins, 
				pageSetupDialog1.PageSettings.PaperSize, 
				pageSetupDialog1.PageSettings.Landscape, 
				pageSetupDialog1.PrinterSettings.PrinterName, 
				pageSetupDialog1.PrinterSettings.PrintRange};
            }
        }

        private void BotaoImprimir_Click(object sender, EventArgs e)
        {
            //TODO: Leitor - Implemente
            printDialog1.ShowDialog();
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarArquivo()
        {
            string fileName = Application.StartupPath + "\\SpedFiscal.txt";
            richTextBox1.LoadFile(fileName, RichTextBoxStreamType.PlainText); 
        }
    }
}
