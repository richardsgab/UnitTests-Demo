using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class DatumHulpMiddelen
    {
        public int BerekenLeeftijd(DateTime geboortedatum)
        {
            var nu = DateTime.Today;
            int leeftijd = nu.Year - geboortedatum.Year;
            if (geboortedatum.Date > nu.AddYears(-leeftijd)) 
                leeftijd--;
            return leeftijd;
        }

        //int age = BerekenLeefTijd(DateTime geboortedatum)
        public DateTime VoegDagenToe(DateTime datum, int dagen)
        {
            return datum.AddDays(dagen);
        }

        public bool IsWeekend(DateTime datum)
        {
            return datum.DayOfWeek == DayOfWeek.Saturday ||
                datum.DayOfWeek == DayOfWeek.Sunday;
        }
        

    }
}
