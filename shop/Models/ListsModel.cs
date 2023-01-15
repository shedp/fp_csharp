using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace shop.Models;

public record ListsModel
{
    [Key]
    public int ListID {get; set;}
    public String User {get; set;}
    public int ProductID {get; set;}
}