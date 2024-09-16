

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class LinqSpecialistForRenderServicesEntity
    {
        public Guid Id { get; set; }

        public Guid SpecialistId { get; set; }
        public SpecialistEntity? Specialist { get; set; }

        public Guid RenderServiceId { get; set; }

        public RenderServiceEntity? RenderService { get; set; }

    }

}
