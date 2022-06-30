using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
public class ARCHIVO
{
    public static string[] Obtener(string rutaDArchivo)
    {
        string[] list = Directory.GetFiles(rutaDArchivo); 
        return list;
    }
    public static List<List<string>> GuardarLista(string[] lista)
    {
        int numRegistro=0;
        List<List<string>> listaDArchivo = new List<List<string>>();
        foreach (string dir in lista)
        { 
            numRegistro++;
            string[] linea = dir.Split('.');//separamos la ruta en arreglo respecto al punto
            int a=linea.Length;//contamos la cantidad de elementos en el arreglo
            List<string> fila=new List<string>();
            fila.Add(numRegistro.ToString());
            fila.Add(linea[a-2]);
            fila.Add(linea[a-1]);
            listaDArchivo.Add(fila);
        }
        return listaDArchivo;
    }
    public static void MostrarLista(List<List<string>> listaA)
    {
        foreach (var item in listaA)
        {
            Console.Write("Registro: "+item[0]);
            Console.Write(" -- Ruta: "+item[1]);
            Console.WriteLine(" -- Extension: "+item[2]);
        }
    }

}