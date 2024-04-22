using Microsoft.EntityFrameworkCore;

namespace CalculatorSolution.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Calculation> Calculations { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações adicionais podem ser feitas aqui, se necessário
        }
    }

    public class Calculation
    {
        public int Id { get; set; }
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }
    }

    public class Operation
    {
        public int Id { get; set; }
        public string OperationText { get; set; }
    }
}
