using System;
using NUnit.Framework;

namespace Gun_Master_9000{
    [TestFixture]
  class UnitTests {
      [Test, Description ("Character whithout Gun can´t shoot")]
      public void CharacterWithoutGunTest() {
          Character Pepe = new Character ("Pepe");
          Bug bug = new Bug();
          Exception ex = Assert.Throws<System.InvalidOperationException>(
              () => {
                Pepe.Shoot(null);
            }
          );
        }  
        [Test, Description("Character whith Gun and whitout target can't shoot")]
        public void CharacterNewGunTest() {
          Character Pepe = new Character ("Pepe");
          Gun revolver = new Gun ("rvolver", 6);
          Pepe.Equip(revolver);
          Exception ex = Assert.Throws<System.ArgumentException>(
              () => {
                Pepe.Shoot(null);
            }
          );
    }
    [Test, Description("Character whith Gun and whitout target can't Reload")]
    public void CharacterWhithoutReloadTest(){
      Character Pepe = new Character ("pepe");
      Gun revolver = new Gun("revolver",6);
      Pepe.Equip(revolver);
      Bug bug = new Bug();
      Pepe.Shoot(bug);
      Assert.That(bug.IsDead(), Is.EqualTo(false));
    
      Pepe.Reload();
      Pepe.Shoot(bug);
      Assert.That(bug.IsDead(), Is.EqualTo(true));
    }
}
}