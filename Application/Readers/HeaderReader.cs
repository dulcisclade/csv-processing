using Application.Models;
using CsvHelper;

namespace Application.Readers;

public class HeaderReader : IRecordReader
{
    public void ParseRecord(CsvReader csv, File file)
    {
        var data = csv.GetRecord<FileHeaderRecord>();
        file.AddHeader(data);
    }
}