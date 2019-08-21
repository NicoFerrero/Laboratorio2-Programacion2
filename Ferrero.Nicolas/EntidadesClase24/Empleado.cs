using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesClase24
{
    public delegate void DelegadoSueldoCero();
    public delegate void DelegadoLimiteSueldo(double sueldo, Empleado e);
    public delegate void DelegadoLimiteSueldoMejorado(Empleado e, EmpleadoEventArgs eArgs);

    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int dni;
        private double _sueldo;
        public event DelegadoSueldoCero SueldoCero;
        public event DelegadoLimiteSueldo SueldoMaximo;
        public event DelegadoLimiteSueldoMejorado SueldoMaximoMejorado;

        public double Sueldo
        {
            get
            {
                return this._sueldo;
            }
            set
            {
                if (value > 20000 && value < 30000)
                {
                    EmpleadoEventArgs e = new EmpleadoEventArgs();
                    e.Sueldo = value;
                    this.SueldoMaximoMejorado(this,e);
                }
                else if (value > 10000)
                {
                    this.SueldoMaximo(value, this);
                }
                else if (value == 0)
                {
                    this.SueldoCero();
                    //this.SueldoCero.Invoke();
                }
                else if (value < 0)
                {
                    throw new SueldoNegativoException("No puede ingresar un sueldo negativo");
                }
                else
                {
                    this._sueldo = value;
                }
            }
        }

        public Empleado(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override string ToString()
        {
            return this.nombre + "-" + this.apellido + "-" + this.dni + "-" + this._sueldo;
        }

        public void ManejadorEvento()
        {
            Console.WriteLine("El sueldo no puede ser cero");
        }

        public void ManejadorEvento2(double sueldo, Empleado e)
        {
            Console.WriteLine("(LIMITE 10000) El empleado " + e.ToString() + " quiere cobrar {0}", sueldo);
        }

        public void ManejadorEvento3(Empleado sender, EmpleadoEventArgs e)
        {
            Console.WriteLine("(ENTRE 20000 Y 30000) El empleado " + sender.ToString() + " quiere cobrar {0}", e.Sueldo);
        }
    }
}
