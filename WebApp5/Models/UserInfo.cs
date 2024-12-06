using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class UserInfo
{
    [Required(ErrorMessage = "Имя обязательно")]
    [StringLength(50, ErrorMessage = "Имя не может быть длиннее 50 символов")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Фамилия обязательна")]
    [StringLength(50, ErrorMessage = "Фамилия не может быть длиннее 50 символов")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Группа обязательна")]
    [StringLength(20, ErrorMessage = "Название группы слишком длинное")]
    public string Group { get; set; }

    [Required(ErrorMessage = "Введите хотя бы одну оценку")]
    [MinLength(1, ErrorMessage = "Нужна хотя бы одна оценка")]
    [MaxLength(3, ErrorMessage = "Максимум 3 оценки")]
    public List<Grade> Grades { get; set; } = new List<Grade>();

    public List<string> ProgrammingLanguages { get; set; } = new List<string>();
}

public class Grade
{
    [Range(0, 100, ErrorMessage = "Оценка должна быть в диапазоне от 0 до 100")]
    public int Value { get; set; }
}
