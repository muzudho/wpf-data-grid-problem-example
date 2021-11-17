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

        private SenpouViewModel senpou;

        /// <summary>
        /// 変更通知プロパティ 戦法
        /// </summary>
        public SenpouViewModel Senpou
        {
            get
            {
                if (senpou == null)
                {
                    senpou = new SenpouViewModel();
                }

                return senpou;
            }
            set
            {
                if (senpou == value)
                {
                    return;
                }
                senpou = value;
                RaisePropertyChanged(nameof(Senpou));
            }
        }
    }
}
