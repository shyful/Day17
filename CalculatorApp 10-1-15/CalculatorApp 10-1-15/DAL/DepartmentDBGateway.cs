using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using CalculatorApp_10_1_15.DAL.DAO;

namespace CalculatorApp_10_1_15.DAL
{
    public class DepartmentDBGateway
    {
        public List<Department> GetAllDepartments()
        {

            List<Department> departments = new List<Department>();
            string connectionString = "SERVER= SHIFU; Database=universityDB; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            var query = "SELECT * FROM t_Department";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Department dept = new Department();
                dept.Id = (int) reader["Id"];
                dept.Name = reader["Name"].ToString();
                departments.Add(dept);
            }

            reader.Close();
            connection.Close();

            return departments;
        }
    }
}