using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Rpg
    {
        Knight,
        Soldier,
        Cleric
    }
}