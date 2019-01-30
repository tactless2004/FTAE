using System;

public class TextAdventureEngine 
{
    //Temporary Main to Compile Delete Later
    public static void Main(string[] args)
    {
        CharacterFunctions.CharCreator();
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
        
        public string Move1;
        public string Move2;
        public string Move3;
        public string Move4;
        
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
            if(InputCharacter.CharClass == Classes.Fighter)
            {
                OutputCharacter.Move1 = "SwordSlash 8 75";  
                OutputCharacter.Move2 = "ShieldBash 4 60";
                OutputCharacter.Move3 = "Rage 1000 20%";
                OutputCharacter.Move4 = "Intimidate 0 40";
                
                OutputCharacter.QuestionText = "1:ShordSlash, 2: ShieldBash, 3:Rage 4: Intimidate";
                
                OutputCharacter.AC = 15;
                OutputCharacter.HP = 10;
            }
            
            //Assigns stats if InputCharacter is a Rogue
            if(InputCharacter.CharClass == Classes.Rogue)
            {
                OutputCharacter.Move1 = "Slice 8 75";  
                OutputCharacter.Move2 = "PoisonThrow 4 80;
                OutputCharacter.Move3 = "BackStab 1000 20%";
                OutputCharacter.Move4 = "StealthDisengage 0 40";
                
                OutputCharacter.QuestionText = "1:Slice, 2: PoisonThrow, 3:BackStab 4: StealthDisengage";
                
                OutputCharacter.AC = 8;
                OutputCharacter.HP = 7;
            }
            
            //Assigns stats if InputCharacter is a Mage
            if(InputCharacter.CharClass == Classes.Mage)
            {
                OutputCharacter.Move1 = "FireBall 10 50";  
                OutputCharacter.Move2 = "FrostBolt 8 60";
                OutputCharacter.Move3 = "UnholyDevastation 1000 20%";
                OutputCharacter.Move4 = "Teleport 0 40";
                
                OutputCharacter.QuestionText = "1:FireBall, 2:FrostBolt, 3:UnholyDevastation 4:Teleport";
                
                OutputCharacter.AC = 10;
                OutputCharacter.HP = 5;
            }
            
            //Assigns stats if InputCharacter is a Ranger
            if(InputCharacter.CharClass == Classes.Ranger)
            {
                OutputCharacter.Move1 = "SwordSlash 8 75";  
                OutputCharacter.Move2 = "ShieldBash 4 60";
                OutputCharacter.Move3 = "Rage 1000 20%";
                OutputCharacter.Move4 = "Intimidate 0 40";
                
                OutputCharacter.QuestionText = "1:ShordSlash, 2: ShieldBash, 3:Rage 4: Intimidate";
                
                OutputCharacter.AC = 15;
                OutputCharacter.HP = 10;
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
        public string Attack;
    }
    
    //Contains Monster List 
    //Later Convert to a Mark Up Language
    public class MonsterList
    {
        Monster Goblin = new Monster();
        //Goblin Stats
            Goblin.HP = 5;
            Goblin.AC = 8;
            Goblin.Name = "Goblin";
            public string Attack = "Scratch 4";
    }
    
    //Combat Manager contains everything related to combat
    public class CombatManager 
    {
        public static string StartCombat(Character character, Monster monster)
        {
            char[] AttackDelimiter = {' '};
            public bool InCombat = true;
            
            while(InCombat)
            {
                //Get Character Attack
                
                //Do Character Attack
                
                //Check if Enemey Dead
                
                //Get Enemy Attack
                
                //Do Enemy Attack
                
                //Check if Enemy Dead
                
                //If one is dead return death message
            }
        }
    }
}