using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace ReadingTables
{
    public class Utilities
    {
        
        static List<TableDatacollection> _tableDataCollections = new List<TableDatacollection>();

        public static void ReadTable(IWebElement table)
        {
            //Get all columns from table 
            var columns = table.FindElements(By.TagName("th"));

            //Get all rows
            var rows = table.FindElements(By.TagName("tr"));

            //Create row index
            int rowIndex = 0;

            foreach(var row in rows)
            {
                int colIndex = 0;
                var colDatas = row.FindElements(By.TagName("td"));

                foreach (var colValue in colDatas)
                {
                    _tableDataCollections.Add(new TableDatacollection
                    {
                        RowNumber = rowIndex,
                        ColumnName = columns[colIndex].Text,
                        ColumnValue = colValue.Text
                    });   

                    //Move to next Column
                    colIndex++;
                }
                rowIndex++;
            }
        }

        internal static void ReadTable(object table)
        {
            throw new NotImplementedException();
        }

        public static string ReadCell(string columnName, int rowNumber)
        {
            var data = (from e in _tableDataCollections
                    where e.ColumnName == columnName && e.RowNumber == rowNumber
                    select e.ColumnValue).SingleOrDefault();

                    return data;
        }
    
    }
        public class TableDatacollection
        {
            public int RowNumber { get; set; }
            public string ColumnName { get; set; }
            public string ColumnValue { get; set; }
        }

}