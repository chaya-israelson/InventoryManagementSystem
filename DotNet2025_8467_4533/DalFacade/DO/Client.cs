
namespace DO;

public record Client
    (int Id,
    string? Name,
    string? Addres,
    string? Phon)
{
 public Client():this(123456789,"israel israeli", "Jerusalem",null) { }
}
