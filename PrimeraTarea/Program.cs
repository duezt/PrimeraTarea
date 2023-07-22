
//Calculadora de perimetro
CargarCuadrado();
//Calculadora de suma y producto
SumaProducto();
//Calculadora de promedio
Promedio();



void CargarCuadrado()
{

    Console.WriteLine("Favor introducir el lado del cuadrado que desea calcular el perimetro");

    decimal lado = decimal.Parse(Console.ReadLine());
    decimal perimetro = lado * 4;

    Console.WriteLine($"perimetro del cuadrado es: {perimetro}\n");
}


void SumaProducto()
{
    Console.WriteLine("----Calculadora de Suma & Producto-----");
    Console.WriteLine("Favor introducir el primer valor");
    decimal primerValor = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Favor introducir el segundo valor");
    decimal segundoValor = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Favor introducir el tercer valor");
    decimal tercerValor = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Favor introducir el cuarto valor");
    decimal cuartoValor = decimal.Parse(Console.ReadLine());

    //Calculo de la operaciones
    decimal resultadoSuma = primerValor + segundoValor;
    decimal resultadoProducto = tercerValor * cuartoValor;

    //Muestra el resultado de las operaciones por los valores solicitados
    Console.WriteLine($"La sumatoria del primer y segundo valor es: {primerValor} + {segundoValor} = {primerValor + segundoValor}");
    Console.WriteLine($"El producto del tercer y cuarto valor: {tercerValor} x {cuartoValor} = {tercerValor + cuartoValor}\n");


}


void Promedio()
{
    Console.WriteLine("---Calculadora de promedio---");

    Console.WriteLine("Favor introducir el primer valor");
    decimal primerValor = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Favor introducir el segundo valor");
    decimal segundoValor = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Favor introducir el tercer valor");
    decimal tercerValor = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Favor introducir el cuarto valor");
    decimal cuartoValor = decimal.Parse(Console.ReadLine());

    //Calculo de la operaciones
    decimal resultadoSuma = primerValor + segundoValor + tercerValor + cuartoValor;

    //Muestra el resultado de las operaciones por los valores solicitados

    Console.WriteLine($"El promedio de la sumatoria de los valores introducidos es {resultadoSuma / 4} \n");

}
