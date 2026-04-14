Algoritmo Act1_Lecc1_inciso1 
	Definir op Como Entero
	Definir grados, radianes, resultado Como Real
	
	Escribir "Calculadora de funciones trigonométricas"
	Escribir "Ingrese el ángulo:"
	Leer grados
	
	radianes = grados * (PI / 180)
	
	Escribir "***************************************************"
    Escribir "* Lista de funciones trigonometricas              *"
    Escribir "* 1- Seno                                         *"
    Escribir "* 2- Coseno                                       *"
    Escribir "* 3- Tangente                                     *"
    Escribir "***************************************************"
	Leer op
	
	Segun op Hacer
		1:
			resultado = Sen(radianes)
			Escribir "El Seno es: ", resultado
		2:
			resultado = Cos(radianes)
			Escribir "El Coseno es: ", resultado
		3:
			resultado = Tan(radianes)
			Escribir "La Tangente es: ", resultado
		De Otro Modo:
			Escribir "Opción no válida"
	FinSegun
	
FinAlgoritmo
