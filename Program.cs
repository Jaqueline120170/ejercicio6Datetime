using System.Globalization;

Console.WriteLine("Intruduzca la fecha del mes que desea calcular en formato dd/mm/yyyy");
string fecha = Console.ReadLine();
DateTime fechaUsuario = Convert.ToDateTime(fecha);
DateTime fechaBucle;

int anyo = fechaUsuario.Year;
int mes = fechaUsuario.Month;

int numDiasMes = DateTime.DaysInMonth(anyo, mes);
Console.WriteLine("El mes introducido tiene " + numDiasMes + " dias");

Console.WriteLine("El nombre del día de la fecha introducida es " +
    fechaUsuario.ToString("dddd", new CultureInfo("es-ES")));
for (int i = 1; i <= numDiasMes; i++)
{
    string fechaAux = i + "/" + mes + "/" + anyo;
    fechaBucle = Convert.ToDateTime(fechaAux);

    string diaSemana = fechaUsuario.ToString("dddd", new CultureInfo("es-ES"));
    if (diaSemana.Equals(fechaBucle.ToString("dddd", new CultureInfo("es-ES"))))
    {
        Console.WriteLine("Estas son las fechas de los dias " +
        fechaUsuario.ToString("dddd", new CultureInfo("es-ES")) + " del més introducido: " +
        fechaBucle.ToString("M"));
    }
}