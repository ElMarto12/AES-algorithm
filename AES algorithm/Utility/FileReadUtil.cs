using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AES_algorithm.Utility
{
    public class FileReadUtil
    {
        public void saveToFile(string text) {

            // Saves result to file << Result.txt >>

            StreamWriter sw = new StreamWriter(@"C:\Programų sistemos 21\antras kursas\antras semestras\informacijos saugumas\AES algorithm\AES algorithm\Result.txt");
            sw.Write(text);

            sw.Close();
            
        }

        public string loadFromFile() {

            //Reads file content and returns as string 

            Stream st;
            string str = "";

            OpenFileDialog opDiag = new OpenFileDialog();
            if(opDiag.ShowDialog() == DialogResult.OK)
            {
               if((st = opDiag.OpenFile()) != null)
                {
                    string file = opDiag.FileName;
                    str = File.ReadAllText(file);

                    st.Close();

                }
            }

            return str;
        }
    }
}
