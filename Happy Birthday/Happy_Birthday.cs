using System;

// For Mariela
// 19.11.2013

internal class Happy_Birthday
{
	private static void print_char(char character_1, char character_2, int count)
	{
		for (int i = 0; i < count; i++)
		{
			Console.Write("{0}{1}", character_1, character_2);
		}
	}

	private static void print_message(char[] message, char character)
	{
		foreach (char letter in message)
		{
			Console.Write("{0}{1}", letter, character);
		}
	}

	private static void Main()
	{
		char[] message = { '\x0048', '\x0041', '\x0050', '\x0050', '\x0059' };
		char[] message_2 = { '\x0042', '\x0049', '\x0052', '\x0054', '\x0048', '\x0044', '\x0041', '\x0059' };
		ConsoleKeyInfo cki;
		char fire = '\x002c';
		char candle = '\x0023';
		char plane = '\x005f';
		char volume_left = '\x007b';
		char volume_right = '\x007d';
		char decoration_1 = '\x0060';
		char decoration_2 = '\x002e';
		char decoration_3 = '\x0022';
		char plate_left = '\x0028';
		char plate_right = '\x0029';
		char plate_up = '\x002d';
		char plate_down = '\x007e';
		char white_space = '\x0020';
		print_char(white_space, white_space, 8);
		print_char(fire, white_space, 5);
		Console.WriteLine();
		print_char(white_space, white_space, 8);
		print_char(candle, white_space, 5);
		Console.WriteLine();
		print_char(white_space, white_space, 7);
		Console.Write(white_space);
		print_char(plane, candle, 5);
		Console.WriteLine(plane);
		print_char(white_space, white_space, 7);
		print_char(volume_left, plane, 1);
		print_char(decoration_1, white_space, 4);
		print_char(decoration_1, plane, 1);
		Console.WriteLine(volume_right);
		print_char(white_space, white_space, 6);
		Console.Write(white_space);
		print_char(plane, volume_left, 1);
		print_char(plane, decoration_2, 5);
		print_char(plane, volume_right, 1);
		Console.WriteLine(plane);
		print_char(white_space, white_space, 6);
		print_char(volume_left, plane, 1);
		print_char(white_space, white_space, 1);
		print_message(message, white_space);
		print_char(white_space, plane, 1);
		Console.WriteLine(volume_right);
		print_char(white_space, white_space, 5);
		Console.Write(white_space);
		print_char(plane, volume_left, 1);
		print_char(plane, decoration_2, 7);
		print_char(plane, volume_right, 1);
		Console.WriteLine(plane);
		print_char(white_space, white_space, 5);
		print_char(volume_left, plane, 1);
		Console.Write(white_space);
		print_message(message_2, white_space);
		print_char(plane, volume_right, 1);
		Console.WriteLine();
		print_char(white_space, white_space, 3);
		print_char(decoration_2, plate_up, 1);
		print_char(plate_up, plate_up, 1);
		Console.Write(volume_left);
		print_char(plane, decoration_2, 9);
		print_char(plane, volume_right, 1);
		print_char(plate_up, plate_up, 1);
		print_char(plate_up, decoration_2, 1);
		Console.WriteLine();
		print_char(white_space, white_space, 2);
		print_char(white_space, plate_left, 1);
		print_char(white_space, white_space, 1);
		print_char(white_space, decoration_1, 1);
		print_char(decoration_3, decoration_3, 10);
		print_char(decoration_3, decoration_1, 1);
		print_char(white_space, white_space, 1);
		print_char(white_space, plate_right, 1);
		Console.WriteLine();
		print_char(white_space, white_space, 3);
		print_char(decoration_1, plate_down, 1);
		print_char(plate_down, plate_down, 13);
		Console.WriteLine(decoration_1);
		Console.WriteLine("Make a wish and press any key... ");
		cki = Console.ReadKey();
		Console.Write("That isn't 'any' key. You pressed ");
		if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
		if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
		if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
		Console.WriteLine(cki.Key.ToString());
		Console.WriteLine("Please try again ;)");
		cki = Console.ReadKey();
	}
}