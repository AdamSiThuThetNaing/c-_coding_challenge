using System;

public class SaveOldValue
{
    public static string Current_Value { get; set; }
    public static string Previous_Value { get; set; }
	public static string third_String { get; set; }

    public static void SetValue(string value)
    {
        Previous_Value = Current_Value;  
        Current_Value = value;        
    }
}

public class Program: SaveOldValue
{
    public static string value1 = null;  // for initial first character
	public static string value2 = null;  // for initial first character
	public static string result;
	public static string digits;
		
	public static void Main()
	{
		string characters;
		Current_Value = "9"; // this label value will be dynamic from button click sender object Window UI

		if(string.IsNullOrEmpty(Previous_Value)) // first button click
		{	
		   digits = Current_Value; 
		   characters = OldPhonePad(Current_Value); 
		   SetValue(Current_Value);
		   value2 = characters;
		   
		   Console.WriteLine(digits);
		   Console.WriteLine(characters);
		}

        if(value1 == null)  // second button click
		{
		   digits = digits + Current_Value;
		   characters = OldPhonePad(Current_Value);  
		   value1 = characters;

           Console.WriteLine(digits);
		   Console.WriteLine(characters);
		}
		
		if(value1 != null)  // third button click
		{
		   digits = digits + Current_Value;
		   characters = OldPhonePad(Current_Value); 
		   third_String = characters;
		   
		   Console.WriteLine(digits);
		   Console.WriteLine(characters);
		}

		if(third_String != null)  // fourth button click (optional)
		{
		   digits = digits + Current_Value;
		   characters = OldPhonePad(Current_Value); 
		   
		   Console.WriteLine(digits);
		   Console.WriteLine(characters);
		}
		
		digits = OldPhonePad("_"); // it is for space character

		digits = OldPhonePad("#");
		Console.WriteLine(digits);
	}
	
	public static String OldPhonePad(string input)
	{	
		switch (input){
				
			case "1":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "\'";
				   }
				   else if(value1 != null)
				   {   
					   result = "(";
				   }

				}
				else
				{
					result = "&";
				}
			    return result;
				break;
				
			case "2":
			
			    if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "b";
				   }
				   else if(value1 != null)
				   {   
					   result = "c";
				   }

				}
				else
				{
					result = "a";
				}
			    return result;
				break;
				
			case "3":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "e";
				   }
				   else if(value1 != null)
				   {   
					   result = "f";
				   }

				}
				else
				{
					result = "d";
				}
			    return result;
				break;
				
			case "4":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "h";
				   }
				   else if(value1 != null)
				   {   
					   result = "i";
				   }

				}
				else
				{
					result = "g";
				}
			    return result;
				break;
				
			case "5":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "k";
				   }
				   else if(value1 != null)
				   {   
					   result = "l";
				   }

				}
				else
				{
					result = "j";
				}
			    return result;
				break;
				
			case "6":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "n";
				   }
				   else if(value1 != null)
				   {   
					   result = "o";
				   }

				}
				else
				{
					result = "m";
				}
			    return result;
				break;
				
			case "7":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "q";
				   }
				   else if(value1 != null && third_String == null)
				   {   
					   result = "r";
				   }
				   else if(third_String != null)
				   {   
					   result = "s";
				   }

				}
				else
				{
					result = "p";
				}
			    return result;
				break;
				
			case "8":
			
				if(input == Previous_Value)
				{
				   if(value2 != null && value1 == null)
				   {   
					   result = "u";
				   }
				   else if(value1 != null)
				   {   
					   result = "v";
				   }

				}
				else
				{
					result = "t";
				}
			    return result;
				break;
				
			case "9":

				if(input == Previous_Value)
				{  
				   if(value2 != null && value1 == null)
				   {   
					   result = "x";
				   }
				   else if(value1 != null && third_String == null)
				   {   
					   result = "y";
				   }
				   else if(third_String != null)
				   {   
					   result = "z";
				   }

				}
				else
				{
					result = "w";
				}
			    return result;
				break;
				
		    case "*":
				
				if (!string.IsNullOrEmpty(input))
                {
                   result = input.Remove(0, 1);
                }
				return result;
				break;
				
			case "#":
				
				return digits + "#";
				break;
				
			case "_":  // it means space bar
			
				digits = digits + " ";
				return digits;
				break;
		}
		
        // Please write your implementation here!
		return input;
     }
}