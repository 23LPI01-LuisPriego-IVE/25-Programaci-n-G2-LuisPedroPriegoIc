Algoritmo Act1_Lecc1_inciso2
    Definir op Como Caracter
    Escribir "Ingrese un carácter:"
    Leer op
    
    Segun op Hacer
        "a","e","i","o","u","A","E","I","O","U":
            Escribir "Es una vocal"
        "0","1","2","3","4","5","6","7","8","9":
            Escribir "Es un dígito"
        De Otro Modo:
            Escribir "Es otro tipo de carácter"
    FinSegun
FinAlgoritmo