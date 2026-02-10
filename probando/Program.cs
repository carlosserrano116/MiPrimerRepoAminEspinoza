// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

// Cargar configuración desde appsettings.json
var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Obtener cadenas de conexión
var defaultConnection = config.GetConnectionString("DefaultConnection");
var secondaryConnection = config.GetConnectionString("SecondaryConnection");

Console.WriteLine("=== Simulación de Cadenas de Conexión ===");
Console.WriteLine($"Conexión Principal: {defaultConnection}");
Console.WriteLine($"Conexión Secundaria: {secondaryConnection}");
Console.WriteLine("\nHola desde Platzi!");
