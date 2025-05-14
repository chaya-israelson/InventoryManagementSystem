using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO;

public record Client
    (int Id,
    string? Name,
    string? Addres,
    string? Phon)
{
 public Client():this(123456789,"israel israeli", "Jerusalem",null) { }
}
