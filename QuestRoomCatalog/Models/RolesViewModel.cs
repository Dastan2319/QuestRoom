namespace QuestRoomCatalog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250) ,MinLength(3)]
        public string RoleName { get; set; }
    }
}
