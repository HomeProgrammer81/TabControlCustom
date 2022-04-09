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
    /// TabItemUserControl.xaml の相互作用ロジック
    /// </summary>
    public partial class TabItemUserControl : UserControl
    {
        public TabItemUserControl()
        {
            InitializeComponent();
        }

        public TabItemUserControl(int num)
        {
            InitializeComponent();

            // ラベルの設定
            label.Content = "タブ" + num;

            // テキストボックスの設定
            textbox.Text = "タブ" + num;
        }
    }
}
