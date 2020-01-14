namespace ConnectToSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Question
    {
        public int? testID { get; set; }

        public int questionID { get; set; }

        [Column("question")]
        [StringLength(60)]
        public string question1 { get; set; }

        [StringLength(30)]
        public string possibleAnswer1 { get; set; }

        [StringLength(30)]
        public string possibleAnswer2 { get; set; }

        [StringLength(30)]
        public string possibleAnswer3 { get; set; }

        [StringLength(30)]
        public string possibleAnswer4 { get; set; }

        [StringLength(1)]
        public string actualAnswer { get; set; }

        public virtual Test Test { get; set; }
    }
}
