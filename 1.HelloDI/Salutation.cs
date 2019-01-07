namespace _1.HelloDI
{
    public class Salutation
    {
        private readonly IMessageWriter writer;

        public Salutation(IMessageWriter writer)
        {
            this.writer = writer;
        }

        public void Exclaim()
        {
            this.writer.Write("Hello DI!");
        }
    }
}
