using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace SallesWebMvc.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>(); // Um vendedor pode estar em vários departamentos         
        public Departament() { }

        public Departament(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public void addSaller(Seller sr)
        {
            Sellers.Add(sr);
        }

        public double totalSellers(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSalles(initial, final));
        }


    }
}
