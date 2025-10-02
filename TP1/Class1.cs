using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{

    public class Enemigo
    {
        // Atributos privados
        private int id;
        private string nombre;
        private string descripcion;
        private int ataque;
        private int defensa;
        private int hp;


        public Enemigo(int id, string nombre, string descripcion, int ataque, int defensa, int hp)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ataque = ataque;
            this.defensa = defensa;
            this.hp = hp;
        }

        //get y set

        public string Nombre
        {
            get { return nombre; }
            set {  nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int Ataque
        {
            get { return ataque; }
            set { ataque = value; }
        }

        public int Defensa
        {
            get { return defensa; }
            set { defensa = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { hp = value; }
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {id} | Nombre: {nombre} | HP: {hp} | Ataque: {ataque} | Defensa: {defensa} | Descripción: {descripcion}");
        }

        public void RecibirDaño(int daño)
        {
            hp -= daño;
            if (hp < 0)
            {
                hp = 0;

            }

            Console.WriteLine($"{nombre} recibió {daño} de daño. HP restante: {hp}");
        }

        public bool EstaVivo()
        {
            return hp > 0;
        }

    }

}
