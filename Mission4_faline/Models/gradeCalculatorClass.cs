using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Mission4_faline.Models
{
    public class gradeCalculatorClass
    {
        [Range(0, 100)]
        public int Assignment { get; set; }
        [Range(0, 100)]
        public int GroupProject { get; set; }
        [Range(0, 100)]
        public int Quizzes { get; set; }
        [Range(0, 100)]
        public int Midterm { get; set; }
        [Range(0, 100)]
        public int Final { get; set; }
        [Range(0, 100)]
        public int Intex { get; set; }
    }
}
