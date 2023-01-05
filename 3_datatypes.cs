using System;
class Klasse
{
	static void Main()
	{
		// Initialisierte Datentypen werden als Objekt gespeichert. Diese Objekte haben Methoden, die anhand des Inhalts des Datentyps ausgeführt werden können
		// Alle types, vordefiniert oder selbstdefiniert, reference types oder value types erben direkt oder indirekt von Object

		//char 	U+0000 to U+FFFF 	16 bit 	System.Char
		char Buchstabe = 'A';
		Console.WriteLine(Buchstabe);

		//string Eine Zeichenkette
		string Phrase = "Es schreien die Tauben vom Dach";
		Console.WriteLine(Phrase);

		//int Eine ganze Zahl
		int Integer = 10 / 3;
		Console.WriteLine(Integer);
		// Output: 3 

		// float 	±1.5 x 10−45 to ±3.4 x 1038 	~6-9 digits 	4 bytes 	System.Single
		float f1 = 10;
		float f2 = 3;
		Console.WriteLine(f1/f2);
		// Output: 3,333333


		// double 	±5.0 × 10−324 to ±1.7 × 10308 	~15-17 digits 	8 bytes 	System.Double
		double do1 = 10;
		double do2 = 3;
		Console.WriteLine(do1/do2);
		// Output: 3,33333333333333

		// decimal 	±1.0 x 10-28 to ±7.9228 x 1028 	28-29 digits 	16 bytes 	System.Decimal
		decimal de1 = 10;
		decimal de2 = 3;
		Console.WriteLine(de1/de2);
		// Output: 3,3333333333333333333333333333

		// Aus (mir noch nicht verständlichen Gründen) wird der Ausdruck 10/3 immer als Int behandelt selbst wenn das Ergebnis in einen Float,Double,Decimal gespeichert wird
		// Um das zu umgehen müssen in diesen "nummerischen" Ausdruck sogenannte Specifier verwendet werden.
		float Float = 10f / 3;
		double Double = 10d / 3;
		decimal Decimal = 10M / 3;
	}

}