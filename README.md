1)¿String es una tipo por valor o un tipo por referencia?
Hay dos tipos de tipos en Visual Basic: tipos de referencia y tipos de valor. Las variables de tipos de referencia almacenan referencias en sus datos (objetos), mientras que las variables de tipos de valor contienen directamente los datos. Con los tipos de referencia, dos variables pueden hacer referencia al mismo objeto y, por lo tanto, las operaciones en una variable pueden afectar al objeto al que hace referencia la otra variable. Con los tipos de valor, cada variable tiene su propia copia de los datos y no es posible que las operaciones en una variable afecten a la otra (excepto en el caso del modificador ByRef en los parámetros).

String es de tipo por referencia

2)¿Qué secuencias de escape tiene el tipo string?
\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)

3)¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?