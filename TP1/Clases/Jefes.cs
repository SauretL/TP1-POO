using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Clases
{
    public class Jefes : Enemigos
    {
        // Atributos privados
        private string habilidadEspecial;
        private int dañoEspecial;
        private int fasesHP;

        public Jefes(int id, string nombre, string descripcion, int ataqueFisico, int ataquePsiquico, int defensaFisica, 
            int defensaPsiquica,int hp, int maxHp, string habilidadEspecial, int dañoEspecial, int fasesHP)
            : base(id, nombre, descripcion, ataqueFisico, ataquePsiquico,
            defensaFisica, defensaPsiquica, maxHp, hp)
        {
            this.habilidadEspecial = habilidadEspecial;
            this.dañoEspecial = (ataqueFisico + ataquePsiquico) / 2;
            this.fasesHP = fasesHP;
        }

        // get y sets

        public string HabilidadEspecial
        {
            get { return habilidadEspecial; }
            set { habilidadEspecial = value; }
        }

        public int DañoEspecial
        {
            get { return dañoEspecial; }
            set { dañoEspecial = value; }
        }

        public int FasesHP
        {
            get { return fasesHP; }
            set { fasesHP = value; }
        }

        //metodos

        public void UsarHabilidadEspecial()
        {
            Console.WriteLine($"{Nombre} usa {habilidadEspecial}!");
        }

        public void CambiarFase()
        {
            if (fasesHP > 1 && Hp == 0)
            {
                fasesHP = fasesHP - 1;
                Hp = MaxHp;
                Console.WriteLine($"{Nombre} cambia de fase!"
                                  + " ¡Se vuelve más fuerte!");
            }
        }


    }


}
