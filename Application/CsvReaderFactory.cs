using Application.Constants;
using Application.Readers;

namespace Application;

public interface ICsvReaderFactory
{
    IRecordReader Create(string field);
}

public class CsvReaderFactory : ICsvReaderFactory
{
    private static readonly Dictionary<string, IRecordReader> Readers = new()
    {
        {RecordConstants.HeaderRecord, new HeaderReader()},
        {RecordConstants.DetailRecord, new DetailReader()},
        {RecordConstants.TrailerRecord, new TrailerReader()},
    };


    public IRecordReader Create(string field)
    {
        if (Readers.TryGetValue(field, out var value))
        {
            return value;
        }

        throw new ApplicationException($"Cannot fined reader for type {field}");
    }
}