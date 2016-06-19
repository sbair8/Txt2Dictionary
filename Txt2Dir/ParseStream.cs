using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Txt2Dir
{
    internal class ParseStream
    {
        private HashSet<string> _words; 

        public void ParseFile(string srcFileName, string output)
        {
            LoadFile(srcFileName);
            SaveFile(output);
        }

        private void SaveFile(string output)
        {
            StreamWriter sw = new StreamWriter(output);

            sw.WriteLine(string.Join(",",_words.ToList()));
            sw.Flush();
            sw.Dispose();
        }

        private static readonly char[] Spliting = new char[] {' ','.',',',':','\n','\r',';','[',']'};

        private void LoadFile(string srcFileName)
        {
            if (_words==null)
                _words = new HashSet<string>();
            else
                _words.Clear();
            
            using (MemoryMappedFile mappedFile1 = MemoryMappedFile.CreateFromFile(srcFileName))
            {
                using (Stream mmStream = mappedFile1.CreateViewStream())
                {
                    using (StreamReader sr = new StreamReader(mmStream, Encoding.ASCII))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line == null) 
                                break;

                            string[] lineWords = line.Split(Spliting);
                            foreach (var word in lineWords)
                            {
                                string trimmedWord = word.Trim();
                                if (string.IsNullOrEmpty(trimmedWord))
                                    continue;

                                if (_words.Contains(trimmedWord) == false)
                                    _words.Add(trimmedWord);
                            }
                        }
                    }  
                }
            }
        }

        
    }
}
