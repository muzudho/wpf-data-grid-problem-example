namespace WpfDataGridProblemExample.UserControls
{
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using WpfDataGridProblemExample.ViewModels;

    /// <summary>
    /// CustomDataGridView.xaml の相互作用ロジック
    /// </summary>
    public partial class CustomDataGridView : UserControl
    {
        public static readonly DependencyProperty RowsProperty = DependencyProperty.Register(
            // プロパティ名
            nameof(Rows),
            // プロパティの型
            typeof(ObservableCollection<RowViewModel>),
            // 所有者の型
            typeof(CustomDataGridView),
            // デフォルト値
            new UIPropertyMetadata(null, RowsPropertyChanged));

        /// <summary>
        /// 依存関係プロパティ 行
        /// </summary>
        public ObservableCollection<RowViewModel> Rows
        {
            get { return (ObservableCollection<RowViewModel>)GetValue(RowsProperty); }
            set { SetValue(RowsProperty, value); }
        }

        /// <summary>
        /// 依存関係プロパティ 行 変更通知イベントハンドラ
        /// </summary>
        /// <param name="sender">変更発生元</param>
        /// <param name="args">イベント引数</param>
        private static void RowsPropertyChanged(
                    DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            Trace.WriteLine($"[Trace] [CustomDataGridView.cs RowsPropertyChanged]: 行オブジェクト変更しました old={args.OldValue} new={args.NewValue}");
        }

        public CustomDataGridView()
        {
            InitializeComponent();
        }
    }
}
