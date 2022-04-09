using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TabControlCustom
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // 先頭のタブの設定
            TabItem item = (TabItem)TabControlAddDel.Items.GetItemAt(0);
            item.Header = "タブ1";
            item.Content = new TabItemUserControl(1);
        }

        private void SelectedAddDelTab(object sender, SelectionChangedEventArgs e)
        {
            // 選択したタブのインデックス
            int idx = TabControlAddDel.SelectedIndex;

            // タブの総数
            int count = TabControlAddDel.Items.Count;

            // 追加ボタン(＋)を選択する
            if (idx == count - 1)
            {
                // 追加するタブの設定
                TabItem item = new TabItem();
                item.Header = "タブ" + count;
                item.Content = new TabItemUserControl(count);

                // 追加ボタンの前にタブを追加
                TabControlAddDel.Items.Insert(count - 1, item);

                // 追加したタブを選択状態にする
                TabControlAddDel.SelectedIndex = count - 1;
            }
        }
    }
}
