namespace Simply.Core;

/// <summary>
/// Entity not found exception.
/// </summary>
public class EntityNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EntityNotFoundException"/> class.
    /// </summary>
    /// <param name="entity">The entity type./param>
    /// <param name="name">The entity name.</param>
    public EntityNotFoundException(string entity, string name)
        : base($"Domain exception: Entity of type {entity} is not found for {name}")
    {
    }
}

