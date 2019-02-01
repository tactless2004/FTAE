using System;

public class TextAdventureEngine 
{
    //Temporary Main to Compile Delete Later
    public static void Main(string[] args)
    {
        Character Player = new Character();
        Player = CharacterFunctions.CharCreator();
    }
    
    //Defines Class Type
    public enum Classes
    {
        Fighter = 1,
        Rogue = 2,
        Mage = 3,
        Ranger = 4
    }
    
    //Defines Character type with various variables
    public class Character 
    {
        public int HP;
        public int AC;
        public string Name;
        
        public Classes CharClass;
        
        public Move Move1 = new Move();
        public Move Move2 = new Move();
        public Move Move3 = new Move();
        public Move Move4 = new Move();
        
        public string QuestionText;
    }
    
    //Contains Functions realted to Character Management, and Character Creation
    public class CharacterFunctions 
    {
        //Call this function to create a character, returns OutputCharacter of type Character
        public static Character CharCreator () 
        {
            Character OutputCharacter = new Character();
            //I/O Character Creation Stuff
                //Name
                Console.WriteLine("!@#$%#@#: What is your Name, young travler");
                OutputCharacter.Name = Console.ReadLine();
            
                //Class
                Console.WriteLine("What is your expertise (1: Fighter, 2: Rogue, 3: Mage, 4: Ranger");
                OutputCharacter.CharClass = (Classes)Int32.Parse(Console.ReadLine());
                
                //Calls CharacterStatAssigner, and Assigns stats based on class
                OutputCharacter = CharacterStatAssigner(OutputCharacter);
                
                return OutputCharacter;
        }
        
        //This function is called by CharCreator to assign stats based on Class
        public static Character CharacterStatAssigner (Character InputCharacter)
        {
            Character OutputCharacter = new Character();
            OutputCharacter = InputCharacter;
            
            Console.WriteLine(OutputCharacter.CharClass);
            //Assigns stats if InputCharacter is a Fighter
            if(OutputCharacter.CharClass == Classes.Fighter)
            {
                OutputCharacter.Move1.Name = "Sword Slash";
                OutputCharacter.Move1.MaxDamage = 8;
                OutputCharacter.Move1.ToHit = 75;
                
                OutputCharacter.Move2.Name = "Shield Bash";
                OutputCharacter.Move2.MaxDamage = 4;
                OutputCharacter.Move2.ToHit = 60;
                
                OutputCharacter.Move3.Name = "Rage";
                OutputCharacter.Move3.MaxDamage = 1000;
                OutputCharacter.Move3.ToHit = 20;
                
                OutputCharacter.Move4.Name = "Intimidate";
                OutputCharacter.Move4.MaxDamage = 0;
                OutputCharacter.Move4.ToHit = 40;
                
                OutputCharacter.QuestionText = "1:ShordSlash, 2: ShieldBash, 3:Rage 4: Intimidate";
                
                OutputCharacter.AC = 15;
                OutputCharacter.HP = 10;
            }
            
            //Assigns stats if InputCharacter is a Rogue
            if(OutputCharacter.CharClass == Classes.Rogue)
            {
                OutputCharacter.Move1.Name = "Slice";
                OutputCharacter.Move1.MaxDamage = 8;
                OutputCharacter.Move1.ToHit = 75;
                
                OutputCharacter.Move2.Name = "Poison Throw";
                OutputCharacter.Move2.MaxDamage = 4;
                OutputCharacter.Move2.ToHit = 80;
                
                OutputCharacter.Move3.Name = "Back Stab";
                OutputCharacter.Move3.MaxDamage = 1000;
                OutputCharacter.Move3.ToHit = 20;
                
                OutputCharacter.Move4.Name = "Stealth Disengage";
                OutputCharacter.Move4.MaxDamage = 0;
                OutputCharacter.Move4.ToHit = 40;
                
                
                
                OutputCharacter.QuestionText = "1:Slice, 2: PoisonThrow, 3:BackStab 4: StealthDisengage";
                
                OutputCharacter.AC = 8;
                OutputCharacter.HP = 7;
            }
            
            //Assigns stats if InputCharacter is a Mage
            if(OutputCharacter.CharClass == Classes.Mage)
            {
                OutputCharacter.Move1.Name = "Fire Ball";
                OutputCharacter.Move1.MaxDamage = 10;
                OutputCharacter.Move1.ToHit = 50;
                
                OutputCharacter.Move2.Name = "Frost Bolt";
                OutputCharacter.Move2.MaxDamage = 8;
                OutputCharacter.Move2.ToHit = 60;
                
                OutputCharacter.Move3.Name = "Unholy Devastation";
                OutputCharacter.Move3.MaxDamage = 1000;
                OutputCharacter.Move3.ToHit = 20;
                
                OutputCharacter.Move4.Name = "Teleport";
                OutputCharacter.Move4.MaxDamage = 0;
                OutputCharacter.Move4.ToHit = 40;
                
                OutputCharacter.QuestionText = "1:FireBall, 2:FrostBolt, 3:UnholyDevastation 4:Teleport";
                
                OutputCharacter.AC = 10;
                OutputCharacter.HP = 5;
            }
            
            //Assigns stats if InputCharacter is a Ranger
            if(OutputCharacter.CharClass == Classes.Ranger)
            {
                OutputCharacter.Move1.Name = "Bow Shot";
                OutputCharacter.Move1.MaxDamage = 8;
                OutputCharacter.Move1.ToHit = 50;
                
                OutputCharacter.Move2.Name = "Entangle";
                OutputCharacter.Move2.MaxDamage = 4;
                OutputCharacter.Move2.ToHit = 60;
                
                OutputCharacter.Move3.Name = "Tree Curse";
                OutputCharacter.Move3.MaxDamage = 1000;
                OutputCharacter.Move3.ToHit = 20;
                
                OutputCharacter.Move4.Name = "Stealth Escape";
                OutputCharacter.Move4.MaxDamage = 0;
                OutputCharacter.Move4.ToHit = 40;
                
                OutputCharacter.QuestionText = "1:BowShot, 2:Entangle, 3:TreeCurse 4:StealthEscape";
                
                OutputCharacter.AC = 5;
                OutputCharacter.HP = 7;
            }
            
            
            
            return OutputCharacter;
        }
        
        
    }
    
    //Defines Monster type with various variables
    public class Monster
    {
        public int HP;
        public int AC;
        public int Name;
        public string AttackName;
        public string AttackToHit;
        public string AttackDamageMax;
    }
    
    public class Move 
    {
        public string Name;
        public int ToHit;
        public int MaxDamage;
    }
    //Contains Monster List 
    //Later Convert to a Mark Up Language
    public class MonsterList
    {
      
    }
    
    //Combat Manager contains everything related to combat
    public class CombatManager 
    {
        public static string StartCombat(Character character, Monster monster)
        {
            char[] AttackDelimiter = {' '};
            bool InCombat = true;
            int MoveChosen;
            
            while(InCombat)
            {
                Console.WriteLine("HP: " + character.HP);
                Console.WriteLine("Monster HP: " + monster.HP);
                Console.WriteLine("Choose Move: " + character.QuestionText);
                
                MoveChosen = Int32.Parse(Console.ReadLine());
                
                //Do Character Attack
                
                //Check if Enemey Dead
                
                //Get Enemy Attack
                
                //Do Enemy Attack
                
                //Check if Enemy Dead
                
                //If one is dead return death message
                return "Done";
            }
            return "Done";
        }
    }
}