namespace Application.Models;

public class DetailInfoType : IRecord<string>
{
    public DetailInfoType(string data)
    {
        var validator = ValidationBuilder.Create().Required().Build();

        if (!validator.Invoke(data))
        {
            throw new ValidationException($"{nameof(DetailInfoType)} is invalid");
        }

        Value = data;
    }
    public string Value { get; }
}