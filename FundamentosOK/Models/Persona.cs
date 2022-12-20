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
                return _Edad; 
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
                    _Edad = value;
                }
            }
        }

        //EN ALGUN MOMENTO, EN OTRO CODIGO, EL PROGRAMADOR
        //IGUALARA EL DATO DE LA EDAD A ALGO
        // persona.Edad = 28;
    }
}
