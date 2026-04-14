Algoritmo Act1_Lecc1_inciso4
Definir op Como Caracter
Definir val, resultado Como Real

Escribir "Seleccione la unidad a convertir:"
Escribir "a) Metros"
Escribir "b) Pies"
Escribir "c) Centimetros"
Escribir "d) Pulgadas"
Leer op

Escribir "Ingrese el valor:"
Leer val

Segun op Hacer
	
	"a": Escribir "Metros a otras unidades:"
		 Escribir "Pies: ", val * 3.281
		 Escribir "Centimetros: ", val * 100
		 Escribir "Pulgadas: ", val * 39.37
		
	"b": Escribir "Pies a otras unidades:"
		 Escribir "Metros: ", val / 3.281
		 Escribir "Centimetros: ", val * 30.48
		 Escribir "Pulgadas: ", val * 12
		
	"c": Escribir "Centimetros a otras unidades:"
		 Escribir "Metros: ", val / 100
		 Escribir "Pies: ", val / 30.48
		 Escribir "Pulgadas: ", val / 2.54
		
	"d": Escribir "Pulgadas a otras unidades:"
		 Escribir "Metros: ", val / 39.37
		 Escribir "Pies: ", val / 12
		 Escribir "Centimetros: ", val * 2.54
		
	De Otro Modo:
		Escribir "Opcion invalida"
		
FinSegun

FinAlgoritmo
