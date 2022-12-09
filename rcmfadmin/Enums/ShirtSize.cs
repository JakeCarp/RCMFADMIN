using System.Text.Json.Serialization;
namespace rcmfadmin.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ShirtSize
{
  XS,
  Small,
  Medium,
  Large,
  XL,
  XXL,
  XXXL
}