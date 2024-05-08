using DataObjects;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public class ConvertAccessor
    {
        public string[] ConvertToPiglin(char[] toConv)
        {
            int decicode;
            int count = 0;
            string[] convertedText = {};
            foreach (var item in toConv)
            {
                if (!char.IsLetter(item))
                {
                    convertedText[count++] = item.ToString();
                    continue;
                }
                else
                {
                    try
                    {
                        decicode = Convert.ToInt32(item);
                        decicode += 27;
                        if (Enum.GetName(typeof(Conversions), decicode) == null)
                        {
                            throw new Exception("you did a bad");
                        }
                        else
                        {
                            convertedText[count++] = "\\" + Enum.GetName(typeof(Conversions), decicode);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    
                }
            }
            return convertedText;
        }
    }
}