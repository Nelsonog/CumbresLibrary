using System.Data.Entity.ModelConfiguration;

namespace CumbresLibrary.Domain
{
    internal class OperationsMap : EntityTypeConfiguration<Operation>
    {
        public OperationsMap()
        {

            HasRequired(o => o.Client)
               .WithMany(m => m.Clients)
               .HasForeignKey(m => m.ClientId);

            HasRequired(o => o.Receptor)
                .WithMany(m => m.Receptors)
                .HasForeignKey(m => m.ReceptorId);
        }
    }
}