/* Пример GUI-приложения с доступом к БД.
 * 
 * В данном приложение доступ к БД настраивается с помощью визуальных конструкторов VS.
 * 
 * В результате использования визуальных конструктора компонента DataGridView был сгенерирован файл AutoLotDataSet.xsd. 
 * 
 * В файле AutoLotDataSet.Designer.cs определены ряд автоматически сгенерированных классов: AutoLotDataSet, InventoryDataTable, InventoryDataRow, InventoryTableAdapter.
 * 
 * Все они скрывают прямую работу с БД.
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

namespace AutoLotGridViewForm
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoLotDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.autoLotDataSet.Inventory);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.inventoryTableAdapter.Update(this.autoLotDataSet.Inventory);
        }
    }
}
