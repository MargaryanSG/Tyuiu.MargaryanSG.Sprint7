using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progect.V8.Lib;

namespace Project.V8
{
    public partial class FormMain : Form
    {
        private readonly DataService dataProcessor;
        private TextBox txtInformation;
        private Button btnShowDeveloperInfo;

        public FormMain()
        {
            InitializeComponent();
            dataProcessor = new DataService();
            InitializeControls();
            RefreshDataGrid();
        }

        private void InitializeControls()
        {
            dataGridView_CAG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            txtInformation = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Bottom,
                Height = 100
            };

            btnShowDeveloperInfo = new Button
            {
                Text = "Показать информацию о разработчике",
                Location = new System.Drawing.Point(12, 250),
                Size = new System.Drawing.Size(250, 30)
            };

            btnShowDeveloperInfo.Click += btnShowDeveloperInfo_Click_CAG;

            btnAddCar_CAG.Click += btnAddCar_Click_CAG;
            btnAddDriver_CAG.Click += btnAddDriver_Click_CAG;
            btnAddTrip_CAG.Click += btnAddTrip_Click_CAG;
            btnSaveToFile_CAG.Click += btnSaveToFile_Click_CAG;
            btnLoadFromFile_CAG.Click += btnLoadFromFile_Click_CAG;
            btnDisplayInfo_CAG.Click += btnDisplayInfo_Click_CAG;

            Controls.Add(txtInformation);
            Controls.Add(btnShowDeveloperInfo);
        }

        private void btnAddCar_Click_CAG(object sender, EventArgs e)
        {
            dataProcessor.Cars.Add(new Car
            {
                Brand = "Toyota",
                LicensePlate = "р000нв 72",
                TechnicalCondition = "Хорошо",
                Location = "Гараж",
                AverageSpeed = 60.0,
                LoadCapacity = 500.0,
                FuelConsumption = 10.0
            });

            RefreshDataGrid();
        }

        private void btnAddDriver_Click_CAG(object sender, EventArgs e)
        {
            dataProcessor.Drivers.Add(new Driver
            {
                LastName = "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                DateOfBirth = new DateTime(1980, 1, 1),
                Experience = 10,
                Salary = 1000
            });

            RefreshDataGrid();
        }

        private void btnAddTrip_Click_CAG(object sender, EventArgs e)
        {
            dataProcessor.Trips.Add(new Trip
            {
                DepartureDate = DateTime.Now,
                ArrivalDate = DateTime.Now.AddDays(1),
                Destination = "Город Тюмень",
                Distance = 200.0,
                FuelConsumption = 15.0,
                CargoWeight = 300.0
            });

            RefreshDataGrid();
        }

        private void btnSaveToFile_Click_CAG(object sender, EventArgs e)
        {
            dataProcessor.SaveToFile("DataFile.bin");
        }

        private void btnLoadFromFile_Click_CAG(object sender, EventArgs e)
        {
            dataProcessor.LoadFromFile("DataFile.bin");
            RefreshDataGrid();
        }

        private void btnShowDeveloperInfo_Click_CAG(object sender, EventArgs e)
        {
            DisplayInformation();
        }

        private void btnDisplayInfo_Click_CAG(object sender, EventArgs e)
        {
            MessageBox.Show("Автотранспортное предприятие | Спринт 7 | Вариант 8 | Группа: РПСб-23-1 | Чебулаев Андрей Геннадьнвич", "Информация о разработчике", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshDataGrid()
        {
            dataGridView_CAG.DataSource = null;
            dataGridView_CAG.DataSource = dataProcessor.Cars;
        }

        private void DisplayInformation()
        {
            if (dataGridView_CAG.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView_CAG.SelectedRows[0].Index;

                if (dataGridView_CAG.DataSource is BindingSource bindingSource)
                {
                    if (bindingSource.DataSource is System.Collections.Generic.List<Car> cars)
                    {
                        if (selectedIndex >= 0 && selectedIndex < cars.Count)
                        {
                            Car selectedCar = cars[selectedIndex];

                            string information = $"Номерной знак: {selectedCar.LicensePlate}\nМарка: {selectedCar.Brand}\nТехническое состояние: {selectedCar.TechnicalCondition}";

                            MessageBox.Show(information, "Информация об автомобиле", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnLoadFromFile_Click_1(object sender, EventArgs e)
        {

        }
    }
}