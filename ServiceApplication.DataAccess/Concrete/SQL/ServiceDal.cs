﻿using ServiceApplication.DataAccess.Abstract;
using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
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
        string connectionString = "Data Source=Y O U R D A T A B A S E;Initial Catalog=master;User ID= Y O U R U S E R N A M E ;Password= Y O U R P A S S ;Persist Security Info =False"; // Bağlantı dizesi
        string databaseName = "ServiceAPP"; // VDS veritabanı adı

        public void CheckAndCreate() {
            string tableName = "ServiceApp";
            CheckAndCreateDatabase();
            CheckAndCreateTable(tableName);
        }
        public void CheckAndCreateDatabase()
        {
            if (CheckDatabaseExists(connectionString, databaseName))
            {
                Console.WriteLine("ServiceAPP veritabanı zaten mevcut.");
            }
            else
            {
                if (CreateDatabase(connectionString, databaseName))
                {
                    Console.WriteLine("ServiceAPP veritabanı başarıyla oluşturuldu.");
                }
                else
                {
                    Console.WriteLine("ServiceAPP veritabanı oluşturma hatası.");
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
                    string createTableQuery = $"USE {databaseName}; CREATE TABLE {tableName} (SERVICE_ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY," +
                         $"CUSTOMER_NAME NVARCHAR(255)," +
                         $"CUSTOMER_SURNAME NVARCHAR(255)," +
                         $"CUSTOMER_TELEPHONE NVARCHAR(255), " +
                         $"CUSTOMER_EMAIL NVARCHAR(255), " +
                         $"CUSTOMER_ADRESS NVARCHAR(255), " +
                         $"PERSON_OF_CONTACT NVARCHAR(255)," +
                         $"DETAILS_OF_PROPERTY NVARCHAR(MAX)," +
                         $"PRICE_OF_DAY INT, " +
                         $"JOB_KIND NVARCHAR(255), " +
                         $"START_DATE DATE, " +
                         $"CUT_DATE DATE," +
                         $"START_ACT_DATE DATE,  " +
                         $"DATE_OF_SER_ACT nvarchar(255),  " +
                         $"SERVICE_CHARGE INT," +
                         $"SPECIAL_NOTE NVARCHAR(MAX), " +
                         $"SELECTED_IMAGE_DATA VARBINARY(MAX) NULL)";

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
            SqlConnection aconnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("use ServiceAPP;Select * from ServiceApp ", aconnection);
            aconnection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Service> serviceInfo = new List<Service>();
            while (reader.Read())
            {
                Service service = new Service()
                {
                    SERVICE_ID = Convert.ToInt32(reader["SERVICE_ID"]),
                    CUSTOMER_NAME = Convert.ToString(reader["CUSTOMER_NAME"]),
                    CUSTOMER_SURNAME= Convert.ToString(reader["CUSTOMER_SURNAME"]),
                    CUSTOMER_TELEPHONE = Convert.ToString(reader["CUSTOMER_TELEPHONE"]),
                    CUSTOMER_EMAIL = Convert.ToString(reader["CUSTOMER_EMAIL"]),
                    CUSTOMER_ADRESS = Convert.ToString(reader["CUSTOMER_ADRESS"]),
                    PERSON_OF_CONTACT = Convert.ToString(reader["PERSON_OF_CONTACT"]),
                    DETAILS_OF_PROPERTY = Convert.ToString(reader["DETAILS_OF_PROPERTY"]),
                    PRICE_OF_DAY = Convert.ToInt32(reader["PRICE_OF_DAY"]),
                    JOB_KIND = Convert.ToString(reader["JOB_KIND"]),
                    START_DATE = Convert.ToDateTime(reader["START_DATE"]),
                    CUT_DATE = Convert.ToDateTime(reader["CUT_DATE"]),
                    START_ACT_DATE = Convert.ToDateTime(reader["START_ACT_DATE"]),
                    DATE_OF_SER_ACT = Convert.ToString(reader["DATE_OF_SER_ACT"]),
                    SERVICE_CHARGE = Convert.ToInt32(reader["SERVICE_CHARGE"]),
                    SPECIAL_NOTE = Convert.ToString(reader["SPECIAL_NOTE"]),
                    //SELECTED_IMAGE_DATA= (byte[])reader["SELECTED_IMAGE_DATA"],
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string queryString = "USE ServiceAPP; INSERT INTO ServiceApp (CUSTOMER_NAME, CUSTOMER_SURNAME, CUSTOMER_TELEPHONE, CUSTOMER_EMAIL, CUSTOMER_ADRESS, PERSON_OF_CONTACT, DETAILS_OF_PROPERTY, PRICE_OF_DAY, JOB_KIND, START_DATE, CUT_DATE, START_ACT_DATE, DATE_OF_SER_ACT, SERVICE_CHARGE, SPECIAL_NOTE ) VALUES (@CUSTOMER_NAME, @CUSTOMER_SURNAME, @CUSTOMER_TELEPHONE, @CUSTOMER_EMAIL, @CUSTOMER_ADRESS, @PERSON_OF_CONTACT, @DETAILS_OF_PROPERTY, @PRICE_OF_DAY, @JOB_KIND, @START_DATE, @CUT_DATE, @START_ACT_DATE, @DATE_OF_SER_ACT, @SERVICE_CHARGE, @SPECIAL_NOTE)";
                //, @SELECTED_IMAGE_DATA --- , SELECTED_IMAGE_DATA
                using (SqlCommand command = new SqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@CUSTOMER_NAME", service.CUSTOMER_NAME);
                    command.Parameters.AddWithValue("@CUSTOMER_SURNAME", service.CUSTOMER_SURNAME);
                    command.Parameters.AddWithValue("@CUSTOMER_TELEPHONE", service.CUSTOMER_TELEPHONE);
                    command.Parameters.AddWithValue("@CUSTOMER_EMAIL", service.CUSTOMER_EMAIL);
                    command.Parameters.AddWithValue("@CUSTOMER_ADRESS", service.CUSTOMER_ADRESS);
                    command.Parameters.AddWithValue("@PERSON_OF_CONTACT", service.PERSON_OF_CONTACT);
                    command.Parameters.AddWithValue("@DETAILS_OF_PROPERTY", service.DETAILS_OF_PROPERTY);
                    command.Parameters.AddWithValue("@PRICE_OF_DAY", service.PRICE_OF_DAY);
                    command.Parameters.AddWithValue("@JOB_KIND", service.JOB_KIND);
                    command.Parameters.AddWithValue("@START_DATE", service.START_DATE);
                    command.Parameters.AddWithValue("@CUT_DATE", service.CUT_DATE);
                    command.Parameters.AddWithValue("@START_ACT_DATE", service.START_ACT_DATE);
                    command.Parameters.AddWithValue("@DATE_OF_SER_ACT", service.DATE_OF_SER_ACT);
                    command.Parameters.AddWithValue("@SERVICE_CHARGE", service.SERVICE_CHARGE);
                    command.Parameters.AddWithValue("@SPECIAL_NOTE", service.SPECIAL_NOTE);
                   //command.Parameters.AddWithValue("@SELECTED_IMAGE_DATA", service.SELECTED_IMAGE_DATA ?? (object)DBNull.Value);

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }



    }
}

