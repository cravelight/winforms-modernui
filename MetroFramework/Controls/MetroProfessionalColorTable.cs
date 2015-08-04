using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls
{
    public class MetroProfessionalColorTable : ProfessionalColorTable
    {
        readonly MetroThemeStyle _theme;
        readonly MetroColorStyle _style;

        public MetroProfessionalColorTable(MetroThemeStyle theme, MetroColorStyle style)
        {
            _theme = theme;
            _style = style;
        }

        private Color ThemeBackColor { get { return MetroPaint.BackColor.Form(_theme); } }
        private Color ThemeForeColor { get { return MetroPaint.ForeColor.Label.Normal(_theme); } }
        private Color ThemeStyleColor { get { return MetroPaint.GetStyleColor(_style); } }

        public override Color ButtonCheckedGradientBegin { get { return ThemeStyleColor; } }
        public override Color ButtonCheckedGradientEnd { get { return ThemeStyleColor; } }
        public override Color ButtonCheckedGradientMiddle { get { return ThemeStyleColor; } }
        public override Color ButtonCheckedHighlight { get { return ThemeStyleColor; } }
        public override Color ButtonCheckedHighlightBorder { get { return ThemeStyleColor; } }
        public override Color ButtonPressedBorder { get { return ThemeStyleColor; } }
        public override Color ButtonPressedGradientBegin { get { return ThemeStyleColor; } }
        public override Color ButtonPressedGradientEnd { get { return ThemeStyleColor; } }
        public override Color ButtonPressedGradientMiddle { get { return ThemeStyleColor; } }
        public override Color ButtonPressedHighlight { get { return ThemeStyleColor; } }
        public override Color ButtonPressedHighlightBorder { get { return ThemeStyleColor; } }
        public override Color ButtonSelectedBorder { get { return ThemeStyleColor; } }
        public override Color ButtonSelectedGradientBegin { get { return ThemeStyleColor; } }
        public override Color ButtonSelectedGradientEnd { get { return ThemeStyleColor; } }
        public override Color ButtonSelectedGradientMiddle { get { return ThemeStyleColor; } }
        public override Color ButtonSelectedHighlight { get { return ThemeStyleColor; } }
        public override Color ButtonSelectedHighlightBorder { get { return ThemeStyleColor; } }
        public override Color CheckBackground { get { return ThemeBackColor; } }
        public override Color CheckPressedBackground { get { return ThemeStyleColor; } }
        public override Color CheckSelectedBackground { get { return ThemeStyleColor; } }
        public override Color GripDark { get { return ThemeStyleColor; } }
        public override Color GripLight { get { return ThemeStyleColor; } }
        public override Color ImageMarginGradientBegin { get { return ThemeBackColor; }        }
        public override Color ImageMarginGradientEnd { get { return ThemeBackColor; }}
        public override Color ImageMarginGradientMiddle { get { return ThemeBackColor; }}
        public override Color ImageMarginRevealedGradientBegin { get { return ThemeBackColor; } }
        public override Color ImageMarginRevealedGradientEnd { get { return ThemeBackColor; } }
        public override Color ImageMarginRevealedGradientMiddle { get { return ThemeBackColor; } }
        public override Color MenuBorder{get { return ThemeBackColor; }}
        public override Color MenuItemBorder{get { return ThemeStyleColor; }}
        public override Color MenuItemPressedGradientBegin { get { return ThemeStyleColor; } }
        public override Color MenuItemPressedGradientEnd { get { return ThemeStyleColor; } }
        public override Color MenuItemPressedGradientMiddle { get { return ThemeStyleColor; } }
        public override Color MenuItemSelected{get { return ThemeStyleColor; }}
        public override Color MenuItemSelectedGradientBegin { get { return ThemeStyleColor; } }
        public override Color MenuItemSelectedGradientEnd { get { return ThemeStyleColor; } }
        public override Color MenuStripGradientBegin { get { return ThemeBackColor; } }
        public override Color MenuStripGradientEnd { get { return ThemeBackColor; } }
        public override Color OverflowButtonGradientBegin { get { return ThemeBackColor; } }
        public override Color OverflowButtonGradientEnd { get { return  ThemeStyleColor; } }
        public override Color OverflowButtonGradientMiddle { get { return  ThemeStyleColor; } }
        public override Color RaftingContainerGradientBegin { get { return ThemeBackColor; } }
        public override Color RaftingContainerGradientEnd { get { return ThemeBackColor; } }
        public override Color SeparatorDark { get { return ThemeStyleColor; } }
        public override Color SeparatorLight { get { return ThemeStyleColor; } }
        public override Color StatusStripGradientBegin { get { return ThemeBackColor; } }
        public override Color StatusStripGradientEnd { get { return ThemeBackColor; } }
        public override Color ToolStripBorder { get { return ThemeStyleColor; } }
        public override Color ToolStripContentPanelGradientBegin { get { return ThemeBackColor; } }
        public override Color ToolStripContentPanelGradientEnd { get { return ThemeBackColor; } }
        public override Color ToolStripDropDownBackground { get { return ThemeBackColor; } }
        public override Color ToolStripGradientBegin { get { return ThemeBackColor; } }
        public override Color ToolStripGradientEnd { get { return ThemeBackColor; } }
        public override Color ToolStripGradientMiddle { get { return ThemeBackColor; } }
        public override Color ToolStripPanelGradientBegin { get { return ThemeBackColor; } }
        public override Color ToolStripPanelGradientEnd { get { return ThemeBackColor; } }



    }
}