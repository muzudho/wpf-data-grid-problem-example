namespace WpfDataGridProblemExample
{
    using System.Diagnostics;
    using System.Windows;
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
            Trace.WriteLine("[Trace] [MainWindow.cs Button_Click]: [テストデータセット]ボタン押下時");
            var windowVM = (MainWindowViewModel)this.DataContext;

            for(int i=0; i<50; i++)
            {
                var no = i + 1;

                var rowVM = new RowViewModel()
                {
                    RowNumber = no,
                    Senpou = new SenpouViewModel()
                    {
                        IsFuribisha=true,
                    }
                };

                windowVM.AddRow(rowVM);
            }
        }
    }
}
