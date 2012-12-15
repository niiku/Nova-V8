using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaV8
{
    public static class TypeExtensions
    {
        private static List<byte[]> tokens = new List<byte[]>() 
    {
        new byte[] {0xb7, 0x7a, 0x5c, 0x56, 0x19, 0x34, 0xe0, 0x89},
        new byte[] {0x31, 0xbf, 0x38, 0x56, 0xad, 0x36, 0x4e, 0x35},
        new byte[] {0xb0, 0x3f, 0x5f, 0x7f, 0x11, 0xd5, 0x0a, 0x3a}
    };

        public static bool IsFrameworkType(this Type type)
        {
            if (type == null) { throw new ArgumentNullException("type"); }

            byte[] publicKeyToken = type.Assembly.GetName().GetPublicKeyToken();

            return publicKeyToken != null && publicKeyToken.Length == 8
               && tokens.Contains(publicKeyToken, new ByteArrayEqualityComparer());
        }
    }
}
