using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ADO.NET_HW_DataLayer.Models;
using System.Data;
using static System.Console;

namespace ADO.NET_HW_DataLayer
{
    public class DL
    {
        public static string ConnectionString { get; private set; } = ConfigurationManager.ConnectionStrings["CompanyDB"].ConnectionString;

        public static class Employee
        {
            public static void Add (EmployeeModel employee)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand addEmployee = new SqlCommand("stp_EmployeeAdd", conn);
                    addEmployee.CommandType = CommandType.StoredProcedure;
                    addEmployee.Parameters.AddWithValue("EmployeeID", employee.ID);
                    addEmployee.Parameters.AddWithValue("FirstName", employee.FirstName);
                    addEmployee.Parameters.AddWithValue("LastName", employee.LastName);
                    addEmployee.Parameters.AddWithValue("BirthDate", employee.DateOfBirth);
                    addEmployee.Parameters.AddWithValue("PositionID", employee.PositionID);
                    addEmployee.Parameters.AddWithValue("Salary", employee.Salary);


                    addEmployee.ExecuteNonQuery();
                    WriteLine($"Пользователь {employee} добавлен");
                    conn.Close();
                }
            }

            public static void Delete (int ID_Employee)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand deleteEmployee = new SqlCommand("stp_EmployeeDelete_1", conn);
                    deleteEmployee.CommandType = CommandType.StoredProcedure;
                    deleteEmployee.Parameters.AddWithValue("EmployeeID", ID_Employee);
                    deleteEmployee.ExecuteNonQuery();
                    WriteLine($"Пользователь с ID {ID_Employee} удален");
                    
                    
                    conn.Close();
                }
            }

            public static void Update (EmployeeModel employee)
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    SqlCommand updateEmployee = new SqlCommand("stp_EmployeeUpdate", conn);
                    updateEmployee.CommandType = CommandType.StoredProcedure;
                    updateEmployee.Parameters.AddWithValue("EmployeeID", employee.ID);
                    updateEmployee.Parameters.AddWithValue("FirstName", employee.FirstName);
                    updateEmployee.Parameters.AddWithValue("LastName", employee.LastName);
                    updateEmployee.Parameters.AddWithValue("BirthDate", employee.DateOfBirth);
                    updateEmployee.Parameters.AddWithValue("PositionID", employee.PositionID);
                    updateEmployee.Parameters.AddWithValue("Salary", employee.Salary);
                    updateEmployee.Parameters.AddWithValue("Result", 1);

                    updateEmployee.ExecuteNonQuery();
                    WriteLine($"Пользователь с ID {employee.ID} изменен на {employee} ");
                    conn.Close();


                }
            }
        }
    }
}
