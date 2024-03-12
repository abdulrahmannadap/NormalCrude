using System.ComponentModel.DataAnnotations.Schema;

namespace NormalCrude.Models;

public class BaseModel
{
    public int Id { get; set; }
    public Customer Customer { get; set; }


    public Membarship Membarship { get; set; }


}
