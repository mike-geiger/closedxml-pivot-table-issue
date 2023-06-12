// See https://aka.ms/new-console-template for more information
using ClosedXML.Excel;
class Program
{
    static void Main(string[] args)
    {
        var ws = new XLWorkbook("test.xlsx");
        ws.SaveAs("test-out.xlsx");
    }
}