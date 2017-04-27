using System;


namespace OrdenamientosAlgoritmos
{
    class Persona: IComparable<Persona>
    {

        string nombre;
        string apellidoP;
        string apellidoM;
        int edad;

        public Persona(string nombre, string apellidoP, string apellidoM, int edad)
        {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.edad = edad;
        }

        public string GenComp()
        {
            return apellidoP + apellidoM + nombre;
        }
        public string GenEq()
        {
            return apellidoP + apellidoM + nombre+ edad;
        }

        public override string ToString()
        {
            
            return nombre+" "+ apellidoP+" "+ apellidoM;
        }

        public int CompareTo(Persona other)
        {
            return GenComp().CompareTo(other.GenComp());
        }

        public bool Equals(Persona other)
        {
            return GenEq().Equals(other.GenEq());
        }
    }
}
