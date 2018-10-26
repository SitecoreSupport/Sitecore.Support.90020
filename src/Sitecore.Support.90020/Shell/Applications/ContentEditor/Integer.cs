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

      return result.ToString("#", GetCultureInfo());
    }
  }
}