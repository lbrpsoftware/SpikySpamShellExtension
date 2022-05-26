namespace SpikySpamShellExtension
{
    internal enum AssociationType : byte
    {
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.AllFilesAndFolders))]
        AllFilesAndFolders = SharpShell.Attributes.AssociationType.AllFilesAndFolders,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.AllFiles))]
        AllFiles = SharpShell.Attributes.AssociationType.AllFiles,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.Folder))]
        Folder = SharpShell.Attributes.AssociationType.Folder,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.Directory))]
        Directory = SharpShell.Attributes.AssociationType.Directory,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.DirectoryBackground))]
        DirectoryBackground = SharpShell.Attributes.AssociationType.DirectoryBackground,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.DesktopBackground))]
        DesktopBackground = SharpShell.Attributes.AssociationType.DesktopBackground,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.Drive))]
        Drive = SharpShell.Attributes.AssociationType.Drive,
        [ResourceDescription(typeof(Properties.Resources), nameof(Properties.Resources.UnknownFiles))]
        UnknownFiles = SharpShell.Attributes.AssociationType.UnknownFiles,
    }
}
