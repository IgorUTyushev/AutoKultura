using AutoKultura.DataAccess.SqlServer.Models;
using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewVechicleForOrder
    {
        public Guid IdVechicle { get; set; }
        public BrandCarEntity? BrandCar { get; set; }

        public ModelCarEntity? Model { get; set; }

        public string RegisterNumber { get; set; } = string.Empty;
    }
}
