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
        public static byte[] pretvoriListToByte(List<List<string>> nestedList)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (BinaryWriter writer = new BinaryWriter(ms))
                    {
                        //Zapisuje broj lista koje sadrže podatke o specifičnom projektu
                        writer.Write(nestedList.Count);
                        foreach (var vanjskaLista in nestedList)
                        {
                            // Zapisuje broj polja stupaca tj. podataka o projektu u bazi
                            writer.Write(vanjskaLista.Count);
                            foreach (var str in vanjskaLista)
                            {
                                // Zapisuje duljine svakog podatka određenog stupca
                                byte[] strBytes = Encoding.UTF8.GetBytes(str);
                                writer.Write(strBytes.Length);
                                // Zapisuje string u bajtove
                                writer.Write(strBytes);
                            }
                        }
                    }

                    byte[] result = ms.ToArray();
                    Console.WriteLine($"Broj konvertiranih bajtovu: {result.Length}");
                    return result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Iznimka u pretvoriListToByte: {ex.Message}");
                Console.WriteLine($"Stack Trace: {ex.StackTrace}");
                return null;
            }
        }

        public static List<List<string>> pretvoriByteToList(byte[] byteArray)
        {
            List<List<string>> result = new List<List<string>>();

            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                using (BinaryReader reader = new BinaryReader(ms))
                {
                    int vanjskaListaCount = reader.ReadInt32();
                    //Čita broj lista koje sadrže podatke o specifičnom projektu
                    for (int i = 0; i < vanjskaListaCount; i++)
                    {
                        // Čita broj polja stupaca tj. podataka o projektu u bazi
                        List<string> unutarnjaLista = new List<string>();
                        int unutarnjaListaCount = reader.ReadInt32();

                        for (int j = 0; j < unutarnjaListaCount; j++)
                        {
                            // Čita duljine svakog podatka određenog stupca
                            int strLength = reader.ReadInt32();
                            byte[] strBytes = reader.ReadBytes(strLength);
                            string str = Encoding.UTF8.GetString(strBytes);
                            unutarnjaLista.Add(str);
                        }
                        //Sprema podatke u listu
                        result.Add(unutarnjaLista);
                    }
                }
            }

            return result;
        }
    }
}
