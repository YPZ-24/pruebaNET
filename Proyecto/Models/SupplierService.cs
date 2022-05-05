using System.ComponentModel.DataAnnotations;

namespace Proyecto.Models
{
    public class SupplierService{
        public SupplierService(){}

        [Key]
        public int SupplierServicesID {get;set;}
        public int SupplierID {get;set;}

        [Range(1, 10, ErrorMessage = "La puntuación debe ser un valor entre 1 y 10")]
        public int? scoreSS {get;set;}

        [Range(1, 10, ErrorMessage = "La puntuación de tiempo de entrega debe ser un valor entre 1 y 10")]
        public int? deliveryTimeSS {get;set;}

        [Range(1, 10, ErrorMessage = "La puntuación de calidad de entrega debe ser un valor entre 1 y 10")]
        public int? deveryQualitySS {get;set;}

        [Range(1, 10, ErrorMessage = "La puntuación de calidad de embalaje debe ser un valor entre 1 y 10")]
        public int? packingQualitySS {get;set;}
        
    }
}