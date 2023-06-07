namespace MyPrimer_App
{
    public class Producto
    {
        public Producto(string text1, string text2, decimal value, string v1, string v2)
        {
        }

        public string Caduca { get; internal set; }
        public string fechaVencimiento { get; internal set; }
        public object[] Nombre { get; internal set; }
        public object Tipo { get; internal set; }
        public object Cantidad { get; internal set; }
    }
}