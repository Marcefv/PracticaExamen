using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaExamen.Models
{
    [MetadataType(typeof(ClienteMetadata))]
    public class Cliente
    {

        /*

         [MetadataType(typeof(AnimalesMetadata))]
    public class Animales
    {
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))] [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string Nombre { get; set; }
        public DateTime fecha { get; set; }
        public string Tipo { get; set; }
        public string Dueno { get; set; }
        public int Peso { get; set; }
        public IList<Tratamiento> tratamiento { get; set; }
}
    public class AnimalesMetadata
    {
        [DisplayName("Identificador")]
        public object _id { get; set; }

        [Required]
        [DisplayName("Nombre")]
        public object Nombre { get; set; }

        [DisplayName("Fecha de ingreso")]
        public object fecha { get; set; }

        [DisplayName("Tipo de mascota")]
        public object Tipo { get; set; }

        [Required]
        [DisplayName("Nombre del dueño")]
        public object Dueno { get; set; }

        [Range(1,100)]
        [DisplayName("Peso en libras")]
        public object Peso { get; set; }

        public IList<Tratamiento> tratamiento { get; set; }
    }

    public class Tratamiento
    {
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public decimal precio { get; set; }
    }
}
    */
        [BsonId(IdGenerator = typeof(StringObjectIdGenerator))]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        public string nombre { get; set; }

        public string telefono { get; set; }

        public string correo { get; set; }

        public IList<Pelis> pelis { get; set; }

    }
        public class ClienteMetadata
        {
            [DisplayName("Identificacion")]
            public object _id { get; set; }
            [DisplayName("Nombre")]
            [Required]
            public object nombre { get; set; }
            [StringLength(8)]
            [RegularExpression(@"^[0-9]{8,8}$")]
            public object telefono { get; set; }
            [EmailAddress]
            public object correo { get; set; }

            public IList<Pelis> pelis { get; set; }

        }

    [MetadataType(typeof(PelisMetadata))]
    public class Pelis
        {
            public string nombrePeli { get; set; }

            public string genero { get; set; }
        }


    public class PelisMetadata
    {
        [Required] [DisplayName("Nombre")]
        public object nombrePeli { get; set; }

        [Required] [DisplayName("Genero")]
        public object genero { get; set; }

    }

}

   



