

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class SpecialistEntity
    {
        public Guid Id { get; set; }

        [DisplayName("ФИО мастера")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Телефон")]
        public string Phone { get; set; } = string.Empty;

        public List<LinqSpecialistForRenderServicesEntity> LinqsRenderServices { get; set; } = [];
    }

}
