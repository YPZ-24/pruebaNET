using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class Supplier{
        public Supplier(){}

        public int SupplierID {get;set;}
        
        [RegularExpression(@"^([A-ZÑ&]{3,4}) ?(?:- ?)?(\d{2}(?:0[1-9]|1[0-2])(?:0[1-9]|[12]\d|3[01])) ?(?:- ?)?([A-Z\d]{2})([A\d])$", ErrorMessage = "RFC invalido")]
        public string RFCSupplier {get; set;}

        public string taxAddressSupplier {get; set;}

        public string dedicatedToSupplier {get; set;}

        public string socialReasonSupplier {get; set;}
    }
}