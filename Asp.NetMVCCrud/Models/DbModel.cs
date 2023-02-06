using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Asp.NetMVCCrud.Models
{
    public enum Course { ESAD=1, DDD,NT,GAVE, JAVA}
    public class Batch
    {
        public int BatchId { get; set; }
        [Required, StringLength(50), Display(Name ="Batch Code")]
        public string BatchCode { get; set; }
        [EnumDataType(typeof(Course))]
        public Course Course { get;set; }
        [Required]
        public int Round { get; set; }
        [Required, Column(TypeName ="date"), Display(Name ="Start Date"), DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime StartDate { get; set; }
        [Column(TypeName ="date"), Display(Name ="End Date"), DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime? EndDate { get; set; }
        [Display(Name ="Complete?")]
        public bool IsComplete { get; set; }

    }
    public class BatchDbContext: DbContext
    {
        public DbSet<Batch> Batches { get; set;}
    }
    
}