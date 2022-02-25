using System.ComponentModel.DataAnnotations;
 
namespace Paz.Eyal._5H.WebCRUD.Models;
public class Movie
{

    public int Id { get; set; }

    [Display(Name="Titolo",Prompt ="Inserire il titolo..", Description = "Titolo del film")]
    public string? Title { get; set; }
   
    [Display(Name="Data Pubblicazione",Prompt ="Inserire data pubbliicazione.", Description = "film con data pubblicazione")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    [Display(Name="Genere",Prompt ="Inserire il genere..", Description = "geneere del film")]
    public string? Genre { get; set; }
    
    [Display(Name="prezzo",Prompt ="Inserire il prezzo..", Description = "prezzo in euro")]
    public decimal Price { get; set; }
}  
