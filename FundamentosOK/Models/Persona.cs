using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOK.Models
{
    //DECLARAMOS UNA ENUMERACION CON UNA SERIE DE VALORES
    public enum Paises { España, Francia, Alemania, Argentina }

    public class Persona
    {
        //LA PROPIEDAD SE DECLARA CON EL TIPO ENUMERADO
        public Paises Nacionalidad { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //EN LAS PROPIEDADES EXTENDIDAS, QUE SON AQUELLAS 
        //EN LAS QUE DESEAMOS CONTROLAR ALGO
        //SE UTILIZAN CAMPOS PRIVADOS
        private int _Edad;

        public int Edad {
            get {
                //SE DEVUELVE EL CAMPO PRIVADO
                return this._Edad;
            }
            set {
                //CAMBIAMOS EL CAMPO PRIVADO
                //COMPROBAMOS EL VALOR QUE VIENE
                if (value < 0) {
                    //LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }

        //DEBEMOS CREARNOS UN CONJUNTO PARA MANEJAR LA PROPIEDAD
        //INDIZADA, DICHO CONJUNTO PODRIA SER UN ARRAY O UNA COLECCION
        private string[] _Descripciones = new string[3];
        public string this[int indice]
        {
            get {
                return this._Descripciones[indice];
            }
            set
            {
                this._Descripciones[indice] = value;
            }
        }

        public virtual string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido + ", Edad: " + this.Edad;
        }

        //POLIMORFISMO
        public string GetNombreCompleto(bool orden)
        {
            if (orden == true)
            {
                return this.Apellido + " " + this.Nombre;
            }
            else
            {
                return this.Nombre + " " + this.Apellido;
            }
        }

        public void GetNombreCompleto(int num1, int num2) { }
        public void GetNombreCompleto(int num1, int num2, int num3) { }

        public Persona()
        {
            this.Nacionalidad = Paises.Alemania;
        }

        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellido = apellidos;
        }

    }
}
