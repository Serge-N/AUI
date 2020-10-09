using System;

namespace AUI.Shared.Classes.Production.Cows
{
    public class Fertility
    {
        public long ID { get; set; }
        public long CattleID { get; set; }
        public char Alive { get; set; }
        public DateTime? DateOfCalving { get; set; }
        public DateTime? DateofExpecting { get; set; }
        public DateTime? DateOfHeating { get; set; }
        public int? ConceptionNumber { get; set; }
        public int? NumberOfCalves { get; set; }
        public string Remarks { get; set; }

    }
}
