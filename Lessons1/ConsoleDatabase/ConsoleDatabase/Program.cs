using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using AutoLotConnectedLayer;
using AutoLotDataSetDLL;
using AutoLotDataSetDLL.DataSet1TableAdapters;

namespace ConsoleDatabase
{
    class Program
    {
        //Процедура подключения к БД 
        //Имя провайдера и строка подключения берутся из конфигурационного файла приложения
        //В данном случае используется сервер MS SQL Server, провайдер System.Data.Client, и подключаемя к базе AutoLot
        //В процедуре для создания подключения используется DbProviderFactory
        public static void ConnectToDB()
        {
            string provider = ConfigurationManager.AppSettings["provider"];

            string cnStr = ConfigurationManager.AppSettings["cnStr"];

            Console.WriteLine("Provider: {0}", provider);
            Console.WriteLine("Connection string: {0}", cnStr);

            DbProviderFactory dbf = DbProviderFactories.GetFactory(provider);

            using (DbConnection cn = dbf.CreateConnection())
            {
                cn.ConnectionString = cnStr;
                cn.Open();

                Console.WriteLine("Connection type: {0}", cn.GetType().Name);
                Console.WriteLine("Server version: {0}", cn.ServerVersion);
                Console.WriteLine("Server: {0}", cn.DataSource);
                Console.WriteLine("Database: {0}", cn.Database);
                Console.WriteLine("Connection state: {0}", cn.State);

                DbCommand cmd = dbf.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from Inventory";

                Console.WriteLine("\n****Cars****");

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Car {0} is a {1}", reader["CarID"], reader["Make"]);
                    }
                }

                Console.WriteLine("\n****Customers****");

                cmd.CommandText = "Select * from Customers";

                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Customer {0} is a {1}", reader["CustID"], reader["FirstName"]);
                    }
                }
            }
        }

        //Вместо DbProviderFactory объекты подключения создаются напрямую
        public static void ConnectToDB2()
        {
            string provider = ConfigurationManager.AppSettings["provider"];

            string cnStr = ConfigurationManager.AppSettings["cnStr"];

            Console.WriteLine("Provider: {0}", provider);
            Console.WriteLine("Connection string: {0}", cnStr);           

            using (SqlConnection cn = new SqlConnection(cnStr))
            {
                cn.ConnectionString = cnStr;
                cn.Open();

                Console.WriteLine("Connection type: {0}", cn.GetType().Name);
                Console.WriteLine("Server version: {0}", cn.ServerVersion);
                Console.WriteLine("Server: {0}", cn.DataSource);
                Console.WriteLine("Database: {0}", cn.Database);
                Console.WriteLine("Connection state: {0}", cn.State);

               
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select * from Inventory";

                Console.WriteLine("\n****Cars****");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Car {0} is a {1}", reader["CarID"], reader["Make"]);
                    }
                }

                Console.WriteLine("\n****Customers****");

                cmd.CommandText = "Select * from Customers";
                /*
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("Customer {0} is a {1}", reader["CustID"], reader["FirstName"]);
                    }
                }*/
                GetData(cmd.ExecuteReader());
            }
        }

        public static void GetSchema(DbConnection cn)
        {
            DataTable schema = cn.GetSchema();

            Console.WriteLine(schema.TableName);

            for (int j = 0; j < schema.Rows.Count; j++)
            {
                for (int i = 0; i < schema.Columns.Count; i++)
                {
                    Console.WriteLine("{0}: {1}", schema.Columns[i].ColumnName, schema.Rows[j][i]);
                }
            }
        }

        public static void GetData(DbDataReader reader)
        {
            while(reader.Read())
            {
                for(int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write("{0} = {1}, ", reader.GetName(i), reader.GetValue(i).ToString());
                }
                Console.WriteLine("");
            }
        }

        //Получение данных из таблицы Inventory базы данных AutoLot 
        //с помощью класса InventoryDAL библиотеки классов AutoLotConnDAL
        public static void GetInventoryData(string cnStr)
        {
            InventoryDAL inv = new InventoryDAL();

            inv.OpenConnection(cnStr);

            inv.PrintInventory();

            inv.InsertAuto(14, "AutoVAZ", "Red", "Niva");

            inv.DeleteCar(11);

            inv.UpdateCar(14, "Niva Chevr");

            Console.WriteLine(inv.GetPetName(14));
            Console.WriteLine("");

            inv.PrintInventory();

            DisplayData(inv.GetInventoryAsList());

            DisplayData(inv.GetInventoryAsTable());

            inv.CloseConnection();
        }

        //Отображение данных списка
        public static void DisplayData(List<Car> list)
        {
            foreach(Car car in list)
            {
                Console.WriteLine("{0} {1} {2} {3}", car.CarID, car.Make, car.Color, car.PetName);
            }
        }

        //Отображение данных таблицы (класс DataTable)
        public static void DisplayData(DataTable tb)
        {
            for(int i = 0; i < tb.Columns.Count; i++)
            {
                Console.Write(tb.Columns[i].ColumnName + "\t");
            }

            Console.WriteLine();

            for(int i = 0; i < tb.Rows.Count; i++)
            {
                for(int j = 0; j < tb.Columns.Count; j++)
                {
                    Console.Write(tb.Rows[i][j].ToString() + "\t");
                }
                Console.WriteLine();
            }

        }

        //Создание объекта DataSet
        public static void CreateDataSet()
        {
            DataSet ds = new DataSet("AutoLot");

            DataColumn colCarId = new DataColumn();
            colCarId.ColumnName = "CarID";
            colCarId.DataType = typeof(int);
            colCarId.Caption = "Car ID";
            colCarId.ReadOnly = true;
            colCarId.AllowDBNull = false;
            colCarId.Unique = true;

            colCarId.AutoIncrement = true;
            colCarId.AutoIncrementSeed = 0;
            colCarId.AutoIncrementStep = 1;

            DataColumn colMake = new DataColumn("Make", typeof(string));
            DataColumn colColor = new DataColumn("Color", typeof(string));
            DataColumn colPetName = new DataColumn("PetName", typeof(string));

            DataTable tb = new DataTable("Inventory");
            tb.Columns.AddRange(new DataColumn[] { colCarId, colMake, colColor, colPetName });

            DataRow row1 = tb.NewRow();
            row1["Make"] = "BMW";
            row1["Color"] = "Green";
            row1["PetName"] = "BMW 3";
            tb.Rows.Add(row1);

            row1 = tb.NewRow();
            row1["Make"] = "Saab";
            row1["Color"] = "Yellow";
            row1["PetName"] = "Sea Breaze";
            tb.Rows.Add(row1);

            ds.Tables.Add(tb);

            PrintDataSet(ds);

            SaveToXML(ds);

            SaveToBinary(ds);
            

            //Сохранение DataTable в файл с помощью сериализации
        }

        //Вывод на консоль данных из объекта DataSet
        public static void PrintDataSet(DataSet ds)
        {
            Console.WriteLine("DataSet: {0}", ds.DataSetName);
            
            foreach(DataTable tb in ds.Tables)
            {
                Console.WriteLine("Table:   {0}", tb.TableName);

                Console.WriteLine();

                for (int col = 0; col < tb.Columns.Count; col++ )
                {
                    Console.Write(tb.Columns[col] + "\t");
                }

                Console.WriteLine();

                for (int row = 0; row < tb.Rows.Count; row++)
                {
                    for (int col = 0; col < tb.Columns.Count; col++)
                    {
                            Console.Write(tb.Rows[row][col] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        //Сохранение DataSet в файл XML
        public static void SaveToXML(DataSet ds)
        {
            ds.WriteXml("AutoLot.xml");
            ds.WriteXmlSchema("AutoLotScheme.xsd");
        }

        //Сериализация объекта DataSet с помощью BinaryFormatter
        public static void SaveToBinary(DataSet ds)
        {
            ds.RemotingFormat = SerializationFormat.Binary;

            using(FileStream fs = new FileStream("AutoLotBinary.bin", FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, ds);
            }
        }

        //Манипулирование строкой и отображение ее состояния RowState
        public static void ManipulateRows()
        {
            DataTable tb = new DataTable();
            tb.Columns.Add(new DataColumn("Temp", typeof(string)));

            DataRow row = tb.NewRow();
            Console.WriteLine("Row state (new row): {0}", row.RowState);

            tb.Rows.Add(row);
            Console.WriteLine("Row state (add in table): {0}", row.RowState);

            row["Temp"] = "mystr";
            Console.WriteLine("Row state (change): {0}", row.RowState);

            tb.AcceptChanges();
            Console.WriteLine("Row state (after accept): {0}", row.RowState);

            tb.Rows[0].Delete();
            Console.WriteLine("Row state (after delete): {0}", row.RowState);
        }

        //Процедура получения данных из БД с помощью SqlDataAdapter и запись их в объект DataSet
        public static void GetDataSet(string cnStr)
        {
            SqlConnection cn = new SqlConnection(cnStr);

            SqlDataAdapter da = new SqlDataAdapter("select * from Inventory", cn);

                        DataTableMapping map = da.TableMappings.Add("Inventory", "Inventory");
                        map.ColumnMappings.Add("CarID", "Car ID");
                        map.ColumnMappings.Add("PetName", "Name of Car");

            DataSet ds = new DataSet("Inventory");

            da.Fill(ds, "Inventory");

            PrintDataSet(ds);
        }

        //Использование библиотеки классов AutoLotConnectedLayer 
        //Данная библиотека была создана вручную
        public static void CreateDataAdapter(string cnStr)
        {
            InventoryDataSet inv = new InventoryDataSet(cnStr);

            DataTable tb = inv.GetInventory();

            DisplayData(tb);
        }

        //Использование библиотеки классов AutoLotDataSetDLL 
        //Данная библиотека сгенерирована автоматические при добавлении в проект элемента DataSet
        public static void GetDataFromDB2()
        {
            AutoLotDataSet.InventoryDataTable tb = new AutoLotDataSet.InventoryDataTable();

            InventoryTableAdapter da = new InventoryTableAdapter();

            da.Fill(tb);
            /*DisplayData(tb);

            Console.ReadLine();

            Console.WriteLine("***************************************\n");
            AddRecords(tb, da);
            DisplayData(tb);

            Console.ReadLine();

            Console.WriteLine("***************************************\n");
            RemoveRecord(tb, da);
            //DisplayData(tb);
            */
            EnumerableRowCollection enumData = tb.AsEnumerable();
            foreach(DataRow car in enumData)
            {
                Console.WriteLine("CarID: {0}", car["CarID"]);
            }

            GetDataByLINQ_3(tb);
        }

        public static void GetDataByLINQ(DataTable data)
        {
            var cars = from car in data.AsEnumerable() 
                       where (string)car["Color"] == "Red"
                       select new 
                       { 
                           CarID = car["CarID"], 
                           Make = car["Make"] 
                       };
            
            foreach (var item in cars)
            {
                Console.WriteLine("Red car: {0} {1}", item.CarID, item.Make);
            }
        }

        public static void GetDataByLINQ_2(DataTable data)
        {
            var cars = from car in data.AsEnumerable()
                       
                       where car.Field<string>("Color") == "Red"

                       select new
                       {
                           CarID = car.Field<int>("CarID"),
                           Make = car.Field<string>("Make")
                       };

            foreach (var item in cars)
            {
                Console.WriteLine("Red car: {0} {1}", item.CarID, item.Make);
            }
        }

        public static void GetDataByLINQ_3(DataTable table)
        {
            var rows = from row in table.AsEnumerable()
                       where (string)row["Color"] == "Red"
                       select row;                       

            foreach (var item in rows)
            {
                Console.WriteLine("Red car: {0} {1}", item["CarID"], item["Make"]);
            }
        }

        public static void AddRecords(AutoLotDataSet.InventoryDataTable tb, InventoryTableAdapter da)
        {
            AutoLotDataSet.InventoryRow newRow = tb.NewInventoryRow();
            newRow.CarID = 15;
            newRow.Make = "GAZ";
            newRow.Color = "Green";
            newRow.PetName = "Volga";
            tb.AddInventoryRow(newRow);

            tb.AddInventoryRow(16, "GAZ", "Black", "Volga 2");

            da.Update(tb);
        }

        public static void RemoveRecord(AutoLotDataSet.InventoryDataTable tb, InventoryTableAdapter da)
        {
            AutoLotDataSet.InventoryRow row = tb.FindByCarID(15);

            da.Delete(row.CarID, row.Make, row.Color, row.PetName);

            row = tb.FindByCarID(16);

            da.Delete(row.CarID, row.Make, row.Color, row.PetName);

            tb.Clear();

            da.Fill(tb);            
        }

        static void Main(string[] args)
        {
            //ConnectToDB();
            //ConnectToDB2();
            
            string cnStr = ConfigurationManager.AppSettings["cnStr"];

            //Доступ к базе данных с помощью класса InventoryDAL реализованного в библиотеке AutoLotConnDAL
            //GetInventoryData(cnStr);
            
            //Манипулирование строкой и отображение ее состояния RowState
            //ManipulateRows();
            //CreateDataSet();

            //Процедура получения данных из БД с помощью SqlDataAdapter и запись их в объект DataSet
            //GetDataSet(cnStr);

            //Процедура использование библиотеки классов AutoLotConnectedLayer
            //CreateDataAdapter(cnStr);

            //Процедура использование библиотеки классов AutoLotDataSetDLL
            GetDataFromDB2();

            Console.ReadLine();
        }
    }
}
