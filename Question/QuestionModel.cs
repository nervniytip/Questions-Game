using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Questions_Game
{
    [DataContract]
    class QuestionModel
    {
        [DataMember]
        public string Question { get; set; }
        [DataMember]
        public string Answer1 { get; set; }
        [DataMember]
        public string Answer2 { get; set; }
        [DataMember]
        public string Answer3 { get; set; }
        [DataMember]
        public string Correct_answer { get; set; }

        public QuestionModel() { }
        public QuestionModel(string question, string correct_answer, string answer1, string answer2, string answer3)
        {
            this.Question = question;
            this.Correct_answer = correct_answer;
            this.Answer1 = answer1;
            this.Answer2 = answer2;
            this.Answer3 = answer3;

        }

        public override string ToString()
        {
            return $"{Question} : \na) {Correct_answer} \nb) {Answer1} \nc) {Answer2} \nd) {Answer3}";
        }

    }
  
}
