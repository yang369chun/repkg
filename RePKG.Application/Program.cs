using System;
using RePKG; // 根据你源码里命名空间修改

namespace RePKG.Application
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // 如果有具体入口方法，例如 RePKG.MainApp.Run(args)
                // 你需要根据源码调整
                MainApp.Run(args);  
            }
            catch (Exception ex)
            {
                Console.WriteLine("运行出错: " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
