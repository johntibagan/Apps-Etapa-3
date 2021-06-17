/**
 * @author  John Tibagan
 * @code    1002709915
 */
namespace AppPasteleria.cs.core
{
    abstract class CantidadAbtractClass
    {

        private int cantidad = 0;

        public int Cantidad
        {
            get => cantidad;
            set
            {
                cantidad = value < 0 ? 0 : value;
            }
        }
    }
}
