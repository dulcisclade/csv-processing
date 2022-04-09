namespace Application.Models;

public class InformationCodeType: IRecord<int>
{
    public InformationCodeType(int data)
    {
        Value = data;
    }
    public int Value { get; }
}