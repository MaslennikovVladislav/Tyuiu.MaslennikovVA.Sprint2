using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.MaslennikovVA.Sprint2.Task6.V13.Lib
{
    public class DataService : ISprint2Task6V13
{
    public string FindDateOfNextDay(int g, int m, int n)
    {
        string month = "";
        string result;
        int daysInMonth;

        switch (m)
        {
            case 1: month = "Январь"; daysInMonth = 31; break;
            case 2: month = "Февраль"; daysInMonth = 29; break;
            case 3: month = "Март"; daysInMonth = 31; break;
            case 4: month = "Апрель"; daysInMonth = 30; break;
            case 5: month = "Май"; daysInMonth = 31; break;
            case 6: month = "Июнь"; daysInMonth = 30; break;
            case 7: month = "Июль"; daysInMonth = 31; break;
            case 8: month = "Август"; daysInMonth = 31; break;
            case 9: month = "Сентябрь"; daysInMonth = 30; break;
            case 10: month = "Октябрь"; daysInMonth = 31; break;
            case 11: month = "Ноябрь"; daysInMonth = 30; break;
            case 12: month = "Декабрь"; daysInMonth = 31; break;

            default: return month = "Некорректный номер месяца.";
        }


        if (m < 1 || m > 12 || n < 1 || n > daysInMonth)
        {
            result = "Некорректная дата.";
        }
        else
        {
            n++;

            if (n > daysInMonth)
            {
                m++;
                n = 1;
                if (m > 12)
                {
                    m = 1;
                    g++;
                }
            }
            if (m > 9)
            {
                result = $"{n}.{m}.{g}";
            }

            else if ((m <= 9) && (n <= 9))
            {
                result = $"0{n}.0{m}.{g}";
            }

            else
            {
                result = $"{n}.0{m}.{g}";
            }
        }
        return result;
    }
}
}