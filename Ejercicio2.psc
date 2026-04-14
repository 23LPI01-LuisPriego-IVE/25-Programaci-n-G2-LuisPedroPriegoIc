Algoritmo Ejercicio2

    Definir op Como Entero
    Definir a, b, s, r, m, d Como Real
    
    Escribir "Calculadora "
    Escribir "Digite el primer valor:"
    Leer a
    Escribir "Digite el segundo valor:"
    Leer b
    
    s = a + b
    r = a - b
    m = a * b
    
    Escribir "¿Qué operación desea realizar?"
    Escribir "1: Suma"
    Escribir "2: Resta"
    Escribir "3: Multiplicación"
    Escribir "4: División"
    Leer op
    
    Segun op Hacer
        1: Escribir "Resultado de la Suma: ", s
        2: Escribir "Resultado de la Resta: ", r
        3: Escribir "Resultado de la Multiplicación: ", m
        4: Escribir "Resultado de la División: ", d
        De Otro Modo:
            Escribir "Opción Incorrecta"
    FinSegun
FinAlgoritmo
