using System.Collections;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Encrypt_Me.model {
    internal class ResultModel
    {
        string textToEncrypt; 

        string[] UTF8;
        string UTF8InString;

        byte[] UTF8InBytes;
        string UTF8InBytesString;

        byte[] hashedInBytes;
        string hashedInBytesString;
        string hashedInHexaDecimalString;
        string result;


        string binaryBeforeHashString;
        string binaryAfterHashString;
        string totalBit;

        public ResultModel(string textToEncrypt)
        {
            this.textToEncrypt =  textToEncrypt; 
        }

        public void setUTF8(string utf8)
        { 
            this.UTF8InString = utf8;
        }

        public void setBinaryBeforeHashString(string txt)
        {
            String res = "";
            foreach (char character in txt)
            {
                int decimalValue = (int)character;
                string binaryValue = Convert.ToString(decimalValue, 2).PadLeft(8, '0');
                res += binaryValue+ "  ";
            }
            this.binaryBeforeHashString = res;
        }

        public void setBinaryAfterHashString(byte[] txt)
        {
            string binaryString = string.Join(" ", txt.Select(b => Convert.ToString(b, 2).PadLeft(8, '0')));
            this.binaryAfterHashString = binaryString;
        }
        public void setTotalBit(string txt)
        {
            byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(txt);
            int totalBits = byteArray.Length * 8;
            this.totalBit = totalBits.ToString();

        }

        public void setUTF8InBytes(byte[] utf8InBytes)
        {
            this.UTF8InBytes = utf8InBytes;
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < utf8InBytes.Length; i++)
            {
                builder.Append(utf8InBytes[i].ToString()).Append("  ");
            }
            this.UTF8InBytesString = builder.ToString();
        }

        public void setEncrypted256Data(byte[] raw)
        {
            this.hashedInBytes = raw;

            // hashed in bytes
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < raw.Length; i++)
            {
                builder.Append(raw[i].ToString()).Append("  ");
            }
            this.hashedInBytesString = builder.ToString();

            // hashed in hexadecimal
            StringBuilder builder2 = new StringBuilder();
            StringBuilder builder3 = new StringBuilder();
            for (int i = 0; i < raw.Length; i++)
            { 
                builder2.Append(raw[i].ToString("x2"));
                builder3.Append(raw[i].ToString("x2")).Append("   ");
            }
            this.hashedInHexaDecimalString = builder3.ToString();
            this.result = builder2.ToString();
        }

        public string getText()
        {
            return textToEncrypt;
        } 

        public string getUTF8()
        {
            return this.UTF8InString;
        }
        public string getUTF8Bytes()
        {
            return this.UTF8InBytesString;
        }
        public string getHashedString()
        {
            return this.hashedInHexaDecimalString;
        }
        public string getHashedInBytes()
        {
            return this.hashedInBytesString;
        }
        public string getResult()
        {
            return this.result;
        }

        public string getBinaryBeforeHash()
        {
            return this.binaryBeforeHashString;
        }

        public string getBinaryAfterHash()
        {
            return this.binaryAfterHashString;
        }

        public string getTotalBit()
        {
            return this.totalBit;
        }

    }
}
