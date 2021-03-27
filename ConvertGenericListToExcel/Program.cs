using ConvertGenericListToExcel.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConvertGenericListToExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            var userList = Employee.SeedData();
            try
            {
                Console.WriteLine("Please select a operation to do ..");
                Console.WriteLine("1. Export Data as EXCEL");
                int command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1:
                        string fileName = "EmployeeData.xlsx";
                        Console.WriteLine("Please give a location to save :");
                        string location = Console.ReadLine();
                        string customExcelSavingPath = location + "\\" + fileName;
                        ExcelExport.GenerateExcel(ConvertToDataTable(userList), customExcelSavingPath);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        static DataTable ConvertToDataTable<T>(List<T> models)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }

            foreach (T item in models)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}
