namespace WpfDataGridProblemExample.UserControls
{
    using System.Diagnostics;
    using System.Windows;
    using System.Windows.Controls;
    using WpfDataGridProblemExample.ViewModels;

    /// <summary>
    /// RadioButtonView.xaml の相互作用ロジック
    /// </summary>
    public partial class SenpouView : UserControl
    {
        public static readonly DependencyProperty SenpouProperty = DependencyProperty.Register(
            // プロパティ名
            nameof(Senpou),
            // プロパティの型
            typeof(SenpouViewModel),
            // 所有者の型
            typeof(SenpouView),
            // デフォルト値
            new UIPropertyMetadata(null, SenpouPropertyChanged));

        /// <summary>
        /// 依存関係プロパティ 行
        /// </summary>
        public SenpouViewModel Senpou
        {
            get { return (SenpouViewModel)GetValue(SenpouProperty); }
            set { SetValue(SenpouProperty, value); }
        }

        /// <summary>
        /// 依存関係プロパティ 行 変更通知イベントハンドラ
        /// </summary>
        /// <param name="sender">変更発生元</param>
        /// <param name="args">イベント引数</param>
        private static void SenpouPropertyChanged(
                    DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            Trace.WriteLine($"[Trace] [SenpouView.cs SenpouPropertyChanged]: 変更通知 変更しました 変更通知 old={args.OldValue} new={args.NewValue}");
        }

        public SenpouView()
        {
            InitializeComponent();
        }
    }
}
