using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PA4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
        }

        private void InitializeListBox()
        {
            String[] word_list = Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            wordList.BeginUpdate();
            wordList.Items.Clear();
            foreach (string s in word_list)
                wordList.Items.Add(s);
            wordList.EndUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void wordList_Click(object sender, EventArgs e)
        {
            textBox.Text = wordList.Text;
        }

        private void rhymeBtn_Click(object sender, EventArgs e)
        {
            InitializeListBox();
            string endString = textBox.Text;
            int numRhyming = 0;
            string tempWord;
            List<string> rhymingWords = new List<string>();

            // while loop with nested if statement will evaluate the ending letters of the inputted string
            foreach(string word in wordList.Items)
            {
                tempWord = word;
                if (tempWord.EndsWith(endString) == true)
                {
                    rhymingWords.Add(word);
                    numRhyming++;
                }
            }
            if (numRhyming != 0)
            {
                wordList.BeginUpdate();
                wordList.Items.Clear();
                foreach (string rhymingWord in rhymingWords)
                {
                    wordList.Items.Add(rhymingWord);
                }
                wordList.EndUpdate();
            }
            else if (numRhyming == 0)
                MessageBox.Show("No words rhyme with that ending string.");
        }

        private void morphBtn_Click(object sender, EventArgs e)
        {
            InitializeListBox();
            string morphWord = textBox.Text;
            string tempWord;
            int j, numMatches, numMorphWords = 0;
            List<string> morphWords = new List<string>();

            // Parses the entire list of words
            foreach(string word in wordList.Items)
            {
                numMatches = 0;
                tempWord = word;

                // For loop compares if current word is one letter different from user inputted word
                for (j = 0; j < tempWord.Length; j++)
                {
                    if (tempWord.Length != morphWord.Length)
                        break;
                    else if (tempWord[j] == morphWord[j])
                        numMatches++;
                }

                if (numMatches == ((morphWord.Length) - 1))
                {
                    morphWords.Add(tempWord);
                    numMorphWords++;
                }
            }
            if (numMorphWords != 0)
            {
                wordList.BeginUpdate();
                wordList.Items.Clear();
                foreach(string word in morphWords)
                {
                    wordList.Items.Add(word);
                }
                wordList.EndUpdate();
            }
            else if (numMorphWords == 0)
                MessageBox.Show("There are no morph words associated with that word. ");
        }

        private void scrabbleBtn_Click(object sender, EventArgs e)
        {
            InitializeListBox();
            string scrabbleLetters, tempWord, tempScrabble;
            char[] replace;
            int j = 0,
                k = 0,
                numMatches = 0,
                numScrabbleWords = 0;
            List<string> scrabbleWords = new List<string>();

            scrabbleLetters = textBox.Text;
            if (scrabbleLetters.Length < 3 || scrabbleLetters.Length > 7)
            {
                MessageBox.Show("The number of letters must be between 3 and 7. Please try again. ");
                return;
            }


            // Parses the entire list of words
            foreach(string word in wordList.Items)
            {
                numMatches = 0;
                tempWord = word;
                tempScrabble = scrabbleLetters;

                // Compares if the current words can be made from the user inputted letters
                for (j = 0; j < tempWord.Length; j++)
                {
                    for (k = 0; k < tempScrabble.Length; k++)
                    {
                        if (tempWord[j] == tempScrabble[k])
                        {
                            replace = tempScrabble.ToCharArray();
                            replace[k] = ' ';
                            tempScrabble = new string(replace);
                            numMatches++;
                            break;
                        }
                    }
                }
                if ((numMatches == tempWord.Length) && (numMatches > 2))
                {
                    scrabbleWords.Add(tempWord);
                    numScrabbleWords++;
                }
            }
            if (numScrabbleWords != 0)
            {
                wordList.BeginUpdate();
                wordList.Items.Clear();
                foreach(string word in scrabbleWords)
                {
                    wordList.Items.Add(word);
                }
                wordList.EndUpdate();
            }
            else if (numScrabbleWords == 0)
                MessageBox.Show("There are no words that can be made from those letters. ");
        }

        private void refillList_Click(object sender, EventArgs e)
        {
            String[] word_list = Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            wordList.BeginUpdate();
            wordList.Items.Clear();
            foreach (string s in word_list)
                wordList.Items.Add(s);
            wordList.EndUpdate();
        }
    }
}
