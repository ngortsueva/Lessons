/* Пример GUI-приложения для работы в автономном уровена ADO.NET.
 * 
 * Используются следующие классы: DataSet, SqlDataAdapter, SqlCommandBuilder. 
 * Класс DataRelation используется для установки отношений(связи) между таблицами внутри DataSet. 
 * В дальнейшем благодаря установленным связям можно использовать процедуры GetClientRows, GetParentRows класса DataRow.
 * 
 * В приложении устанавливается подключение к БД AutoLot (строка соединения сохранена в конфигурационном файле).
 * Данные отображаются в визуальных компонентах DataGridView.  
 * Приложение позволяет обновлять данные с помощью кнопки Update. 
 * При использовании кнопки Order - выводится информация о заказе выбранного клиента (ID клиент указывается в текстовом поле).
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AutoLotForm2
{
    public partial class FormMain : Form
    {
        private DataSet ds = new DataSet("AutoLot");
        private SqlCommandBuilder bldInv;
        private SqlCommandBuilder bldCust;
        private SqlCommandBuilder bldOrd;

        private SqlDataAdapter daInv;
        private SqlDataAdapter daCust;
        private SqlDataAdapter daOrd;
        public FormMain()
        {
            InitializeComponent();

            string cnStr = ConfigurationManager.ConnectionStrings["AutoLot"].ConnectionString;

            daInv = new SqlDataAdapter("select * from Inventory", cnStr);
            daCust= new SqlDataAdapter("select * from Customers", cnStr);
            daOrd = new SqlDataAdapter("select * from Orders", cnStr);

            bldInv = new SqlCommandBuilder(daInv);
            bldCust = new SqlCommandBuilder(daCust);
            bldOrd = new SqlCommandBuilder(daOrd);

            daInv.Fill(ds, "Inventory");
            daCust.Fill(ds, "Customers");
            daOrd.Fill(ds, "Orders");

            BuildTableRelationship();

            gridInventory.DataSource = ds.Tables["Inventory"];
            gridCustomers.DataSource = ds.Tables["Customers"];
            gridOrders.DataSource = ds.Tables["Orders"];


        }

        private void BuildTableRelationship()
        {
            DataRelation dr1 = new DataRelation("CustomerOrder",
                ds.Tables["Customers"].Columns["CustID"],
                ds.Tables["Orders"].Columns["CustID"]
                );
            ds.Relations.Add(dr1);

            DataRelation dr2 = new DataRelation("InventoryOrder",
                ds.Tables["Inventory"].Columns["CarID"],
                ds.Tables["Orders"].Columns["CarID"]
                );

            ds.Relations.Add(dr2);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                daInv.Update(ds, "Inventory");
                daCust.Update(ds, "Customers");
                daOrd.Update(ds, "Orders");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonGetOrder_Click(object sender, EventArgs e)
        {
            string strOrderInfo = string.Empty;
            DataRow[] drsCust = null;
            DataRow[] drsOrder = null;

            int nCustId = int.Parse(textCustId.Text);

            drsCust = ds.Tables["Customers"].Select(string.Format("CustID={0}", nCustId));

            strOrderInfo += string.Format("Customer {0}: {1} {2}\n",
                drsCust[0]["CustID"].ToString(),
                drsCust[0]["FirstName"].ToString(),
                drsCust[0]["LastName"].ToString()
            );

            drsOrder = drsCust[0].GetChildRows(ds.Relations["CustomerOrder"]);

            foreach(DataRow order in drsOrder)
            {
                strOrderInfo += "\n****Order Info****\n";

                DataRow[] drsInv = order.GetParentRows(ds.Relations["InventoryOrder"]);

                DataRow car = drsInv[0];

                strOrderInfo += string.Format("Make: {0}\n", car["Make"]);
                strOrderInfo += string.Format("Color: {0}\n", car["Color"]);
                strOrderInfo += string.Format("PetName: {0}\n", car["PetName"]);
            }

            MessageBox.Show(strOrderInfo);
        }
    }
}
