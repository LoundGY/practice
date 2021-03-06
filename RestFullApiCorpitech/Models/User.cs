using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using RestFullApiCorpitech.util;

namespace RestFullApiCorpitech.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Заполните Фамилию")]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Заполните Имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Заполните Отчество")]
        [Display(Name = "Отчество")]
        public string Middlename { get; set; }

        [Required(ErrorMessage = "Введите дату найма")]
        [Display(Name = "Дата найма")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        [JsonConverter(typeof(DateConverter))]
        public DateTime DateOfEmployment { get; set; } = DateTime.MinValue;

        public ICollection<Vacation> Vacations { get; set; } = new List<Vacation>();
        
        public string Login { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public string Role { get; set; }
        
        public ICollection<VacationDay> VacationDays { get; set; }

    }
}
