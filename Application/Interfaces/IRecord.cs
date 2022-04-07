using System.Text.Json.Serialization;
using Application.Converters;

namespace Application;

[JsonConverter(typeof(JsonRecordConverter))]
public interface IRecord<out T>
{
    T Value { get; }
}