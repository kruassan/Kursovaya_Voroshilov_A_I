using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Voroshilov_A_I
{
    public partial class AsAdministrator : Form
    {
        Worker4Admin W4A = null;

        internal AsAdministrator(Worker4Admin W4A)
        {
            InitializeComponent();
            this.W4A = W4A;
        }

        private void SelectTables_LB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            switch (((ListView)sender).SelectedItems[0].Text)
            {
                case ("Персональные данные работников"):
                    {
                        new Admin_Person_danniye(W4A).Show();
                        break;
                    }
                case ("Предприятия"):
                    {
                        new Admin_Predpriyatiya(W4A).Show();
                        break;
                    }

                case ("Должности"):
                    {
                        new Admin_Doljnosti(W4A).Show();
                        break;
                    }

                case ("Зарплата"):
                    {
                        new Admin_Zachisleniya_Zarplat(W4A).Show();
                        //Code4Aechive
                        break;
                    }
                case ("Трудовая история работников"):
                    {
                        new Admin_Prin_U_Rabotnikov(W4A).Show();
                        //Code4Aechive
                        break;
                    }
                case ("Вакансии"):
                    {
                        new Admin_Vacancyes(W4A).Show();
                        //Code4Aechive
                        break;
                    }
                case ("Резюме"):
                    {
                        new Admin_Resumes(W4A).Show();
                        //Code4Aechive
                        break;
                    }
                case ("Доступ"):
                    {
                        //Code4Aechive
                        break;
                    }
            }
        }

        private void GoServer_Btn_Click(object sender, EventArgs e)
        {
            new ServerForm(W4A).Show();
        }
    }
}
