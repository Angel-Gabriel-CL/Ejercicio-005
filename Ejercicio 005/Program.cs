{
    // ---------------------------------------------------------------------------------
    // 6) ENCABEZADO EN CONSOLA CON EL PLANTEAMIENTO DEL PROBLEMA
    // ---------------------------------------------------------------------------------
    Console.WriteLine("==================================================================================");
    Console.WriteLine("                PROBLEMARIO #1: CICLOS Y ESTRUCTURAS EN C# - EJERCICIO 5          ");
    Console.WriteLine("==================================================================================");
    Console.WriteLine("Planteamiento del problema:");
    Console.WriteLine("Diseñe un programa que permita analizar la vibración de varios motores.");
    Console.WriteLine("Para cada motor el programa solicitará su identificador y 4 mediciones de vibración");
    Console.WriteLine("usando un ciclo 'for'. Calculará el promedio y clasificará su estado:");
    Console.WriteLine(" - Promedio <= 4.5 mm/s : FUNCIONAMIENTO NORMAL DEL MOTOR");
    Console.WriteLine(" - Promedio > 4.5 mm/s  : EL MOTOR REQUIERE MANTENIMIENTO");
    Console.WriteLine("La repetición se controla mediante un ciclo 'while'. Al finalizar muestra el total");
    Console.WriteLine("de motores evaluados y el desglose de su estado.");
    Console.WriteLine("==================================================================================\n");

    // Variables de conteo global
    int totalMotores = 0;
    int motoresNormales = 0;
    int motoresMantenimiento = 0;

    // Variable de control para el ciclo while
    string respuesta = "S";

    // Ciclo while para evaluar múltiples motores
    while (respuesta.ToUpper() == "S")
    {
        Console.Write("Ingrese el nombre del motor: ");
        string nombreMotor = Console.ReadLine();

        double sumaVibraciones = 0;

        // Ciclo for para solicitar las 4 mediciones requeridas
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"  Ingrese la medición de vibración #{i} (en mm/s): ");
            double medicion = double.Parse(Console.ReadLine());
            sumaVibraciones += medicion;
        }

        // Cálculo del promedio
        double promedio = sumaVibraciones / 4.0;
        totalMotores++;

        // Evaluación y clasificación según criterio de diseño
        Console.WriteLine($"\n--> Motor: {nombreMotor}");
        Console.WriteLine($"--> Vibración Promedio: {promedio:F2} mm/s");

        if (promedio <= 4.5)
        {
            Console.WriteLine("--> Estado: FUNCIONAMIENTO NORMAL DEL MOTOR\n");
            motoresNormales++;
        }
        else
        {
            Console.WriteLine("--> Estado: EL MOTOR REQUIERE MANTENIMIENTO\n");
            motoresMantenimiento++;
        }

        // Control de ciclo para preguntar al usuario si desea continuar
        Console.Write("¿Desea analizar otro motor? (S/N): ");
        respuesta = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------------------------------------");
    }

    // Muestra de resultados finales
    Console.WriteLine("\n==================================================================================");
    Console.WriteLine("                             RESUMEN FINAL DE EVALUACIÓN                           ");
    Console.WriteLine("==================================================================================");
    Console.WriteLine($"a) Total de motores evaluados: {totalMotores}");
    Console.WriteLine($"b) Cantidad de motores con funcionamiento normal: {motoresNormales}");
    Console.WriteLine($"c) Cantidad de motores que requieren mantenimiento: {motoresMantenimiento}");
    Console.WriteLine("==================================================================================");
    Console.WriteLine("\nPresione cualquier tecla para salir...");
    Console.ReadKey();
}