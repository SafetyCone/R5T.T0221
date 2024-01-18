using System;


namespace R5T.T0221
{
    /// <summary>
    /// It can be unclear if a method requires a file path to exist or not.
    /// For example, determining the output assembly file location for a project file can depend on the SDK value within the project file,
    /// but determining the parent directory path of a file path only involves analysis of the file path string.
    /// Using this wrapper type as the input to the method allows communicating the assumption that the file path exists.
    /// </summary>
    public readonly struct FilePathExists<TFilePath>
    {
        /// <summary>
        /// Note: this will fail if the <typeparamref name="TFilePath"/> is an interface.
        /// The compilation error is misleading, but the issue is that C# disallows implicit conversions to or from an interface (<see href="https://github.com/dotnet/core/issues/3939"/>).
        /// </summary>
        public static implicit operator TFilePath(FilePathExists<TFilePath> filePathExists)
        {
            return filePathExists.FilePath;
        }


        public TFilePath FilePath { get; }


        public FilePathExists(TFilePath filePath)
        {
            this.FilePath = filePath;
        }
    }


    public static class FilePathExists
    {
        public static FilePathExists<TFilePath> From<TFilePath>(TFilePath filePath)
        {
            var output = new FilePathExists<TFilePath>(filePath);
            return output;
        }
    }
}
