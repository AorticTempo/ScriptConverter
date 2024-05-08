using DataObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public class ConvertAccessor
    {
        public string[] ConvertToPiglin(char[] toConv)
        {
            int decicode;
            List<string> convertedText = new List<string>();
            foreach (var item in toConv)
            {
                if (!char.IsLetter(item))
                {
                    convertedText.Add(item.ToString());
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
                            convertedText.Add("\\" + Enum.GetName(typeof(Conversions), decicode));
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return convertedText.ToArray();
        }
    }
}