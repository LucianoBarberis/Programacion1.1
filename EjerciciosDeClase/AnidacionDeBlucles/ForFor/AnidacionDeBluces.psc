Algoritmo AnidacionDeBlucles

	Definir i, j Como Entero;
	Definir nota, promedioU, promedioCurso, CA, CN Como Real;
	Repetir
		Escribir "Ingrese la cantida de alumnos";
		Leer CA;
		Si CA < 1 Entonces
			Escribir "Debe ingresar mas de un alumno!!!";
		FinSi
	Mientras Que CA < 1
	Repetir
		Escribir "Ingrese la cantidad de notas por alumno";
		Leer CN;
		Si CN < 1 Entonces
			Escribir "Debe ingresar mas de una nota!!!";
		FinSi
	Mientras Que CN < 1 
	
	promedioU = 0;
	promedioCurso = 0;
	Para i = 1 Hasta CA Con Paso 1 Hacer
		Escribir "____________________________________";
		Escribir "Calculo del promedio del alumno ", i, "/", CA;
		Para j = 1 Hasta CN Con Paso 1 Hacer
			Repetir
				Escribir "Ingrese la nota ",j, "/", CN, " del alumno ", i;
				Leer nota;
				Si nota < 0 o nota > 10 Entonces
					Escribir "Nota Incorrecta";
				SiNo
					promedioU = promedioU + nota;
				FinSi
			Mientras Que nota < 1 o nota > 10
		Fin Para
		promedioU = promedioU / CN;
		promedioCurso = promedioCurso + promedioU;
		Escribir "El promedio general del alumno ", i, " es ", promedioU;
	Fin Para
	
	promedioCurso = promedioCurso / CA;
	Escribir "El promedio general del curso es: ", promedioCurso;
FinAlgoritmo
