using ServiceApplication.DataAccess.Abstract;
using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.DataAccess.Concrete.SQL
{
    public class ServiceDal:IServiceDal
    {
        string connectionString = "Data Source=DORUKPC5;Initial Catalog=master;User ID=sa;Password=sapass;Persist Security Info =False"; // Bağlantı dizesi
        string databaseName = "MyVdsDatabase"; // VDS veritabanı adı

        public void CheckAndCreate() {
            string tableName = "ServiceApp";
            CheckAndCreateDatabase();
            CheckAndCreateTable(tableName);
        }
        public void CheckAndCreateDatabase()
        {
            if (CheckDatabaseExists(connectionString, databaseName))
            {
                Console.WriteLine("VDS veritabanı zaten mevcut.");
            }
            else
            {
                if (CreateDatabase(connectionString, databaseName))
                {
                    Console.WriteLine("VDS veritabanı başarıyla oluşturuldu.");
                }
                else
                {
                    Console.WriteLine("VDS veritabanı oluşturma hatası.");
                }
            }
        }
        static bool CheckDatabaseExists(string connectionString, string databaseName)
        {
            try
            {
                // SQL Server'a bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanını sorgula
                    string query = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }
        static bool CreateDatabase(string connectionString, string databaseName)
        {
            try
            {
                // SQL Server'a bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Veritabanı oluşturma komutunu hazırla
                    string createDatabaseQuery = $"CREATE DATABASE {databaseName}";

                    // Komutu SQL Server'a gönder
                    using (SqlCommand command = new SqlCommand(createDatabaseQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }
        public void CheckAndCreateTable(string tableName)
        {
            if (CheckTableExists(connectionString, databaseName, tableName))
            {
                Console.WriteLine($"Tablo '{tableName}' zaten mevcut.");
            }
            else
            {
                if (CreateTable(connectionString, databaseName, tableName))
                {
                    Console.WriteLine($"Tablo '{tableName}' başarıyla oluşturuldu.");
                }
                else
                {
                    Console.WriteLine($"Tablo '{tableName}' oluşturma hatası.");
                }
            }
        }
        static bool CheckTableExists(string connectionString, string databaseName, string tableName)
        {
            try
            {
                // SQL Server'a bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tabloyu sorgula
                    string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = '{tableName}'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }
        static bool CreateTable(string connectionString, string databaseName, string tableName)
        {
            try
            {
                // SQL Server'a bağlan
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tablo oluşturma komutunu hazırla
                    string createTableQuery = $"USE {databaseName}; CREATE TABLE {tableName} (SERVICE_ID INT PRIMARY KEY," +
                        $"CUSTOMER_NAME NVARCHAR(255)," +
                        $"CUSTOMER_SURNAME NVARCHAR(255)," +
                        $"CUSTOMER_ADDRESS NVARCHAR(255), " +
                        $"CUSTOMER_TELEPHONE INT, " +
                        $"CUSTOMER_EMAİL NVARCHAR(255), " +
                        $"PERSON_OF_CONTACT NVARCHAR(255)," +
                        $"DESC_PROPERTY NVARCHAR(MAX)," +
                        $"SPECİAL_NOTE NVARCHAR(MAX), " +
                        $"ACTUALLY_PERFORMED INT," +
                        $"JOB_KİND NVARCHAR(255), " +
                        $"DATE_SERTAKEPLACE DATETIME, " +
                        $"DATE_SERTOOKPLACE DATETIME," +
                        $"DATE_TWOWEEKS DATETIME,  " +
                        $"CHARGE_BEING INT," +
                        $"CHARGE_DONE INT, " +
                        $"PAID_ALONG INT, " +
                        $"BALANCE INT," +
                        $"ResimData VARBINARY(MAX) NULL)";

                    // Komutu SQL Server'a gönder
                    using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }
        public List<Service> GetAll()
        {
            CheckAndCreate();
            SqlConnection aconnection = new SqlConnection("...");
            SqlCommand command = new SqlCommand("Select * from ServiceApp ", aconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Service> serviceInfo = new List<Service>();
            while (reader.Read())
            {
                Service service = new Service()
                {
                    SERVICE_ID = Convert.ToInt32(reader["SERVICE_ID"]),
                    CUSTOMER_NAME = Convert.ToString(reader["CUSTOMER_NAME"]),
                    CUSTOMER_SURNAME= Convert.ToString(reader["CUSTOMER_SURNAME"]),
                    CUSTOMER_ADDRESS = Convert.ToString(reader["CUSTOMER_ADDRESS"]),
                    CUSTOMER_TELEPHONE = Convert.ToInt32(reader["CUSTOMER_TELEPHONE"]),
                    CUSTOMER_EMAİL = Convert.ToString(reader["CUSTOMER_EMAİL"]),
                    PERSON_OF_CONTACT = Convert.ToString(reader["PERSON_OF_CONTACT"]),
                    DESC_PROPERTY = Convert.ToString(reader["DESC_PROPERTY"]),
                    SPECİAL_NOTE = Convert.ToString(reader["SPECİAL_NOTE"]),
                    ACTUALLY_PERFORMED = Convert.ToInt32(reader["ACTUALLY_PERFORMED"]),
                    JOB_KİND = Convert.ToString(reader["JOB_KİND"]),
                    DATE_SERTAKEPLACE = Convert.ToDateTime(reader["DATE_SERTAKEPLACE"]),
                    DATE_SERTOOKPLACE = Convert.ToDateTime(reader["DATE_SERTOOKPLACE"]),
                    DATE_TWOWEEKS = Convert.ToDateTime(reader["DATE_TWOWEEKS"]),
                    CHARGE_BEING = Convert.ToInt32(reader["CHARGE_BEING"]),
                    CHARGE_DONE = Convert.ToInt32(reader["CHARGE_DONE"]),
                    PAID_ALONG = Convert.ToInt32(reader["PAID_ALONG"]),
                    BALANCE = Convert.ToInt32(reader["BALANCE"]),
                    SELECTED_IMAGE_DATA= (byte[])reader["SELECTED_IMAGE_DATA"],
            };
                serviceInfo.Add(service);

            }
            reader.Close();
            aconnection.Close();

            return serviceInfo;
        }
        public void Add(Service service)
        {

            CheckAndCreate();
            SqlConnection aconnection = new SqlConnection("...");
            SqlCommand command = new SqlCommand(
                "INSERT INTO YourTableName VALUES (@CUSTOMER_NAME,@CUSTOMER_SURNAME, @CUSTOMER_ADDRESS, @CUSTOMER_TELEPHONE, @CUSTOMER_EMAİL, @PERSON_OF_CONTACT, @DESC_PROPERTY, @SPECİAL_NOTE, " +
                "@ACTUALLY_PERFORMED, @JOB_KİND, @DATE_SERTAKEPLACE, @DATE_SERTOOKPLACE, @DATE_TWOWEEKS, @CHARGE_BEING, @CHARGE_DONE, @PAID_ALONG, @BALANCE,@SELECTED_IMAGE_DATA", aconnection);

            command.Parameters.AddWithValue("@CUSTOMER_NAME", service.CUSTOMER_NAME);
            command.Parameters.AddWithValue("@CUSTOMER_SURNAME", service.CUSTOMER_SURNAME);
            command.Parameters.AddWithValue("@CUSTOMER_ADDRESS", service.CUSTOMER_ADDRESS);
            command.Parameters.AddWithValue("@CUSTOMER_TELEPHONE", service.CUSTOMER_TELEPHONE);
            command.Parameters.AddWithValue("@CUSTOMER_EMAİL", service.CUSTOMER_EMAİL);
            command.Parameters.AddWithValue("@PERSON_OF_CONTACT", service.PERSON_OF_CONTACT);
            command.Parameters.AddWithValue("@DESC_PROPERTY", service.DESC_PROPERTY);
            command.Parameters.AddWithValue("@SPECİAL_NOTE", service.SPECİAL_NOTE);
            command.Parameters.AddWithValue("@ACTUALLY_PERFORMED", service.ACTUALLY_PERFORMED);
            command.Parameters.AddWithValue("@JOB_KİND", service.JOB_KİND);
            command.Parameters.AddWithValue("@DATE_SERTAKEPLACE", service.DATE_SERTAKEPLACE);
            command.Parameters.AddWithValue("@DATE_SERTOOKPLACE", service.DATE_SERTOOKPLACE);
            command.Parameters.AddWithValue("@DATE_TWOWEEKS", service.DATE_TWOWEEKS);
            command.Parameters.AddWithValue("@CHARGE_BEING", service.CHARGE_BEING);
            command.Parameters.AddWithValue("@CHARGE_DONE", service.CHARGE_DONE);
            command.Parameters.AddWithValue("@PAID_ALONG", service.PAID_ALONG);
            command.Parameters.AddWithValue("@BALANCE", service.BALANCE);
            command.Parameters.AddWithValue("@SELECTED_IMAGE_DATA", service.SELECTED_IMAGE_DATA);
            command.ExecuteNonQuery();
            aconnection.Close();
        }
    }
}

