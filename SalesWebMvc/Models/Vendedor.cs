using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double SalarioBase { get; set; }

        public DateTime DataNascimento { get; set; }

        public Departamento Departamento{ get; set; }

        public ICollection<RegistroVendas> Vendas { get; set; } = new List<RegistroVendas>();

        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, double salarioBase, DateTime dataNascimento, Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            SalarioBase = salarioBase;
            DataNascimento = dataNascimento;
            Departamento = departamento;
        }

        public void addVendas(RegistroVendas rv)
        {
            Vendas.Add(rv);
        }

        public void RemoverVenda(RegistroVendas rv)
        {
            Vendas.Remove(rv);
        }

        public double TotalVendas(DateTime dataInicial, DateTime dataFinal)
        {
            return Vendas.Where(rv => rv.Data >= dataInicial && rv.Data <= dataFinal).Sum(rv => rv.Montante);
        }
    }
}
