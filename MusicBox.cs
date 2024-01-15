using System;
using System.Collections.Generic;
using System.Text;

namespace harkkaC1
{
    static class MusicBox
    {
        private static int C1 = 265;
        private static int D = 297;
        private static int Eb = 315;
        private static int E = 334;
        private static int F = 354;
        private static int Gb = 375;
        private static int G = 397;
        private static int A = 446;
        private static int H = 500;
        private static int C2 = 530;

        public static void PlayDramaticSound()
        {
            Console.Beep(Gb, 300);
            Console.Beep(Gb, 300);
            Console.Beep(Gb, 300);
            Console.Beep(Eb, 1200);

            Console.Beep(F, 300);
            Console.Beep(F, 300);
            Console.Beep(F, 300);
            Console.Beep(D, 1200);
        }

        public static void PlayUp()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int y = 2000; y < 4000; y += 100)
                {
                    Console.Beep(y, 100);
                }
            }
        }
        public static void PlaySadSound()
        {
            Console.Beep(3000, 500);
            Console.Beep(2000, 1000);
        }
    }
}

