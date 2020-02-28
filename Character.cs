using System;

namespace  Gun_Master_9000
{
    class Character{
        public string Name;

        public Gun gun;

        public Character(string Name){
            this.Name = Name;
        }
        public void Equip(Gun gun){
            this.gun = gun;
        }
        public void Shoot(Target target){
            if(this.gun == null){
                throw new System.InvalidOperationException("character can't Shoot");
            }
            try{
                this.gun.Shoot(target);
            } catch (InvalidOperationException ex) {
                Console.WriteLine("*GUN CLICKS*");

            }
        }
        
    }
}