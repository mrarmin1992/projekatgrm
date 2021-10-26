using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandCreateDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}