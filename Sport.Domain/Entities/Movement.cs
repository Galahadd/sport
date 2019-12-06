using Sport.Domain.Entities.MMRelation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sport.Domain.Entities
{
    public class Movement
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string MovementName { get; set; }
        public string MovementPhoto { get; set; }
        public string MovementDescription { get; set; }
        // public bool IsCardioMove { get; set; } enum yapılacak

        public int FKAreaId { get; set; }
        [ForeignKey("FKAreaId")]
        public virtual Area Area { get; set; }
        public virtual ICollection<AreaMovements> AreaMovements { get; set; }
    }
}
