string? ganhou = "nao";
int fichas = 1;

Console.WriteLine("Vamos jogar um jogo de poker?!");
while (ganhou != "sim"){
  Console.WriteLine("Beleza! Escolha uma mão de poker, se ela for maior que a minha você vence!");
  Console.WriteLine("Aqui, usamos  seguinte regra: Digite '1' se você tiver um par, '2' se tiver dois pares e assim vai. Agora vamos lá! O que você tem?");
  int num = int.Parse(Console.ReadLine()!);

  Random random = new Random();
  int randomNumber = random.Next(1, 10);

  switch (num){
    case 1:  //par
      Console.WriteLine($"Você tem um par! Bom, eu tenho um... {randomNumber}!");
      break;
    case 2:  //2 pares
      Console.WriteLine($"Você tem dois pares! Bom, eu tenho um... {randomNumber}!");
      break;
    case 3:  //trinca
      Console.WriteLine($"Você tem uma trinca! Bom, eu tenho um... {randomNumber}!");
      break;
    case 4:  //sequência
      Console.WriteLine($"Você tem uma sequência! Bom, eu tenho um... {randomNumber}!");
      break;
    case 5:  //flush
      Console.WriteLine($"Você tem um flush! Bom, eu tenho um... {randomNumber}!");
      break;
    case 6:  //full house
      Console.WriteLine($"Você tem um full house! Bom, eu tenho um... {randomNumber}!");
      break;
    case 7:  //quadra
      Console.WriteLine($"Você tem uma quadra! Bom, eu tenho um... {randomNumber}!");
      break;
    case 8:  //straight flush
      Console.WriteLine($"Você tem um straight flush! Bom, eu tenho um... {randomNumber}!");
      break;
    case 9:  //royal straight flush
      Console.WriteLine($"Você tem um royal straight flush! Bom, eu tenho um... {randomNumber}!");
      break;
  }

  if (num > randomNumber){
    ganhou = "sim";
    fichas++;
    Console.WriteLine($"Você venceu! Toma aqui suas fichas. Agora você tem {fichas} fichas!");


    Console.WriteLine("Vai querer continuar apostando, ou vai manter o que você acumulou? (continuar / parar)");
    string? resposta = Console.ReadLine()!.ToLower();

    switch (resposta){
      case "continuar":
        ganhou = "nao";
        break;
      case "parar":
        Console.WriteLine($"Que chato você em... enfim, você acumulou um total de {fichas} fichas!");
        break;
    }
  }
  else if (num == randomNumber){
    ganhou = "sim";
    fichas++;
    Console.WriteLine($"Ixi, a gente empatou! Pode pegar as fichas. Agora você tem {fichas} fichas!");

    Console.WriteLine("Vai querer continuar apostando, ou vai manter o que você acumulou? (continuar / parar)");
    string? resposta = Console.ReadLine()!.ToLower();

    switch (resposta){
      case "continuar":
        ganhou = "nao";
        break;
      case "parar":
        Console.WriteLine($"Que chato você em... enfim, você acumulou um total de {fichas} fichas!");
        break;
    }
  }
  else{
    fichas--;
    Console.WriteLine($"Opa! Parece que sua mão era pior do que a minha... Eu venci! Me dá aqui essas fichas. Agora você tem {fichas} fichas!");
  }
}

/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */