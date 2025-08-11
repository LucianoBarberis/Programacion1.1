Algoritmo BuclesCiclos
	Escribir "----------------For----------------------";
	Definir index Como Entero;
	Para index = 0 Hasta 10 Con Paso 1 Hacer
		Escribir "Es la iteracion numero: ", index;
	Fin Para
	
	Escribir "----------------While--------------------";
	Definir salida, iteracion Como Entero;
	salida = 1;
	iteracion = 0;
	
	Mientras salida <> 0 Hacer
		iteracion = iteracion + 1;
		Escribir "Esta es la iteracion numero: ", iteracion;
		Escribir "Escribir 0 para salir del bucle while: ";
		Leer salida;
	Fin Mientras
	
	Escribir "---------------Do-While------------------";
	Definir salirDo, iteracionDo Como Entero;
	salirDo = 1;
	iteracionDo = 0;
	
	Repetir
		iteracionDo = iteracionDo + 1;
		Escribir "Esta es la iteracion numero: ", iteracionDo;
		Escribir "0. Para salir del bucle";
		Escribir "1. Para entrar en un bucle infinito";
		Leer salirDo;
		Si salirDo == 1 Entonces
			Definir i Como Entero;
			i = 1;
			Mientras i == 1 Hacer
				Escribir "BucleInfinito.";
			FinMientras
		FinSi
	Hasta Que salirDo == 0
FinAlgoritmo
