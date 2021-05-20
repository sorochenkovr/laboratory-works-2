using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataTier
{
    public class Students
    {
        public string ФИО { get; set; }
        public string Группа { get; set; }
        public float Курс { get; set; }
        public float Задолженности { get; set; }
        public static Students Create(string str)
        {
            Students info = new Students();
            string[] elem = str.Split('*');
            info.ФИО = elem[0].Trim();
            info.Группа = elem[1].Trim();
            info.Курс = Convert.ToSingle(elem[2]);
            elem[2] = elem[2].Replace('.', ',');
            info.Задолженности = Convert.ToSingle(elem[3]);
            elem[3] = elem[3].Replace('.', ',');
            return info;
        }
    }

    public class StudInfo
    {

        public static List<Students> StIn(StreamReader txt)
        {
            List<Students> list = new List<Students>();
            string line;
            while ((line = txt.ReadLine()) != null)
            {
                list.Add(Students.Create(line));
            }
            return list;
        }
    }
}
