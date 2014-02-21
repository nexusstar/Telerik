using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class WordDocument:OfficeDocument, IDocument, IEncryptable
    {
        public WordDocument(string name, string content, long size, string version, int numberOfCharacters)
            : base(name, content, size, version)
        {
            this.NumberOfCharacters = numberOfCharacters;
            this.IsEncrypted = false;
        }
        public int NumberOfCharacters { get; private set; }

        public bool IsEncrypted
        {
            get;
            private set;
        }

        public void Encrypt()
        {
            this.IsEncrypted = true;
        }

        public void Decrypt()
        {
            this.IsEncrypted = false;
        }
    }
}
