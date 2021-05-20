using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataTier;

namespace LogicTier
{
    public class StudentValues
    {
        private Students st;
        public StudentValues(Students s)
        {
            st = s;
        }
        public string FIO
        {
            get { return st.ФИО; }
            set { st.ФИО = value; }
        }
        public string Group
        {
            get { return st.Группа; }
            set { st.Группа = value; }
        }
        public float Curs
        {
            get { return st.Курс; }
            set { st.Курс = value; }
        }
        public float Debt
        {
            get { return st.Задолженности; }
            set { st.Задолженности = value; }
        }
    }
    public class Summary
    {
        StreamReader txt = new StreamReader(@"input.txt");
        private List<StudentValues> st = new List<StudentValues>();

        float sum1, sum2 = 0;
        public Summary()
        {

            List<Students> tmp = StudInfo.StIn(txt);
            foreach (var v in tmp)
            {
                st.Add(new StudentValues(v));
                if (v.Задолженности == 0)
                {
                    sum1 += 1;
                }

            }

            sum2 = (from v in tmp
                  where v.Задолженности > 0
                  select v.Задолженности).Sum();

        }
        public float СуммарноеКоличествоЗадолжностей
        {
            get { return sum2; }
        }
        public float СуммарноеКоличествоЛюдей
        {
            get { return sum1; }
        }
    }
}
