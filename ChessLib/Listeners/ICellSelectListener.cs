
using ChessLib.Models;

namespace ChessLib.Listeners
{
    public interface ICellSelectListener
    {
        /// <summary>
        /// Método que se llama cuando se desea invocar el listener
        /// </summary>
        /// <param name="selectedCell">Coordenada de la celda seleccionada</param>
        void Listen(Coordenada selectedCell);
    }
}
