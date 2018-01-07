using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KEPIT_Proiznye
{
    public class Manager
    {
        #region Переменные
        private readonly DateTime now = DateTime.Now;
        private int year;
        public int Month;
        private List<object> all;
        #endregion

        public Manager()
        {
            year = now.Year;
            Month = now.Month;
            all = new List<object>();
            GetAll();
        }
        private void GetAll()
        {
            for (int i = Month; i < Month + 6; i++)
            {
                int num = i - 2;
                if (num > 0 && num < 13) all.Add(ConvertMonth(num, year));
                else
                {
                    switch (num)
                    {
                        case 0: all.Add(ConvertMonth(12, year - 1)); break;
                        case -1: all.Add(ConvertMonth(11, year - 1)); break;
                        case 13: all.Add(ConvertMonth(1, year + 1)); break;
                        case 14: all.Add(ConvertMonth(2, year + 1)); break;
                        case 15: all.Add(ConvertMonth(3, year + 1)); break;
                    }
                }
            }
        }
        private object ConvertMonth(int month, int y)
        {
            switch (month)
            {
                case 1: return "Січень " + y.ToString();
                case 2: return "Лютий " + y.ToString();
                case 3: return "Березень " + y.ToString();
                case 4: return "Квітень " + y.ToString();
                case 5: return "Травень " + y.ToString();
                case 6: return "Червень " + y.ToString();
                case 7: return "Липень " + y.ToString();
                case 8: return "Серпень " + y.ToString();
                case 9: return "Вересень " + y.ToString();
                case 10: return "Жовтень " + y.ToString();
                case 11: return "Листопад " + y.ToString();
                case 12: return "Грудень " + y.ToString();
                default: return string.Empty;
            }
        }
        public object[] GetMonthList()
        {
            return all.ToArray();
        }
    }
}
