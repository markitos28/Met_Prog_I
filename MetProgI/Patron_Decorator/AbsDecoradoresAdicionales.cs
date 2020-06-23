using System;
using System.Collections.Generic;
using System.Text;
using MetodologíasDeProgramaciónI;

namespace MetProgI.Patron_Decorator
{
    public abstract class AbsDecoradoresAdicionales :  IImprimirDec, Student
    {
        public Student estudiante;

        public bool equals(Student student)
        {
           return estudiante.equals(student);
        }

        public string getName()
        {
            return estudiante.getName();
        }

        public int getScore()
        {
            return estudiante.getScore();
        }

        public bool greaterThan(Student student)
        {
            return estudiante.greaterThan(student);
        }

        public abstract string imprimirDecorado();

        public bool lessThan(Student student)
        {
            return estudiante.lessThan(student);
        }

        public void setScore(int score)
        {
            estudiante.setScore(score);
        }

        public abstract string showResult();
        

        public int yourAnswerIs(int question)
        {
            return estudiante.yourAnswerIs(question);
        }
    }
}
