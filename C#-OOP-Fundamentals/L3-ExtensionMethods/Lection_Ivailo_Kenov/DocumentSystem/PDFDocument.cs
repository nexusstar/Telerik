using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentSystem
{
    public class PDFDocument:TextDocument, IDocument
    {
        public override string GetInformation()
        {
            throw new NotImplementedException();
        }

        string IDocument.Name
        {
            get { throw new NotImplementedException(); }
        }

        string IDocument.Content
        {
            get { throw new NotImplementedException(); }
        }

        void IDocument.LoadProperty(string key, string value)
        {
            throw new NotImplementedException();
        }

        void IDocument.SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            throw new NotImplementedException();
        }

        string IDocument.ToString()
        {
            throw new NotImplementedException();
        }
    }
}
