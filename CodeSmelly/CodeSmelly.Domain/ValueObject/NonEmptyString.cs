using CodeSmelly.Domain.Exceptions;

namespace CodeSmelly.Domain.ValueObject;

public class NonEmptyString
{
    public string Value { get; }

    public NonEmptyString(string value)
    {
        if (IncorrectValue(value))
            throw new DomainRuleException("The string is null or empty.");

        Value = value;
    }

    private bool IncorrectValue(string value) => string.IsNullOrEmpty(value) || value == " ";
}
