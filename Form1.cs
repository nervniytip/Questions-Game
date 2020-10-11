using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questions_Game
{ 
    public partial class Form1 : Form
    {
        string[] arrayAnswer = new string[4];
        QuestionModel questionModel;
        ListQuestions listQuestions = new ListQuestions();
        private Button[] buttons = new Button[4];
        

        public Form1()
        {                 
            InitializeComponent();
        }

        void SetButtonArray()
        {
            buttons[0] = button1;
            buttons[1] = button2;
            buttons[2] = button3;
            buttons[3] = button4;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (Button b in buttons) b.BackColor = Color.Gainsboro;
            SetShowQuestions();
        }

        void SetRedColor(Button button)
        {
            foreach (Button b in buttons)
            {
                if (b.Text == questionModel.Correct_answer)
                    b.BackColor = Color.DarkGreen;
            }
            button.BackColor = Color.Red;
        } 
        
        void TrueAnswer(object sender)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DarkGreen;
            timer1.Enabled = true;
            timer1.Start();
            listQuestions.Remove(questionModel);
            listQuestions.Save();
        }
        void FalseAnswer(object sender)
        {
            Button button = (Button)sender;
            SetRedColor(button);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void HideStartButtons() // удаление начальных кнопок 
        {
            button_NewGame.Visible = false;
            button_Continue.Dispose();
        }

        private void SetShowQuestions() // вывод вопроса и ответов на элементы
        {
            //// проверку на пустой лист и нул
            questionModel = listQuestions.GetQuestionOrNull(); // вынести в другой метод !!
            if (questionModel != null)
            {
                label_Question.Text = questionModel.Question;
                arrayAnswer = listQuestions.AnswerArray(questionModel);
                button4.Text = arrayAnswer[0];
                button3.Text = arrayAnswer[1];
                button2.Text = arrayAnswer[2];
                button1.Text = arrayAnswer[3];
                this.panel_Questions.Visible = true;
            }
            else
            {
                button_NewGame.Visible = true;
                panel_Questions.Visible = false;
                MessageBox.Show("К сожалению все вопросы закончились!");
            }
        }

        //______________________Начадьные Кнопки______________________________//
        private void Button_NewGame_Click(object sender, EventArgs e)
        {
            SetButtonArray();
            try
            {
                listQuestions.Load();
                HideStartButtons();
                SetShowQuestions();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Button_Continue_Click(object sender, EventArgs e)
        {
            SetButtonArray();
            try
            {
                listQuestions.LoadSave();
                if (listQuestions.Count != 0)
                {
                    HideStartButtons();
                    SetShowQuestions();
                }
                else { MessageBox.Show("К сожалению все вопросы закончились!"); }
            }
            catch (FileNotFoundException ex) { MessageBox.Show($"Отсутствует файл \n" + ex.Message); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //_______________Обработчик Кнопок Ответов_____________________////

        private void button_Click(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == questionModel.Correct_answer)
            {
                TrueAnswer(sender);
            }
            else
            {
                FalseAnswer(sender);
            }
        }    
    }
}
