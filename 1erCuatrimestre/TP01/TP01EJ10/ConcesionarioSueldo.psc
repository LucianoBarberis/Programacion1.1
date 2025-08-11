Algoritmo ConcesionarioSueldo
	Definir sueldo, vehiculos, valorVehiculo, recaudado Como Entero;
	Definir comision Como Real
	sueldo <- 500;
	
	Escribir "-------Liquidación de sueldos Concesionaria-------"
	Escribir "Cuantos vehiculos vendio?: ";
	Leer vehiculos;
	
	Si vehiculos <> 0 Entonces
		Escribir "Valor del tipo de vehiculo vendido?: ";
		Leer valorVehiculo;
		
		recaudado <- valorVehiculo * vehiculos;
		comision <- recaudado * 0.10;
		sueldo <- sueldo + comision + (vehiculos * 50);
		
		Escribir "-----------------------------"
		Escribir "Sueldo minimo: $500";
		Escribir " ----"
		Escribir " Vehiculos vendidos: ", vehiculos;
		Escribir " Total recaudado: $", recaudado;
		Escribir " 10% de cada vehiculo: $" valorVehiculo * 0.10;
		Escribir " ----"
		Escribir "Total valor constate x c/u (50): $" vehiculos * 50;
		Escribir  "Total correspondiente por venta: $" comision;
		Escribir "Su sueldo total es de: $", sueldo;
		Escribir "-----------------------------"
	SiNo
		Escribir "Le corresponden $", sueldo;
	FinSi
	
FinAlgoritmo
