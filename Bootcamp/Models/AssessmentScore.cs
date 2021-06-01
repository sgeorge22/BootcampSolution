using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bootcamp.Models
{
    public class AssessmentScore
    {
        public int Id { get; set; }
        [Required]
        public int ActualScore { get; set; }
        [Required]
        public int StudentId { get; set; } //FK to the student table
        public virtual Student Student { get; set; }
        [Required]
        public int AssessmentId { get; set; } //FK to the assessment table
        public virtual Assessment Assessment { get; set; }

        public AssessmentScore()
        {
                
        }

    }
}
