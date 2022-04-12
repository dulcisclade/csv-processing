namespace Application.Models;

public class RecordType : IRecord<string>
{
    public RecordType(string data)
    {
        var validator = ValidationBuilder.Create().Required().Build();
        if (!validator.Invoke(data))
        {
            throw new ValidationException($"{nameof(RecordType)} is invalid");
        }

        Value = data;
    }
    public string Value { get; }
}