using Application.Models;
using CsvHelper.Configuration;

namespace Application;

public sealed class FileHeaderRecordMap : ClassMap<FileHeaderRecord>
{
    public FileHeaderRecordMap()
    {
        Map(member => member.Record).Index(0).TypeConverter<RecordConvertor<RecordType>>();
        Map(member => member.InformationCode).Index(0).TypeConverter<RecordConvertor<InformationCodeType>>();
    }
}