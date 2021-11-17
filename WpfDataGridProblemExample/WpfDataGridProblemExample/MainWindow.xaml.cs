namespace WpfDataGridProblemExample
{
    using System;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using WpfDataGridProblemExample.ViewModels;

    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// [テストデータセット]ボタン押下時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 2回も押さなくていいぜ（＾～＾）
            var button = (Button)sender;
            button.IsEnabled = false;

            Trace.WriteLine("[Trace] [MainWindow.cs Button_Click]: [テストデータセット]ボタン押下時");
            var windowVM = (MainWindowViewModel)this.DataContext;

            for(int i=0; i<50; i++)
            {
                var no = i + 1;

                var rowVM = new RowViewModel()
                {
                    RowNumber = no,
                };

                // 戦法クラスに行番号とか要らないんだが、デバッグのために付けてるぜ（＾～＾）
                rowVM.Senpou.RowNumber = no;

                var senpou = i % 4;
                switch (senpou)
                {
                    case 0:
                        rowVM.Senpou.IsNotSelected = true;
                        break;
                    case 1:
                        rowVM.Senpou.IsIbisha = true;
                        break;
                    case 2:
                        rowVM.Senpou.IsFuribisha = true;
                        break;
                    case 3:
                        rowVM.Senpou.IsAllRounder = true;
                        break;
                    default:
                        throw new InvalidOperationException($"Unexpected senpou {senpou}");
                }

                windowVM.AddRow(rowVM);
            }
        }
    }
}
