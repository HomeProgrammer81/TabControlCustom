using System.Windows;
using System.Windows.Controls;

namespace TabControlCustom
{
    /// <summary>
    /// TabHeaderUserControl.xaml の相互作用ロジック
    /// </summary>
    public partial class TabHeaderUserControl : UserControl
    {
        public TabHeaderUserControl()
        {
            InitializeComponent();
        }

        public TabHeaderUserControl(int num)
        {
            InitializeComponent();

            label.Content = "タブ" + num;
        }

        private void ClickedDelete(object sender, RoutedEventArgs e)
        {
            TabItem item = (TabItem)this.Parent;
            TabControl tabControl = (TabControl)item.Parent;

            // 1つ前のタブを選択する
            tabControl.SelectedIndex--;

            // タブを削除する
            tabControl.Items.Remove(item);
        }
    }
}
