using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // this enables recursion. it resembles a tree structure like XML or file system
            // https://en.wikipedia.org/wiki/Composite_pattern
            var directory = new Directory{Name = "root"};

            directory.DirecotyItems.Add(new File{ Name = "test", FileType = "txt"});
            var subDir = new Directory {Name = "user"};
            subDir.DirecotyItems.Add(new File { Name = "profiles", FileType = "xml" });
            subDir.DirecotyItems.Add(new File { Name = "user", FileType = "jpeg" });
            directory.DirecotyItems.Add(subDir);

            foreach (var path in directory.GetPaths())
            {
                Console.WriteLine(path);
            }
            Console.ReadLine();
        }
    }
}
