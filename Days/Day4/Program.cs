string line;
int card = 0;
string[] winningNumbers;
string[] myNumbers;
int matches;
int points = 0;
List<int> copies = new List<int>();
copies.Add(0);
int totalCards = 0;

while((line = Console.ReadLine())!="") {
    string[] numberSets = line.Split(':','|');
    winningNumbers = numberSets[1].Split(" ", StringSplitOptions.RemoveEmptyEntries); //need to remove emptry entries because the single digit numbers are formatted with an extra space
    myNumbers = numberSets[2].Split(" ", StringSplitOptions.RemoveEmptyEntries); //as such splitting by spaces returns a space as an entry
    matches = 0;
    foreach(string number in myNumbers) {
        if (winningNumbers.Contains(number)) {
            //Console.WriteLine(number);
            matches++;
        }
    }
    //Console.WriteLine(matches);
    for(int i=0; i<matches; i++) { // adding copies to the next X matches
        while(card+i+1 >= copies.Count) {
            copies.Add(0);
        }//just to increase the size of the copies list 
        //Console.WriteLine(copies.Count+" "+(card+i+1));
        copies[card+i+1]+=copies[card]+1; //if I have X copies of a card, I add an additional X copies to the next cards
    }
    if(matches>0) {points+=(int) Math.Pow(2,matches-1);}
    card++;
}
Console.WriteLine(points);

foreach(int s in copies) {
    //Console.WriteLine(s);
    totalCards += s;
}
totalCards += card;
Console.WriteLine(totalCards);