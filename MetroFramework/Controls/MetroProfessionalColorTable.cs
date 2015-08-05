using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls
{
    /// <summary>
    /// Override ProfessionalColorTable to match Metro colors
    /// see: https://msdn.microsoft.com/en-us/library/system.windows.forms.professionalcolortable_properties(v=vs.110).aspx
    /// </summary>
    public class MetroProfessionalColorTable : ProfessionalColorTable
    {
        readonly MetroThemeStyle _theme;
        readonly MetroColorStyle _style;

        public MetroProfessionalColorTable(MetroThemeStyle theme, MetroColorStyle style)
        {
            _theme = theme;
            _style = style;

        }

        public override Color MenuItemSelected
        {
            get
            {
                return MetroPaint.BackColor.Button.Normal(_theme);
            }
        }
        public override Color ButtonPressedHighlight { get { return MenuItemSelected; } }
        public override Color ButtonPressedGradientBegin { get { return MenuItemSelected; } }
        public override Color ButtonPressedGradientEnd { get { return MenuItemSelected; } }
        public override Color ButtonPressedGradientMiddle { get { return MenuItemSelected; } }
        public override Color CheckPressedBackground { get { return MenuItemSelected; } }
        public override Color MenuItemPressedGradientBegin { get { return MenuItemSelected; } }
        public override Color MenuItemPressedGradientEnd { get { return MenuItemSelected; } }
        public override Color MenuItemPressedGradientMiddle { get { return MenuItemSelected; } }
        public override Color ButtonSelectedHighlight { get { return MenuItemSelected; } }
        public override Color ButtonSelectedGradientBegin { get { return MenuItemSelected; } }
        public override Color ButtonSelectedGradientEnd { get { return MenuItemSelected; } }
        public override Color ButtonSelectedGradientMiddle { get { return MenuItemSelected; } }
        public override Color CheckSelectedBackground { get { return MenuItemSelected; } }
        public override Color MenuItemSelectedGradientBegin { get { return MenuItemSelected; } }
        public override Color MenuItemSelectedGradientEnd { get { return MenuItemSelected; } }
        public override Color ButtonCheckedHighlight { get { return MenuItemSelected; } }
        public override Color ButtonCheckedGradientBegin { get { return MenuItemSelected; } }
        public override Color ButtonCheckedGradientEnd { get { return MenuItemSelected; } }
        public override Color ButtonCheckedGradientMiddle { get { return MenuItemSelected; } }
        public override Color CheckBackground { get { return MenuItemSelected; } }

        
        public override Color MenuBorder
        {
            get
            {
                return MetroPaint.BorderColor.Button.Normal(_theme);
            }
        }
        public override Color MenuItemBorder { get { return MenuBorder; } }
        public override Color ToolStripBorder { get { return MenuBorder; } }
        public override Color SeparatorDark { get { return MenuBorder; } }
        public override Color SeparatorLight { get { return MenuBorder; } }
        public override Color GripDark { get { return MenuBorder; } }
        public override Color GripLight { get { return MenuBorder; } }
        public override Color ButtonSelectedHighlightBorder { get { return MenuBorder; } }
        public override Color ButtonSelectedBorder { get { return MenuBorder; } }
        public override Color ButtonCheckedHighlightBorder { get { return MenuBorder; } }  
        public override Color ButtonPressedHighlightBorder { get { return MenuBorder; } }  
        public override Color ButtonPressedBorder { get { return MenuBorder; } }

        
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return MetroPaint.BackColor.Form(_theme);
            }
        }
        public override Color MenuStripGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color MenuStripGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color OverflowButtonGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color OverflowButtonGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color OverflowButtonGradientMiddle { get { return ToolStripDropDownBackground; } }
        public override Color RaftingContainerGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color RaftingContainerGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color StatusStripGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color StatusStripGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripContentPanelGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripContentPanelGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripGradientMiddle { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripPanelGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color ToolStripPanelGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color ImageMarginGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color ImageMarginGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color ImageMarginGradientMiddle { get { return ToolStripDropDownBackground; } }
        public override Color ImageMarginRevealedGradientBegin { get { return ToolStripDropDownBackground; } }
        public override Color ImageMarginRevealedGradientEnd { get { return ToolStripDropDownBackground; } }
        public override Color ImageMarginRevealedGradientMiddle { get { return ToolStripDropDownBackground; } }

    }
}