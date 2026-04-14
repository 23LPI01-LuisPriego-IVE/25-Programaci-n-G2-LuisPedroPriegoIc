Algoritmo Act1_Lecc1_inciso5
	Definir cant, forma Como Entero
	Definir precioConIva, totalSinDesc, desc, total Como Real
	Definir nombre Como Caracter
	
	precioConIva = 650 * 1.12 // Q728.00
	
	Escribir "Cantidad de impresoras a comprar:"
	Leer cant
	totalSinDesc <- precioConIva * cant
	
	Escribir "Seleccione forma de pago:"
	Escribir "1. Efectivo"
	Escribir "2. Tarjeta de credito"
	Escribir "3. Vale de regalo"
	Leer forma
	
	Segun forma Hacer
		1:
			nombre = "Efectivo"
			desc = totalSinDesc * 0.10
		2:
			nombre = "Tarjeta de Crédito"
			desc = totalSinDesc * 0.05
		3:
			nombre = "Vale de Regalo"
			desc = totalSinDesc * 0.15
		De Otro Modo:
			desc = 0
			nombre = "No valido"
	FinSegun
	
	total <- totalSinDesc - desc
	
	Escribir "Detalle del Pago:"
	Escribir "Cantidad: ", cant
	Escribir "Precio Unitario (con IVA): Q728.00"
	Escribir "Total sin descuento: Q", totalSinDesc
	Escribir "Forma de pago: ", nombre
	Escribir "Descuento realizado: Q", desc
	Escribir "Total a Pagar: Q", total
FinAlgoritmo