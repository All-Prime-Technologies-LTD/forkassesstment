using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAssessment2.Services
{
    public class CorrectionService : ICorrectionService
    {
        public int MyAtoi(string str)
        {
            char[] sepatrator = { ' ' };
            string[] words = str.Split(sepatrator);
            int length = str.Length;
            Dictionary<int, string> result = new Dictionary<int, string>();

            for (int i = 0; i < length; i++)
            {
                //if(string.IsNullOrEmpty(str[i].ToString()))
                //    continue;
                string valu = str[i].ToString().Trim();
                if (valu == "0" && i == 0)
                    return 0;

                if (valu == "-")
                {
                    result.Add(i, valu);
                }
                else if (valu == "+")
                {
                    result.Add(i, valu);
                }
                else if (Char.IsDigit(str, i))
                {
                    if (valu != "0")
                        result.Add(i, valu);
                }
                else
                {
                    if (valu == "")
                        continue;
                    else
                        break;
                }
            }

            string ans = null;
            foreach (var items in result)
            {
                ans += items.Value;
            }

            if (ans == null)
            {
                return 0;
            }
            else if (ans == "-")
            {
                return 0;
            }
            else if (ans == "+")
            {
                return 0;
            }
            else if (ans.Contains("-") && ans.Contains("+"))
                return 0;

            int ret = 0;
            int num = Int32.MinValue;
            if (!(int.TryParse(ans, out num)))
            {
                if (ans.Contains("-"))
                    ret = -2147483648;
                else
                    ret = Math.Clamp(Int32.MaxValue, 0, Int32.MaxValue);
            }
            else
                ret = Convert.ToInt32(ans);
            return ret;
        }

        //Coding is my career and I wish to be consider. Thanks
    }
}
