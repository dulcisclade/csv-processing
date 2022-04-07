using Application.Models;

namespace Application;

public class File
{
    public FileHeaderRecord Header { get; private set; }
    public ICollection<FileDetailRecord> Details { get; } = new List<FileDetailRecord>();
    public FileTrailerRecor Trailer { get; private set; }

    public void AddDetail(FileDetailRecord data)
    {
        ArgumentNullException.ThrowIfNull(data);
        Details.Add(data);
    }

    public void AddHeader(FileHeaderRecord data)
    {
        ArgumentNullException.ThrowIfNull(data);
        if (Header != null)
        {
            throw new ApplicationException($"{nameof(Header)} is already set");
        }

        Header = data;
    }

    public void AddTrailer(FileTrailerRecor data)
    {
        ArgumentNullException.ThrowIfNull(data);
        if (Trailer != null)
        {
            throw new ApplicationException($"{nameof(Trailer)} is already set");
        }

        Trailer = data;
    }
}