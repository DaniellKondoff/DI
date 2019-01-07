using System.Threading;

namespace _1.HelloDI
{
    public class SecureMessageWriter : IMessageWriter
    {
        private readonly IMessageWriter writer;

        public SecureMessageWriter(IMessageWriter writer)
        {
            this.writer = writer;
        }

        public void Write(string message)
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                this.writer.Write(message);
            }
        }
    }
}
