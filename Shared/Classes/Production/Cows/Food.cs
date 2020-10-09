using System;

namespace AUI.Shared.Classes.Production.Cows
{
    public class Food
    {
        public long ID { get; set; }
        public long CattleID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StopDate { get; set; }
        public string FeedType { get; set; }
    }
}
