using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace core2angular5.ViewModels
{
    [JsonObject(MemberSerialization.OptOut)]
    public class AnswerViewModel
    {
        public AnswerViewModel()
        {

        }

        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }

        public string Notes { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }

        [DefaultValue(0)]
        public int Flags { get; set; }

        [DefaultValue(0)]
        public int Value { get; set; }

        [JsonIgnore]
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

    }
}
