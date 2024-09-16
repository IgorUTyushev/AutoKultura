

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class CustomerEntity
    {
        public Guid Id { get; set; }

        [DisplayName("ФИО клиента")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Телефон")]
        public string Phone { get; set; } = string.Empty;

        [DisplayName("Почта")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Дополнительная информация")]
        public string AdditionalInformation { get; set; } = string.Empty;

        [DisplayName("Транспортные средства")]
        public List<VechicleEntity> Vechicles { get; set; } = [];
    }
}
