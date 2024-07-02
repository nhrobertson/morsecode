using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Translator
{
    public partial class MorseCodeTranslatorUI : Form
    {

        private Dictionary<char, string> morseCodeDict = new Dictionary<char, string>()
        {
            {'A',".-"},
            {'B', "-..."},
            {'C', "-.-."},
            {'D', "-.."},
            {'E', "."},
            {'F', "..-."},
            {'G', "--."},
            {'H', "...."},
            {'I', ".."},
            {'J', ".---"},
            {'K', "-.-" },
            {'L',".-.."},
            {'M',"--"},
            {'N',"-."},
            {'O',"---"},
            {'P',".--."},
            {'Q',"--.-"},
            {'R',".-."},
            {'S',"..."},
            {'T',"-"},
            {'U',"..-"},
            {'V',"...-"},
            {'W',".--"},
            {'X',"-..-"},
            {'Y',"-.--"},
            {'Z',"--.."},
            {'0', "-----"},
            {'1', ".----"},
            {'2', "..---"},
            {'3', "...--"},
            {'4', "....-"},
            {'5', "....."},
            {'6', "-...."},
            {'7', "--..."},
            {'8', "---.."},
            {'9', "----."},
            {' ', " /" }
        };

        private Dictionary<string, char> inverseMorseCodeDict = new Dictionary<string, char>()
        {
            {".-", 'A'}, {"-...", 'B'}, {"-.-.", 'C'}, {"-..", 'D'}, {".", 'E'},
            {"..-.", 'F'}, {"--.", 'G'}, {"....", 'H'}, {"..", 'I'}, {".---", 'J'},
            {"-.-", 'K'}, {".-..", 'L'}, {"--", 'M'}, {"-.", 'N'}, {"---", 'O'},
            {".--.", 'P'}, {"--.-", 'Q'}, {".-.", 'R'}, {"...", 'S'}, {"-", 'T'},
            {"..-", 'U'}, {"...-", 'V'}, {".--", 'W'}, {"-..-", 'X'}, {"-.--", 'Y'},
            {"--..", 'Z'}, {"-----", '0'}, {".----", '1'}, {"..---", '2'},
            {"...--", '3'}, {"....-", '4'}, {".....", '5'}, {"-....", '6'},
            {"--...", '7'}, {"---..", '8'}, {"----.", '9'}, {"/", ' '}
        };


        public MorseCodeTranslatorUI()
        {
            InitializeComponent();
        }

        private string ToMorse(string input)
        {
            string message = input.ToUpper();
            string ret = "";
            foreach (char ch in message) {
                ret += morseCodeDict[ch] + " ";
            }
            return ret.Trim();
        }

        private string ToEnglish(string input)
        {
            string[] message = input.Split(' ');
            string ret = "";
            foreach (string line in message)
            {
                if (line == "" || line == " ")
                {
                    continue;
                }
                ret += inverseMorseCodeDict[line];
            }
            return ret.Trim();
        }

        private void toMorseBtn_Click(object sender, EventArgs e)
        {
            string englishText = englishTextBox.Text;
            morseTextBox.Text = ToMorse(englishText);
        }

        private void toEnglishBtn_Click(object sender, EventArgs e)
        {
            string morseText = morseTextBox.Text;
            englishTextBox.Text = ToEnglish(morseText);
        }

        private void MorseCodeTranslatorUI_Load(object sender, EventArgs e)
        {

        }
    }
}
