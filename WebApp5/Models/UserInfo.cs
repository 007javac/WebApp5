using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class UserInfo
{
    [Required]
    public string FirstName { get; set; }

    [Required]
    public string LastName { get; set; }

    [Required]
    public string Group { get; set; }

    [Required]
    public List<int> Grades { get; set; } = new List<int>();

    public List<string> ProgrammingLanguages { get; set; } = new List<string>();
}
