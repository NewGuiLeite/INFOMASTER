using INFOMASTER.Forms;
using System;
using FirebirdSql.Data.FirebirdClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;

namespace INFOMASTER
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNCM_Click(object sender, EventArgs e)
        {
            try
            {
                string sql1 = "UPDATE PRODUTO SET PRO_COD_NCM = '30049099' WHERE COALESCE(pro_cod_ncm,'') <> '' and CHAR_LENGTH(trim(pro_cod_ncm)) < 8";
                int linhasAfetadas1 = BD.ExecutarSQL(sql1);
                rtbLog.AppendText("Script 1 executado com " + linhasAfetadas1 + " linhas afetadas.\n");
                rtbLog.AppendText("Script executado: " + sql1 + "\n\n");

                string sql2 = "UPDATE PRODUTO SET PRO_COD_NCM = '30049099' WHERE PRO_COD_NCM = ' '";
                int linhasAfetadas2 = BD.ExecutarSQL(sql2);
                rtbLog.AppendText("Script 2 executado com " + linhasAfetadas2 + " linhas afetadas.\n");
                rtbLog.AppendText("Script executado: " + sql2 + "\n\n");

                string sql3 = "UPDATE PRODUTO SET PRO_COD_NCM = '30049099' WHERE PRO_COD_NCM IS NULL";
                int linhasAfetadas3 = BD.ExecutarSQL(sql3);
                rtbLog.AppendText("Script 3 executado com " + linhasAfetadas3 + " linhas afetadas.\n");
                rtbLog.AppendText("Script executado: " + sql3 + "\n\n");

                MessageBox.Show("Atualizações concluídas com sucesso!");
            }
            catch (Exception ex)
            {
                string erro = "Erro ao executar as atualizações: " + ex.Message;
                rtbLog.AppendText(erro + "\n\n");
                MessageBox.Show(erro);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string script = "update produto set " +
                               "\r\npro_ini_promo = '27/OCT/2020 00:00:00' " +
                               "\r\nwhere " +
                               "\r\npro_val_promo is not null";

                rtbLog.AppendText("Executando o seguinte script:\n" + script + "\n");

                int linhasAfetadas = BD.ExecutarSQL(script);

                string mensagem = "Script executado com sucesso. Linhas afetadas: " + linhasAfetadas;
                rtbLog.AppendText(mensagem + "\n");

                MessageBox.Show(mensagem);
            }
            catch (Exception ex)
            {
                string erro = "Erro ao executar o script: " + ex.Message;
                rtbLog.AppendText(erro + "\n");

                MessageBox.Show(erro);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
              

                string insertSql1 = "UPDATE OR INSERT INTO CONDPGTO (CPT_COD, CPT_DESCR, CPT_AVISTA, CPT_STATUS, CPT_PARCELAS, CPT_DIAS, CPT_ENTRADA, CPT_PERC_ENTRADA, CPT_FINANCEIRA, CPT_TAXA, CPT_TIPO_TAXA) VALUES (1, 'A Vista', 'S', 'S', 1, NULL, NULL, NULL, NULL, NULL, NULL)";
                int linhasInseridas1 = BD.ExecutarSQL(insertSql1);
                rtbLog.AppendText("Registro inserido com sucesso: " + linhasInseridas1 + "\n");
                rtbLog.AppendText("Script executado: " + insertSql1 + "\n\n");

                string insertSql2 = "UPDATE OR INSERT INTO CONDPGTO (CPT_COD, CPT_DESCR, CPT_AVISTA, CPT_STATUS, CPT_PARCELAS, CPT_DIAS, CPT_ENTRADA, CPT_PERC_ENTRADA, CPT_FINANCEIRA, CPT_TAXA, CPT_TIPO_TAXA) VALUES (2, 'A Prazo - 30 Dias', 'N', 'S', 1, 30, 'N', NULL, NULL, NULL, NULL)";
                int linhasInseridas2 = BD.ExecutarSQL(insertSql2);
                rtbLog.AppendText("Registro inserido com sucesso: " + linhasInseridas2 + "\n");
                rtbLog.AppendText("Script executado: " + insertSql2 + "\n\n");

                string insertSql3 = "UPDATE OR INSERT INTO CONDPGTO (CPT_COD, CPT_DESCR, CPT_AVISTA, CPT_STATUS, CPT_PARCELAS, CPT_DIAS, CPT_ENTRADA, CPT_PERC_ENTRADA, CPT_FINANCEIRA, CPT_TAXA, CPT_TIPO_TAXA) VALUES (3, 'A Prazo - 30/60 Dias', 'N', 'S', 2, 30, 'N', NULL, NULL, NULL, 'P')";
                int linhasInseridas3 = BD.ExecutarSQL(insertSql3);
                rtbLog.AppendText("Registro inserido com sucesso: " + linhasInseridas3 + "\n");
                rtbLog.AppendText("Script executado: " + insertSql3 + "\n\n");

                MessageBox.Show("Inserções concluídas com sucesso!");
            }
            catch (Exception ex)
            {
                string erro = "Erro ao executar as operações: " + ex.Message;
                rtbLog.AppendText(erro + "\n\n");
                MessageBox.Show(erro);
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
