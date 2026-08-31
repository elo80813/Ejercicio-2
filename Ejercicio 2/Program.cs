Console.WriteLine("EJERCICIO_1"); //Numero de la practica
Console.WriteLine("CÁLCULO DEL PROMEDIO DE TRES CALIFICACIONES"); //Nombre del ejercicio
Console.WriteLine(); //Instruccion para dejar un espacio en blanco en la consola

Console.Write("Ingrese la primera calificación: "); // se solicita al usuario que ingrese la primera calificaci
double calificacion1 = Convert.ToDouble(Console.ReadLine()); //solicita al usuario que ingrese la primera calificacion

Console.Write("Ingrese la segunda calificación: "); // solicita al usuario que ingrese la segunda calificacion
double calificacion2 = Convert.ToDouble(Console.ReadLine()); // solicita al usuario que ingrese la segunda calificacion

Console.Write("Ingrese la tercera calificación: "); // solicita al usuario que ingrese la tercera calificacion
double calificacion3 = Convert.ToDouble(Console.ReadLine()); // solicita al usuario que ingrese la tercera calificacion

double promedio = (calificacion1 + calificacion2 + calificacion3) / 3.0; //se calcula el promedio de las tres calificaciones

Console.WriteLine(); //Instruccion para dejar un espacio en blanco en la consola
Console.WriteLine($"El promedio de las tres calificaciones es: {promedio:F2}"); //hacer una concatenacion
if (promedio >= 70) //se hace una condicion para saber si el promedio es mayor o igual a 6
{
    Console.WriteLine("¡Felicidades! Has aprobado."); //si el promedio es mayor o igual a 6 se imprime este mensaje
}
else //si el promedio es menor a 6 se imprime este mensaje
{
    Console.WriteLine("Lo siento, has reprobado."); //si el promedio es menor a 6 se imprime este mensaje
}