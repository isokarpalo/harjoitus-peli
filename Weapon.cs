namespace harkkaC1
{
    public class Weapon //luodaan luokka ase ja sille arvot
    {
        private string name;
        private int attack;
        private int defence;
        private bool isBroken;

        //luodaan getterit ja setterit arvoille
        public string GetName()
        {
            return name;
        }
        public void SetName(string newName)
        {
            name = newName;
        }
        public int GetAttack()
        {
            return attack;
        }
        public void SetAttack(int newAttack)
        {
            attack = newAttack;
        }
        public int GetDefence()
        {
            return defence;
        }
        public void SetDefence(int newDefence)
        {
            defence = newDefence;
        }
        private void SetIsBroken(bool brokenVal)
        {
            isBroken = brokenVal;  
        }
        public bool IsBroken() {
            return isBroken;
        }

        //luodaan Init-metodi, jolla alustetaan arvot (kutsutaan character-luokassa)
        public void Init()
        {
            SetName("Dragon Slayer");
            SetAttack(Die.Roll1d20());
            SetDefence(Die.Roll1d6());
            SetIsBroken(false);
        }
    }
}