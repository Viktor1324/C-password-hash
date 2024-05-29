using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasicForm.Model
{
    [Table(name: "Users")]
    public class User
    {
        [Column(TypeName = "binary(32)")]
        public byte[] Password { get; set; }
        //Don't forget to match the DB model to the return type of the algo!
        public User() { }
    }
}
