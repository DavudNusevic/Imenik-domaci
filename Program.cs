using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImenikXYZZZ
{
	class Program
	{
		//TODO Napraviti aplikaciju poput ove, samo za artikle.
		//Korisnik moze da unese artikal (ima sifru, naziv i cenu)
		//Stampaje i brisanje i sve to :) 
		//Za odvazne, artikal ima i kolicinu na stanju, koja moze da se doda
		//ili oduzme (ne sme da dodje ispod 0 :) )
		static void Main(string[] args)
		{
			List<string> Imena = new List<string>();
			List<string> BrTel = new List<string>();

			string unos = "";
			while (unos != "5")
			{
				Console.WriteLine("1 -- Unos");
				Console.WriteLine("2 -- Ispis");
				Console.WriteLine("3 -- Pretraga");
				Console.WriteLine("4 -- Brisanje");
				Console.WriteLine("5 -- Izlaz");
				Console.WriteLine("----------------");
				Console.Write("Izaberite: ");

				unos = Console.ReadKey().KeyChar.ToString();
				Console.WriteLine();

				switch (unos)
				{
					case "1":

						/*
						 Koristio sam funkciju IsNullOrWhiteSpace umesto funkcije IsNullOrEmpty jer ne zelim da mi
						 korisnik unosi prazan string
						 */

						string unosImenaIBrTel = "";

						do
						{
							Console.Write("Unesite ime i prezime( 0 za izlazak ): ");
							unosImenaIBrTel = Console.ReadLine();
						} while (string.IsNullOrWhiteSpace(unosImenaIBrTel));
						if (unosImenaIBrTel == "0")
						{
							break;
						}
						Imena.Add(unosImenaIBrTel);
						do
						{
							Console.Write("Unesite tel:  ");
							unosImenaIBrTel = Console.ReadLine();
						} while (string.IsNullOrWhiteSpace(unosImenaIBrTel));
						BrTel.Add(unosImenaIBrTel);

						break;
					case "2":
						for (int indeks = 0; indeks < Imena.Count; indeks++)
						{
							Console.WriteLine($"{indeks + 1}. {Imena[indeks]} ---- {BrTel[indeks]}");
						}
						break;
					case "3":
						Console.Write("Unesite ime: ");
						string ime = Console.ReadLine();
						for (int indeks = 0; indeks < Imena.Count; indeks++)
						{
							if (Imena[indeks].ToLower().Contains(ime.ToLower()))
							{
								Console.WriteLine($"{indeks + 1}. {Imena[indeks]} ---- {BrTel[indeks]}");
							}
						}
						break;
					case "4":

						Console.Write("Unesite ime koje zelite da izbrisete ");
						string brisanje = Console.ReadLine();
						char daLiBrisati;

						for (int indeks = 0; indeks < Imena.Count(); indeks++)
						{
							if (Imena[indeks].ToLower().Contains(brisanje.ToLower()))
							{
								do
								{
									Console.Write($"Da li zelite da izbrisete {Imena[indeks]} ? (D/N/0) : ");
									daLiBrisati = Console.ReadKey().KeyChar;
									Console.Write("\n");
								} while (daLiBrisati != 'D' && daLiBrisati != 'N' && daLiBrisati != '0');


								if (daLiBrisati == 'D')
								{
									Imena.RemoveAt(indeks);
									break;
								}

								if (daLiBrisati == '0')
								{
									break;
								}
							}
						}


						/*
						Console.Write("Unesite indeks: ");
						int ind = int.Parse(Console.ReadLine()) - 1;
						Imena.RemoveAt(ind);
						BrTel.RemoveAt(ind);
						*/

						break;
					case "5":
						Console.WriteLine("Bye :D");
						break;
				}
			}
			Console.ReadKey();

		}
	}
}
