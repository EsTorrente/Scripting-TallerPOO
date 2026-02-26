# ARGUMENTACIÓN

## Clase abstracta Empleado:
1. Es abstracta porque simplemente se usa como una base para los empleados.
2. En el constructor defino de una vez el ID, porque ese es un proceso que debe ser automatizado para mejorar la experiencia. Evita que me quieran poner IDs repetidos (porque la gente es dañina)
3. El id solo tiene get porque nadie lo toca, y el nombre DEBE llenarse.
4. Los métodos los dejé sin rellenar porque para ambos son completamente distintos.

## Interfaz IEvaluado
1. Solamente le voy a dar bonus a los que trabajan tiempo completo porque son fieles a mi compañía. A los de hora no.

## Clase EmpleadoPorHoras
1. Double para el salario, porque quizá me vuelva millonaria y les pague un número ridículo.
2. Uint porque las horas no pueden ser negativas
3. La sobrecarga se la puse al método de calcular horas, porque quizá le quería aumentar un poquito el saldo a la hora de pagar si trabajó muy bien.
4. Le puse también un método de modificar horas por si quiero romper contrato y quitarle porque me cayó mal, o aumentarle porque lo necesito otro rato.

## Clase EmpleadoTiempoCompleto
1. Le puse un contador de faltas porque soy jefe estricta.
2. Las ausencias no las pueden quitar. Si faltó, faltó. Sólo se pueden aumentar desde el método. Como el método sólo sube +1, el set no necesita validar nada.


No hay foreach. Me dan rabia los foreach. Mi empresa se dedica a modificar códigos en masa para eliminar los foreach.
