/* Пример GUI-приложения для работы с классом DataTable.
 * 
 * Подключение к БД отсутствует.
 * 
 * Здесь показана только работа с классом DataTable. Это так называемый автономный уровень в ADO.NET. 
 * 
 * Создается объекта DataTable, наполняется данными и привязывается к визуальному компоненту DataGridView
 * с помощью свойства DataSource.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoLotConnectedLayer;

namespace AutoLotForm
{
    public partial class MainForm : Form
    {
        List<Car> cars = null;
        DataTable tb = new DataTable();
        DataView dv;
        public MainForm()
        {
            InitializeComponent();

            CreateTable();

            CreateView();
        }

        private void CreateTable()
        {
            cars = new List<Car>()
            {
                new Car(){ CarID = 1, Make = "Opel", Color = "Black", PetName="Astra"},
                new Car(){ CarID = 2, Make = "Opel", Color = "Green", PetName="Astra"},
                new Car(){ CarID = 3, Make = "Opel", Color = "Yellow", PetName="Astra"},
                new Car(){ CarID = 4, Make = "Opel", Color = "White", PetName="Astra"},
                new Car(){ CarID = 5, Make = "BMW", Color = "Black", PetName="BMW 3"},
                new Car(){ CarID = 6, Make = "AutoVAZ", Color = "Black", PetName="Niva"},
                new Car(){ CarID = 7, Make = "GM", Color = "Black", PetName="Mustang"},
                new Car(){ CarID = 8, Make = "Ford", Color = "Black", PetName="Focus"},
                new Car(){ CarID = 9, Make = "Ferrary", Color = "Black", PetName="Ferrary1"},
                new Car(){ CarID = 10, Make = "Shkoda", Color = "Black", PetName="Shkoda1"}
            };

            DataColumn colCarId = new DataColumn("CarID", typeof(int));
            DataColumn colMake = new DataColumn("Make", typeof(string));
            DataColumn colColor = new DataColumn("Color", typeof(string));
            DataColumn colPetName = new DataColumn("PetName", typeof(string));

            tb.Columns.AddRange(new DataColumn[] { colCarId, colMake, colColor, colPetName });

            foreach (Car car in cars)
            {
                DataRow row = tb.NewRow();
                row["CarID"] = car.CarID;
                row["Make"] = car.Make;
                row["Color"] = car.Color;
                row["PetName"] = car.PetName;
                tb.Rows.Add(row);
            }

            carInventory.DataSource = tb;
        }

        private void CreateView()
        {
            dv = new DataView(tb);

            dv.RowFilter = "Make = 'AutoVAZ'";

            dataGridView1.DataSource = dv;
        }

        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] rows = tb.Select(string.Format("CarID={0}", int.Parse(textBoxCarID.Text)));

                rows[0].Delete();

                tb.AcceptChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string filter = string.Format("Make='{0}'", textBoxMake.Text);

            DataRow[] rows = tb.Select(filter);

            string strMake = "";

            foreach(DataRow row in rows)
            {
                strMake += row["PetName"] + "\n";
            }

            MessageBox.Show(strMake);
        }

        private void buttonChangeMake_Click(object sender, EventArgs e)
        {
            string filter = string.Format("Make='{0}'", textBoxMake.Text);

            DataRow[] rows = tb.Select(filter);

            foreach (DataRow row in rows)
            {
                row["Make"] = textBoxChange.Text;
            }
        }
    }
}
