using System.Collections.Generic;
namespace RoleplayGame
{
    public class Enemy: Character
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Enemy(string name)
        :base(name)
        {
            
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }

        public new string Name { get; set; }
        
        public new int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }

         public int VPGiven
        {
            get
            {
                int value = 1;
                return value;
            }
        }

        public new int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public new int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public override void ReceiveAttack(int power, int vp)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
                if (this.health <= 0)
                {
                    vp += this.VPGiven;
                }
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }

        public override void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
    }
}