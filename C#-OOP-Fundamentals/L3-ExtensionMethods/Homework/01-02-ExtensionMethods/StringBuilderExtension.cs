namespace _01_02_ExtensionMethods
{
    using System;
    using System.Text;
    public static class StringBuilderExtension
    {       
        /// <summary>
        /// StringBuilder StringBuilder.Substring 
        /// </summary>
        /// <param name="input">StringBuilder</param>
        /// <param name="startIndex">int index from where to extract Substring</param>
        /// <returns>StringBuilder object</returns>
        public static StringBuilder Substring(this StringBuilder input, int startIndex)
        {
            return new StringBuilder(input.ToString().Substring(startIndex));
        }
        /// <summary>
        /// StringBuilder StringBuilder.Substring 
        /// </summary>
        /// <param name="input">StringBuilder</param>
        /// <param name="startIndex">int start index</param>
        /// <param name="length">int length to be extracted</param>
        /// <returns>StringBuilder object</returns>
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            return new StringBuilder(input.ToString().Substring(startIndex, length));
        }
        
    }
}
