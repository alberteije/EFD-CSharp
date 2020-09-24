/********************************************************************************
Title: AlbertEije ERP
Description: Permite a emissão dos relatorios do SPED Fiscal

The MIT License

Copyright: Copyright (C) 2012 Albert Eije

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.

       The author may be contacted at:
           alberteije@gmail.com

@author Albert Eije
@version 1.0
********************************************************************************/


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using SpedFiscal.Model;
using NHibernate;
using SpedService.NHibernate;

namespace SpedFiscal.View
{

    public partial class FSpedFiscal : Form
    {
        IList<ContadorDTO> ListaContador;

        public FSpedFiscal()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
            ComboBoxVersaoLeiauteSped.SelectedIndex = 0;
            ComboBoxFinalidadeArquivoSped.SelectedIndex = 0;
            ComboBoxPerfilSped.SelectedIndex = 0;
            ComboBoxInventario.SelectedIndex = 0;
            mkeDataIni.Text = DateTime.Now.ToString("dd/MM/yyyy");
            mkeDataFim.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //
            ListaContador = new List<ContadorDTO>();
            CarregarContador();
            GridContador.DataSource = typeof(List<ContadorDTO>);
            GridContador.DataSource = ListaContador;
            GridContador.Refresh();
        }

        private void FVendasPeriodo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
                Confirma();
            if (e.KeyCode == Keys.Escape)
                botaoCancela.PerformClick();
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoConfirma_Click(object sender, EventArgs e)
        {
            Confirma();
        }

        private void Confirma()
        {
            int FinalidadeArquivo, Versao, Perfil, Inventario, Contador;
            if (MessageBox.Show("Deseja gerar o arquivo do SPED FISCAL?", "Pergunta do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Versao = ComboBoxVersaoLeiauteSped.SelectedIndex;
                FinalidadeArquivo = ComboBoxVersaoLeiauteSped.SelectedIndex;
                Perfil = ComboBoxPerfilSped.SelectedIndex;
                Inventario = ComboBoxInventario.SelectedIndex;
                Contador = ListaContador[GridContador.CurrentRow.Index].Id;
                //
                new SpedFiscalDAL().GerarArquivoSpedFiscal(
                                                            Convert.ToDateTime(mkeDataIni.Text).ToString("yyyy-MM-dd"),
                                                            Convert.ToDateTime(mkeDataFim.Text).ToString("yyyy-MM-dd"),
                                                            Versao,
                                                            FinalidadeArquivo,
                                                            Perfil,
                                                            1,
                                                            Inventario,
                                                            Contador
                                                            );

                //

                FPreview FPreview = new FPreview();
                FPreview.ShowDialog();
            }
        }

        private void CarregarContador()
        {
            try
            {
                using (ISession session = NHibernateHelper.getSessionFactory().OpenSession())
                {
                    NHibernateDAL<ContadorDTO> DAL = new NHibernateDAL<ContadorDTO>(session);
                    ListaContador = DAL.selectPagina(0, 10, new ContadorDTO());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + (ex.InnerException != null ? " " + ex.InnerException.Message : ""));
            }
        }

    }

}
