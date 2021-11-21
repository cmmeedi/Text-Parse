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
using System.Collections;

namespace ProgrammingProject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating an ArrayList to hold a scalable list
                ArrayList allWords = new ArrayList();

                //Declaring a variable to store the word
                string wordly;
                string maximum;
                int maximumInt;


                ArrayList vowels = new ArrayList();




                //Declaring the StreamReader variable
                StreamReader inputFile;    
                
                //==============================================================================================
                //Asks the user to open a file
                if(openFileDialogue.ShowDialog() == DialogResult.OK)
                {
                    //Assigns the input file variable to the user selected file
                    inputFile = File.OpenText(openFileDialogue.FileName);

                    //Creates a loop printing out each line until the end of the file.
                    while (!inputFile.EndOfStream)
                    {
                        //Adds line to Placeholder "wordly" and converts them to lowercase.
                        wordly = inputFile.ReadLine().ToLower();

                        //Adds current "wordly" to "allWords" ArrayList
                        allWords.Add(wordly);

                        //Adds current "wordly" to listbox1
                        listBox1.Items.Add(wordly);
                    }

                //========================================================================================================================================

                    //This sorts the "allWords" ArrayList in alphabetical order
                    allWords.Sort();

                    //then pulls the first word
                    FirstWordLabel.Text = allWords[0].ToString();

                    //Afterwards we reverse the list
                    allWords.Reverse();

                    //and pull the first word
                    LastWord.Text = allWords[0].ToString();

                    //This loop iterates through the arraylist
                    for (int i = 0; i <= allWords.Count; i++)
                    {
                        //Creates a placeholder for the length of the iterated string
                        int length = allWords[i].ToString().Length;

                        //and a placeholder of the one being compared
                        int big = allWords[0].ToString().Length;

                        //They get plugged into this loop and get compared
                        if (length > big)
                        {
                            //The maximum placeholder gets set to the longest word
                            maximum = allWords[i].ToString();

                            //and assigned to the LongestWord label
                            LongestWord.Text = maximum;
                        }
                    }

                //==========================================================================================================================================

                    //This loop iterates through the arraylist
                    for (int i = 0; i <= allWords.Count; i++)
                    {
                        //This is variable is a placeholder for how many vowels there are in the word
                        int vowel = 0;

                        //An array list is created to hold the vowels corresponding with the same position as the word in "allWords"

                        //This for loop iterates through each letter of the current word looking for vowels
                        for ( int j = 0; j < allWords[i].ToString().Length; j++)
                        {
                            if (j.ToString().Contains('a'))
                            {
                                //if a vowel is found then the vowel variable is incremented
                                vowel++;

                                if (j.ToString().Contains('e'))
                                {
                                    vowel++;

                                    if (j.ToString().Contains('i'))
                                    {
                                        vowel++;

                                        if (j.ToString().Contains('o'))
                                        {
                                            vowel++;

                                            if (j.ToString().Contains('u'))
                                            {
                                                vowel++;

                                                //The amount of vowels is stored in a different array list with the same position as the "allWords" arraylist
                                                vowels.Add(vowel);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    //=====================================================================================================================================

                        //This for loop iterates through the vowels arrayList
                        for(int big = 0; big < vowels.Count; big++)
                        {
                            //Setting the length variable to the current selection
                            int length = (int)vowels[big];

                            //and the max variable to the 0 position
                            int max = (int)vowels[0];

                            //Then compares the two
                            if(length > max)
                            {
                                //Then we set the biggest one to the index of the "allWords" list and set that to the maximum variable
                                maximum = allWords[(int)vowels[big]].ToString();

                                //and print that to the most vowels label
                                MostVowels.Text = maximum;

                                //I'm not understanding why this won't print
                            }
                        }
                    }

                //=========================================================================================================================================

                    //Closes the File
                    inputFile.Close();

                }
                else
                {
                    //Cancel Message
                    MessageBox.Show("Operation Canceled");
                }   
            }
            catch
            {
                //Error message
                MessageBox.Show("Something went wrong");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {

            //Declaring the StreamWriter variable
            StreamWriter outputFile;

            //Asks the user to save a file
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                //Assigns the file to be saved as the output variable
                MessageBox.Show("You clicked the Save button.");
                outputFile = File.CreateText(saveFile.FileName);
            }
            else
            {
                //Cancel Message
                MessageBox.Show("you clicked the Cancel button.");
            }
        }
    }
}
