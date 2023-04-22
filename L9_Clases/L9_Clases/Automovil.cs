using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9_Clases
{

    public class Automovil
    {
        //atributos privados
        private int modelo;
        private double precio, cambiodolar, descuento;
        private string marca;
        private bool disponible;

        //metodo get y set, enviar y recibir variables
        public int Modelo { get; }
        public double Precio { get; }
        public double CambioDolar { get; }
        public string Marca { get { return marca; } }
        public Automovil()
        {
            modelo = 2019;
            precio = 10000.00;
            marca = "";
            disponible = false;
            cambiodolar = 7.50;
            descuento = 0.00;

        }
        public void DefinirModelo(int unmodelo)
        {
            modelo = unmodelo;
        }
        public void DefinirPrecio(double unprecio)
        {
            precio = unprecio;
        }
        public void DefinirMarca(string unamarca)
        {
            marca = unamarca;
        }
        public void DefinirTipoCambio(double uncambiodolar)
        {
            cambiodolar = uncambiodolar;

        }
        public void DefinirDisponibilidad()
        {
            if (disponible)
            {
                disponible = false;
            }
            else
            {
                disponible = true;
            }
        }
        public string Mostrardisponibilidad()
        {
            if (disponible)
            {
                return "Diponible";
            }
            else
            {
                return "No se encuentra diponible actualmente";
            }
        }
        private double Conversion()
        {
            return precio * cambiodolar;
        }
        public string MostrarInformacion()
        {
            return $"\nMarca: {marca}.\nModelo: {modelo}.\nPrecio de venta: Q{precio}\nPrecio en dólares: {Conversion()}.\n{Mostrardisponibilidad()}.";
        }

        public void AplicarDescuento(double midescuento)
        {
            descuento = midescuento;
            double  nuevopre = precio - descuento;
            DefinirPrecio(nuevopre);
        }
    }
}
