class Klasse
{
	// Die Main Methode ist die vordefinierte Hauptmethode jedes C# Programms. Wenn die exe ausgeführt wird, wird als Einstieg immer die Main Methode ausgeführt und daher auch erwartet
	static void Main()
	{
		Greeter("Phexy Bexy");
		Greeter("Dalmatiner");
		System.Console.WriteLine(Prozent(888,2040));
	}
	// Eine selbstdefinierte Methode names Greeter, die ein Argument erwartet (string name)
	// Der definierte Parameter erwartet strikt einen String und muss übermittelt werden (ist nicht optional)
	// void bedeutet, dass diese Methode keinen Rückgabewert hat 
	static void Greeter(string name)
	{
		System.Console.WriteLine("Horrido " + name);
	}
	// Statt void wird hier ein Datentyp angegeben. Das bedeutet, dass eine Wert dieses Datentyps von der Methode zurückgegeben wird
	static float Prozent(float wert, float basis)
	{
		float prozent = wert / basis * 100;
		return prozent;
	}
}