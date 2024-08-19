using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]

        public int CategoryId { get; set; }


        [Column(TypeName = "nvarchar50)")]
        public string Title {  get; set; }

        [Column(TypeName = "nvarchar5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar50)")]
        public string Type { get; set; } = "Expense";

    }
}
