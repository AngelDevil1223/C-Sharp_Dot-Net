using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AliaksandrForms
{
    public class DataProvider
    {
        public readonly string connectionString;
        public DataProvider()
        {
            string mdfPath = Path.Combine(@"C:\Users\Admin\source\repos\AliaksandrProject\AliaksandrForms\AliaksandrForms", "AppData.mdf");
            connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={mdfPath};Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        }
        public void AddIncome(Income income)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    conn.Open();
                    command.CommandText = $"insert into Income(Source,Value,Date) values('{income.Source}',{income.Value},'{income.Date:dd/MM/yyyy}');";
                    command.ExecuteNonQuery();
                }
            }
        }
        public void AddOutcome(Outcome outcome)
        {
            using (var conn = new SqlConnection(connectionString))
            {
                using (var command = new SqlCommand())
                {
                    command.Connection = conn;
                    conn.Open();
                    command.CommandText = $"insert into Outcome(Source,Value,Date) values('{outcome.Source}',{outcome.Value},'{outcome.Date:dd/MM/yyyy}');";
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Income> Incomes
        {
            get
            {
                List<Income> records = new();
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand($"select Source,Value,Date from income", conn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    records.Add(new Income()
                                    {
                                        Source = reader.GetString(0),
                                        Value = reader.GetDecimal(1),
                                        Date = reader.GetDateTime(2)
                                    });
                                }
                            }
                        }
                    }
                }
                return records;
            }
        }
        public List<Outcome> Outcomes
        {
            get
            {
                List<Outcome> records = new();
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand($"select Source,Value,Date from outcome", conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    records.Add(new Outcome()
                                    {
                                        Source = reader.GetString(0),
                                        Value = reader.GetDecimal(1),
                                        Date = reader.GetDateTime(2)
                                    });
                                }
                            }
                        }
                    }
                }
                return records;
            }
        }
    }

    public class Income
    {
        public string Source { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }

    public class Outcome
    {
        public string Source { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
