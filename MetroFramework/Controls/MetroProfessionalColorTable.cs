using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls
{
    public class MetroProfessionalColorTable : ProfessionalColorTable
    {
        readonly MetroThemeStyle _theme;
        readonly MetroColorStyle _style;

        public MetroProfessionalColorTable(MetroFramework.MetroThemeStyle theme, MetroColorStyle style)
        {
            _theme = theme;
            _style = style;
        }

        public override Color MenuItemSelected
        {
            get { return MetroPaint.GetStyleColor(_style); }
        }

        public override Color MenuBorder
        {
            get { return MetroPaint.BackColor.Form(_theme); }
        }

        public override Color MenuItemBorder
        {
            get { return MetroPaint.GetStyleColor(_style); }
        }

        public override Color ImageMarginGradientBegin
        {
            get { return MetroPaint.BackColor.Form(_theme); }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return MetroPaint.BackColor.Form(_theme); }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return MetroPaint.BackColor.Form(_theme); }
        }
    }
}