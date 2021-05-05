using dotnet_rpg.Models;

namespace dotnet_rpg.DTOs.Character
{
    public class GetCharacterDto
    {
        public int id { get; set; }
        public string Name { get; set; } = "Frodo";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 10;
        public int Defence { get; set; } =10;
        public int Inteligence { get; set; } = 10;
        public Rpg Class { get; set; } = Rpg.Knight;
    }
}