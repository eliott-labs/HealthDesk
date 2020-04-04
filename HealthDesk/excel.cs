using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace HealthDesk
{
    class Excel
    {
        string path = "Test";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;


        public void CreateNewFile()
        {
            this.wb = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
        }

        public void SaveAs(string path)
        {
            wb.SaveAs(path);
        }

        public void Close()
        {
            wb.Close();
        }

        public void WriteTocell(int i, int j , string s)
        {
            i++;
            j++;
            ws.Cells[1, j].Value2 = s;
        }

        public void Save()
        {
            wb.Save();
        }

        public Excel(string path, int Sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }

        public Excel()
        {

        }
    }


}
