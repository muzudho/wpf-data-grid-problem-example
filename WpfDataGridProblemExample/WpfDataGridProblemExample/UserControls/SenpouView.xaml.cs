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
        #region 依存関係プロパティ [戦法]
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
        /// 依存関係プロパティ [戦法]
        /// </summary>
        public SenpouViewModel Senpou
        {
            get { return (SenpouViewModel)GetValue(SenpouProperty); }
            set
            {
                // XAMLを使っている間はここを通らないよう
                int? comeRowNumber = (value == null) ? null : (int?)value.RowNumber;
                var comeBitboard = (value == null) ? "null" : value.GetBitBoard();

                Trace.WriteLine($"[Trace] [SenpouView.cs SenpouPropertyChanged]: 戦法オブジェクトをセットします come:[{comeRowNumber}]{comeBitboard}");
                SetValue(SenpouProperty, value);
            }
        }

        /// <summary>
        /// 依存関係プロパティ [戦法] 変更通知イベントハンドラ
        /// </summary>
        /// <param name="sender">変更発生元</param>
        /// <param name="args">イベント引数</param>
        private static void SenpouPropertyChanged(
                    DependencyObject sender, DependencyPropertyChangedEventArgs args)
        {
            // 可視範囲の外に出ていった行オブジェクトは削除され、
            // 可視範囲の中に入ってきた行オブジェクトが設定されますが、
            // ずれてしまうようです
            var gone = args.OldValue as SenpouViewModel;
            var come = args.NewValue as SenpouViewModel;

            int? goneRowNumber = (gone == null) ? null : (int?)gone.RowNumber;
            int? comeRowNumber = (come == null) ? null : (int?)come.RowNumber;

            var goneBitboard = (gone == null) ? "null" : gone.GetBitBoard();
            var comeBitboard = (come == null) ? "null" : come.GetBitBoard();
            Trace.WriteLine($"[Trace] [SenpouView.cs SenpouPropertyChanged]: 戦法オブジェクトを使い回します gone:[{goneRowNumber}]{goneBitboard} come:[{comeRowNumber}]{comeBitboard}");
        }
        #endregion

        public SenpouView()
        {
            InitializeComponent();
        }
    }
}
