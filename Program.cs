//start main
string joy = GetEnjoymentLevel();
string stadium = GetStadiumRec(joy);
string game = GetGameRecs(stadium);
string message = DisplayDetails(stadium,game);
//end main



static string GetEnjoymentLevel(){
string joy = "";
System.Console.WriteLine("What is your prefered enjoyment: Boring, Average, Fun, or Epic");
joy = Console.ReadLine();
return joy;
}

static string GetStadiumRec(string joy){
string stadium = "";
if(joy == "Boring"){
System.Console.WriteLine(stadium = "Neyland Stadium");
} else if (joy == "Average"){
     System.Console.WriteLine(stadium = "Jordan-Hare Stadium");
} else if(joy == "Fun"){
     System.Console.WriteLine(stadium = "Tiger Stadium");
} else if(joy== "Epic"){
System.Console.WriteLine(stadium = "Saban Field at Bryant-Denny Stadium");
} else {
    System.Console.WriteLine("Invalid Input");
}
   return stadium; 
}

static string GetGameRecs(string stadium){
string game = "";
if(stadium == "Neyland Stadium"){
    System.Console.WriteLine(game = "Kent State");
} else if(stadium == "Jordan-Hare Stadium" ){
    System.Console.WriteLine(game = "Kentucky");
} else if (stadium == "Tiger Stadium"){
    System.Console.WriteLine(game = "Alabama");
}else if (stadium == "Saban Field at Bryant-Denny Stadium"){
    System.Console.WriteLine(game = "Auburn");
}
    return game; 
}

static string DisplayDetails(string stadium, string game){
    Console.Clear();
    string message= "";
System.Console.WriteLine("Based on your prefrence you should attend " + stadium +" When they play " + game) ;
return message;
}

