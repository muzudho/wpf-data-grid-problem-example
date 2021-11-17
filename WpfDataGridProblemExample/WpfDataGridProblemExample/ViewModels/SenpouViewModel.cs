namespace WpfDataGridProblemExample.ViewModels
{
    using Livet;

    /// <summary>
    /// 戦法ビューモデル
    /// </summary>
    public class SenpouViewModel : ViewModel
    {
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
    }
}
