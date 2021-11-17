namespace WpfDataGridProblemExample.ViewModels
{
    using Livet;
    using System.Collections.ObjectModel;

    public class MainWindowViewModel : ViewModel
    {
        private ObservableCollection<RowViewModel> rows;

        /// <summary>
        /// 変更通知プロパティ 行コレクション
        /// </summary>
        public ObservableCollection<RowViewModel> Rows
        {
            get
            {
                if (rows == null)
                {
                    rows = new ObservableCollection<RowViewModel>();
                }
                return rows;
            }
            set
            {
                if (rows == value)
                {
                    return;
                }
                rows = value;
                RaisePropertyChanged(nameof(Rows));
            }
        }

        public void AddRow(RowViewModel rowVM)
        {
            this.Rows.Add(rowVM);
            RaisePropertyChanged(nameof(Rows));
        }
    }
}
