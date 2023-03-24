using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The flavor type can't be empty!")]
    public string FlavorType { get; set; }
    public List<FlavorTreat> JoinFlavorTreat { get; set; }
    public ApplicationUser User { get; set; }
  }
}