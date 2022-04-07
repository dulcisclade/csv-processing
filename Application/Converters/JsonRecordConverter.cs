using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Application.Converters;

public class JsonRecordConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var record = ((dynamic) value)?.Value ?? string.Empty;
        var token = JToken.FromObject(record);
        writer.WriteToken(token.CreateReader());

    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => throw new NotImplementedException();

    public override bool CanConvert(Type objectType) => false;
}