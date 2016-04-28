namespace CodeWalk.Ast.CSharp
{
    public interface TypeInfo
    {
        string Name { get; }
        string FullName { get; }
        object RawTypeInfo { get; }
    }
} 