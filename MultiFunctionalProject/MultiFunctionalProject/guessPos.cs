using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab01Deneme
{
    public class guessPos
    {
        public guessPos() { }
        //public static int[,] map = new int[1024, 1024];
        public int sag_sınır;
        public int sol_sınır;
        public int ust_sınır;
        public int alt_sınır;
        //int index1, index2;

        
        //public void CreatMap()
        //{
        //    for (int i = 0; i < 1024; i++)
        //    {
        //        for (int j = 0; j < 1024; j++)
        //        {
        //            map[i,j] = new int();
        //            map[i, j] = 1;
        //        }
        //    }
        //}

        public void guess_first()
        {
                sag_sınır = 1024;
                sol_sınır = 0;
                ust_sınır = 0;
                alt_sınır = 1024;
                Random Rnd = new Random();
                Map.index1 = Rnd.Next(ust_sınır, alt_sınır);
                Map.index2 = Rnd.Next(sol_sınır, sag_sınır);
            

        }
        public void guess_right()
        {
                sol_sınır = Map.index2;
                Random Rnd = new Random();
                Map.index2 = Rnd.Next(sol_sınır + 1, sag_sınır);
            
        }
        public void guess_left()
        {
            sag_sınır = Map.index2;
            Random Rnd = new Random();
            Map.index2 = Rnd.Next(sol_sınır, sag_sınır-1);
            

        }
        public void guess_up()
        {
            
            alt_sınır = Map.index1;
            Random Rnd = new Random();
            Map.index1 = Rnd.Next(ust_sınır, alt_sınır-1);
            

        }
        public void guess_down()
        {

            ust_sınır = Map.index1;
            Random Rnd = new Random();
            Map.index1 = Rnd.Next(ust_sınır+1, alt_sınır);
             

        }
        public void guess_rightup()
        {
            sol_sınır = Map.index2;
            alt_sınır = Map.index1;
            Random Rnd = new Random();
            Map.index1 = Rnd.Next(ust_sınır, alt_sınır-1);
            Map.index2 = Rnd.Next(sol_sınır+1, sag_sınır);


        }
        public void guess_rightdown()
        {
            sol_sınır = Map.index2;
            ust_sınır = Map.index1;
            Random Rnd = new Random();
            Map.index1 = Rnd.Next(ust_sınır+1, alt_sınır);
            Map.index2 = Rnd.Next(sol_sınır+1, sag_sınır);

        }
        public void guess_leftup()
        {
            sag_sınır = Map.index2;
            alt_sınır = Map.index1;
            Random Rnd = new Random();
            Map.index1 = Rnd.Next(ust_sınır, alt_sınır-1);
            Map.index2 = Rnd.Next(sol_sınır, sag_sınır-1);


        }
        public void guess_leftdown()
        {
            sag_sınır = Map.index2;
            ust_sınır = Map.index1;
            Random Rnd = new Random();
            Map.index1 = Rnd.Next(ust_sınır+1, alt_sınır);
            Map.index2 = Rnd.Next(sol_sınır, sag_sınır-1);


        }
    }

}
