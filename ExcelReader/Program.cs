using ExcelReader;
using System;

namespace ExcelReader
{
    class Program
    {


        static void Main(string[] args)
        {
            // C:\Users\micha\Downloads\FBA Inventory 1-17-18 11_41
            Console.WriteLine("Enter File Path For Excel Spreadsheet And Press Enter:");
            var path = Console.ReadLine();
            try
            {
                Read_From_Excel.getExcelFile(path);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
