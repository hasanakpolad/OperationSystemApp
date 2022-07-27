using OperationSystemApp.Business;
using System.Runtime.InteropServices;

namespace OperationSystemApp
{
    public static class Configuration
    {
        public static void AddDependencyObject(this IServiceCollection collection)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                collection.AddTransient<IUtnService, UtnServiceWindows>();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                collection.AddTransient<IUtnService, UtnServiceLinux>();

            }
        }
    }
}
