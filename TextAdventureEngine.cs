using System;
using System.Threading;

public class TextAdventureEngine 
{
    //Temporary Main to Compile Delete Later
    public static void Main(string[] args)
    {
        
         Monster Goblin = new Monster();
            Goblin.HP = 5;
            Goblin.AC = 7;
            Goblin.Name = "Goblin";
            Goblin.MonsterMove1.Name = "Slash";
            Goblin.MonsterMove1.MaxDamage = 4;
        
        Character Player = new Character();
        Player = CharacterFunctions.CharCreator();
        
        Console.WriteLine("Bloise:Im going to run you through some example combat to get you used to the system");
        
        CombatManager.StartCombat(Player, Goblin);
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
            
            //Assigns stats if InputCharacter is a Fighter
            if(OutputCharacter.CharClass == Classes.Fighter)
            {
                OutputCharacter.Move1.Name = "Sword Slash";
                OutputCharacter.Move1.MaxDamage = 8;
                
                OutputCharacter.Move2.Name = "Shield Bash";
                OutputCharacter.Move2.MaxDamage = 4;
                
                OutputCharacter.Move3.Name = "Rage";
                OutputCharacter.Move3.MaxDamage = 1000;
                
                OutputCharacter.Move4.Name = "Intimidate";
                OutputCharacter.Move4.MaxDamage = 0;
                
                OutputCharacter.QuestionText = "1:ShordSlash, 2: ShieldBash, 3:Rage 4: Intimidate";
                
                OutputCharacter.AC = 15;
                OutputCharacter.HP = 10;
            }
            
            //Assigns stats if InputCharacter is a Rogue
            if(OutputCharacter.CharClass == Classes.Rogue)
            {
                OutputCharacter.Move1.Name = "Slice";
                OutputCharacter.Move1.MaxDamage = 8;

                OutputCharacter.Move2.Name = "Poison Throw";
                OutputCharacter.Move2.MaxDamage = 4;
                
                OutputCharacter.Move3.Name = "Back Stab";
                OutputCharacter.Move3.MaxDamage = 1000;
                
                OutputCharacter.Move4.Name = "Stealth Disengage";
                OutputCharacter.Move4.MaxDamage = 0;
                
                
                
                OutputCharacter.QuestionText = "1:Slice, 2: PoisonThrow, 3:BackStab 4: StealthDisengage";
                
                OutputCharacter.AC = 8;
                OutputCharacter.HP = 7;
            }
            
            //Assigns stats if InputCharacter is a Mage
            if(OutputCharacter.CharClass == Classes.Mage)
            {
                OutputCharacter.Move1.Name = "Fire Ball";
                OutputCharacter.Move1.MaxDamage = 10;
                
                OutputCharacter.Move2.Name = "Frost Bolt";
                OutputCharacter.Move2.MaxDamage = 8;
                
                OutputCharacter.Move3.Name = "Unholy Devastation";
                OutputCharacter.Move3.MaxDamage = 1000;
                
                OutputCharacter.Move4.Name = "Teleport";
                OutputCharacter.Move4.MaxDamage = 0;
                
                OutputCharacter.QuestionText = "1:FireBall, 2:FrostBolt, 3:UnholyDevastation 4:Teleport";
                
                OutputCharacter.AC = 10;
                OutputCharacter.HP = 5;
            }
            
            //Assigns stats if InputCharacter is a Ranger
            if(OutputCharacter.CharClass == Classes.Ranger)
            {
                OutputCharacter.Move1.Name = "Bow Shot";
                OutputCharacter.Move1.MaxDamage = 8;
                
                OutputCharacter.Move2.Name = "Entangle";
                OutputCharacter.Move2.MaxDamage = 4;
                
                OutputCharacter.Move3.Name = "Tree Curse";
                OutputCharacter.Move3.MaxDamage = 1000;
                
                OutputCharacter.Move4.Name = "Stealth Escape";
                OutputCharacter.Move4.MaxDamage = 0;
                
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
        public string Name;
        
        public Move MonsterMove1 = new Move();
           
    }
    
    public class Move 
    {
        public string Name;
        public int MaxDamage;
    }
    //Contains Monster List 
    //Later Convert to a Mark Up Language
    public static class DefaultMonster
    {
        //Nested in a function because c# is d
    }
    
    //Combat Manager contains everything related to combat
    public class CombatManager 
    {
        public static string StartCombat(Character character, Monster monster)
        {
            bool InCombat = true;
            int MoveChosen;
            //Combat Variables For Monster
                int MonsterAC = monster.AC;
                int MonsterHP = monster.HP;
                string MonsterName = monster.Name;
                
            //Used to track current move data    
                Move CurrentMove = new Move();
            
            //Combat Variables For Monster
                int PlayerAC =  character.AC;
                int PlayerHP = character.HP;
                string PlayerName = character.Name;
                
            //Used as a RNG
                Random RNG = new Random();
                
            //intergers used to for AC
                int ToHit;
                int CalculatedDamage;
            //Combat Runner 
            while(InCombat)
            {
                Console.WriteLine("HP: " + PlayerHP);
                Console.WriteLine("-------------------- ");
                Console.WriteLine("Monster HP: " + MonsterHP);
                Console.WriteLine(" ");
                Console.WriteLine("Choose Move: " + character.QuestionText);
                
                MoveChosen = Int32.Parse(Console.ReadLine());
                
                //Sets Current Move equal to the move that goes with the number chosen
                switch(MoveChosen)
                {
                    case 1:
                        CurrentMove = character.Move1;
                        break;
                    case 2:
                        CurrentMove = character.Move2;
                        break;
                    case 3:
                        CurrentMove = character.Move3;
                        break;
                    case 4:
                        CurrentMove = character.Move4;
                        break;
                }
                
                //Determines If hit
                ToHit = RNG.Next(1,20);
                
                //Applys Damage if Hit
                if(ToHit>=MonsterAC)
                {
                    CalculatedDamage = RNG.Next(1, CurrentMove.MaxDamage);
                    MonsterHP-=CalculatedDamage;
                }
                
                if(MonsterHP<=0)
                {
                    InCombat = false;
                    return PlayerName +" has vanquished " + MonsterName;
                }
                
                CurrentMove = monster.MonsterMove1;
                
                //Checks if Enemy Hit Player
                ToHit = RNG.Next(1,20);
                
                //If Enemy hit player do damage
                if(ToHit>=PlayerAC)
                {
                   CalculatedDamage = RNG.Next(1, CurrentMove.MaxDamage);
                   PlayerHP-=CalculatedDamage; 
                }
                
                if(PlayerHP<=0)
                {
                    InCombat = false;
                    return MonsterName +" has vanquished " + PlayerName;
                }
            }
            return "Done";
        }
    }
}