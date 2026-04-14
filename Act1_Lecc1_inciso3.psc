Algoritmo Act1_Lecc1_inciso3
    Definir op, tipoPrecio, cantidad Como Entero
    Definir precio, total Como Real
    
    Escribir "Estadio Doroteo Guamuch Flores"
    Escribir "1. Palco (Q300)"
    Escribir "2. Tribuna (Q100 o Q125)"
    Escribir "3. Preferencia (Q50 o Q75)"
    Escribir "4. Generales (Q30 o Q50)"
    Leer op
    
    Segun op Hacer
        1:
            precio = 300
        2:
            Escribir "Seleccione: 1. Q100 | 2. Q125"
            Leer tipoPrecio
            Segun tipoPrecio Hacer
                1: precio = 100
                2: precio = 125
            FinSegun
        3:
            Escribir "Seleccione: 1. Q50 | 2. Q75"
            Leer tipoPrecio
            Segun tipoPrecio Hacer
                1: precio = 50
                2: precio = 75
            FinSegun
        4:
            Escribir "Seleccione: 1. Q30 | 2. Q50"
            Leer tipoPrecio
            Segun tipoPrecio Hacer
                1: precio = 30
                2: precio = 50
            FinSegun
		De Otro Modo:
			Escribir "Opción no válida"
    FinSegun
    
    Escribir "Cantidad de entradas:"
    Leer cantidad
    total = precio * cantidad
    Escribir "Total a Pagar: Q", total
FinAlgoritmo