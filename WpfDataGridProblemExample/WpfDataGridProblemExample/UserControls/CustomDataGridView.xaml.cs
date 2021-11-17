namespace WpfDataGridProblemExample.UserControls
{
    using System.Collections.ObjectModel;
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
            new UIPropertyMetadata(null));

        /// <summary>
        /// 依存関係プロパティ 行
        /// </summary>
        public ObservableCollection<RowViewModel> Rows
        {
            get { return (ObservableCollection<RowViewModel>)GetValue(RowsProperty); }
            set { SetValue(RowsProperty, value); }
        }

        public CustomDataGridView()
        {
            InitializeComponent();
        }
    }
}
