using System.Globalization;
using CsvHelper;

namespace Application;

public interface ICsvValidationReader
{
    File ReadFile(string fileContent);
}
public class CsvValidationReader : ICsvValidationReader
{
    private ICsvReaderFactory _readerFactory;

    public CsvValidationReader(ICsvReaderFactory readerFactory)
    {
        _readerFactory = readerFactory;
    }

    public File ReadFile(string fileContent)
    {
        ArgumentNullException.ThrowIfNull(fileContent);

        var file = new File();
        
        using var reader = new StringReader(fileContent);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Configuration.Delimiter = ",";
        csv.Configuration.HasHeaderRecord = false;
        csv.Configuration.RegisterClassMap<FileHeaderRecordMap>();
        csv.Configuration.RegisterClassMap<FileDetailRecordMap>();
        csv.Configuration.RegisterClassMap<FileTrailerRecordMap>();

        while (csv.Read())
        {
            var currentReader = _readerFactory.Create(csv.GetField(0));
            currentReader.ParseRecord(csv, file);
        }

        return file;
    }
}