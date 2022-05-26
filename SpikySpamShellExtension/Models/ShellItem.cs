namespace SpikySpamShellExtension
{
    internal class ShellItem
    {

        internal ShellItem()
        {
        }

        internal ShellItem(AssociationType type, string extensions, string description, string command, string arguments)
        {
            Type = type;
            Extensions = extensions;
            Description = description;
            Command = command;
            Arguments = arguments;
        }

        public AssociationType Type { get; set; } = AssociationType.AllFilesAndFolders;
        public string Extensions { get; set; }
        public string Description { get; set; }
        public string Command { get; set; }
        public string Arguments { get; set; }

    }
}
