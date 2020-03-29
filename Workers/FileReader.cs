using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unscrambler.Workers
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            string[] fileContent;
            try
            {
                fileContent = File.ReadAllLines(filename);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           

            return fileContent;
        }
    }
}
