using Application.Models;
using CsvHelper;

namespace Application.Readers;

public class TrailerReader : IRecordReader
{
    public void ParseRecord(CsvReader csv, File file)
    {
        var data = csv.GetRecord<FileTrailerRecor>();
        file.AddTrailer(data);
    }
}