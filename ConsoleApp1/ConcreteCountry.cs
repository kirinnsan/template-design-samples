using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConcreteCountry : TemplateCSV<Country>
    {
        private readonly string filePath = "country.csv";

        public override string getFilePath()
        {
            return this.filePath;
        }

        public override List<Country> ReadCSV(string filePath)
        {

            List<Country> result = new List<Country>();
            Country country = new Country();

            // 出力用のファイルを開く
            using (var sr = new System.IO.StreamReader(filePath, Encoding.GetEncoding("UTF-8")))
            {
                while (!sr.EndOfStream)
                {
                    // CSVファイルの一行を読み込む
                    string line = sr.ReadLine();
                    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    string[] values = line.Split(',');

                    country.countryName = values[0];
                    country.language =  values[1];
                    result.Add(country);
                }
            }

            return result;
        }
    }
}
