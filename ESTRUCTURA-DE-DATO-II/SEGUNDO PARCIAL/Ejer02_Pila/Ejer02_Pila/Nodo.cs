using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02_Pila
{
    class Nodo
    {
        int stock;
        int codigo;
        float precio;
        string descripcion;
        Nodo sig;
        public Nodo()
        {
            stock = 0;
            codigo = 0;
            precio = 0;
            descripcion = "";
        }
        /*    Setters     */
        public void Set_stok(int _stock)
        {
            stock = _stock;
        }
        public void Set_Codigo(int _codigo)
        {
            codigo = _codigo;
        }
        public void Set_Precio(float _precio)
        {
            precio = _precio;
        }
        public void Set_descripcion(string _descripcion)
        {
            descripcion = _descripcion;
        }
        public void Set_sig(Nodo _sig)
        {
            sig = _sig;
        }
        /*          Getters         */
        public int Get_Stock()
        {
            return stock;
        }
        public int Get_Codigo()
        {
            return codigo;
        }
        public float Get_precio()
        {
            return precio;
        }
        public string Get_descripcion()
        {
            return descripcion;
        }
        public Nodo Get_sig()
        {
            return sig;

        }
    }
}
