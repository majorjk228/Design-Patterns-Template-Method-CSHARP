namespace Design_Patterns_Template_Method_CSHARP
{
    // Шаблонный метод(Template Method)
    internal class Program
    {
        static void Main(string[] args)
        {
            var secretTemplate = new SecretDocumentTemplate();
            var result = secretTemplate.GetTemplate("This is a template of secret document");
            Console.WriteLine(result);
            Console.WriteLine("---");
            Console.WriteLine(secretTemplate.DecodeString(result));
        }
    }
}