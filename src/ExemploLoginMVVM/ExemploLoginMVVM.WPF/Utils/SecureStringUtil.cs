using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ExemploLoginMVVM.WPF.Utils
{
    public static class SecureStringUtil
    {
        public static string SecureStringToString(SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = Marshal.SecureStringToGlobalAllocUnicode(value);
                return Marshal.PtrToStringUni(valuePtr);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);
            }
        }
    }
}
