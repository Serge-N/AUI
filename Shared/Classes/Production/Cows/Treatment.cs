using System;

namespace AUI.Shared.Classes.Production.Cows
{
    public class Treatment
    {
        public long ID { get; set; }
        public long CattleID { get; set; }
        public DateTime Date { get; set; }
        public string Disease { get; set; }
        public string Cure { get; set; }
        public string DrugName { get; set; }
        public int ? DrugAmount { get; set; }
        public  string DrugUnits { get; set; }
        public string Remarks { get; set; }
    }
}
