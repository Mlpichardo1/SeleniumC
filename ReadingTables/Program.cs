using System;
using OpenQA.Selenium.Firefox;

namespace ReadingTables
{
    class Program : Base
    {
        static void Main(string[] args)
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("");

            TablePage page =  new TablePage();

            //Read Table
            Utilities.ReadTable(page.table);

            //Get the cell value of each table
            System.Console.WriteLine(Utilities.ReadCell("Email", 1)); 
            System.Console.WriteLine("The Name {0} with Email {1} and Phone{2}", 
            Utilities.ReadCell("Name", 2), Utilities.ReadCell("Email", 2), Utilities.ReadCell("Phone", 2)); 
            
            Console.Read();
        }
    }
}
