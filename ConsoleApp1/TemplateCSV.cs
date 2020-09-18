using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConsoleApp1
{
    abstract class TemplateCSV<T>
    {

        public abstract string getFilePath();
        public abstract List<T> ReadCSV(string filePath);

        public List<T> Read()
        {
            List<T> list;

            string filePath = this.getFilePath();
            list = ReadCSV(filePath);

            return list;
        }
    }
}
