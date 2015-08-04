using System.Windows.Forms;

namespace MetroFramework.Controls
{
    public class MetroToolStripProfessionalRenderer : ToolStripProfessionalRenderer
    {
        public MetroToolStripProfessionalRenderer(MetroThemeStyle theme, MetroColorStyle style)
            : base(new MetroProfessionalColorTable(theme, style))
        {
        }
    }
}