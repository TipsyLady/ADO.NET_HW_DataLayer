using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_HW_DataLayer.Models
{
   public class EmployeeModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PositionID { get; set; }
        public int Salary { get; set; }

        public EmployeeModel (int _ID, string _FN, string _LN, DateTime _BD, int _P,int _S)
        {
            ID = _ID;
            FirstName = _FN;
            LastName = _LN;
            DateOfBirth = _BD;
            PositionID = _P;
            Salary = _S;
        }

        public override string ToString()
        {
            return $" {FirstName}  {LastName} " +
                $" {DateOfBirth.ToShortDateString()} ";
        }

    }
}
