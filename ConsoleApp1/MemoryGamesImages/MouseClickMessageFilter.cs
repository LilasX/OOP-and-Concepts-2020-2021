using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MemoryGamesImages
{
    public class MouseClickMessageFilter : IMessageFilter
    {
        private static MouseClickMessageFilter Filter;

        private const int LButtonDown = 0x201;
        private const int LButtonUp = 0x202;
        private const int LButtonDoubleClick = 0x203;

        public bool PreFilterMessage(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case LButtonDown:
                case LButtonUp:
                case LButtonDoubleClick:
                    return true;
            }
            return false;
        }
        public static void DisableMouseClicks()
        {
            if (Filter == null)
            {
                Filter = new MouseClickMessageFilter();
                Application.AddMessageFilter(Filter);
            }
        }

        public static void EnableMouseClicks()
        {
            if ((Filter != null))
            {
                Application.RemoveMessageFilter(Filter);
                Filter = null;
            }
        }

    }
}
