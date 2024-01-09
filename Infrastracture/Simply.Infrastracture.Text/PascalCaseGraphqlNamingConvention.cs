namespace Simply.Infrastracture.Text;

using HotChocolate.Types.Descriptors;

/// <summary>
/// Setting a naming convention to enumarations and fields to PascalCase in GraphQL.
/// </summary>
public class PascalCaseGraphqlNamingConvention 
    : DefaultNamingConventions
{
    public override string GetEnumValueName(object value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }
        
        return value.ToString();
    }
}
