/* Библиотеке классов для доступа к базе данных AutoLot.
 * 
 * Класс Inventory - реализует подключенный уровень доступа к таблице Inventory.
 * 
 * Подключенный уровень - операции работают напрямую с таблицей БД.* 
 * 
 * Автономный уровень - данные загружаются в объект DataSet и затем над ними проводятся операции. После этого изменения отправляются из DataSet в БД.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotConnectedLayer
{
    public class Car
    {
        public int CarID;
        public string Make;
        public string Color;
        public string PetName;
    }

    //Класс реализует доступ к таблице Inventory
    //Доступ осуществляется на так называемом подключенном уровне
    public class InventoryDAL
    {
        private SqlConnection cn = null;

        public void OpenConnection(string strCon)
        {
            cn = new SqlConnection();
            cn.ConnectionString = strCon;
            cn.Open();
        }

        public void CloseConnection()
        {
            cn.Close();
        }

        public void InsertAuto(int carid, string make, string color, string petname)
        {
            string sql = string.Format("Insert Into Inventory (CarID, Make, Color, PetName) Values('{0}', '{1}', '{2}', '{3}')", carid, make, color, petname);
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertAuto(Car car)
        {
            string sql = string.Format("Insert into Inventory (CarID, Make, Color, PetName) Values ('{0}', '{1}', '{2}', '{3}')", car.CarID, car.Make, car.Color, car.PetName);

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCar(int id)
        {
            string sql = string.Format("Delete from Inventory where CarID = '{0}'", id);
            try
            {
                using(SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Delete command error: {0}", ex.Message);
            }
        }

        public void UpdateCar(int id, string PetName)
        {
            string sql = string.Format("Update Inventory Set PetName = '{0}' Where CarID = '{1}'", PetName, id);

            try
            {
                using(SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Update command error: {0}", ex.Message);
            }
        }

        public void PrintInventory()
        {
            string sql = string.Format("Select * from Inventory");
            try
            {
                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2} {3}", reader["CarID"], reader["Make"], reader["Color"], reader["PetName"]);
                    }

                    reader.Close();
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Print command error: {0}", ex.Message);
            }
        }

        public List<Car> GetInventoryAsList()
        {
            string sql = string.Format("Select * from Inventory");

            List<Car> list = new List<Car>();

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Car()
                    { 
                        CarID = (int)reader["CarID"],
                        Make = (string)reader["Make"],
                        Color = (string)reader["Color"],
                        PetName = (string)reader["PetName"]
                    });
                }
                reader.Close();
            }

            return list;
        }

        public DataTable GetInventoryAsTable()
        {
            DataTable table = new DataTable();

            string sql = string.Format("Select * from Inventory");

            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();

                table.Load(reader);

                reader.Close();
            }

            return table;
        }

        public string GetPetName(int carid)
        {
            string carPetName = string.Empty;

            try
            {
                using (SqlCommand cmd = new SqlCommand("GetPetName", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@carID";
                    param1.SqlDbType = SqlDbType.Int;
                    param1.SqlValue = carid;
                    param1.Direction = ParameterDirection.Input;
                    cmd.Parameters.Add(param1);

                    SqlParameter param2 = new SqlParameter();
                    param2.ParameterName = "@petName";
                    param2.SqlDbType = SqlDbType.Char;
                    param2.Size = 10;
                    param2.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(param2);

                    cmd.ExecuteNonQuery();
                    carPetName = (string)cmd.Parameters["@petName"].Value;
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return carPetName;
        }
    }

    public class InventoryDataSet
    {
        private string cnStr = string.Empty;
        private SqlDataAdapter da = null;

        public InventoryDataSet(string cnStr)
        {
            this.cnStr = cnStr;

            ConfigureAdapter(out da);
        }

        protected void ConfigureAdapter(out SqlDataAdapter da)
        {
            da = new SqlDataAdapter("select * from Inventory", cnStr);

            SqlCommandBuilder builder = new SqlCommandBuilder(da);
        }

        public DataTable GetInventory()
        {
            DataTable tb = new DataTable();

            da.Fill(tb);

            return tb;
        }

        public void UpdateInventory(DataTable tb)
        {
            da.Update(tb);
        }
    }
}
