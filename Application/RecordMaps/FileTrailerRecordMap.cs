using Application.Models;
using CsvHelper.Configuration;

namespace Application;

public class FileTrailerRecordMap : ClassMap<FileTrailerRecor>
{
    public FileTrailerRecordMap()
    {
        Map(member => member.RecordType).Index(0).TypeConverter<RecordConvertor<RecordType>>();
    }
}