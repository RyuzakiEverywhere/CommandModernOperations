using System;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace Nini.Util
{
	// Token: 0x02000C07 RID: 3079
	public sealed class ArgvParser
	{
		// Token: 0x06004C56 RID: 19542 RVA: 0x002F9078 File Offset: 0x002F7278
		public ArgvParser(string args)
		{
			Regex regex = new Regex("(['\"][^\"]+['\"])\\s*|([^\\s]+)\\s*", 8);
			MatchCollection matchCollection = regex.Matches(args);
			string[] array = new string[matchCollection.Count - 1];
			for (int i = 1; i < matchCollection.Count; i++)
			{
				array[i - 1] = matchCollection[i].Value.Trim();
			}
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x000302C4 File Offset: 0x0002E4C4
		public ArgvParser(string[] args)
		{
			this.Extract(args);
		}

		// Token: 0x170003D2 RID: 978
		public string this[string param]
		{
			get
			{
				return this.parameters[param];
			}
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x002F90F4 File Offset: 0x002F72F4
		private void Extract(string[] args)
		{
			this.parameters = new StringDictionary();
			Regex regex = new Regex("^([/-]|--){1}(?<name>\\w+)([:=])?(?<value>.+)?$", 8);
			char[] trimChars = new char[]
			{
				'"',
				'\''
			};
			string text = null;
			foreach (string text2 in args)
			{
				Match match = regex.Match(text2);
				if (!match.Success)
				{
					if (text != null)
					{
						this.parameters[text] = text2.Trim(trimChars);
					}
				}
				else
				{
					text = match.Groups["name"].Value;
					this.parameters.Add(text, match.Groups["value"].Value.Trim(trimChars));
				}
			}
		}

		// Token: 0x0400302C RID: 12332
		private StringDictionary parameters;
	}
}
