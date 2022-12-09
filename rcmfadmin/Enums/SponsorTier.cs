using System.Text.Json.Serialization;
namespace rcmfadmin.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SponsorTier
{
  Hole,
  Team,
  Bronze,
  Silver,
  Gold,
  Platinum,
  Diamond
}