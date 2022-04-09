namespace Application.Models;

public class DateType: IRecord<DateTime>
{
    public DateType(DateTime data)
    {
        Value = data;
    }
    public DateTime Value { get; }
}