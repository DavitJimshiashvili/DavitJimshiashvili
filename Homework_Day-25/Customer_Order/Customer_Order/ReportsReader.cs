using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Customer_Order
{
    public class ReportsReader
    {
        private readonly string _FilePath;
        public ReportsReader(string filePath)
        {
            _FilePath = filePath;
        }

        public string[] ParseTextFile()
        {
            return File.ReadAllLines(_FilePath);
        }
    }
}
