using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.Text;
using System.IO;

namespace Questions_Game
{
    // сделать загрузку для новой игры и для сохранений!
    class JsonSerializer : ISerializer
    {
        private const string path = @"../../../BaseQuestions.json";  // База
        private const string userPath = @"../../../UserSave.json";
        public void Save(List<QuestionModel> list)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<QuestionModel>));
            using (FileStream fileStream = new FileStream(userPath, FileMode.Create))
            {
                serializer.WriteObject(fileStream, list);
            }
        }

        public List<QuestionModel> Load()
        {
            List<QuestionModel> list = new List<QuestionModel>();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<QuestionModel>));
            using(FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                list = serializer.ReadObject(fileStream) as List<QuestionModel>;
            }
            return list;
        }

        public List<QuestionModel> LoadSave()
        {
            List<QuestionModel> list = new List<QuestionModel>();
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<QuestionModel>));
            using (FileStream fileStream = new FileStream(userPath, FileMode.Open))
            {
                list = serializer.ReadObject(fileStream) as List<QuestionModel>;
            }
            return list;
        }

    }
}
