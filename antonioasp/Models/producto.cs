using System;
namespace antonioasp.Models
{
    public class producto
    {
        public producto()
        {
        }
        public int ID { get; set; }
        public string nombre { get; set; }
        public int Cantidad { get; set; }
        public float presio { get; set;}
    }
}
