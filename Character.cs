using System;
using System.Collections.Generic;
using System.Text;

namespace harkkaC1
{
    class Character
    {
        public Weapon w = null;

        //näiden ominaisuuksien lähtötaso 0 (ellei ole edennyt pelissä)
        //jos onnistuu pelissä niin näiden kasvatus taistelussa
        private int xp;
        private int level;

        //nämä ominaisuudet kysytään pelaajalta
        private string name;
        private string playerName;
        private int armorClass;

        //nämä ominaisuudet satunnaisesti
        private string background;
        private string alignment;
        private string adventuringGroup;
        private int speed;
        private int vision;
        private int initiative;

        //nämä ominaisuudet arvotaan nopilla
        private int strength;
        private int dexterity;
        private int constitution;
        private int intelligence;
        private int wisdom;
        private int charisma;
        private int hp;

        public void Init()
        {
            w = new Weapon(); //luodaan olio w (weapon)
            w.Init(); //kutsutaan aseen Init-metodia, jotta saadaan w:lle arvot

            SetStrenght(Die.Roll1d20());
            SetDexterity(Die.Roll1d20());
            SetConstitution(Die.Roll1d20());
            SetIntelligence(Die.Roll1d20());
            SetWisdom(Die.Roll1d20());
            SetCharisma(Die.Roll1d20());
            SetHp(Die.Roll1d20() + Die.Roll1d20() + Die.Roll1d20());
        }
        
        public void FillInRest()
        {
            Init();
            if (GetName() == null && GetName().Length == 0)
            {
                SetName("Hero");
            }
            if (GetPlayerName() == null && GetPlayerName().Length == 0)
            {
                SetPlayerName("Player");
            }
            if (GetArmorClass() == 0)
            {
                SetArmorClass(Die.Roll1d6());
            }
        }
        public string GetName()
        {
            if (name != null && name.Length != 0)
            {
                return name;
            }
            else
            {
                return "Name not set yet";
            }
        }
        public void SetName(string newName)
        {
            if (newName.Length != 0)
            {
                name = newName;
            }
        }

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel(int newLevel)
        {
            if (newLevel > 0) //jos level > 0, se päivittyy
            {
                level = newLevel;
            }
            else //jos leveliä ei ole, se on 0 (lähtötaso)
            {
                level = 0;
            }
        }
        public int GetXp()
        {
            return xp;
        }

        public void SetXp(int newXp)
        {
            if (newXp > 0) //jos xp > 0, se päivittyy
            {
                xp = newXp;
            }
            else //jos xp:tä ei ole, se on 0 (lähtötaso)
            {
                xp = 0;
            }
        }
        public string GetPlayerName()
        {
            return playerName;
        }
        public void SetPlayerName(string newPlayerName)
        {
            playerName = newPlayerName;
        }

        public int GetArmorClass()
        {
            return armorClass;
        }
        public void SetArmorClass(int newArmorClass)
        {
            armorClass = newArmorClass;
        }

        public string Background { get => background; set => background = value; }
        public string Alignment { get => alignment; set => alignment = value; }
        public string AdventuringGroup { get => adventuringGroup; set => adventuringGroup = value; }
        public int Speed { get => speed; set => speed = value; }
        public int Vision { get => vision; set => vision = value; }
        public int Initiative { get => initiative; set => initiative = value; }

        public int GetStrength()
        {
            return strength;
        }
        public void SetStrenght(int newStrength)
        {
            strength = newStrength;
        }

        public int GetDexterity()
        {
            return dexterity;
        } 

        public void SetDexterity(int newDexterity)
        {
            dexterity = newDexterity;
        }

        public int GetConstitution()
        {
            return constitution;
        }

        public void SetConstitution(int newConstitution)
        {
            constitution = newConstitution;
        }
        public int GetIntelligence()
        {
            return intelligence;
        }

        public void SetIntelligence(int newIntelligence)
        {
            intelligence = newIntelligence;
        }

        public int GetWisdom()
        {
            return wisdom;
        }

        public void SetWisdom(int newWisdom)
        {
            wisdom = newWisdom;
        }

        public int GetCharisma()
        {
            return charisma;
        }

        public void SetCharisma(int newCharisma)
        {
            charisma = newCharisma;
        }

        public void SetHp(int newHp)
        {
            hp = newHp;
        }
        public int GetHp()
        {
            return hp;
        }
    }
}
