using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPServer
{
    public class ListToBytes
    {
        public static byte[] ConvertListToByte(List<List<string>> nestedList)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(ms))
                    {
                        // Write the number of outer lists
                        writer.Write(nestedList.Count);
                        foreach (var innerList in nestedList)
                        {
                            // Write the number of strings in this inner list
                            writer.Write(innerList.Count);
                            foreach (var str in innerList)
                            {
                                // Write the length of the string
                                byte[] strBytes = Encoding.UTF8.GetBytes(str);
                                writer.Write(strBytes.Length);
                                // Write the string bytes
                                writer.Write(strBytes);
                            }
                        }
                    }

                    byte[] result = ms.ToArray();
                    Console.WriteLine($"Converted byte array length: {result.Length}");
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in ConvertListToByte: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return null;
            }
        }

        public static List<List<string>> ConvertByteToList(byte[] byteArray)
        {
            List<List<string>> result = new List<List<string>>();

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                using (BinaryReader reader = new BinaryReader(ms))
                {
                    int outerListCount = reader.ReadInt32();

                    for (int i = 0; i < outerListCount; i++)
                    {
                        List<string> innerList = new List<string>();
                        int innerListCount = reader.ReadInt32();

                        for (int j = 0; j < innerListCount; j++)
                        {
                            int strLength = reader.ReadInt32();
                            byte[] strBytes = reader.ReadBytes(strLength);
                            string str = Encoding.UTF8.GetString(strBytes);
                            innerList.Add(str);
                        }

                        result.Add(innerList);
                    }
                }
            }

            return result;
        }
    }
}
