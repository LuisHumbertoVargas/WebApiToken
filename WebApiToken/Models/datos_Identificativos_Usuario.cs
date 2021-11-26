namespace WebApiToken.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class datos_Identificativos_Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string app_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string apm_usuario { get; set; }

        public int celular_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaNacimiento_usuario { get; set; }

        [Required]
        [StringLength(18)]
        public string curp_usuario { get; set; }

        public int nss_usuario { get; set; }

        [Required]
        [StringLength(18)]
        public string rfc_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string estadoCivil_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string sexo_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string religion_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string lugarNacimiento_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string viveEn_usuario { get; set; }

        public virtual datos_Sesion_Usuario datos_Sesion_Usuario { get; set; }

        public virtual datos_Tarjeta_Usuario datos_Tarjeta_Usuario { get; set; }
    }
}
