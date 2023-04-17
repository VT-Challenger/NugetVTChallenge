using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NugetVTChallenge.Models {

    [Table("V_TOURNAMENT_COMPLETE")]
    public class TournamentComplete {
        [Key]
        [Column("TID")]
        public int Tid { get; set; }

        [Column("NAME")]
        public string? Name { get; set; }

        [Column("TRANK")]
        public string? Rank { get; set; }

        [Column("DATEINIT")]
        public DateTime DateInit { get; set; }

        [Column("DESCRIPTION")]
        public string? Description { get; set; }

        [Column("PLATFORM")]
        public string Platform { get; set; }

        [Column("PLATFORM_IMAGE")]
        public string PlatformImage { get; set; }

        [Column("LIMIT_PLAYERS")]
        public int LimitPlayers { get; set; }

        [Column("ORGANIZATOR")]
        public string Organizator { get; set; }

        [Column("IMAGE_ORGANIZATOR")]
        public string ImageOrganization { get; set; }

        [Column("IMAGE")]
        public string? Image { get; set; }

        [Column("INSCRIPTIONS")]
        public int Inscriptions { get; set; }

    }
}
