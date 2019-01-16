  public string Disassemble(string sentence)

        {

            uint block, initial, neutral, final;

            string[] spStr = Regex.Split(sentence, "\n");

            string result="";




            foreach(string str in spStr)

            {

                foreach (char character in str)

                {

                    block = Convert.ToUInt32(character) - 0xAC00;

                    initial = block / 588; neutral = (block % 588) / 28; final = (block % 588) % 28;

                    initial += 0x1100; neutral += 0x1161; final += 0x11a7;




                    string init = "\\u" + Convert.ToInt32(initial).ToString("X");

                    string neut = "\\u" + Convert.ToInt32(neutral).ToString("X");

                    string fin = "\\u" + Convert.ToInt32(final).ToString("X");




                    result += init + neut + fin;

                }

                result += "\r\n";

            }

            return result;

        }
