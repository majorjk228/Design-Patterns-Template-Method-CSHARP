namespace Design_Patterns_Template_Method_CSHARP;

public abstract class StringTemplate
{
    public virtual string GetTemplate(string text)
    {
        return $"{EncodeString(GetFirstLine() + text + GetLastLine())}";
    }

    public abstract string GetFirstLine();
    public abstract string GetLastLine();
    public abstract string EncodeString(string text);
}