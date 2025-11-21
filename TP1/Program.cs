using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Xml.Linq;
using TP1.Clases;
using static System.Runtime.InteropServices.JavaScript.JSType;

/* Desafío: Crea tu propia clase
           Deberán elegir un concepto del mundo real o ficticio que les interese y modelarlo como una clase.Pueden elegir cualquier tema: un PersonajeDeVideojuego, un Auto, una RecetaDeCocina, una MascotaVirtual o ¡lo que se les ocurra! La creatividad es bienvenida. El objetivo es que diseñen e implementen una clase desde cero, aplicando las buenas prácticas que hemos visto en clase.
Requisitos Indispensables
Para que el ejercicio sea válido, la clase que creen debe cumplir con las siguientes condiciones sin excepción:
           Atributos Privados: Todos los atributos de la clase deben ser declarados como privados.Esto es clave para garantizar el encapsulamiento y proteger el estado interno del objeto.
Método Constructor:
Deben implementar un constructor que se encargue de inicializar los atributos del objeto.
Si lo consideran necesario para su modelo, pueden inicializar algún atributo con un valor constante o por defecto directamente en el constructor(por ejemplo, un nivel que siempre empieza en 1).
Métodos Getters y Setters:
No todos los atributos necesitan ser modificables.Deberán crear métodos get(para obtener el valor) y set(para modificar el valor) únicamente para los atributos que consideren que deben ser accesibles o modificables desde fuera de la clase.
¡Punto extra! 💡 Si implementan alguna validación simple dentro de un método set(por ejemplo, que la vida de un personaje no pueda ser negativa), será muy valorado.
Métodos Propios:
Aquí es donde su clase cobra vida.Deben crear al menos cuatro métodos propios que representen comportamientos o acciones que un objeto de su clase pueda realizar.
Por ejemplo, si la clase es PersonajeDeVideojuego, los métodos podrían ser atacar(enemigo) y subirDeNivel(). Si es RecetaDeCocina, podrían ser agregarIngrediente(ingrediente) y verificarCalorias().
¡Punto extra! 💡  Usar stringbuilder para los métodos que retornen string en lugar de retornar una cadena de texto simple.

Programa de Prueba(Consola):
Para verificar que todo funciona correctamente, deberán crear un archivo principal o proyecto de consola.
En este archivo, deben:
           Crear al menos dos objetos(instancias) diferentes de su clase.
Utilizar los métodos set para modificar el estado de alguno de los objetos.
Utilizar los métodos get para mostrar por consola los datos de los objetos.
Llamar a los métodos propios de cada objeto y mostrar los resultados de sus acciones en la consola. */

namespace TP1
{


    // enemigos

    internal class Program
    {

        static void Main(string[] args)
        {
             Enemigos goblin = new Enemigos(1, "Goblin", "Un monstruo pequeño y molesto", 15, 5, 5, 2, 0, 50);
             Enemigos ogro = new Enemigos(2, "Ogro", "Una bestia enorme y fuerte", 30, 15, 10, 5, 0, 120);
             Jefes boss = new Jefes(3, "Boss", "El jefe de todos los enemigos", 40, 30, 12, 10, 0, 100, "Onda de fuego", 0, 3);

             while (ogro.EstaVivo() && goblin.EstaVivo())
             {

                 Console.WriteLine("=== ENEMIGOS CREADOS ===");
                 goblin.MostrarInfo();
                 ogro.MostrarInfo();
                 boss.MostrarInfo();

                 int daño1 = goblin.daño(ogro.AtaqueFisico, goblin.DefensaFisica);
                 int daño2 = ogro.daño(goblin.AtaquePsiquico, goblin.DefensaPsiquica);
                 int daño3 = goblin.daño(ogro.AtaqueFisico, goblin.DefensaFisica);

                 Console.WriteLine("\n=== COMBATE ===");
                 goblin.RecibirDaño(daño1);
                 ogro.RecibirDaño(daño2);
                 goblin.RecibirDaño(daño3);

                 Console.WriteLine($"\n¿El goblin está vivo? {goblin.EstaVivo()}");
                 Console.WriteLine($"¿El ogro está vivo? {ogro.EstaVivo()}");

                 Console.ReadLine();
             }
        } 

        }
    }

