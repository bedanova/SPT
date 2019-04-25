using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{    
        static class PrevodyCisel
        {

            public static string Binary(ulong VstupBin)
            {
                ulong vstupBin = Convert.ToUInt64(VstupBin);
                ulong zbytekBin = 0;

                List<ulong> bin = new List<ulong>();
                while (vstupBin > 0)
                {
                    zbytekBin = vstupBin % 2;
                    bin.Add(zbytekBin);
                    vstupBin /= 2;
                }
                ulong[] pole_List_Bin = bin.ToArray();
                ulong[] pole_Bin_mirror = new ulong[pole_List_Bin.Length];
                for (int i = 0, j = pole_List_Bin.Length - 1; i < pole_List_Bin.Length; i++, j--)
                {
                    pole_Bin_mirror[j] = pole_List_Bin[i];
                }
                string output = string.Join("", pole_Bin_mirror);
                return output;

            }
        }
    }
