using Microsoft.Office.Interop.Excel;

namespace WPFTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Application excel = new Application();
            Workbook workbook = excel.Workbooks.Add();
            excel.Visible = true;

        }
    }
}
