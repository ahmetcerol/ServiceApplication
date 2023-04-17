using ServiceApplication.DataAccess.Abstract;
using ServiceApplication.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApplication.DataAccess.Concrete.SQL
{
    public class ServiceDal:IServiceDal
    {
        string connectionString = "Data Source=DORUKPC5;Initial Catalog=master;User ID=sa;Password=sapass;Persist Security Info =False"; // Bağlantı dizesi
        string databaseName = "MyVdsDatabase"; // VDS veritabanı adı

        SqlConnection aconnection= new SqlConnection("...");

        public void concontrol()
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

        public List<Service> GetAll()
        {

            concontrol();
            SqlCommand command = new SqlCommand("Select * from Bilgiler ", aconnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Service> serviceInfo = new List<Service>();
            while (reader.Read())
            {
                Service service = new Service()
                {

                };
                serviceInfo.Add(service);

            }
            reader.Close();
            aconnection.Close();

            return serviceInfo;
        }
        public void Add(Service service)
        {
            concontrol();
            SqlCommand command = new SqlCommand(
                "Insert into Bilgiler Values(@...)", aconnection);
            //command.Parameters.AddWithValue("@....");
            command.ExecuteNonQuery();
            aconnection.Close();
        }
    }
}

