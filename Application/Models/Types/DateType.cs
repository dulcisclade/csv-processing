namespace Application.Models;

public class DateType: IRecord<DateTime>
{
    public DateType(string data)
    {
        var validator = ValidationBuilder.Create().Required().Build();
        if (!validator.Invoke(data))
        {
            throw new ValidationException($"{nameof(DateType)} is invalid");
        }
        
        Value = DateTime.Parse(data);
    }
    public DateTime Value { get; }
}