using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.NET_HW_DataLayer.Models;

namespace ADO.NET_HW_DataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel employee = new EmployeeModel(14, "Yulia", "Titova", new DateTime(1990,08,05), 2, 4780);
            //DL.Employee.Add(employee);
            //DL.Employee.Delete(13);
            DL.Employee.Update(employee);
           
        }
    }
}
