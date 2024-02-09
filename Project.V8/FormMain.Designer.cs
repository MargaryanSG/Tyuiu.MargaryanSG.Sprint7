
namespace Project.V8
{
    partial class FormMain
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
            this.btnAddCar_CAG = new System.Windows.Forms.Button();
            this.btnAddDriver_CAG = new System.Windows.Forms.Button();
            this.btnAddTrip_CAG = new System.Windows.Forms.Button();
            this.btnSaveToFile_CAG = new System.Windows.Forms.Button();
            this.btnLoadFromFile_CAG = new System.Windows.Forms.Button();
            this.btnDisplayInfo_CAG = new System.Windows.Forms.Button();
            this.dataGridView_CAG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CAG)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCar_CAG
            // 
            this.btnAddCar_CAG.Location = new System.Drawing.Point(16, 5);
            this.btnAddCar_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCar_CAG.Name = "btnAddCar_CAG";
            this.btnAddCar_CAG.Size = new System.Drawing.Size(181, 37);
            this.btnAddCar_CAG.TabIndex = 0;
            this.btnAddCar_CAG.Text = "Добавить авто";
            this.btnAddCar_CAG.UseVisualStyleBackColor = true;
            // 
            // btnAddDriver_CAG
            // 
            this.btnAddDriver_CAG.Location = new System.Drawing.Point(16, 50);
            this.btnAddDriver_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDriver_CAG.Name = "btnAddDriver_CAG";
            this.btnAddDriver_CAG.Size = new System.Drawing.Size(181, 37);
            this.btnAddDriver_CAG.TabIndex = 1;
            this.btnAddDriver_CAG.Text = "Добавить водителя";
            this.btnAddDriver_CAG.UseVisualStyleBackColor = true;
            // 
            // btnAddTrip_CAG
            // 
            this.btnAddTrip_CAG.Location = new System.Drawing.Point(205, 33);
            this.btnAddTrip_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTrip_CAG.Name = "btnAddTrip_CAG";
            this.btnAddTrip_CAG.Size = new System.Drawing.Size(158, 37);
            this.btnAddTrip_CAG.TabIndex = 2;
            this.btnAddTrip_CAG.Text = "Добавить поездку";
            this.btnAddTrip_CAG.UseVisualStyleBackColor = true;
            // 
            // btnSaveToFile_CAG
            // 
            this.btnSaveToFile_CAG.Location = new System.Drawing.Point(396, 5);
            this.btnSaveToFile_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveToFile_CAG.Name = "btnSaveToFile_CAG";
            this.btnSaveToFile_CAG.Size = new System.Drawing.Size(160, 37);
            this.btnSaveToFile_CAG.TabIndex = 3;
            this.btnSaveToFile_CAG.Text = "Сохранить в файл";
            this.btnSaveToFile_CAG.UseVisualStyleBackColor = true;
            // 
            // btnLoadFromFile_CAG
            // 
            this.btnLoadFromFile_CAG.Location = new System.Drawing.Point(396, 50);
            this.btnLoadFromFile_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoadFromFile_CAG.Name = "btnLoadFromFile_CAG";
            this.btnLoadFromFile_CAG.Size = new System.Drawing.Size(160, 37);
            this.btnLoadFromFile_CAG.TabIndex = 4;
            this.btnLoadFromFile_CAG.Text = "Загрузить из файла";
            this.btnLoadFromFile_CAG.UseVisualStyleBackColor = true;
            this.btnLoadFromFile_CAG.Click += new System.EventHandler(this.btnLoadFromFile_Click_1);
            // 
            // btnDisplayInfo_CAG
            // 
            this.btnDisplayInfo_CAG.Location = new System.Drawing.Point(564, 13);
            this.btnDisplayInfo_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisplayInfo_CAG.Name = "btnDisplayInfo_CAG";
            this.btnDisplayInfo_CAG.Size = new System.Drawing.Size(154, 72);
            this.btnDisplayInfo_CAG.TabIndex = 5;
            this.btnDisplayInfo_CAG.Text = "Отобразить информацию";
            this.btnDisplayInfo_CAG.UseVisualStyleBackColor = true;
            // 
            // dataGridView_CAG
            // 
            this.dataGridView_CAG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CAG.Location = new System.Drawing.Point(16, 111);
            this.dataGridView_CAG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_CAG.Name = "dataGridView_CAG";
            this.dataGridView_CAG.RowHeadersWidth = 51;
            this.dataGridView_CAG.Size = new System.Drawing.Size(1040, 272);
            this.dataGridView_CAG.TabIndex = 6;
            // 
            // FormMain_CAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 422);
            this.Controls.Add(this.dataGridView_CAG);
            this.Controls.Add(this.btnDisplayInfo_CAG);
            this.Controls.Add(this.btnLoadFromFile_CAG);
            this.Controls.Add(this.btnSaveToFile_CAG);
            this.Controls.Add(this.btnAddTrip_CAG);
            this.Controls.Add(this.btnAddDriver_CAG);
            this.Controls.Add(this.btnAddCar_CAG);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain_CAG";
            this.Text = "Автотранспортное предприятие | Спринт 7 | Вариант 8 | Группа: РПСб-23-1 | Чебулаев А.Г.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CAG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar_CAG;
        private System.Windows.Forms.Button btnAddDriver_CAG;
        private System.Windows.Forms.Button btnAddTrip_CAG;
        private System.Windows.Forms.Button btnSaveToFile_CAG;
        private System.Windows.Forms.Button btnLoadFromFile_CAG;
        private System.Windows.Forms.Button btnDisplayInfo_CAG;
        private System.Windows.Forms.DataGridView dataGridView_CAG;
    }
}