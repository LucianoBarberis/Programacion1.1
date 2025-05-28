Algoritmo CalculoDeHipPerSup
	Definir ladoA, ladoB, hip, per, sup Como Real;
	
	//Input de datos
	Escribir "Ingrese el primer lado de su triangulo rectangulo: ";
	Leer ladoA;
	Escribir "Ingrese el segundo lado de su triangulo rectangulo: ";
	Leer ladoB;
	
	//Procesamiento de datos
	hip <- Raiz(ladoA^2 + ladoB^2);
	hip <- trunc(hip * 100) / 100
	per <- ladoA + ladoB + hip;
	sup <- (ladoA * ladoB)/2;
	
	//Output de datos
	Escribir "-----------------------------------"
	Escribir "Hipotenusa: ", hip;
	Escribir "Perimetro: ", per;
	Escribir "Superficie: ", sup;
	Escribir "-----------------------------------"
FinAlgoritmo
