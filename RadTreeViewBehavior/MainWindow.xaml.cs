using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RadTreeViewBehavior
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Projects = new ObservableCollection<ProjectItem>()
            {
                new ProjectItem()
                {
                    Name = $"Project-{Guid.NewGuid().ToString()}",
                    Files = new ObservableCollection<FileItem>()
                    {
                        new FileItem() { Name = $"File-{Guid.NewGuid().ToString()}", },
                        new FileItem() { Name = $"File-{Guid.NewGuid().ToString()}", },
                        new FileItem() { Name = $"File-{Guid.NewGuid().ToString()}", },
                    }
                }
            };
            this.DataContext = this;
            InitializeComponent();
        }

        public ObservableCollection<ProjectItem> Projects { get; }

        private void RadTreeView_Edited(object sender, Telerik.Windows.Controls.RadTreeViewItemEditedEventArgs e)
        {
            if (object.Equals(e.OldValue, e.NewValue))
                MessageBox.Show("OldValue same as NewValue");

        }
    }
}