using Model.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class AddUserRequestDto
    {
        [Key]
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        [MinLength(6)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{6,}$", ErrorMessage = "長度不少於6，數字和英文字母混合，至少有一個數字和一個英文字母")]
        public required string Password { get; set; }

        [Required]
        public required string Name { get; set; }
        [Range(0, 120, ErrorMessage = "年齡必須在0到120之間")]
        public int? Age { get; set; }

        [Required]
        [RegularExpression("^(男|女)$", ErrorMessage = "性別必須是 '男' 或 '女'")]
        public required string Gender { get; set; }
        [Required]
        public required string Province { get; set; }

        [Required]
        public required string City { get; set; }

    }
}
