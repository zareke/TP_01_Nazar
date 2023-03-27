#region Pruebas
/*Console.WriteLine("PUNTO 1");
Console.Write("Ingrese su fecha de cumpleaños: ");
Console.WriteLine(CuandoEsMiCumple(DateTime.Parse(Console.ReadLine())));
Console.WriteLine("PUNTO 2");
Console.WriteLine("A continuacion, ingrese fecha y cuotas");
ObtenerFechasPago(DateTime.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
Console.WriteLine("PUNTO 3");
Console.WriteLine("A continuacion, ingrese dos fechas. La primera tiene que ser menor a la segunda");
DateTime fecha1 = DateTime.Parse(Console.ReadLine());
DateTime fecha2 = DateTime.Parse(Console.ReadLine());
while(fecha2 < fecha1){
Console.WriteLine("La fecha 2 tiene que ser mayor o igual a la fecha 1...");
fecha2 = DateTime.Parse(Console.ReadLine());
}
ObtenerMesesEntre(fecha1,fecha2)*/
#endregion

#region 1)
static int CuandoEsMiCumple(DateTime fecha)
{
    Double diasTotales = 0;
    


        DateTime nuevaFecha = new DateTime(DateTime.Today.Year, fecha.Month, fecha.Day);


        diasTotales = DateTime.Today.Subtract(nuevaFecha).TotalDays;


        
            /*
        if (diasTotales == 0)
        {
            
            Console.WriteLine("Feliz cumple!");

        }
        else if (diasTotales <0)
        {


            Console.Write("Dias que faltan para tu cumple: ");
            diasTotales = -diasTotales;
        }else{


              Console.Write("Dias que pasaron desde tu cumple: ");
        }
    
*/

    return (int)diasTotales;
}

#endregion

#region 2)
static List<string> ObtenerFechasPago(DateTime fecha, int cuotas)
{

    List<string> fechasPago = new List<string>();


    for (int i = 0; i < cuotas; i++)
    {


        fechasPago.Add(fecha.AddMonths(i).ToShortDateString());

        //Console.WriteLine(fechasPago[i]);

    }



    return fechasPago;

}
#endregion

#region 3)
static List<string> ObtenerMesesEntre(DateTime a, DateTime b){
  

List<string> mesesEnMedio = new List<string>();

int maximo = a.Month == b.Month ? 0 : b.AddMonths(-a.Month).Month;


for (int i = 0; i<=maximo; i++){
mesesEnMedio.Add(a.AddMonths(i).ToString("MMMM"));



//Console.WriteLine(mesesEnMedio[i]);
}




return mesesEnMedio;






} 
#endregion