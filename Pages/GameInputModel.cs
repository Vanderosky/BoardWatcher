using System.ComponentModel.DataAnnotations;

public class GameInputModel
{
    [Required]
    [StringLength(8, ErrorMessage = "Game ID is too long ")]
    public string Id { get; set; }
}