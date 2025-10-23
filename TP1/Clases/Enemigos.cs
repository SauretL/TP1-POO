using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Clases
{

    public class Enemigos
    {
        // Atributos privados
        private int id;
        private string nombre;
        private string descripcion;
        private int ataqueFisico;
        private int ataquePsiquico;
        private int defensaFisica;
        private int defensaPsiquica;
        private int hp;
        private int maxHp;


        public Enemigos(int id, string nombre, string descripcion, int ataqueFisico, int ataquePsiquico, int defensaFisica, 
            int defensaPsiquica, int hp, int maxHp)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.ataqueFisico = ataqueFisico;
            this.ataquePsiquico = ataquePsiquico;
            this.defensaFisica = defensaFisica;
            this.defensaPsiquica = defensaPsiquica;
            this.hp = hp;
            this.maxHp = maxHp;
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

        public int AtaqueFisico
        {
            get { return ataqueFisico; }
            set { ataqueFisico = value; }
        }

        public int AtaquePsiquico
        {
            get { return ataquePsiquico; }
            set { ataquePsiquico = value; }
        }

        public int DefensaFisica
        {
            get { return defensaFisica; }
            set { defensaFisica = value; }
        }

        public int DefensaPsiquica
        {
            get { return defensaPsiquica; }
            set { defensaPsiquica = value; }
        }

        public int Hp
        {
            get { return hp; }
            set { if (value < 0)
                {
                    hp = 0;
                } else
                    hp = value; }
        }

        //metodos

        public void MostrarInfo()
        {
            Console.WriteLine($"ID: {id} | Nombre: {nombre} | HP: {hp}/{maxHp} | Ataque Fisico: {ataqueFisico} " +
                $"| Ataque Psiquico: {ataquePsiquico} | Defensa Fisica: {defensaFisica} | DefensaPsiquica: {defensaPsiquica} " +
                $"| Descripción: {descripcion}");
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

        public int daño(int ataque, int defensa)
        {
            int dañoTotal = ataque - defensa;
            if (dañoTotal < 0) {
                dañoTotal = 0;
            }
            return dañoTotal;
                    
        }

    }

}
