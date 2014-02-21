namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        #region Constructors
        public Document(string name)
        {
            this.Name = name;
        }

        public Document(string name, string content)
            : this(name)
        {
            this.Content = content;
        }

        #endregion

        #region Properties
        public string Name
        {
            get;
            private set;
        }

        public string Content
        {
            get;
            private set;
        }
        #endregion

        #region Methods
        public void LoadProperty(string key, string value)
        {
            throw new System.NotImplementedException();
        }

        public void SaveAllProperties(System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<string, object>> output)
        {
            throw new System.NotImplementedException();
        }

        public abstract string GetInformation();

        #endregion
    }
}
