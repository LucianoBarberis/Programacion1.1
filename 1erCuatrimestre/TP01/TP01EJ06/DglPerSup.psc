Algoritmo DglPerSup
	Definir ladoA, ladoB, dgl, per, sup Como Real;
	
	//Input de datos
	Escribir "Ingrese el primer lado de su rectangulo: ";
	Leer ladoA;
	Escribir "Ingrese el segundo lado de su rectangulo: ";
	Leer ladoB;
	
	//Procesamiento de datos
	dgl <- Raiz(ladoA^2 + ladoB^2);
	dgl <- trunc(dgl * 100) / 100
	per <- (ladoA + ladoB) * 2;
	sup <- ladoA * ladoB;
	
	//Output de datos
	Escribir "-----------------------------------"
	Escribir "Diagonal: ", dgl;
	Escribir "Perimetro: ", per;
	Escribir "Superficie: ", sup;
	Escribir "-----------------------------------"
FinAlgoritmo
