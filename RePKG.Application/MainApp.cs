using System;
using RePKG.Core.Package;
using RePKG.Core.Texture;

namespace RePKG.Application
{
    public static class MainApp
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("MainApp 启动...");

            if (args.Length == 0)
            {
                Console.WriteLine("未提供命令参数，示例: pack/unpack");
                return;
            }

            string command = args[0].ToLower();

            switch (command)
            {
                case "pack":
                    Console.WriteLine("执行打包逻辑（TODO: 调用 RePKG.Core 方法）");
                    break;
                case "unpack":
                    Console.WriteLine("执行解包逻辑（TODO: 调用 RePKG.Core 方法）");
                    break;
                default:
                    Console.WriteLine($"未知命令: {command}");
                    break;
            }

            Console.WriteLine("MainApp 执行完成。");
        }
    }
}
