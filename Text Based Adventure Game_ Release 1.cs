using System;

namespace Text_Based_Adventure_Game
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Ints:
			int correct = 0;
			int Player_One_Handed = 0;
			int Player_Two_Handed = 0;
			int Player_Ranged_Weapon = 0;
			int Player_Magic = 0;




			//Strings:
			string Gender;
			string Race;
			string Class;


			//Character Creation:
			do {
				Console.Clear();
				Console.WriteLine ("Please choose a gender as below:");
				Console.WriteLine ("Male / Female");
				Gender = Console.ReadLine ().ToUpper ();
				if (Gender == "MALE") 
				{
					correct = 1;
				}
				if (Gender == "FEMALE") 
				{
					correct = 1;
				} 
				else {}
			} while(correct == 0);
			correct = 0;




			//Race Creation:
			do {
				Console.Clear ();
				Console.WriteLine ("Please choose a race as below:");
				Console.WriteLine ("Human");
				Console.WriteLine ("Dwarf");
				Console.WriteLine ("Elf");
				Console.WriteLine ("Orc");
				Console.WriteLine ("Your Choice:");
				Race = Console.ReadLine ().ToUpper ();
				if (Race == "HUMAN" || Race == "DWARF" || Race == "ELF" || Race == "ORC") {
					correct = 1;
				} 
				else {}			
			} while(correct == 0);
			correct = 0;




			//Class Creation:
			do {
				Console.Clear();
				Console.WriteLine("Please choose a class as below:");
				Console.WriteLine("Warrior");
				Console.WriteLine("Hunter");
				Console.WriteLine("Mage");
				Console.WriteLine("Thief");
				Console.WriteLine("Your Choice:");
				Class = Console.ReadLine().ToUpper();
				if(Class == "WARRIOR" || Class == "HUNTER" || Class == "MAGE" || Class == "THIEF")
				{
					correct = 1;
				}else{}
			} while(correct == 0);
			correct = 0;





			//Bonuses:
			//Race Bonus:
			if (Race == "HUMAN") 
			{
				Player_One_Handed++;  
				Player_Two_Handed++; 
				Player_Ranged_Weapon++; 
				Player_Magic++;
			}
			if (Race == "DWARF") 
			{
				Player_One_Handed++;  
				Player_Two_Handed = Player_Two_Handed + 2; 
				Player_Ranged_Weapon++; 
			}
			if (Race == "ELF") 
			{
				Player_One_Handed++;  
				Player_Ranged_Weapon = Player_Ranged_Weapon + 2;
				Player_Magic++;
			}
			if (Race == "ORC") 
			{
				Player_One_Handed = Player_One_Handed + 2; 
				Player_Two_Handed = Player_Two_Handed + 2; 
			}
				
			//Class Bonus:
			if (Class == "WARRIOR") 
			{
				Player_One_Handed = Player_One_Handed + 2;
				Player_Two_Handed = Player_Two_Handed + 2;
			}
			if (Class == "HUNTER") 
			{
				Player_One_Handed++;  
				Player_Two_Handed++; 
				Player_Ranged_Weapon = Player_Ranged_Weapon + 2; 
			}
			if (Class == "MAGE") 
			{
				Player_One_Handed++;  
				Player_Ranged_Weapon++; 
				Player_Magic = Player_Magic + 2;
			}
			if (Class == "THIEF") 
			{
				Player_One_Handed = Player_One_Handed + 2;
				Player_Ranged_Weapon++; 
				Player_Magic++;
			}






		}
	}
}
