using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniEncryptionNotepad
{
    public class EncryClass
    { 
        private int[] myKeyList = new int[0];
        public string setKeyList
        {
            get { return "U can't read the password"; }
            set {
                char[] charList = value.ToCharArray();
                myKeyList = new int[charList.Length];

                for (int i = 0; i < charList.Length; i++)
                {
                    myKeyList[i] = Convert.ToInt32(charList[i]);
                }
            }
        }
        Random rdm = new Random();
        public string Randomkey()
        {
            //random key's length is 49 to 1024
            int keyLength = rdm.Next(49, 1024);
            int[] _intLists = new int[keyLength];
            for(int i=0;i<_intLists.Length;i++)
            {
                _intLists[i] = rdm.Next(33, 126); 
            }
            myKeyList = _intLists;
            string _str = intsList_StringList(_intLists);
            return _str;
        }
        public  int[]  encodeList = new int[0];
        public string encodeListNumStr = "";

        public string encode(string _str)
        { 
            if (myKeyList.Length == 0)
                return _str;

            char[] ch = _str.ToCharArray();
            
            encodeList = new int[ch.Length];

            for (int i = 0; i < ch.Length; i++)
            {
                encodeList[i] = Convert.ToInt32(ch[i]);
            }
            StringBuilder sb = new StringBuilder();
            StringBuilder sbNumStr = new StringBuilder();
            string filter="\\";
            for (int i = 0; i < encodeList.Length; i++)
            {
                encodeList[i] = encodeList[i] ^ myKeyList[i % myKeyList.Length];
                sb.Append(Convert.ToChar(encodeList[i]));
                sbNumStr.Append(filter);
                sbNumStr.Append(encodeList[i]);
            }
            encodeListNumStr = sbNumStr.ToString();
            return sb.ToString();
        }
        public string deCode(string _str)
        {
            if (myKeyList.Length == 0)
                return _str;


            char[] ch = _str.ToCharArray();
            int[] ints = new int[ch.Length];

            for (int i = 0; i < ch.Length; i++)
            {
                ints[i] = Convert.ToInt32(ch[i]);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = ints[i] ^ myKeyList[i % myKeyList.Length]; 
                sb.Append(Convert.ToChar(ints[i]));
            }
            return sb.ToString();
        }

        public string intsList_StringList(int[] intsList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < intsList.Length; i++)
            {
                sb.Append(Convert.ToChar(intsList[i]));
            }
            return sb.ToString();
        }
        public static string intsList_StringIntsList(int[] intsList)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < intsList.Length; i++)
            {
                sb.Append("\\");
                sb.Append(intsList[i]);
            }
            return sb.ToString();
        }
        //public static string StringIntsList_intsList(int[] intsList)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i < intsList.Length; i++)
        //    {
        //        sb.Append("\\");
        //        sb.Append(intsList[i]);
        //    }
        //    return sb.ToString();
        //}
        public int[] StringList_IntsList(string str)
        {
            char[] _charList = str.ToCharArray();

            int[] _intsList = new int[_charList.Length];

            for (int i = 0; i < _charList.Length; i++)
            {
                _intsList[i] = Convert.ToInt32(_charList[i]);
            }
            return _intsList;
        }
        public char[] DecodeString_CharList(string str)
        {
            string[] __str = str.Split('\\');
            char[] _charList = new char[__str.Length];

            return _charList;
        }
        public int[] DecodeString_IntsList(string str)
        { 
            char[] _charList = DecodeString_CharList(str);


            int[] _intsList = new int[_charList.Length];

            for (int i = 0; i < _charList.Length; i++)
            {
                _intsList[i] = Convert.ToInt32(_charList[i]);
            }
            return _intsList;
        }
 

    }
}
