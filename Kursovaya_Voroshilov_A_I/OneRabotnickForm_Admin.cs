using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;
using System.IO;

namespace Kursovaya_Voroshilov_A_I
{
    public partial class OneRabotnickForm_Admin : Form
    {
        Worker4Admin W4A = null;

        internal OneRabotnickForm_Admin(string Code, string Name, string Family, string Otchestvo, string Pol, string Date, DataTable HistOfPrinAndUv, DataTable HistOfZpHistory, Worker4Admin W4A)
        {
            InitializeComponent();
            this.Code_Of_Rabotnick_TB.Text = Code;
            this.Name_TB.Text = Name;
            this.Family_TB.Text = Family;
            this.Otchestvo_TB.Text = Otchestvo;
            this.Pol_TB.Text = Pol;
            this.Date_TB.Text = Date;
            this.DGV_Prin_Uvol_History.DataSource = HistOfPrinAndUv;
            this.DGV_ZP_History.DataSource = HistOfZpHistory;
            this.W4A = W4A;
            
            for (int x = 0; x<Otobr_1_Tabl.Items.Count; x++)
            {
                Otobr_1_Tabl.SetItemChecked(x, true);
            }

            for (int x = 0; x < Otobr_2_Tabl.Items.Count; x++)
            {
                Otobr_2_Tabl.SetItemChecked(x, true);
            }
        }

        private void GoToCode_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника = " + GoToCode_TB.Text);

            if(DT.Rows.Count <1)
            {
                MessageBox.Show("Пользователь с таким кодом отсутствует");
                return;
            }

            DataRow DR = DT.Rows[0];
            this.Code_Of_Rabotnick_TB.Text = DR[0].ToString();
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
            this.Date_TB.Text = DR[5].ToString();

            DataTable DTable_Prin = W4A.GetTableFromZapros("select * from Принятия_и_увольнения_работников where Код_работника = " + GoToCode_TB.Text);
            /*CheckedListBox.CheckedIndexCollection CLB_CIC1 = Otobr_1_Tabl.CheckedIndices;
            for(int x = DTable_Prin.Columns.Count; x>0; x--)
            {
                if(!CLB_CIC1.Contains(x-1))
                {
                    DTable_Prin.Columns.RemoveAt(x-1);
                }
            }*/
            this.DGV_Prin_Uvol_History.DataSource = DTable_Prin;

            DataTable DTable_Hist = W4A.GetTableFromZapros("select * from Зачисления_зарплат where Код_работника = " + GoToCode_TB.Text);
            /*CheckedListBox.CheckedIndexCollection CLB_CIC2 = Otobr_2_Tabl.CheckedIndices;
            for (int x = DTable_Hist.Columns.Count; x > 0; x--)
            {
                if (!CLB_CIC2.Contains(x - 1))
                {
                    DTable_Hist.Columns.RemoveAt(x - 1);
                }
            }*/
            this.DGV_ZP_History.DataSource = DTable_Hist;

            Refresh_Demonstration_Buttom_Click(null, null);
        }

        private void Refresh_Demonstration_Buttom_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection CLB_CIC1 = Otobr_1_Tabl.CheckedIndices;
            for (int x = DGV_Prin_Uvol_History.Columns.Count; x > 0; x--)
            {
                if (!CLB_CIC1.Contains(x - 1))
                {
                    if (DGV_Prin_Uvol_History.Columns[x - 1].Visible)
                    {
                        DGV_Prin_Uvol_History.Columns[x - 1].Visible = false;
                    }
                }
                else
                {
                    if (!DGV_Prin_Uvol_History.Columns[x - 1].Visible)
                    {
                        DGV_Prin_Uvol_History.Columns[x - 1].Visible = true;
                    }
                }
            }

            CheckedListBox.CheckedIndexCollection CLB_CIC2 = Otobr_2_Tabl.CheckedIndices;
            for (int x = DGV_ZP_History.Columns.Count; x > 0; x--)
            {
                if (!CLB_CIC2.Contains(x - 1))
                {
                    if (DGV_ZP_History.Columns[x - 1].Visible)
                    {
                        DGV_ZP_History.Columns[x - 1].Visible = false;
                    }
                }
                else
                {
                    if (!DGV_ZP_History.Columns[x - 1].Visible)
                    {
                        DGV_ZP_History.Columns[x - 1].Visible = true;
                    }
                }
            }

        }

        private void Refresh_Content_Btn_Click(object sender, EventArgs e)
        {
            DataTable DT = W4A.GetTableFromZapros("select * from ПерсДанныеРаботников where Код_работника = " + Code_Of_Rabotnick_TB.Text);

            DataRow DR = DT.Rows[0];
            this.Name_TB.Text = DR[1].ToString();
            this.Family_TB.Text = DR[2].ToString();
            this.Otchestvo_TB.Text = DR[3].ToString();
            this.Pol_TB.Text = DR[4].ToString();
            this.Date_TB.Text = DR[5].ToString();

            DataTable DTable_Prin = W4A.GetTableFromZapros("select * from Принятия_и_увольнения_работников where Код_работника = " + Code_Of_Rabotnick_TB.Text);
            this.DGV_Prin_Uvol_History.DataSource = DTable_Prin;

            DataTable DTable_Hist = W4A.GetTableFromZapros("select * from Зачисления_зарплат where Код_работника = " + Code_Of_Rabotnick_TB.Text);
            this.DGV_ZP_History.DataSource = DTable_Hist;

            Refresh_Demonstration_Buttom_Click(null, null);
        }
    }
}
