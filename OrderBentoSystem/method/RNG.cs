using System;
using System.Security.Cryptography;

/// <summary>
/// https://blog.miniasp.com/post/2008/05/13/Random-vs-RNGCryptoServiceProvider
/// </summary>
namespace OrderBentoSystem.method
{
    /*主程式
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        char[] chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int length = RNG.Next(8, 8);
        for (int i = 0; i<length; i++)
        {
            sb.Append(chars[RNG.Next(chars.Length - 1)]);
        }
        string YourPassword = sb.ToString();
    */

    public static class RNG
    {
        private static RNGCryptoServiceProvider rngp = new RNGCryptoServiceProvider();
        private static byte[] rb = new byte[4];

        /// <summary>
        /// 產生一個非負數的亂數
        /// </summary>
        public static int Next()
        {
            rngp.GetBytes(rb);
            int value = BitConverter.ToInt32(rb, 0);
            if (value < 0) value = -value;
            return value;
        }
        /// <summary>
        /// 產生一個非負數且最大值 max 以下的亂數
        /// </summary>
        /// <param name="max">最大值</param>
        public static int Next(int max)
        {
            rngp.GetBytes(rb);
            int value = BitConverter.ToInt32(rb, 0);
            value = value % (max + 1);
            if (value < 0) value = -value;
            return value;
        }
        /// <summary>
        /// 產生一個非負數且最小值在 min 以上最大值在 max 以下的亂數
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        public static int Next(int min, int max)
        {
            int value = Next(max - min) + min;
            return value;
        }
    }
}
