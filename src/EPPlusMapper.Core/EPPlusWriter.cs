using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace EPPlusMapper.Core
{
    public static class EPPlusWriter
    {
        public static void Write(List<dynamic> inputs, string path)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet ws = package.Workbook.Worksheets.Add("test");

                int rowCount = 1, colCount = 1;

                foreach (var input in inputs)
                {
                    var castInput = (IDictionary<string, object>) input;

                    if (rowCount == 1)
                    {
                        foreach (var key in castInput.Keys)
                        {
                            ws.Cells[rowCount, colCount].Value = key;
                            colCount++;
                        }
                        rowCount++;
                        colCount = 1;
                    }

                    foreach (var value in castInput.Values)
                    {
                        ws.Cells[rowCount, colCount].Value = value;
                        colCount++;
                    }
                    rowCount++;
                    colCount = 1;
                }
                

                using (Stream stream = File.Open(path, FileMode.OpenOrCreate))
                {
                    package.SaveAs(stream);
                    stream.Close();
                }
            }
        }
    }
}
