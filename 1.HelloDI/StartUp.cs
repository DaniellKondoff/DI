using System;
using System.Threading;

namespace _1.HelloDI
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //string typeName = TypesConstants.MessageWriter;
            //var type = Type.GetType(typeName, true);
            //IMessageWriter writer = (IMessageWriter)Activator.CreateInstance(type);
            //Salutation salutation = new Salutation(writer);
            //salutation.Exclaim();


            /* Replace the hard-coded initialization of ConsoleMessageWriter with the below two
            * statements to use an example of a Decorator. */
            //Thread.CurrentPrincipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            IMessageWriter writer =
                new SecureMessageWriter(
                    new ConsoleMessageWriter());

            //IMessageWriter writer = new ConsoleMessageWriter();
            var salutation = new Salutation(writer);
            salutation.Exclaim();
        }
    }
}
