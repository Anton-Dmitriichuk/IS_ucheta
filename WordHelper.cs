using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace WindowsFormsApp1
{
    class WordHelper
    {
        public WordHelper(string filename) {
            if (File.Exists(filename))
            {
                var _fileInfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("NO FIND FILE");
            }
        }
    }
}
