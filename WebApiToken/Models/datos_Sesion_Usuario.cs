namespace WebApiToken.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class datos_Sesion_Usuario
    {
        [Key]
        public int id_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string nickName_usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string email_usario { get; set; }

        [Required]
        [StringLength(255)]
        public string password_usuario { get; set; }

        public virtual datos_Identificativos_Usuario datos_Identificativos_Usuario { get; set; }
    }
}
