//Console.Write("Inserisci il primo numero: ");
//int num1 = int.Parse(Console.ReadLine());

//Console.Write("Inserisci il secondo numero: ");
//int num2 = int.Parse(Console.ReadLine());

//int maggiore = num1;

//if (num2 > num1)
//{
//    maggiore = num2;
//}

//Console.WriteLine("Il maggiore numero inserito è: " + maggiore);

//----------------------------------------------------------------

//Console.WriteLine("Inserisci la prima parola: ");
//string word1 = (Console.ReadLine());

//Console.WriteLine("Inserisci la seconda parola: ");
//string word2 = (Console.ReadLine());

//if (word1.Length > word2.Length)
//{
//    Console.WriteLine("La parola più lunga è: " + word1);
//}
//else if (word1.Length < word2.Length)
//{
//    Console.WriteLine("La parola più lunga è: " + word2);
//}
//else
//{
//    Console.WriteLine("Le parole hanno la stessa lunghezza");
//}

//----------------------------------------------------------------

//int sum = 0;

//for (var i = 0; i < 10; i++)
//{
//    Console.Write("Inserisci un numero: ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    sum += num;
//}

//Console.WriteLine("la somma di tutti i numeri inseriti è: " + sum);

//----------------------------------------------------------------

//int sum = 0;

//for (int i = 2; i <= 10; i++)
//{
//    sum += i;
//}

//Console.WriteLine("La somma dei numeri da 2 a 10 è: " + sum);

//double average = (double)sum / 9;
//Console.WriteLine("La media della somma dei numeri da 2 a 10 è: " + average);

//----------------------------------------------------------------

//Console.Write("Inserisci un numero positivo: ");
//int num = int.Parse(Console.ReadLine());

//if (num > 0)
//{
//    if (num % 2 == 0)
//    {
//        Console.WriteLine("Complimenti per la scelta: " + num);
//    }
//    else
//    {
//        Console.WriteLine("Questo numero è dispari, io odio i numeri dispari: " + (num + 1));
//    }
//}
//else
//{
//    Console.WriteLine("Il numero inserito non è valido. Inserire un numero positivo diverso da zero.");
//}

//----------------------------------------------------------------

//string[] invitati = { "nick ncarraway", "jay gatsby", "daisy buchanan", "tom buchanan", "jordan baker", "myrtle wilson" };

//Console.Write("Inserisci il tuo nome: ");
//string name = Console.ReadLine().ToLower();

//bool guest = false;

//for (int i = 0; i < invitati.Length; i++)
//{
//    if (invitati.Contains(name))
//    {
//        guest = true;
//        break;
//    }
//}

//if (guest)
//{
//    Console.WriteLine("Sei stato invitato alla festa del Grande Gatsby!");
//}
//else
//{
//    Console.WriteLine("Mi dispiace, il tuo nome non è presente nell'elenco degli invitati.");
//}

//----------------------------------------------------------------

//int[] myArray = new int[0];

//for (var i = 0; i < 6; i++)
//{
//    Console.Write("Inserisci un numero: ");
//    int num = Convert.ToInt32(Console.ReadLine());
//    if (num % 2 != 0)
//    {
//        Array.Resize(ref myArray, myArray.Length + 1);
//        myArray[myArray.Length - 1] = num;
//    }
//}

//Console.WriteLine("Numeri dispari inseriti: ");
//foreach (int element in myArray)
//{
//    Console.WriteLine(element);
//}

//----------------------------------------------------------------

//int[] myArray = new int[] { 2, 5, 3, 14, 12, 7, 29, 1 };
//int sum = 0;

//for (int i = 1; i < myArray.Length; i += 2)
//{
//    Console.WriteLine(myArray[i]);
//    sum += myArray[i];
//}

//Console.WriteLine("La somma: " + sum);

//----------------------------------------------------------------

//int[] myArray = new int[0];
//int sum = 0;


//while (sum < 49)
//{
//    Console.Write("Inserisci un numero: ");
//    int num = int.Parse(Console.ReadLine());

//    Array.Resize(ref myArray, myArray.Length + 1);
//    myArray[myArray.Length - 1] = num;
//    sum += num;
//}

//Console.WriteLine("Hai raggiunto il valore 49!");

//----------------------------------------------------------------

Console.Write("Inserisci un numero: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] myArray = new int[n];
    Console.WriteLine(myArray[i]);
}

