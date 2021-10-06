namespace RoleplayGame
{
    /*public interface ICharacter
    {
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        void Cure();

        void ReceiveAttack(int power);
    }*/


    public abstract class Character
        {
            protected Character(string name)
            {
                this.Name = name;
            }

            public string Name { get; set; }

            public int Health { get; }

            public int AttackValue { get; }

            public int DefenseValue { get; }

            public int VictoryPoints { get; set; }


            public abstract void AddItem(IItem item);  

            public abstract void RemoveItem(IItem item);

            public abstract void Cure();

            public abstract void ReceiveAttack(int power, int vp);

        
        }
}
