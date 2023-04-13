using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c_.EmployeeTable
{
    public class PrintTable
    {

        public void PrintingGraph()
        {
            var studentsTable = new SortingTable().GetTableWithLogs();
            foreach (DictionaryEntry item in studentsTable)
            {
                System.Console.WriteLine(item.Value);
            }
        }
    }
}