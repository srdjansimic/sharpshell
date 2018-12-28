using SharpShell.Attributes;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SharpShell.SharpContextMenu;

namespace CreateDateFolder
{
    /// <summary>
    /// This extension adds the 'Create Data Folder' command to the background of folders.
    /// </summary>
    [ComVisible(true)]
    [COMServerAssociation(AssociationType.Class, @"Directory\Background")]
    public class CreateDateFolderExtension : SharpContextMenu
    {
        /// <summary>
        /// Determines whether this instance can a shell context show menu, given the specified selected file list.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance should show a shell context menu for the specified file list; otherwise, <c>false</c>.
        /// </returns>
        protected override bool CanShowMenu()
        {
            return true;
        }

        /// <summary>
        /// Creates the context menu. This can be a single menu item or a tree of them.
        /// </summary>
        /// <returns>
        /// The context menu for the shell context menu.
        /// </returns>
        protected override ContextMenuStrip CreateMenu()
        {
            //  Create the context menu.
            var contextMenu = new ContextMenuStrip();

            //  Add the 'copy path' item. This just copies the folder path for the extension.
            var menuItem = new ToolStripMenuItem("Create Date Folder");

            // Ovo kopira folder u Clipboard
            //menuItem.Click += (sender, args) => Clipboard.SetText(FolderPath);
            menuItem.Click += (sender, args) => CreateFolder();
            contextMenu.Items.Add(menuItem);

            //  Return the menu.
            return contextMenu;
        }

        private void CreateFolder()
        {
            Clipboard.SetText(FolderPath);
        }
    }
}
