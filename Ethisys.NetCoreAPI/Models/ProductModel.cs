using Ethisys.NetCoreDomain.Dtos;
using System;

namespace Ethisys.NetCoreAPI.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public DateTime DateAvailable { get; set; }
        public ManufacturerModel Manufacturer { get; set; }
    }
}
