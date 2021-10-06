namespace RoleplayGame
{
    /*public interface IMagicCharacter: Character
    {
        void AddItem(IMagicalItem item);

        void RemoveItem(IMagicalItem item);
    }*/

    public abstract class MagicCharacter: Character
    {
         protected MagicCharacter(string name)
         :base(name)
            {
                this.Name = name;
            }


            public abstract void AddItem(IMagicalItem item);
            
            public abstract void RemoveItem(IMagicalItem item);

    }


}



