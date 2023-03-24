using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage = "The treat name can't be empty!")]
    public string TreatName { get; set; }
    public List<FlavorTreat> JoinFlavorTreat { get; set; }
    public ApplicationUser User { get; set; }
  }
}