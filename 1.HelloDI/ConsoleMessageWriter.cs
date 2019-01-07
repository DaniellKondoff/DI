namespace _1.HelloDI
{
    public class ConsoleMessageWriter : IMessageWriter
    {
        public void Write(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
