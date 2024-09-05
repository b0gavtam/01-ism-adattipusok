// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a = 1, b = 2;
int x; // deklaráció
//Console.WriteLine($"Deklaráció után: {x}.");
//Hibaüzenet: Use of unassigned variable 'x'
x = 10; // definíció
Console.WriteLine($"Deklaráció után: {x}.");
int y = 11; //deklaráció és definíció
Console.WriteLine($"x = {y}");

int integer = 0; // Előjeles, 32 bites egész szám (–2147483648.. 2147483647).
float flóath = 6 / 2.3F; flóath = (float)5 / 4; // csak 7 számjegyig képes pontosan számolni.
double dábül = 6 / 2.3; dábül = 6 / 2.3D; // 15-17 számjegyig képes pontosan számolni.

byte bájt = 250; // Előjel nélküli 8 bites egész szám(0..255)
char karakter = 'X'; // Egy Unicode karakter
decimal decimál = 6 / 2.3M; decimál = Convert.ToDecimal(6 / 2.3); // 25-29 számjegyig képes pontosan számolni. 
                                                                  // FONTOS: Pénz értéket mindig decimalban tároljunk!