using System.Collections.Generic;
using System.Linq;

namespace Composite
{
    public abstract class DirectoryItem
    {
        public string Name { get; set; }

        public abstract IEnumerable<string> GetPaths();
    }

    public class File : DirectoryItem
    {
        public string FileType { get; set; }

        public override IEnumerable<string> GetPaths()
        {
            yield return string.Format("/{0}.{1}", Name, FileType);
        }
    }

    public class Directory : DirectoryItem
    {
        public readonly IList<DirectoryItem> DirecotyItems = new List<DirectoryItem>();

        public override IEnumerable<string> GetPaths()
        {
            return from item in DirecotyItems
                   from path in item.GetPaths()
                   select string.Format("/{0}{1}", Name, path);
        }
    }
}