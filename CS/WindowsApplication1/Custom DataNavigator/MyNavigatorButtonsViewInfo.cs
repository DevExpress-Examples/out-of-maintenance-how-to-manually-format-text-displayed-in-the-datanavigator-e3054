using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public class MyNavigatorButtonsViewInfo : NavigatorButtonsViewInfo
    {
        public MyNavigatorButtonsViewInfo(NavigatorButtonsBase buttons)
            : base(buttons)
        {

        }

        protected override NavigatorTextViewInfo CreateTextViewInfo()
        {
            return new MyNavigatorTextViewInfo(this);
        }

    }
}
