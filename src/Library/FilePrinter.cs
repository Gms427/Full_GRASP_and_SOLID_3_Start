using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// Clase encargada de imprimir recipes en un archivo, implementa la interfaz IPrinter. Asi como esta, podriamos tener 
    /// más clases que implementen la interfaz y asi poder tener varios tipos de impresión disponibles.
    /// 
    /// Por otro lado, es una clase que cumple con SRP, ya que tiene una única responsabilidad que es
    /// imprimir recipes, asi como también tiene una única razón para cambiar.
    /// </summary>
    public class FilePrinter: IPrinter
    {
        public FilePrinter()
        {
        }

        public void PrintRecipe(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}