namespace WebApiToken.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class datos_Tarjeta_Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_usuario { get; set; }

        public int noTarjeta_usuario { get; set; }

        public byte cvvTarjeta_usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaValida_usuario { get; set; }

        public virtual datos_Identificativos_Usuario datos_Identificativos_Usuario { get; set; }
    }
}
