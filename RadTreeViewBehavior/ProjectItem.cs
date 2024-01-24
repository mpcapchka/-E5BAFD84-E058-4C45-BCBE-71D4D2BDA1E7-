using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadTreeViewBehavior
{
    public class ProjectItem
    {
        public string Name { get; set; } = string.Empty;
        public ObservableCollection<FileItem> Files { get; set; } = new ObservableCollection<FileItem>();
    }
}
