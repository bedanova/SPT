using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{    
        static class PrevodyCisel
        {

        public static string Binary(uint VstupBin)
            {
                uint vstupBin = Convert.ToUInt32(VstupBin);
                uint zbytekBin = 0;

                List<uint> bin = new List<uint>();
                while (vstupBin > 0)
                {
                    zbytekBin = vstupBin % 2;
                    bin.Add(zbytekBin);
                    vstupBin /= 2;
                }
                uint[] pole_List_Bin = bin.ToArray();
                uint[] pole_Bin_mirror = new uint[pole_List_Bin.Length];
                for (int i = 0, j = pole_List_Bin.Length - 1; i < pole_List_Bin.Length; i++, j--)
                {
                    pole_Bin_mirror[j] = pole_List_Bin[i];
                }
                string output = string.Join("", pole_Bin_mirror);
                return output;

            }
            public static string Hex(uint VstupHex)
            {
                uint vstupHex = Convert.ToUInt32(VstupHex); ;
                uint zbytekHex = 0;

                List<uint> hex = new List<uint>();
                while (vstupHex > 0)
                    {
                        zbytekHex = vstupHex % 6;
                        hex.Add(zbytekHex);
                        vstupHex /= 6;
                    }
                uint[] pole_List_Hex = hex.ToArray();
                uint[] pole_Hex_mirror = new uint[pole_List_Hex.Length];
                for (int i = 0, j = pole_List_Hex.Length - 1; i < pole_List_Hex.Length; i++, j--)
                    {
                        pole_Hex_mirror[j] = pole_List_Hex[i];
                    }
                string outputHex = string.Join("", pole_Hex_mirror);
                return outputHex;
                
            }
            public static string Okta(uint VstupOkta)
            {
                uint vstupOkta = Convert.ToUInt32(VstupOkta);
                uint zbytekOkta = 0;

                List<uint> osm = new List<uint>();
                while (vstupOkta > 0)
                    {
                        zbytekOkta = vstupOkta % 8;
                        osm.Add(zbytekOkta);
                        vstupOkta /= 8;
                    }
                uint[] pole_List_Osm = osm.ToArray();
                uint[] pole_Osm_mirror = new uint[pole_List_Osm.Length];
                for (int i = 0, j = pole_List_Osm.Length - 1; i < pole_List_Osm.Length; i++, j--)
                    {
                        pole_Osm_mirror[j] = pole_List_Osm[i];
                    }
                string outputHex = string.Join("", pole_Osm_mirror);
                return outputHex;

            }
            public static string HexDec(uint VstupHexDec)
            {
                uint vstupHexDec = Convert.ToUInt32(VstupHexDec);
                uint zbytekHexDec = 0;

                List<char> hexdec = new List<char>();
                while (vstupHexDec > 0)
                    {
                        zbytekHexDec = vstupHexDec % 16;

                        if (zbytekHexDec == 0) zbytekHexDec = (char)'0';
                        if (zbytekHexDec == 1) zbytekHexDec = (char)'1';
                        if (zbytekHexDec == 2) zbytekHexDec = (char)'2';
                        if (zbytekHexDec == 3) zbytekHexDec = (char)'3';
                        if (zbytekHexDec == 4) zbytekHexDec = (char)'4';
                        if (zbytekHexDec == 5) zbytekHexDec = (char)'5';
                        if (zbytekHexDec == 6) zbytekHexDec = (char)'6';
                        if (zbytekHexDec == 7) zbytekHexDec = (char)'7';
                        if (zbytekHexDec == 8) zbytekHexDec = (char)'8';
                        if (zbytekHexDec == 9) zbytekHexDec = (char)'9';
                        if (zbytekHexDec == 10) zbytekHexDec = (char)'A';
                        if (zbytekHexDec == 11) zbytekHexDec = (char)'B';
                        if (zbytekHexDec == 12) zbytekHexDec = (char)'C';
                        if (zbytekHexDec == 13) zbytekHexDec = (char)'D';
                        if (zbytekHexDec == 14) zbytekHexDec = (char)'E';
                        if (zbytekHexDec == 15) zbytekHexDec = (char)'F';

                        hexdec.Add((char)zbytekHexDec);
                        vstupHexDec /= 16;
                    }
                char[] pole_List_HexDec = hexdec.ToArray();
                char[] pole_HexDec_mirror = new char[pole_List_HexDec.Length];
                for (int i = 0, j = pole_List_HexDec.Length - 1; i < pole_List_HexDec.Length; i++, j--)
                    {
                        pole_HexDec_mirror[j] = pole_List_HexDec[i];
                    }

                string outputHex = string.Join("", pole_HexDec_mirror);
                return outputHex;
        }
    }
    }
