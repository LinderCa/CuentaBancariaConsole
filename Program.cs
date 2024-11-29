//DIRECTIVA PARA LLAMAR AL ESPACIO DE NOMBRES Y SUS CLASES
using CuentaBancariaConsole.Entidades;

//Variables globales 
int opcion=0;
//Generamos un Menu
do{
    Console.WriteLine("-------------------------------");
    Console.WriteLine("\tMENU USUARIO");
    Console.WriteLine("-------------------------------");
    Console.WriteLine("|1|->Registre una cuenta Bancaria");
    Console.WriteLine("|2|->Consulte una cuenta Bancaria");
    Console.WriteLine("|3|->Consulte Toda las cuentas Bancarias");
    Console.WriteLine("|4|->Realize un Deposito");
    Console.WriteLine("|5|->Realize un reintegro");
    Console.WriteLine("|6|->Salir");
    Console.WriteLine("-->Digite una Opcion(1 al 6): ");
    opcion=int.Parse(Console.ReadLine());

}while(opcion!=6);



Console.WriteLine("");
