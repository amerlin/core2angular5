using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace core2angular5.ViewModels
{
    public class ResultViewModel
    {
        public ResultViewModel()
        {

        }

        public int Id { get; set; }
        public int QuizId { get; set; }

        public string Text { get; set; }

        public string Notes { get; set; }

        [DefaultValue(0)]
        public int Type { get; set; }

        [DefaultValue(0)]
        public int Flags { get; set; }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
