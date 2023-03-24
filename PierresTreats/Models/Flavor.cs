using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string FlavorType { get; set; }
    public List<FlavorTreat> JoinFlavorTreat { get; set; }
    public ApplicationUser User { get; set; }
  }
}