using System.Windows.Controls;

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
