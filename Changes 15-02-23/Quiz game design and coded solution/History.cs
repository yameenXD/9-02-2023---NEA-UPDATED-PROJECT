﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Quiz_game_design_and_coded_solution
{
    public partial class History : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int optionnumber = 0;
        int score;
        int percentage;
        int totalQuestions;
        DateTime startTime = DateTime.Now;
        int[] goArray;
        static string FilePath = @"D:\NEA TECHNICAL SOLUTION\9-02-2023---NEA-UPDATED-PROJECT-main\Quiz game design and coded solution\bin\Debug\h.txt";
        List<string> questions;


        public History()
        {
            InitializeComponent();
            question_reading();
            askQuestion(0, 9); // Started at 1 should start at 0.
            totalQuestions = 10;
            timer1.Start();
        }

        public void question_reading()
        {
            FilePath = System.Environment.CurrentDirectory + "\\h.txt";
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
            optionnumber = 5;
            questionNumber += 1;
            askQuestion(questionNumber, optionnumber);


           
        }

        private void askQuestion(int qnum, int optionnumber)
        {

            pictureBox1.Image = Properties.Resources.images;
            

            try
            {
                label1.Text = questions[(qnum - 1) * (optionnumber + 1)]; // the question asked to the user
                string[] options = new string[] { questions[(qnum - 1) * (optionnumber + 1) + 1], questions[(qnum - 1) * (optionnumber + 1) + 2], questions[(qnum - 1) * (optionnumber + 1) + 3], questions[(qnum - 1) * (optionnumber + 1) + 4] };
                button1.Text = options[0];
                button2.Text = options[1];
                button3.Text = options[2];
                button4.Text = options[3];
                correctAnswer = Convert.ToInt32(questions[(qnum - 1) * (optionnumber + 1) + 5]);

                correctAnswer = Convert.ToInt32(questions[(qnum * 6) + 5]); // the correct is 5 passed the question

                if (questionNumber == 10)
                {
                    timer1.Stop();
                    percentage = (int)Math.Round((double)(score * 100) / totalQuestions);
                    MessageBox.Show("Quiz Ended!" + Environment.NewLine + "You have answered " + score + "questions correctly" + Environment.NewLine +
                        "Your total percentage is" + percentage + "%" + Environment.NewLine +
                        "Click OK to play again");
                    score = 0;
                    questionNumber = 0; // this will reset the questionnumber to 0
                    DateTime time = DateTime.Now;
                    string User = lblUserName.Text;
                    string SQL_2 = "INSERT INTO tblUserScores (UserName, TestDate, Score) VALUES ('" + User + "','" + time + "','" + percentage + "');";
                    DBCon.AmendAddInsertData_2(SQL_2);
                }
            }
            catch(Exception ex) 
            { 
                MessageBox.Show(ex.Message);
            }
          

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void lblName_Click(object sender, EventArgs e)
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
            //  Change by GMK // lbltimer.Text = DateTime.Now.ToString("HH:mm:ss");
        }

      
        private void History_Load_1(object sender, EventArgs e)
        {
            lblUserName.Text = System.Environment.UserName;
        }
    }
}