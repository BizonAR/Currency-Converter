using System;

namespace CurrencyConverter
{
	internal class CurrencyConverter
	{
		static void Main(string[] args)
		{
			const string CommandExit = "exit";
			const string CommandUsdToEur = "usd to eur";
			const string CommandUsdToRub = "usd to rub";
			const string CommandEurToUsd = "eur to usd";
			const string CommandEurToRub = "eur to rub";
			const string CommandRubToUsd = "rub to usd";
			const string CommandRubToEur = "rub to eur";

			float usdToEurRate = 0.85f;
			float usdToRubRate = 75.0f;
			float eurToUsdRate = 1 / usdToEurRate;
			float eurToRubRate = 103.41f;
			float rubToUsdRate = 1 / usdToRubRate;
			float rubToEurRate = 1 / eurToRubRate;
			float balanceUsd = 1000.0f;
			float balanceEur = 800.0f;
			float balanceRub = 600.0f;
			float moneyExchange;
			float moneyReceived;
			bool isProgramActive = true;

			Console.WriteLine("Добро пожаловать в конвертер валют!");

			while (isProgramActive)
			{
				Console.WriteLine($"Ваш баланс: USD {balanceUsd}, EUR {balanceEur} и RUB {balanceRub}");
				Console.WriteLine("Список команд:\n" +
				$"1. Для выхода из программы введите {CommandExit}.\n" +
				$"2. Перевод USD в EUR - {CommandUsdToEur}\n" +
				$"3. Перевод USD в RUB - {CommandUsdToRub}\n" +
				$"4. Перевод EUR to USD - {CommandEurToUsd}\n" +
				$"5. Перевод EUR to RUB - {CommandEurToRub}\n" +
				$"6. Перевод RUB to USD - {CommandRubToUsd}\n" +
				$"7. Перевод RUB to EUR - {CommandRubToEur}\n"); ;
				Console.Write("Введите команду: ");
				string input = Console.ReadLine();

				switch (input)
				{
					case CommandExit:
						isProgramActive = false;
						break;
					case CommandUsdToEur:
						Console.Write("Введите, сколько usd вы хотите обменять на eur: ");
						moneyExchange = Convert.ToSingle(Console.ReadLine());

						if (balanceUsd >= moneyExchange)
						{
							balanceUsd -= moneyExchange;
							moneyReceived = moneyExchange * usdToEurRate;
							balanceEur += moneyReceived;
							Console.WriteLine($"Вы обменяли {moneyExchange} usd на {moneyReceived} eur.");
						}
						else
						{
							Console.WriteLine("Недостаточно средств на долларовом счёте. Обмен не произведён.");
						}
						break;
					case CommandUsdToRub:
						Console.Write("Введите, сколько usd вы хотите обменять на rub: ");
						moneyExchange = Convert.ToSingle(Console.ReadLine());

						if (balanceUsd >= moneyExchange)
						{
							balanceUsd -= moneyExchange;
							moneyReceived = moneyExchange * usdToRubRate;
							balanceRub += moneyReceived;
							Console.WriteLine($"Вы обменяли {moneyExchange} usd на {moneyReceived} eur.");
						}
						else
						{
							Console.WriteLine("Недостаточно средств на долларовом счёте. Обмен не произведён.");
						}
						break;
					case CommandEurToUsd:
						Console.Write("Введите, сколько eur вы хотите обменять на usd: ");
						moneyExchange = Convert.ToSingle(Console.ReadLine());

						if (balanceEur >= moneyExchange)
						{
							balanceEur -= moneyExchange;
							moneyReceived = moneyExchange * eurToUsdRate;
							balanceUsd += moneyReceived;
							Console.WriteLine($"Вы обменяли {moneyExchange} usd на {moneyReceived} eur.");
						}
						else
						{
							Console.WriteLine("Недостаточно средств на евровом счёте. Обмен не произведён.");
						}
						break;
					case CommandEurToRub:
						Console.Write("Введите, сколько eur вы хотите обменять на usd: ");
						moneyExchange = Convert.ToSingle(Console.ReadLine());

						if (balanceEur >= moneyExchange)
						{
							balanceEur -= moneyExchange;
							moneyReceived = moneyExchange * eurToRubRate;
							balanceRub += moneyReceived;
							Console.WriteLine($"Вы обменяли {moneyExchange} usd на {moneyReceived} eur.");
						}
						else
						{
							Console.WriteLine("Недостаточно средств на евровом счёте. Обмен не произведён.");
						}
						break;
					case CommandRubToUsd:
						Console.Write("Введите, сколько rub вы хотите обменять на usd: ");
						moneyExchange = Convert.ToSingle(Console.ReadLine());

						if (balanceRub >= moneyExchange)
						{
							balanceRub -= moneyExchange;
							moneyReceived = moneyExchange * rubToUsdRate;
							balanceUsd += moneyReceived;
							Console.WriteLine($"Вы обменяли {moneyExchange} usd на {moneyReceived} eur.");
						}
						else
						{
							Console.WriteLine("Недостаточно средств на рублёвом счёте. Обмен не произведён.");
						}
						break;
					case CommandRubToEur:
						Console.Write("Введите, сколько rub вы хотите обменять на usd: ");
						moneyExchange = Convert.ToSingle(Console.ReadLine());

						if (balanceRub >= moneyExchange)
						{
							balanceRub -= moneyExchange;
							moneyReceived = moneyExchange * rubToEurRate;
							balanceEur += moneyReceived;
							Console.WriteLine($"Вы обменяли {moneyExchange} usd на {moneyReceived} eur.");
						}
						else
						{
							Console.WriteLine("Недостаточно средств на рублёвом счёте. Обмен не произведён.");
						}
						break;
					default:
						Console.WriteLine("Вы ввели не существующую команду.");
						break;
				}
			}
			Console.WriteLine($"Ваш баланс: USD {balanceUsd}, EUR {balanceEur} и RUB {balanceRub}");
			Console.WriteLine("Программа завершена");
		}
	}
}
