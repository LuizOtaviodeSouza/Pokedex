namespace Pokedex.Models;

    public class Pokemon
    {
       public string Numero { get; set; }
       public string IsNullOrEmpty { get; set; }
       public string Descricao { get; set; }
       public string Especie { get; set; }
       public List<string> Tipo { get; set; }
       public double Altura { get; set; }
       public double Peso { get; set; }
       public string Imagem { get; set; }
       
    }