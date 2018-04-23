using System;
using DevExpress.XtraEditors;

namespace WindowsApplication1
{
    public class MyDataNavigator : DataNavigator
    {



        protected override NavigatorButtonsBase CreateButtons()
        {
            return new MyDataNavigatorButtons(this);
        }
    }
}
