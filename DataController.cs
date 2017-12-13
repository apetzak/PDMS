using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace PDMS
{
    public class DataController
    {
        public SQLiteConnection dbConnection = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3;");
        public SQLiteCommand command = new SQLiteCommand();
        public SQLiteDataReader reader;
        public string sql = "";

        public DataController()
        {
            command = new SQLiteCommand(sql, dbConnection);
        }

        public void ExecuteNonQuery()
        {
            try
            {
                dbConnection.Open();
                command = new SQLiteCommand(sql, dbConnection);
                command.ExecuteNonQuery();
                dbConnection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void StartReader()
        {
            dbConnection.Open();
            command = new SQLiteCommand(sql, dbConnection);
            reader = command.ExecuteReader();
        }

        public void CreateTables()
        {
            dbConnection.Open();
            //CreateTable("CREATE TABLE users (username VARCHAR(30), password VARCHAR(30), role INT, branch VARCHAR(30))");
            //CreateTable("CREATE TABLE medicines (name VARCHAR(30), price DECIMAL, casePrice DECIMAL, expirationDay INT)");
            //CreateTable("CREATE TABLE patients (name VARCHAR(50), dateOfBirth DATETIME, prescription VARCHAR(100), insurance VARCHAR(50), lastVisitDate DATETIME, email VARCHAR(100), address VARCHAR(100))");
            //CreateTable("CREATE TABLE warehouses (name VARCHAR(50), address VARCHAR(50), defaultExpectedDelivery INT)");
            CreateTable("CREATE TABLE inventory (medicine VARCHAR(30), warehouse VARCHAR(50), quantity INT, shipmentNumber INT, expireDate VARCHAR(50))");
            //CreateTable("CREATE TABLE orders (id INT, medicine VARCHAR(200), patient VARCHAR(50), pharmacist VARCHAR(50), date VARCHAR(50), expectedDelivery VARCHAR(50), completed INT)");
            //CreateTable("CREATE TABLE lineitems (id INT, medicine VARCHAR(50), uofm INT)");
            dbConnection.Close();
        }

        public void CreateTable(string s)
        {
            sql = s;
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        public void InsertData()
        {
            //dbConnection.Open();

            //Insert("insert into medicines (name, price, casePrice, expirationDay, shipmentNumber, quantity) " +
            //       "values ('Super Pills', 3.50, 10.00, 90, 112233, 100)", command);

            //Insert("insert into patients (firstName, lastName, dateOfBirth, prescription, insurance, lastVisitDate) " +
            //       "values ('Vic', 'Rattlehead', '2017-02-03', 'Super Pill', 'Reliable Insurance', '2017-02-03')", command);

            //Insert("insert into warehouses (name, address, inventory, stockableMedicines, earliestExpireDate, defaultExpectedDelivery) " +
            //      "values ('North', '123 North St.', 'inventory', 'stock medicine', '2017-02-03', 4)", command);

            //dbConnection.Close();
        }

        public void Insert(string sql, SQLiteCommand command)
        {
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
        }

        public string DataName = "";
        public string SelectedRowName = "";

        public void UpdateData(DataGridView dgv, Label lblCount, string header, DataGridViewCellEventArgs e)
        {
            #region add data from bottom row
            bool create = true;
            foreach (DataGridViewCell c in dgv.Rows[Convert.ToInt32(lblCount.Text)].Cells)
                if ((c.Value == null || c.Value.ToString() == ""))
                    create = false;

            if (create)
            {
                DataGridViewRow row = dgv.Rows[Convert.ToInt32(lblCount.Text)];

                if (header == "Medicines")
                {
                    sql = "insert into medicines (name, price, casePrice, expirationDay) " +
                          "values ('" + row.Cells[0].Value.ToString() + "', " + Convert.ToDouble(row.Cells[1].Value) +
                          ", " + Convert.ToDouble(row.Cells[2].Value) + ", " + Convert.ToInt32(row.Cells[3].Value) + ")";
                }
                else if (header == "Patients")
                {
                    sql = "insert into patients (name, dateOfBirth, prescription, insurance, lastVisitDate, email, address) " +
                          "values ('" + row.Cells[0].Value.ToString() + "', '" + row.Cells[1].Value.ToString() + "', '" + row.Cells[2].Value.ToString() +
                          "', '" + row.Cells[3].Value.ToString() + "', '" + row.Cells[4].Value.ToString() + "', '" + row.Cells[5].Value.ToString() + 
                          "', '" + row.Cells[6].Value.ToString() + "')";
                }
                else if (header == "Warehouses")
                {
                    sql = "insert into warehouses (name, address, defaultExpectedDelivery) " +
                          "values ('" + row.Cells[0].Value.ToString() + "', '" + row.Cells[1].Value.ToString() + "', " + Convert.ToInt32(row.Cells[2].Value) + ")";
                }
                ExecuteNonQuery();
                lblCount.Text = Convert.ToString(Convert.ToInt32(lblCount.Text) + 1);
                return;
            }
            #endregion

            #region update data

            DataName = GetDataName(dgv.Columns[e.ColumnIndex].Name);

            if (header == "Medicines")
                sql = "update medicines set " + DataName + " = '" + dgv[e.ColumnIndex, e.RowIndex].Value + "' where name = '" + SelectedRowName + "'";

            else if (header == "Patients")
                sql = "update patients set " + DataName + " = '" + dgv[e.ColumnIndex, e.RowIndex].Value + "' where name = '" + SelectedRowName + "'";

            else if (header == "Warehouses")
                sql = "update warehouses set " + DataName + " = '" + dgv[e.ColumnIndex, e.RowIndex].Value + "' where name = '" + SelectedRowName + "'";

            try
            {
                ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            #endregion
        }

        public void GetColumn(string columnName, string dataName, DataGridViewCellEventArgs e, DataGridView dgv)
        {
            if (dgv.Columns[e.ColumnIndex].Name == columnName)
                DataName = dataName;
        }

        public void DeleteData()
        {
            sql = "delete * from medicines, patients, warehouses";
            ExecuteNonQuery();
        }

        public void LoadData(string header, DataGridView dgv, string filter, string comboSelection)
        {
            dgv.Rows.Clear();
           
            if (header == "Medicines")
            {
                sql = "select * from medicines";

                if (filter != "")
                    sql = sql + " where " + GetDataName(comboSelection) + " like '%" + filter + "%'";

                StartReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(new object[] {
                    reader.GetValue(0),
                    reader.GetValue(1),
                    reader.GetValue(2),
                    reader.GetValue(3),
                    });
                }
            }               
            else if (header == "Patients")
            {
                sql = "select * from patients";

                if (filter != "")
                    sql = sql + " where " + GetDataName(comboSelection) + " like '%" + filter + "%'";

                StartReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(new object[] {
                    reader.GetValue(0),
                    reader.GetValue(1),
                    reader.GetValue(2),
                    reader.GetValue(3),
                    reader.GetValue(4),
                    reader.GetValue(5),
                    reader.GetValue(6),
                    });
                }
            }             
            else if (header == "Warehouses")
            {
                sql = "select * from warehouses";

                if (filter != "")
                    sql = sql + " where " + GetDataName(comboSelection) + " like '%" + filter + "%'";

                StartReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(new object[] {
                    reader.GetValue(0),
                    reader.GetValue(1),
                    reader.GetValue(2),
                    });
                }
            }
            else
            {
                sql = "select * from inventory where warehouse='" + header + "'";

                if (filter != "")
                    sql = sql + " where " + GetDataName(comboSelection) + " like '%" + filter + "%'";

                StartReader();

                while (reader.Read())
                {
                    dgv.Rows.Add(new object[] {
                    reader.GetValue(0),
                    reader.GetValue(2),
                    reader.GetValue(3),
                    reader.GetValue(4),
                    });
                }
            }                
           
            dbConnection.Close();
        }

        public string GetDataName(string comboSelection)
        {
            if (comboSelection == "Case Price")
                return "casePrice";
            if (comboSelection == "Expiration Days")
                return "expirationDay";
            if (comboSelection == "Shipment Number")
                return "shipmentNumber";
            if (comboSelection == "Date of Birth")
                return "dateOfBirth";
            if (comboSelection == "Last Visit Date")
                return "lastVisitDate";
            if (comboSelection == "Stockable Medicines")
                return "stockableMedicines";
            if (comboSelection == "Earliest Expire Date")
                return "earliestExpireDate";
            if (comboSelection == "Default Expected Delivery")
                return "defaultExpectedDelivery";
            if (comboSelection == "Email")
                return "email";
            if (comboSelection == "Address")
                return "address";
            return comboSelection;
        }

        public void InsertShipment(string medicine, string warehouse, int quantity, int shipmentNumber, string expireDate)
        {
            sql = "insert into inventory (medicine, warehouse, quantity, shipmentNumber, expireDate) " +
                   "values ('" + medicine + "', '" + warehouse + "', " + quantity + ", '" + shipmentNumber
                   + "', '" + expireDate + "')";

            ExecuteNonQuery();
        }

        public void ImportData(string filePath, string type)
        {
            StreamReader reader = new StreamReader(filePath);

            while (true)
            {
                string line = reader.ReadLine();
                string[] values = line.Split(',');

                if (line == null)
                {
                    break;
                }

                if (type == "Medicines")
                    sql = "insert into medicines (name, price, casePrice, expirationDay) " +
                          "values ('" + values[0] + "', '" + values[1] + "', '" + values[2] + "', " + values[3] + ")";

                else if (type == "Patients")
                    sql = "insert into patients (name, dateOfBirth, prescription, insurance, lastVisitDate, email) " +
                          "values ('" + values[0] + "', '" + values[1] + "', '" + values[2] + "', '" + values[3] + "', '" + values[4] + "', '" + values[5] + "')";

                else if (type == "Warehouses")
                    sql = "insert into warehouses (name, address, defaultExpectedDelivery) " + 
                          "values ('" + values[0] + "', '" + values[1] + "', '" + values[2] + "')";

                else if (type == "Inventory")
                    sql = "insert into inventory (medicine, warehouse, quantity, shipmentNumber, expireDate) " + 
                          "values ('" + values[0] + "', '" + values[1] + "', " + values[2] + ", " + values[3] + ", '" + values[4] + "')";

                ExecuteNonQuery();
            }
        }

        #region users

        public void InsertUser(string name, int role, string branch)
        {
            sql = "insert into users (username, password, role, branch) " + 
                  "values ('" + name + "', ' ', " + role + ", '" + branch + "')";
            ExecuteNonQuery();
        }

        public void DeleteUser(string name)
        {
            sql = "delete from users where username ='" + name + "'";
            ExecuteNonQuery();
        }

        public void SetPassword(string username, string password)
        {
            sql = "update users set password='" + password + "' where username='" + username + "'";
            ExecuteNonQuery();
        }

        public string LoadUserName(string username)
        {
            string s = "";

            sql = "select * from users where username ='" + username + "'";

            StartReader();

            while (reader.Read())
            {
                s = reader.GetString(0);
            }

            dbConnection.Close();

            return s;
        }

        public int LoadUserRole(string username)
        {
            int i = 0;

            sql = "select role from users where username ='" + username + "'";

            StartReader();

            while (reader.Read())
            {
                i = reader.GetInt32(0);
            }

            dbConnection.Close();
            return i;
        }

        public string LoadUserPassword(string username)
        {
            string s = "";

            sql = "select password from users where username ='" + username + "'";

            StartReader();

            while (reader.Read())
            {
                s = reader.GetString(0);
            }

            dbConnection.Close();
            return s;
        }

        public void LoadUsers(DataGridView dgv)
        {
            dgv.Rows.Clear();

            sql = "select * from users";

            StartReader();
            while (reader.Read())
            {
                string role = "";

                if (Convert.ToInt32(reader.GetValue(2)) == 0)
                    role = "Administrator";
                if (Convert.ToInt32(reader.GetValue(2)) == 1)
                    role = "Pharmacist";
                if (Convert.ToInt32(reader.GetValue(2)) == 2)
                    role = "Financial Manager";

                dgv.Rows.Add(new object[] {
                    reader.GetValue(0),
                    role,
                    reader.GetValue(3),
                    });
            }
            dbConnection.Close();
        }
        #endregion

        public List<string> LoadName(string table)
        {
            List<string> list = new List<string>();

            sql = "select name from " + table;

            StartReader();

            while (reader.Read())
            {
                list.Add(reader.GetValue(0).ToString());
            }
            dbConnection.Close();

            return list;
        }

        public List<string> LoadPrescriptions(string patient)
        {
            List<string> list = new List<string>();

            sql = "select prescription from patients where name='" + patient + "'";

            StartReader();

            while (reader.Read())
            {
                string prescription = reader.GetValue(0).ToString();
                string[] prescriptions = prescription.Split(',');

                foreach (string s in prescriptions)
                {
                    if (s.StartsWith(" "))
                    {
                        list.Add(s.Remove(0, 1));
                        list.Add(s.Remove(0, 1) + " - Case");
                    }                   
                    else
                    {
                        list.Add(s);
                        list.Add(s + " - Case");
                    }                                         
                }
                    
            }
            dbConnection.Close();

            return list;
        }

        public int LoadExpectedDelivery(string branch)
        {
            int i = 0;

            sql = "select defaultExpectedDelivery from warehouses where name='" + branch + "'";
            StartReader();
            while (reader.Read())
            {
                i = reader.GetInt32(0);
            }
            dbConnection.Close();

            return i;
        }

        public string LoadUserBranch(string user)
        {
            string i = "";

            sql = "select branch from users where username='" + user + "'";

            StartReader();
            while (reader.Read())
            {
                i = reader.GetValue(0).ToString();
            }
            dbConnection.Close();

            return i;
        }

        public decimal LoadPrice(string item, string uofm)
        {
            decimal i = 0;

            if (uofm == "Each")
                sql = "select price from medicines where name='" + item + "'";
            else
            {
                item = item.Remove(item.Length - 7);
                sql = "select casePrice from medicines where name='" + item + "'";            
            }
                
            StartReader();
            while (reader.Read())
            {
                i = reader.GetDecimal(0);
            }
            dbConnection.Close();

            return i;
        }

        public int LoadOrderCount()
        {
            int i = 1;

            sql = "select * from orders";

            StartReader();
            while (reader.Read())
            {
                i++;
            }
            dbConnection.Close();

            return i;
        }

        public int LoadShipmentCount()
        {
            int i = 1;

            sql = "select * from inventory";

            StartReader();
            while (reader.Read())
            {
                i++;
            }
            dbConnection.Close();

            return i;
        }

        public void CreateOrder(int id, string medicine, string patient, string pharmacist, DateTime date, DateTime expectedDelivery, int completed)
        {
            string d = date.ToString("yyyy-MM-dd");
            string ed = expectedDelivery.ToString("yyyy-MM-dd");

            sql = "insert into orders (id, medicine, patient, pharmacist, date, expectedDelivery, completed) " +
                  "values (" + id + ", '" + medicine + "', '" + patient + "', '" + pharmacist + "', '" + d + "', '" + ed + "', " + completed + ")";
            ExecuteNonQuery();
        }

        public void LoadOrders(DataGridView dgv)
        {
            sql = "select * from orders";

            StartReader();

            while (reader.Read())
            {
                dgv.Rows.Add(new object[] {
                    reader.GetValue(0),
                    reader.GetValue(1),
                    reader.GetValue(2),
                    reader.GetValue(3),
                    reader.GetValue(4),
                    reader.GetValue(5),
                    reader.GetValue(6),
                    });
            }
            dbConnection.Close();
        }

        public void LoadMedicines(ComboBox combo)
        {
            sql = "select name from medicines";

            StartReader();

            while (reader.Read())
            {
                combo.Items.Add(reader.GetValue(0).ToString());
            }
            dbConnection.Close();
        }

        public string LoadExpireDate(string medicine)
        {
            string s = "";
            int days = 0;

            sql = "select expirationDay from medicines where name='" + medicine + "'";

            StartReader();

            while (reader.Read())
            {
                days = reader.GetInt32(0);
            }
            dbConnection.Close();

            DateTime date = DateTime.Today;
            date = date.AddDays(days);

            s = date.ToString("yyyy-MM-dd");

            return s;
        }

        public void LoadLineItems(DataGridView dgv, int orderNumber)
        {
            sql = "select * from orders where id='" + orderNumber + "'";

            StartReader();

            while (reader.Read())
            {
                string value = reader.GetString(1);

                string[] medicines = value.Split(',');

                foreach (string s in medicines)
                {
                    string uofm = "Each";
                    string name = s;

                    if (s.EndsWith("Case"))
                    {
                        name = s.Remove(s.Length - 7);
                        uofm = "Case";
                    }

                    if (name.StartsWith(" "))
                        name = name.Remove(0, 1);

                    dgv.Rows.Add(new object[] {
                    name,
                    uofm,
                    reader.GetValue(6),
                    });
                }
            }
            dbConnection.Close();
        }

        public void LoadAvailableQty(ComboBox combo, string medicine)
        {
            sql = "select * from inventory where medicine='" + medicine + "'";

            StartReader();

            while (reader.Read())
            {
                string s = "Qty " + reader.GetValue(2).ToString() + " / " + reader.GetValue(1).ToString() + " / " + reader.GetValue(3).ToString() + " / " + reader.GetValue(4).ToString();
                combo.Items.Add(s);
            }
            dbConnection.Close();
        }

        public void UpdateInventory(string shipmentNumber, int uofm)
        {
            int quantity = 0;

            if (uofm == 0)
                quantity = 1;
            else
                quantity = 10;

            sql = "select quantity from inventory where shipmentNumber=" + shipmentNumber;

            StartReader();

            int qtyAvail = 0;
            while (reader.Read())
            {
                qtyAvail = reader.GetInt32(0);
            }
            dbConnection.Close();

            sql = "update inventory set quantity =" + (qtyAvail - quantity) + " where shipmentNumber=" + shipmentNumber;
            ExecuteNonQuery();
        }

        public void UpdateOrder(int orderNumber, string pharmacist)
        {
            sql = "update orders set completed=1 where id=" + orderNumber;
            ExecuteNonQuery();
    
            sql = "update orders set pharmacist='" + pharmacist + "' where id=" + orderNumber;
            ExecuteNonQuery();
        }
    }
}
