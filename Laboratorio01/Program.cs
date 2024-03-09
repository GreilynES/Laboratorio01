// See https://aka.ms/new-console-template for more information
using Lab_1.Abstraccion;

Console.WriteLine("Hello, World!");


PosibleEmpleado objposibleEmpleado = new PosibleEmpleado();
//PosibleEmpleado2 objposibleEmpleado2 = new PosibleEmpleado2();

objposibleEmpleado.AgregarPosibleEmpleado();
objposibleEmpleado.AgregarPosibleEmpleado();


List<string> listIntengers = new List<string>();

listIntengers.Add("502370727, Rodrigo, 32, 7 años de experiencia");
listIntengers.Add("507770777, Pblo, 30, 5 años de experiencia");

foreach (string item in listIntengers) //Recorre lista
{
    Console.WriteLine(item);
}
