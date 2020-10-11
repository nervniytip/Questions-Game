using System;
using System.Collections.Generic;
using System.Text;

namespace Questions_Game
{
    interface ISerializer
    {
        // сделать загрузку для новой игры и для сохранений!
        public void Save(List<QuestionModel> list);
        public List<QuestionModel> Load();
        public List<QuestionModel> LoadSave();
        
    }
}
