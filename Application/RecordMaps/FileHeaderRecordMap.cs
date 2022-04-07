using Application.Models;
using CsvHelper.Configuration;

namespace Application;

public class FileHeaderRecordMap : ClassMap<FileHeaderRecord>
{
    public FileHeaderRecordMap()
    {
        Map(member => member.RecordType).Index(0).TypeConverter<RecordConvertor<RecordType>>();
    }
}