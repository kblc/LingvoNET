using System.Text;

namespace LingvoNET
{
    internal static class StreamEncodings
    {
        static StreamEncodings()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public static Encoding GetEncoding()
        {
            return Encoding.GetEncoding(1251);
        }
    }
}
