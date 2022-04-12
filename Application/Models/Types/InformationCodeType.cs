namespace Application.Models;

public class InformationCodeType : IRecord<int>
{
    public InformationCodeType(string data)
    {
        var validator = ValidationBuilder.Create().Required().Build();
        if (!validator.Invoke(data))
        {
            throw new ValidationException($"{nameof(InformationCodeType)} is invalid");
        }

        Value = int.Parse(data);
    }

    public int Value { get; }
}