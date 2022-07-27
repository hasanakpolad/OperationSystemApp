namespace OperationSystemApp.Business
{
    public interface IUtnService
    {
        string SayHello();
    }

    public class UtnServiceWindows : IUtnService
    {
        public string SayHello()
        {
            return "Hello from Windows";
        }
    }

    public class UtnServiceLinux : IUtnService
    {
        public string SayHello()
        {
            return "Hello from Linux";

        }
    }
}
