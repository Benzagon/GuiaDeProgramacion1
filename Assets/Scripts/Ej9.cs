//9. Realizá un programa que resuelva el siguiente problema:
//Tres personas aportan diferente capital a una sociedad.Se desea saber qué porcentaje del
//total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado
//por las tres.
//Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego
//mostrar lo pedido en el siguiente formato:
//Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ ….
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej9 : MonoBehaviour
{
    public float cap1, cap2, cap3;
    
    public string name1, name2, name3;

    void Start()
    {
        float capTotal = cap1 + cap2 + cap3;

        Debug.Log("Nombre: " + name1 + ", Capital aportado: $" + cap1 + ", Porcentaje del capital: " + ((cap1 / capTotal) * 100) + "%, Monto total aportado: $" + capTotal);
        Debug.Log("Nombre: " + name2 + ", Capital aportado: $" + cap2 + ", Porcentaje del capital: " + ((cap2 / capTotal) * 100) + "%, Monto total aportado: $" + capTotal);
        Debug.Log("Nombre: " + name3 + ", Capital aportado: $" + cap3 + ", Porcentaje del capital: " + ((cap3 / capTotal) * 100) + "%, Monto total aportado: $" + capTotal);
    }

    void Update()
    {
        
    }
}
