namespace DocumentSystem
{
    public abstract class BinaryDocument : Document, IDocument
    {
        public BinaryDocument(string name, long size)
            : base(name)
        {
            this.Size = size;
        }

        public BinaryDocument(string name, string content, long size)
            : base(name, content)
        {
            this.Size = size;
        }
        public long Size { get; private set; }
    }
}
