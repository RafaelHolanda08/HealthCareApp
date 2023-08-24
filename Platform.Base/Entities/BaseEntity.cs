using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Platform.Base.Entities
{
    public abstract class BaseEntity
    {

        [Key]
        [Column("Id")]
        public long? Id { get; set; }
    }
}