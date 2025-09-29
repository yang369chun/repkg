using System;

namespace RePKG.Application
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("启动 RePKG.Application...");

            // 调用 MainApp
            MainApp.Run(args);

            Console.WriteLine("程序执行完毕。");
        }
    }
}
