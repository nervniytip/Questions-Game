using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Questions_Game
{
    //[DataContract]
    class ListQuestions //: IList<Questions>
    {
        //[DataMember]
        private List<QuestionModel> listQuestions;
        readonly ISerializer serializer = new JsonSerializer();
        public ListQuestions()
        {
            listQuestions = new List<QuestionModel>();
        }
        public int Count { get => listQuestions.Count; }
        public Int32 Countt()
        {
            return listQuestions.Count;
        }

        public QuestionModel GetQuestionOrNull()
        {
            // проверку на пустой лист и нул
            Random rnd = new Random();
            int count = this.listQuestions.Count;
            if (count != 0)
            {
                int rabdom_index = rnd.Next(count);
                return this.listQuestions[rabdom_index];
            }
            return null;
        }

        public string[] AnswerArray(QuestionModel question)
        {
            string[] temp = new string[4];
            temp[0] = question.Answer1;
            temp[1] = question.Answer2;
            temp[2] = question.Answer3;
            temp[3] = question.Correct_answer;
            temp.Shufel();
            return temp;
        }

        public bool Remove(QuestionModel question)
        {
            return this.listQuestions.Remove(question);
        }

        public void Save()
        {
            serializer.Save(listQuestions);
        }

        public void Load()
        {
            this.listQuestions = serializer.Load();
        }

        public void LoadSave()
        {
            this.listQuestions = serializer.LoadSave();
        }


        
    }
}
