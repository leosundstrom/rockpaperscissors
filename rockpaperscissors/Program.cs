int score = 0;
int damage;
int mScore = 0;
int eDamage;
string weapon;
bool eAlive;
bool alive;
string pText;
Random generator = new Random();
int rng = 0;
string rps = "";
bool rpsg = false;

Console.WriteLine("Rock Paper Scissors!");

while(score <= 2 && mScore <= 2){

rng = generator.Next(1,4);

if(rng == 1){
    rps = "Rock";
}
if(rng == 2){
    rps = "Paper";
}
if(rng == 3){
    rps = "Scissors";
}


pText = Console.ReadLine();
if(pText == "rock" ||  pText == "Rock" || pText == "paper" || pText == "Paper" || pText == "scissors" || pText == "Scissors"){



if(pText == "rock" && rps == "Rock" || pText == "Rock" && rps == "Rock"){
 Console.WriteLine($"I chose {rps}! Draw!");  
 Console.WriteLine($"{score}-{mScore}");
}

if(pText == "rock" && rps == "Scissors" || pText == "Rock" && rps == "Scissors"){
 Console.WriteLine($"I chose {rps}! Victory!");   
score = score + 1;
 Console.WriteLine($"{score}-{mScore}");
}

if(pText == "rock" && rps == "Paper"|| pText == "Rock"  && rps == "Paper"){
 Console.WriteLine($"I chose {rps}! Defeat!");   
mScore = mScore + 1;
 Console.WriteLine($"{score}-{mScore}");
}


if(pText == "paper" && rps == "Rock"|| pText == "Paper" && rps == "Rock"){
 Console.WriteLine($"I chose {rps}! Victory!");   
score = score + 1;
 Console.WriteLine($"{score}-{mScore}");
}
if(pText == "paper" && rps == "Paper" || pText == "Paper" && rps == "Paper"){
 Console.WriteLine($"I chose {rps}! Draw!");   
 Console.WriteLine($"{score}-{mScore}");
}
if(pText == "paper" && rps == "Scissors" || pText == "Paper" && rps == "Scissors"){
 Console.WriteLine($"I chose {rps}! Defeat!");   
mScore = mScore + 1;
 Console.WriteLine($"{score}-{mScore}");
}
if(pText == "scissors" && rps == "Rock" || pText == "Scissors" && rps == "Rock"){
 Console.WriteLine($"I chose {rps}! Defeat!");   
mScore = mScore + 1;
 Console.WriteLine($"{score}-{mScore}");
}
if(pText == "scissors" && rps == "Paper" || pText == "Scissors" && rps == "Paper"){
 Console.WriteLine($"I chose {rps}! Victory!");   
score = score + 1;
 Console.WriteLine($"{score}-{mScore}");
}
if(pText == "scissors" && rps == "Scissors" || pText == "Scissors" && rps == "Scissors"){
 Console.WriteLine($"I chose {rps}! Draw!");   
 Console.WriteLine($"{score}-{mScore}");
}


}

if(score >= 3){
    Console.Clear();
    Console.WriteLine($"You win {score}-{mScore}!");
  
}
if(mScore >= 3){
    Console.Clear();
    Console.WriteLine($"You lost {mScore}-{score}");
  
    
}
}
Console.ReadLine();


