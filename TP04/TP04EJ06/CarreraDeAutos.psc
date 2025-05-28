Algoritmo CarreraDeAutos
	Definir opc, nAuto, hora, min, seg, ms Como Entero;
	Definir winner, wHora, wMin, wSeg, wMs Como Entero;
	Definir loser, lHora, lMin, lSeg, lMs Como Entero;
	Definir index Como Entero;
	index <- 0;
	Repetir
		Escribir '1. Añadir auto';
		Escribir '0. Ver resultados';
		Leer opc;
		Si opc=1 Entonces
			Escribir 'Auto N°: ';
			Leer nAuto;
			Escribir 'Hora: ';
			Leer hora;
			Repetir
				Escribir 'Minuto: ';
				Leer min;
			Hasta Que min<59 Y min>0
			Repetir
				Escribir 'Segundo: ';
				Leer seg;
			Hasta Que seg<59 Y seg>0
			Repetir
				Escribir 'Milésimas: ';
				Leer ms;
			Hasta Que ms<100 Y ms>0
			Si index=0 Entonces
				winner <- nAuto;
				wHora <- hora;
				wMin <- min;
				wSeg <- seg;
				wMs <- ms;
				loser <- nAuto;
				lHora <- hora;
				lMin <- min;
				lSeg <- seg;
				lMs <- ms;
			SiNo
				Si (hora<wHora) O (hora=wHora Y min<wMin) O (hora=wHora Y min=wMin Y seg<wSeg) O (hora=wHora Y min=wMin Y seg=wSeg Y ms<wMs) Entonces
					winner <- nAuto;
					wHora <- hora;
					wMin <- min;
					wSeg <- seg;
					wMs <- ms;
				FinSi
				Si (hora>lHora) O (hora=lHora Y min>lMin) O (hora=lHora Y min=lMin Y seg>lSeg) O (hora=lHora Y min=lMin Y seg=lSeg Y ms>lMs) Entonces
					loser <- nAuto;
					lHora <- hora;
					lMin <- min;
					lSeg <- seg;
					lMs <- ms;
				FinSi
			FinSi
			index <- index+1;
		FinSi
	Hasta Que opc=0
	Escribir 'Ganador: Auto ', winner, ' con tiempo ', wHora, ':', wMin, ':', wSeg, '.', wMs;
	Escribir 'Último: Auto ', loser, ' con tiempo ', lHora, ':', lMin, ':', lSeg, '.', lMs;
FinAlgoritmo
