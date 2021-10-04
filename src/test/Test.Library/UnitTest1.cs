using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {

        [Test]
        public void TestCreationCharacter()
        {
            Dwarf gimli = new Dwarf("Gimli");
            int DefenseExpected = 18;
            Assert.AreEqual(DefenseExpected, gimli.DefenseValue);
            int DamageExpected = 25;
            Assert.AreEqual(DamageExpected, gimli.AttackValue);
            Axe axe = new Axe();
            Helmet helmet = new Helmet();
            gimli.AddItem(axe);
            gimli.AddItem(helmet);
            DefenseExpected = 36;
            Assert.AreEqual(DefenseExpected, gimli.DefenseValue);
            DamageExpected = 50;
            Assert.AreEqual(DamageExpected, gimli.AttackValue);
            gimli.RemoveItem(axe);
            gimli.RemoveItem(helmet);
            DefenseExpected = 18;
            Assert.AreEqual(DefenseExpected, gimli.DefenseValue);
            DamageExpected = 25;
            Assert.AreEqual(DamageExpected, gimli.AttackValue);
           
            

            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);
            int WizDamageExpected = 240;
            Assert.AreEqual(WizDamageExpected, gandalf.AttackValue);
            int WizDefenseExpected = 240;
            Assert.AreEqual(WizDefenseExpected, gandalf.DefenseValue);
            gandalf.AddItem(axe);
            gandalf.AddItem(helmet);
            WizDamageExpected = 265;
            Assert.AreEqual(WizDamageExpected, gandalf.AttackValue);
            WizDefenseExpected = 258;
            Assert.AreEqual(WizDefenseExpected, gandalf.DefenseValue);
            gandalf.RemoveItem(axe);
            gandalf.RemoveItem(helmet);
            WizDamageExpected = 240;
            Assert.AreEqual(WizDamageExpected, gandalf.AttackValue);
            WizDefenseExpected = 240;
            Assert.AreEqual(WizDefenseExpected, gandalf.DefenseValue);
            
            
            



        }
    }
}