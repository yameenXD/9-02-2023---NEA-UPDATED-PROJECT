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

namespace Quiz_game_design_and_coded_solution
{
    public partial class Food_and_Drink : Form
    {
        int correctAnswer;
        int questionNumber = 0;
        int optionnumber = 5;
        int score = 0;
        int percentage;
        int totalQuestions;
        int[] goArray;
        DateTime startTime = DateTime.Now;
        static string FilePath = @"P:\6th Form Computing\16MunirY\NEA 16-02-2023 UPDATED\9-02-2023---NEA-UPDATED-PROJECT-main\Changes 15-02-23\Quiz game design and coded solution\bin\Debug\fad.txt";
        List<string> questions;
        static string subject = "Food and Drink";

        
        public Food_and_Drink()
        {
            
            question_reading();
            InitializeComponent();
            askQuestion(0, 9);
            totalQuestions = 10;
            timer1.Start();
        }

        public void question_reading()
        {
            FilePath = System.Environment.CurrentDirectory + "\\fad.txt";
            int count = 0;
            string data;
            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            questions = new List<string>();

            while (count < 60)
            {
                data = streamReader.ReadLine();
                questions.Add(data);
                count++;
            }

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;


            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (buttonTag == correctAnswer)
            {
                score = score + 1;
                label2.Text = "Score: " + Convert.ToString(score);

            }
            optionnumber = 6;
            questionNumber += 1;
            askQuestion(questionNumber, optionnumber);

            
        }

        public void askQuestion(int qnum, int optionnumber)
        {
            qnum = questionNumber; // sets qnum to become questionNumber

            //Set the image to be displayed
            pictureBox1.Image = Properties.Resources.images;
            try
            {
                //This will display the question and answer options to the user
                label1.Text = questions[(questionNumber) * (optionnumber)]; // the question asked to the user
                string[] options = new string[] { questions[(questionNumber) * (optionnumber) + 1], questions[(questionNumber) * (optionnumber) + 2], questions[(questionNumber) * (optionnumber) + 3], questions[(questionNumber) * (optionnumber) + 4] };
                button1.Text = options[0];
                button2.Text = options[1];
                button3.Text = options[2];
                button4.Text = options[3];
                //This will store the correct answer and question options
                correctAnswer = Convert.ToInt32(questions[(questionNumber) * (optionnumber) + 5]);
                // This will stop the timer and display the user's score
                if (questionNumber == 9)
                {

                    timer1.Stop();

                    percentage = (int)Math.Round((double)(score * 100)) / totalQuestions;

                    MessageBox.Show("Quiz Ended!" + Environment.NewLine + "You have answered " + score + " questions correctly" + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again");
                    score = 0;
                    questionNumber = 0;

                    DateTime time = DateTime.Now;
                    string user = lblUserName.Text;
                    string subject = "Food and Drink";
                    string SQL_2 = "INSERT INTO tblUserScores (UserName, TestDate, Score, Subject) VALUES ('" + user + "','" + time + "'," + percentage + ",'" + subject + "');";
                    DBCon.AmendAddInsertData_2(SQL_2);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void label2_Click(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer) // selection. If the selected answer is equal to the correct answer the score will be incremented by one.
            {
                score = score + 1; // score will be incremented by one

                score = 0;
                int goscore = goArray[0];

                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime nowDateTime = DateTime.Now;
            var currentTime = Math.Abs(startTime.Second - nowDateTime.Second);
            lbltimer.Text = currentTime.ToString();
        }
        private void Food_and_Drink_Load(object sender, EventArgs e)
        {
            lblUserName.Text = System.Environment.UserName;
        }
    }
  
}

      