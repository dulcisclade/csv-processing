namespace Application;

public class ValidationBuilder
{
    private readonly List<Func<string, bool>> _validationFunctions = new();
    public static ValidationBuilder Create()
    {
        return new ValidationBuilder();
    }

    public ValidationBuilder Required()
    {
        _validationFunctions.Add(data => !string.IsNullOrWhiteSpace(data));
        return this;
    }

    public ValidationBuilder Empty()
    {
        _validationFunctions.Add(string.IsNullOrWhiteSpace);
        return this;
    }

    public Func<string, bool> Build()
    {
        return data =>
        {
            foreach (var func in _validationFunctions)
            {
                if (!func(data))
                {
                    return false;
                }
            }

            return true;
        };
    }
}