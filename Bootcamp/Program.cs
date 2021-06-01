using Bootcamp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new BootcampContext();

            var scores = from s in context.Students
                         join asc in context.AssessmentScores
                         on s.Id equals asc.StudentId
                         join a in context.Assessments
                         on asc.AssessmentId equals a.Id
                         select new { s, asc, a };
            foreach (var s in scores) { Console.WriteLine($"{s.s.Lastname} {s.asc.ActualScore}"); }
            

            var avgPoints = (from asc in context.AssessmentScores
                             select new { asc.ActualScore })
                             .Average(asc => asc.ActualScore);
            avgPoints = context.AssessmentScores.Average(asc => asc.ActualScore);
            Console.WriteLine($"Average points on assessments is {avgPoints}");

            //    var student = new Student
            //    {
            //        Id = 0,
            //        Firstname = "Sarah",
            //        Lastname = "George",
            //        TargetSalary = 85000,
            //        InBootcamp = true
            //    };
            //    context.Students.Add(student);
            //    if (context.SaveChanges() != 1) { throw new Exception("Insert student failed!"); }

            //    //Added a student above ^^

            //    var git = new Assessment() { Topic = "Git", NumberOfQuestions = 6, MaxPoints = 120 };
            //    var sql = new Assessment() { Topic = "Sql", NumberOfQuestions = 12, MaxPoints = 110 };
            //    var cs = new Assessment() { Topic = "Csharp", NumberOfQuestions = 11, MaxPoints = 110 };
            //    var js = new Assessment() { Topic = "Javascript", NumberOfQuestions = 11, MaxPoints = 110 };
            //    var ng = new Assessment() { Topic = "Angular", NumberOfQuestions = 11, MaxPoints = 110 };

            //    context.Assessments.AddRange(git, sql, cs, js, ng);
            //    if (context.SaveChanges() != 5) { throw new Exception("Insert assessments failed!"); }

            //    //Added the assessments to the table ^^

            //    var gitScore = new AssessmentScore()
            //    {
            //        StudentId = student.Id, AssessmentId = git.Id, ActualScore = 120
            //    };

            //    var sqlScore = new AssessmentScore()
            //    {
            //        StudentId = student.Id,
            //        AssessmentId = sql.Id,
            //        ActualScore = 110
            //    };
            //    context.AssessmentScores.AddRange(gitScore, sqlScore);
            //    if(context.SaveChanges()!= 2) { throw new Exception("Insert assessment score failed!"); }




        }
        }
    }
