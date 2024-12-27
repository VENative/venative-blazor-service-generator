using System;

namespace VENative.Blazor.ServiceGenerator.Attributes;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class GenerateHubAttribute(string @namespace, string route) : Attribute
{
    public string Namespace { get; } = @namespace;
    public string Route { get; } = route;
}