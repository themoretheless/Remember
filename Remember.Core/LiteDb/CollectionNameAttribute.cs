using System;

namespace LiteDB
{
    internal class CollectionAttribute : Attribute
    {
        public string Name { get; set; }
        public CollectionAttribute(string name)
        {
            Name = name;
        }
    }
}