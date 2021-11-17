namespace WpfDataGridProblemExample.ViewModels
{
    using Livet;

    /// <summary>
    /// 戦法ビューモデル
    /// </summary>
    public class SenpouViewModel : ViewModel
    {
        private int rowNumber;

        /// <summary>
        /// 変更通知プロパティ 行番号
        /// このクラスに行番号とか要らないんだが、デバッグのために付けてるぜ（＾～＾）
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

        private bool isNotSelected;

        /// <summary>
        /// 変更通知プロパティ 未選択
        /// </summary>
        public bool IsNotSelected
        {
            get
            {
                return isNotSelected;
            }
            set
            {
                if (isNotSelected == value)
                {
                    return;
                }
                isNotSelected = value;
                RaisePropertyChanged(nameof(IsNotSelected));
            }
        }

        private bool isIbisha;

        /// <summary>
        /// 変更通知プロパティ 居飛車党
        /// </summary>
        public bool IsIbisha
        {
            get
            {
                return isIbisha;
            }
            set
            {
                if (isIbisha == value)
                {
                    return;
                }
                isIbisha = value;
                RaisePropertyChanged(nameof(IsIbisha));
            }
        }

        private bool isFuribisha;

        /// <summary>
        /// 変更通知プロパティ 振り飛車党
        /// </summary>
        public bool IsFuribisha
        {
            get
            {
                return isFuribisha;
            }
            set
            {
                if (isFuribisha == value)
                {
                    return;
                }
                isFuribisha = value;
                RaisePropertyChanged(nameof(IsFuribisha));
            }
        }

        private bool isAllRounder;

        /// <summary>
        /// 変更通知プロパティ オールラウンダー
        /// </summary>
        public bool IsAllRounder
        {
            get
            {
                return isAllRounder;
            }
            set
            {
                if (isAllRounder == value)
                {
                    return;
                }
                isAllRounder = value;
                RaisePropertyChanged(nameof(IsAllRounder));
            }
        }

        /// <summary>
        /// チェックの状態をビットボード表現で返します
        /// </summary>
        /// <returns></returns>
        public string GetBitBoard()
        {
            var notSelected = IsNotSelected ? 1 : 0;
            var isIbisha = IsIbisha ? 1 : 0;
            var isFuribisha = IsFuribisha ? 1 : 0;
            var isAllRounder = IsAllRounder ? 1 : 0;

            return $"{notSelected}{isIbisha}{isFuribisha}{isAllRounder}";
        }
    }
}
