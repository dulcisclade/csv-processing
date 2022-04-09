using Application.Models;
using CsvHelper.Configuration;

namespace Application;

public sealed class FileDetailRecordMap : ClassMap<FileDetailRecord>
{
    public FileDetailRecordMap()
    {
        Map(member => member.Record).Index(0).TypeConverter<RecordConvertor<RecordType>>();
        Map(member => member.DetailInfo).Index(1).TypeConverter<RecordConvertor<DetailInfoType>>();
    }
}