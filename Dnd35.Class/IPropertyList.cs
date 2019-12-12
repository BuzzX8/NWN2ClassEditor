using System.Collections.Generic;

namespace Dnd35.Class
{
    public interface IPropertyList<T> : IDictionary<int, T> where T : ClassProperty
    { }
}