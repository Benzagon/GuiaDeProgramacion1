﻿//11. Realizá un programa que resuelva el siguiente problema:
//Deberá ingresarse por Inspector una fecha de compra(String en el siguiente formato:
//YYYYMMDD), un nombre de comprador, un nombre de producto y una cantidad y precio del
//producto comprado.Mostrá a modo de ticket, la información ingresada y el monto a pagar.
//Modelo de Ticket:
//Fecha de Compra: YYYYMMDD
//Nombre del Comprador: xxxxx xxxxx
//Producto solicitado: xxxxx
//Cantidad solicitada: xx
//Precio Unitario: $xxx
//Total a Pagar: $xxxxx

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej11 : MonoBehaviour
{
    public string fechaCompra, nombreComprador, nombreProducto;
    public int cantProducto;
    public float precioProducto;
        
    void Start()
    {
        float precioTotal = precioProducto * cantProducto;

        Debug.Log("Fecha de Compra: " + fechaCompra + " Nombre del Comprador: " + nombreComprador );
    }

    void Update()
    {
        
    }
}
