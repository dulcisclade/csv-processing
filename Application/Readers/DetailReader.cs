using Application.Models;
using CsvHelper;

namespace Application.Readers;

public class DetailReader : IRecordReader
{
    public void ParseRecord(CsvReader csv, File file)
    {
        var data = csv.GetRecord<FileDetailRecord>();
        file.AddDetail(data);
    }
}