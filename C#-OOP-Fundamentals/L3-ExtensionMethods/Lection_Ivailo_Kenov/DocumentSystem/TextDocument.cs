namespace DocumentSystem
{
    using System;
    public abstract class  TextDocument:Document, IDocument
    {
        public  TextDocument(string name, string charset)
            : base(name)
        {
            this.Charset = charset;
        }

        public TextDocument(string name, string content, string charset)
            : base(name, content)
        {
            this.Charset = charset;
        }
        public string Charset { get; private set; }
        
    }
}
