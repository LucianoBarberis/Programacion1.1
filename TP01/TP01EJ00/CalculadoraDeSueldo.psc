Algoritmo CalculadoraDeSueldo
	Definir vh Como Entero
	Definir ch Como Entero
	Definir emp Como Entero
	Definir sdo Como Entero
	
	Escribir "--------Calculadora de Sueldo--------"
	Escribir "Ingrese el identificador del empleado"
	Leer emp
	Escribir "Cantidad de horas trabajadas:"
	Leer ch
	Escribir "Valor por hora:"
	Leer vh
	sdo <- vh*ch
	Escribir "------------------------------------"
	Escribir "Empleado n°", emp;
	Escribir "Sueldo a pagar: $", sdo;
	Escribir "------------------------------------"
FinAlgoritmo
