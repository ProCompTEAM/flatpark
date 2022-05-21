using DataCenter.Common;
using DataCenter.Data.Attributes;
using DataCenter.Data.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataCenter.Data.Models
{
    public class FloatingText : BaseEntity, IUnited, ICreatedDate
    {
        [Required, Unicode(Defaults.DefaultLongStringLength)]
        public string Text { get; set; }

        [Required, Unicode(Defaults.DefaultStringLength)]
        public string UnitId { get; set; }

        [Required, Unicode(Defaults.DefaultStringLength)]
        public string World { get; set; }

        [Required]
        public double X { get; set; }

        [Required]
        public double Y { get; set; }

        [Required]
        public double Z { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}