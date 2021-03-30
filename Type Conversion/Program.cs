using System;

namespace Type_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // one byte
            // byte b = 1;
            // 4 bytes
            // int i = b;
            // Console.WriteLine(i);

            // chance for data loss because byte only goes up to 255
            // int i = 1000;
            // byte b = (byte)i;
            // Console.WriteLine(b);

            //try
            //{
            //    var number = "1234";
            //    int i = Convert.ToByte(number);
            //    Console.WriteLine(i);
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte.");
            //}

            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
