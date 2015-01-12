using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CalculatorApp_10_1_15.DAL;
using CalculatorApp_10_1_15.DAL.DAO;

namespace CalculatorApp_10_1_15.BLL
{
    public class DepartmentManager
    {
        DepartmentDBGateway gateway = new DepartmentDBGateway();
        public List<Department> GetAllDepartments()
        {
            return gateway.GetAllDepartments();
        }
    }
}