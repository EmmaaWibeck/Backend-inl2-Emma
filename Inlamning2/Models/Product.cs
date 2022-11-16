using System.Security.Cryptography.X509Certificates;

namespace Inlamning2.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Created { get; set; } = DateTime.Now;


        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemNumber { get; set; }
        public decimal Price { get; set; }

    }
}
