using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace Vim.UI.Wpf.Implementation.CommandMargin
{
    [Export(typeof(EditorFormatDefinition))]
    [Name(CommandMarginFormatDefinition.Name)]
    [UserVisible(true)]
    internal sealed class CommandMarginFormatDefinition : EditorFormatDefinition
    {
        internal const string Name = VimWpfConstants.CommandMarginFormatDefinitionName;

        internal CommandMarginFormatDefinition()
        {
            DisplayName = "VsVim Command Margin";
            ForegroundColor = Colors.LightGray;
            BackgroundColor = Color.FromRgb(30, 30, 30);
        }
    }
}
