namespace ConnectToSQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("userInfo")]
    public partial class userInfo
    {
        [Key]
        public int userID { get; set; }

        public int? studentNumber { get; set; }

        [StringLength(30)]
        public string name { get; set; }

        [StringLength(30)]
        public string surname { get; set; }

        [StringLength(30)]
        public string password { get; set; }

        [StringLength(5)]
        public string islecture { get; set; }
    }
}
