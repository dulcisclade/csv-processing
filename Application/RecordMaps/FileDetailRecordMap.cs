using Application.Models;
using CsvHelper.Configuration;

namespace Application;

public class FileDetailRecordMap : ClassMap<FileDetailRecord>
{
    public FileDetailRecordMap()
    {
        Map(member => member.RecordType).Index(0).TypeConverter<RecordConvertor<RecordType>>();
    }
}