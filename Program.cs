using System;
using System.Text.Json;
using System.Collections.Generic;

const string NombreArchivo = "index.json";
//obteniendo archivo del directorio
Console.WriteLine("Seleccion archivos del directorio elegido:");
string rutaDArchivo = @"C:\Users\USUARIO\Desktop\DirectorioTP8\";
string[] files = ARCHIVO.Obtener(rutaDArchivo);
List<List<string>> listaDlistArch= ARCHIVO.GuardarLista(files);
Console.WriteLine("Muestra de los datos en la lista");
ARCHIVO.MostrarLista(listaDlistArch);

var miHelperdeArchivos = new HelperDeJson();

//Guardo el archivo
Console.WriteLine("--Serializando--");
string ArchivoJson = JsonSerializer.Serialize(listaDlistArch);
Console.WriteLine("Archivo Serializado : " + ArchivoJson);
Console.WriteLine("--Guardando--");
miHelperdeArchivos.GuardarArchivoTexto(NombreArchivo, ArchivoJson);

//Abro el Archivo
Console.WriteLine("--Abriendo--");
string jsonDocument = miHelperdeArchivos.AbrirArchivoTexto(NombreArchivo);
Console.WriteLine("--Deserializando--");
var listadoArchivoRecuperado = JsonSerializer.Deserialize<List<List<string>>>(jsonDocument);
Console.WriteLine("--Mostrando datos recuperardos--");
ARCHIVO.MostrarLista(listadoArchivoRecuperado);