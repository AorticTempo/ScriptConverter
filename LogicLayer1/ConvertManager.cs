using DataAccessLayer;
using System;

namespace LogicLayer
{
    public class ConvertManager
    {
        ConvertAccessor convertAccessor = new ConvertAccessor();
        public string convertTo(string script, char[] Text)
        {
            string[] newText;
            string convertedText = "";
            try
            {
                newText = convertAccessor.ConvertToPiglin(Text);
            }
            catch (Exception)
            {

                throw;
            }
            foreach (var item in newText)
            {
                convertedText += item;
            }
            return convertedText;
            
        }
    }
}