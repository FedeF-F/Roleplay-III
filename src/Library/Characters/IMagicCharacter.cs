namespace RoleplayGame
{
    /*public interface IMagicCharacter: Character
    {
        void AddItem(IMagicalItem item);

        void RemoveItem(IMagicalItem item);
    }*/

    public abstract class MagicCharacter
    {
         protected MagicCharacter(string name)
            {
                this.Name = name;
            }

            public string Name { get; set; }

            public int Health { get; }

            public int AttackValue { get; }

            public int DefenseValue { get; }

            public abstract void AddItem(IItem item);  

            public abstract void RemoveItem(IItem item);

            public abstract void Cure();

            public abstract void ReceiveAttack(int power);

            public abstract void AddItem(IMagicalItem item);
            
             public abstract void RemoveItem(IMagicalItem item);

    }


}



