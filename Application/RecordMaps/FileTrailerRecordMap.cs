using Application.Models;
using CsvHelper.Configuration;

namespace Application;

public sealed class FileTrailerRecordMap : ClassMap<FileTrailerRecor>
{
    public FileTrailerRecordMap()
    {
        Map(member => member.Record).Index(0).TypeConverter<RecordConvertor<RecordType>>();
        Map(member => member.Date).Index(0).TypeConverter<RecordConvertor<DateType>>();
    }
}