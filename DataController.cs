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
            dbConnection.Open();
            command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();
            dbConnection.Close();
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
            CreateTable("CREATE TABLE users (username VARCHAR(30), password VARCHAR(30), role INT, branch VARCHAR(30))");
            CreateTable("CREATE TABLE medicines (name VARCHAR(30), price DECIMAL, casePrice DECIMAL, expirationDay INT, shipmentNumber INT, quantity INT)");
            CreateTable("CREATE TABLE patients (firstName VARCHAR(20), lastName VARCHAR(20), dateOfBirth DATETIME, prescription VARCHAR(100), insurance VARCHAR(50), lastVisitDate DATETIME)");
            CreateTable("CREATE TABLE warehouses (name VARCHAR(50), address VARCHAR(50), inventory VARCHAR(500), stockableMedicines VARCHAR(500), earliestExpireDate DATETIME, defaultExpectedDelivery INT)");
            //CreateTable("CREATE TABLE orders ()");
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
            dbConnection.Open();

            Insert("insert into medicines (name, price, casePrice, expirationDay, shipmentNumber, quantity) " +
                   "values ('Super Pills', 3.50, 10.00, 90, 112233, 100)", command);

            Insert("insert into patients (firstName, lastName, dateOfBirth, prescription, insurance, lastVisitDate) " +
                   "values ('Vic', 'Rattlehead', '2017-02-03', 'Super Pill', 'Reliable Insurance', '2017-02-03')", command);

            Insert("insert into warehouses (name, address, inventory, stockableMedicines, earliestExpireDate, defaultExpectedDelivery) " +
                  "values ('North', '123 North St.', 'inventory', 'stock medicine', '2017-02-03', 4)", command);

            dbConnection.Close();
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
                if (c.Value == null || c.Value.ToString() == "")
                    create = false;

            if (create)
            {
                DataGridViewRow row = dgv.Rows[Convert.ToInt32(lblCount.Text)];

                if (header == "Medicines")
                {
                    sql = "insert into medicines (name, price, casePrice, expirationDay, shipmentNumber, quantity) " +
                          "values ('" + row.Cells[0].Value.ToString() + "', " + Convert.ToDouble(row.Cells[1].Value) +
                          ", " + Convert.ToDouble(row.Cells[2].Value) + ", " + Convert.ToInt32(row.Cells[3].Value) +
                          ", " + Convert.ToInt32(row.Cells[4].Value) + ", " + Convert.ToInt32(row.Cells[5].Value) + ")";
                }
                else if (header == "Patients")
                {
                    sql = "insert into patients (firstName, lastName, dateOfBirth, prescription, insurance, lastVisitDate) " +
                          "values ('" + row.Cells[0].Value.ToString() + "', '" + row.Cells[1].Value.ToString() +
                          "', '" + row.Cells[2].Value.ToString() + "', '" + row.Cells[3].Value.ToString() +
                          "', '" + row.Cells[4].Value.ToString() + "', '" + row.Cells[5].Value.ToString() + "')";
                }
                else if (header == "Warehouses")
                {
                    sql = "insert into warehouses (name, address, inventory, stockableMedicines, earliestExpireDate, defaultExpectedDelivery) " +
                          "values ('" + row.Cells[0].Value.ToString() + "', '" + row.Cells[1].Value.ToString() +
                          "', '" + row.Cells[2].Value.ToString() + "', '" + row.Cells[3].Value.ToString() +
                          "', '" + Convert.ToDateTime(row.Cells[4].Value) + "', " + Convert.ToInt32(row.Cells[5].Value) + ")";
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
                sql = "update patients set " + DataName + " = '" + dgv[e.ColumnIndex, e.RowIndex].Value + "' where firstName = '" + SelectedRowName + "'";

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
                sql = "select * from medicines";

            else if (header == "Patients")
                sql = "select * from patients";

            else if (header == "Warehouses")
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
                    reader.GetValue(3),
                    reader.GetValue(4),
                    reader.GetValue(5),
                    });
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
            if (comboSelection == "First Name")
                return "firstName";
            if (comboSelection == "Last Name")
                return "lastName";
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
            return comboSelection;
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

                string s = "values ('" + values[0] + "', '" + values[1] + "', '" + values[2] + "', '" + values[3] + "', '" + values[4] + "', '" + values[5] + "')";

                if (type == "Medicines")
                    sql = "insert into medicines (name, price, casePrice, expirationDay, shipmentNumber, quantity) " + s;

                else if (type == "Patients")
                    sql = "insert into patients (firstName, lastName, dateOfBirth, prescription, insurance, lastVisitDate) " + s;

                else if (type == "Warehouses")
                    sql = "insert into warehouses (name, address, inventory, stockableMedicines, earliestExpireDate, defaultExpectedDelivery) " + s;

                ExecuteNonQuery();
            }
        }
    }
}
