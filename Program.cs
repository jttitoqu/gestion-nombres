List<string> listaNombres = new List<string>();

//Agregar un nombre
listaNombres.Add("Johann");
listaNombres.Add("Maria");
listaNombres.Add("Ttito");

//Eliminar un nombre
listaNombres.Remove("jorge");

//Buscar un nombre
BuscarNombre("Johann");


//Ordenar alfabeticamente
listaNombres.Sort();

//Mostrar todos los nombres 
Console.WriteLine(string.Join(", ", listaNombres));



void BuscarNombre(string nombre)
{
    if (listaNombres.Contains(nombre))
    {
        Console.WriteLine("Si existe el nombre en la lista");
    }else
    {
        Console.WriteLine("No existe el nombre en la lista");
    }

}