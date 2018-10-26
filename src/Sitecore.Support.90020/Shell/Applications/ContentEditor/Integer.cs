using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Shell.Applications.ContentEditor
{
  public class Integer : Sitecore.Shell.Applications.ContentEditor.Integer
  {
    protected override string FormatNumber(string value)
    {
      if (value.Length == 0)
      {
        return string.Empty;
      }

      long result;
      if (!long.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
      {
        return value;
      }
      else if (result == 0)
      {
        // Return zero value without formatting.
        return "0";
      }

      return result.ToString("#", GetCultureInfo());
    }
  }
}