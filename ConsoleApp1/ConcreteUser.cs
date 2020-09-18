using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConcreteUser:TemplateCSV<User>
    {

        private readonly string filePath = "user.csv";

        public override string getFilePath()
        {
            return this.filePath;
        }

        public override List<User> ReadCSV(string filePath)
        {

            List<User> result = new List<User>();
            User user = new User();

            // 出力用のファイルを開く
            using (var sr = new System.IO.StreamReader(filePath, Encoding.GetEncoding("UTF-8")))
            {
                while (!sr.EndOfStream)
                {
                    // CSVファイルの一行を読み込む
                    string line = sr.ReadLine();
                    // 読み込んだ一行をカンマ毎に分けて配列に格納する
                    string[] values = line.Split(',');

                    user.name = values[0];
                    user.age =  values[1];
                    result.Add(user);

                }
            }

            return result;
        }
    }
}
