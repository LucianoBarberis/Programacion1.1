Algoritmo SumaDeEnteros
	Definir num1 Como Entero
	Definir num2 Como Entero
	Definir num3 Como Entero
	Definir result Como Entero
	Definir opc Como Entero
	
	Hacer
		Escribir "-------------------Algoritmo de Suma---------------------";
		Escribir  "Primer Numero:";
		Leer num1;
		Escribir  "Segundo Numero:";
		Leer num2;
		Escribir "Tercer Numero:";
		Leer num3;
		result <- num1 + num2 + num3;
		Escribir "La suma de ", num1, ", ", num2, " y ", num3, " es ", result;
		Escribir "Para salir escribir 0: ";
		Leer opc;
	Hasta Que opc == 0;
	Escribir "----------------Saliendo del Algoritmo---------------------";
FinAlgoritmo
