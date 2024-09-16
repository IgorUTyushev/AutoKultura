

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class CompanyEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Название компании")]
        public string Name { get; set; } = string.Empty;

        [Display(AutoGenerateFilter = true)]
        [DisplayName("Телефон для связи")]
        public string Phone { get; set; } = string.Empty;

        [DisplayName("Почта")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Адрес")]
        public string Adress { get; set; } = string.Empty;

        [DisplayName("№ Заказ наряда")]
        public int NumberOrderOnOutfit { get; set; }

        [DisplayName("Папка для сохранения заказ нарядов")]
        public string PathToFilesOrderOnOutfit { get; set; } = string.Empty;

    }
}
