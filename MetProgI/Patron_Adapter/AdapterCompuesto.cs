using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetProgI.Patron_Adapter
{
    public class AdapterCompuesto : Student
    {
        AdapterComponent adaptado;

        public AdapterCompuesto(AdapterComponent in_adaptar)
        {
            adaptado = in_adaptar;
        }
        public bool equals(Student student)
        {
            return adaptado._nombre== student.getName();
        }

        public string getName()
        {
            return adaptado._nombre;
        }

        public int getScore()
        {
            throw new NotImplementedException();
        }

        public bool greaterThan(Student student)
        {
            throw new NotImplementedException();
        }

        public bool lessThan(Student student)
        {
            throw new NotImplementedException();
        }

        public void setScore(int score)
        {
            throw new NotImplementedException();
        }

        public string showResult()
        {
            throw new NotImplementedException();
        }

        public int yourAnswerIs(int question)
        {
            throw new NotImplementedException();
        }
    }
}
