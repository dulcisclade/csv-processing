namespace Application;

public class FileHandler
{
    private ICsvValidationReader _reader;

    public FileHandler(ICsvValidationReader reader)
    {
        _reader = reader;
    }

    public File Handle(string fileContent)
    {
        return _reader.ReadFile(fileContent);
    }
}