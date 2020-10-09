using System;
using System.ComponentModel.DataAnnotations;

namespace AUI.Shared.Classes.Production.Cows
{
    public class Growth
    {
        public long CattleID { get; set; } 
        public long CattleFK { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfSale { get; set; }
        public DateTime? DateOfWeaning { get; set; }
        [Range(50, 1000, ErrorMessage = "Birth weight. Invalid (50-1000).")]
        public int? BirthWeight { get; set; }
        [Range(1000, 30000, ErrorMessage = "Price Invalid (1000-90000).")]
        public int? SalePrice { get; set; }
        [Range(80, 1000, ErrorMessage = "Sale weight. Invalid (80-1000).")]
        public int? SaleWeight { get; set; }
        [Range(50, 1000, ErrorMessage = "Weaning weight. Invalid (50-1000).")]
        public int? WeaningWeight { get; set; }
        [StringLength(20, ErrorMessage = "Buyer Name too long (20 character limit).")]
        public string Buyer { get; set; }
        [StringLength(20, ErrorMessage = "Mode too long (20 character limit).")]
        public string Mode { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        [Range(1000, 30000, ErrorMessage = "Price Invalid (1000-90000).")]
        public int ? PurchaseValue { get; set; }
        [StringLength(20, ErrorMessage = "Supplier too long (20 character limit).")]
        public string Seller { get; set; }
    }
}
