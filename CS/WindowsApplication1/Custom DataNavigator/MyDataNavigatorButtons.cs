using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;

namespace WindowsApplication1
{
    public class MyDataNavigatorButtons : DataNavigatorButtons
    {
        public MyDataNavigatorButtons(INavigatorOwner owner)
            : base(owner)
        {

        }

        protected override NavigatorButtonsViewInfo CreateViewInfo()
        {
            return new MyNavigatorButtonsViewInfo(this);
        }



    }
}
