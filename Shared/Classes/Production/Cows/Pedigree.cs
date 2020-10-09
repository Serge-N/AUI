namespace AUI.Shared.Classes.Production.Cows
{
    public class Pedigree
    {
        public long CattleID { get; set; }
        public long CattleFK { get; set; }
        public long? MotherID { get; set; }
        public long? FatherID { get; set; }

    }
}
