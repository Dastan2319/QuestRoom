namespace QuestRoomCatalog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    
    public partial class Rating
    {
        public int Id { get; set; }

        public int QuestRoomId { get; set; }
        [MaxLength(100),MinLength(1)]
        public int RatingLevel { get; set; }

        public virtual QuestsRooms QuestsRooms { get; set; }
    }
}
