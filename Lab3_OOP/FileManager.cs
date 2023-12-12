using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab4_OOP
{
    internal class FileManager
    {
        public void SaveDataToTxtFile(string filePath, DataGridView dataGridView)
        {
            StreamWriter streamWriter = new StreamWriter(filePath);
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string name = row.Cells["name"].Value.ToString();
                    string x1 = row.Cells["x1"].Value.ToString();
                    string y1 = row.Cells["y1"].Value.ToString();
                    string x2 = row.Cells["x2"].Value.ToString();
                    string y2 = row.Cells["y2"].Value.ToString();

                    streamWriter.Write($"{name}\n\t{x1}, {y1}, {x2}, {y2}\n");
                }
            }
            streamWriter.Close();
        }

    }
}
