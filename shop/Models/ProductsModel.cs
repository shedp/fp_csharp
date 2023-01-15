//create model, each model representing each table, each 
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace shop.Models;

//create record that'll represent the model, will contain contents of database
//define key by writing [key] above the key
public record ProductsModel
{
    [Key]
    public int ProductID {get; set;}
    public String? ProductName {get; set;}
    public int ProductQTY {get; set;}
    public decimal ProductCost {get; set;}
}