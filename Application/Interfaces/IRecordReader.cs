using CsvHelper;

namespace Application;

public interface IRecordReader
{
    void ParseRecord(CsvReader csv, File file);
}