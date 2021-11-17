namespace WpfDataGridProblemExample.ViewModels
{
    using Livet;

    public class RowViewModel : ViewModel
    {
        private int rowNumber;

        /// <summary>
        /// 変更通知プロパティ 行番号
        /// </summary>
        public int RowNumber
        {
            get
            {
                return rowNumber;
            }
            set
            {
                if (rowNumber == value)
                {
                    return;
                }
                rowNumber = value;
                RaisePropertyChanged(nameof(RowNumber));
            }
        }
    }
}
