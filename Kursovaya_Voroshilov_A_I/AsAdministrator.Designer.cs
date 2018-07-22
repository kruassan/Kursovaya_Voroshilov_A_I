namespace Kursovaya_Voroshilov_A_I
{
    partial class AsAdministrator
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Должности", 1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Зарплата", 3);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Персональные данные работников", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Предприятия", 4);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Трудовая история работников", 5);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Вакансии", 7);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Резюме", 8);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Доступ", 6);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsAdministrator));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectTables_LB = new System.Windows.Forms.ListView();
            this.ImagesOfTables = new System.Windows.Forms.ImageList(this.components);
            this.GoServer_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите интересующую вас таблицу:";
            // 
            // SelectTables_LB
            // 
            this.SelectTables_LB.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.SelectTables_LB.LargeImageList = this.ImagesOfTables;
            this.SelectTables_LB.Location = new System.Drawing.Point(12, 38);
            this.SelectTables_LB.MultiSelect = false;
            this.SelectTables_LB.Name = "SelectTables_LB";
            this.SelectTables_LB.Size = new System.Drawing.Size(764, 109);
            this.SelectTables_LB.TabIndex = 1;
            this.SelectTables_LB.UseCompatibleStateImageBehavior = false;
            this.SelectTables_LB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SelectTables_LB_MouseDoubleClick);
            // 
            // ImagesOfTables
            // 
            this.ImagesOfTables.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImagesOfTables.ImageStream")));
            this.ImagesOfTables.TransparentColor = System.Drawing.Color.Transparent;
            this.ImagesOfTables.Images.SetKeyName(0, "Archive.png");
            this.ImagesOfTables.Images.SetKeyName(1, "Doljnost.png");
            this.ImagesOfTables.Images.SetKeyName(2, "Lichiye_Danniye.jpg");
            this.ImagesOfTables.Images.SetKeyName(3, "Oplata.png");
            this.ImagesOfTables.Images.SetKeyName(4, "Predpriyatiye.jpg");
            this.ImagesOfTables.Images.SetKeyName(5, "Личность.png");
            this.ImagesOfTables.Images.SetKeyName(6, "dostup.png");
            this.ImagesOfTables.Images.SetKeyName(7, "vacansy.png");
            this.ImagesOfTables.Images.SetKeyName(8, "Rezyume.png");
            // 
            // GoServer_Btn
            // 
            this.GoServer_Btn.Location = new System.Drawing.Point(797, 77);
            this.GoServer_Btn.Name = "GoServer_Btn";
            this.GoServer_Btn.Size = new System.Drawing.Size(137, 40);
            this.GoServer_Btn.TabIndex = 2;
            this.GoServer_Btn.Text = "Перейти к запуску сервера";
            this.GoServer_Btn.UseVisualStyleBackColor = true;
            this.GoServer_Btn.Click += new System.EventHandler(this.GoServer_Btn_Click);
            // 
            // AsAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 387);
            this.Controls.Add(this.GoServer_Btn);
            this.Controls.Add(this.SelectTables_LB);
            this.Controls.Add(this.label1);
            this.Name = "AsAdministrator";
            this.Text = "AsAdministrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView SelectTables_LB;
        private System.Windows.Forms.ImageList ImagesOfTables;
        private System.Windows.Forms.Button GoServer_Btn;
    }
}