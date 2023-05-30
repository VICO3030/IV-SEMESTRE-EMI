namespace Arbol_Binario
{
	class arbolito
	{
		NodoArbol raiz, nuevo, aux;
		bool xx;
		public int suma;
		public int pares;
		public int impares;
		public arbolito()
		{
			this.raiz = null;
			this.nuevo = null;
			this.aux = raiz;
			this.xx = false;
			this.suma = 0;
			this.pares = 0;
			this.impares = 0;
		}

		public void crearNodo(int d)
		{
			this.nuevo = new NodoArbol();
			nuevo.Dato = d;
			nuevo.Izq = null;
			nuevo.Der = null;
		}

		public void crear_arbol(int d)
		{
		   raiz =  crear_arbol(d, raiz);
		}

		public NodoArbol crear_arbol(int d, NodoArbol x)
		{
			crearNodo(d);
			 aux = x;
			if (x == null) {even(d); suma += d; return nuevo; }
			else
			{
				if (d < x.Dato) { x.Izq = crear_arbol(d, x.Izq);}
				else if (d > x.Dato) { x.Der = crear_arbol(d, x.Der); }
				else { return x; }
				return x;
			}
		}

		public bool buscar(int dato, NodoArbol x)
		{
			if (x == null) { return false;  }
			if (x.Dato == dato) { xx= true; }
			else if (dato > x.Dato) { xx = buscar(dato, x.Der); }
			else if (dato < x.Dato) { xx = buscar(dato, x.Izq); }
			else  xx = false;

			return xx;
        }

		public NodoArbol get_raiz()
		{
			return this.raiz;
		}

		void even(int dato)
		{
			if (dato % 2 == 0) {
				pares++;
			}
			else
			{
				impares++;
			}
		}
	}
}
