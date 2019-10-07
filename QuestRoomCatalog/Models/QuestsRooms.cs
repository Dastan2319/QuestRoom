namespace QuestRoomCatalog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class QuestsRooms
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }
        [MinLength(10),MaxLength(500)]
        public string Description { get; set; }

        public int TimeForQuest { get; set; }

        public int MaxGamer { get; set; }
        [MinLength(2)]
        public int MinGamer { get; set; }
       
        public int MinAgeGamer { get; set; }

        public int FearLevel { get; set; }

        public int ComplexityLevel { get; set; }
    }
}
