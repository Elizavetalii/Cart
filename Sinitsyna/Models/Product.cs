using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Sinitsyna.Models;

namespace Sinitsyna.Models
{
    public class Product
    {
        [Key]
        public int Id_product { get; set; }

        [Required(ErrorMessage = "Название товара обязательно.")]
        public string Product_name { get; set; }

        [Required(ErrorMessage = "Цена обязательна.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Цена должна быть больше нуля.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Количество обязательно.")]
        [Range(1, int.MaxValue, ErrorMessage = "Количество должно быть больше нуля.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Описание товара обязательно.")]
        public string Product_description { get; set; }

        [ValidateNever] // Исключаем из проверки валидации
        public int? Id_boutique { get; set; }

        [ForeignKey("Id_boutique")]
        public Boutique Boutique { get; set; }

        [ValidateNever] // Исключаем из проверки валидации
        public int? Id_type { get; set; }

        [ForeignKey("Id_type")]
        public ProductType ProductType { get; set; }

        [ValidateNever] // Исключаем из проверки валидации
        public int? Id_material { get; set; }

        [ForeignKey("Id_material")]
        public ProductMaterial ProductMaterial { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
    }
}