using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace Application;

public class RecordConvertor<T> : DefaultTypeConverter where T : class
{
    public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
    {
        return (T) Activator.CreateInstance(typeof(T), text)!;
    }

    public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
    {
        return ((dynamic)value).Value.ToString();
    }
}