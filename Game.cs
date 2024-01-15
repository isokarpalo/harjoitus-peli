using System;
using System.Collections.Generic;
using System.Text;

namespace harkkaC1
{
    class Game
    {
        UI ui = new UI();
        Character hero, villain;

        public void Start()
        {
            //muodostetaan oliot hero ja villain
            hero = new Character();
            villain = new Character();
            ui.AskCharacterStats(ref hero);
            hero.FillInRest();
            villain.Init();

            //taistelu
            Console.WriteLine("You meet a villain. Do you want to battle? (y/n)");
            string battle = Console.ReadLine();
            Console.WriteLine("Name is " + hero.GetName());
            Console.WriteLine("Player name is " + hero.GetPlayerName());
            Console.WriteLine(hero.GetName() + "'s HP is " + Convert.ToString(hero.GetHp()));
            Console.WriteLine("Villain's HP is " + Convert.ToString(villain.GetHp()));
            Console.WriteLine(hero.GetName() + "'s weapon's attack is " + Convert.ToString(hero.w.GetAttack()));
            Console.WriteLine("Villain's weapons's attack is " + Convert.ToString(villain.w.GetAttack()));
            if (battle == "y" || battle == "Y") //jos taistellaan
            {
                Console.WriteLine("Battle starts");
                MusicBox.PlayDramaticSound();

                //Taistelu jatkuu, kunnes jomman kumman HP on 0 tai alle. Hp vähenee aseen (Attack - Defence) verran.
                while ((villain.GetHp() > 0) && (hero.GetHp() > 0))
                {
                    villain.SetHp(villain.GetHp() - (hero.w.GetAttack() - villain.w.GetDefence()));
                    hero.SetHp(hero.GetHp() - (villain.w.GetAttack() - hero.w.GetDefence()));
                    Console.WriteLine("Villain hits and " + hero.GetName() + "'s HP is " + Convert.ToString(hero.GetHp()));
                    Console.WriteLine(hero.GetName() + " hits and villain's HP is " + Convert.ToString(villain.GetHp()));
                }
                if (villain.GetHp() <= 0) //jos villain kuolee
                {
                    Console.WriteLine("Villain died. " + hero.GetName() + " got 500 XP.");
                    hero.SetXp(hero.GetXp() + 500);
                    MusicBox.PlayUp();
                    Console.WriteLine(hero.GetName() + " has " + hero.GetHp() + " HP.");
                }
                else if (hero.GetHp() <= 0) //jos hero kuolee
                {
                    Console.WriteLine(hero.GetName() + " died.");
                    MusicBox.PlaySadSound();
                }
            }
            else //jos ei taistella niin paetaan
            {
                Console.Write("Flee!");
            }
        }
    }
}