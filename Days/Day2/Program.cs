using System.Numerics;

string line;
int game = 1;
int sum = 0;
int redIndex;  int red; int redMax = 12;
int greenIndex; int green; int greenMax = 13;
int blueIndex; int blue; int blueMax = 14;
long powerSum = 0;

while((line = Console.ReadLine())!="") {
    string[] sets = line.Split(':',';');
    // the first string in the set should be game X, the rest will be sets of dice
    int[] colours = new int[]{0,0,0}; // highest r,g,b for each game
    
    for(int i=1; i<sets.Length; i++) {
        red = 0; green = 0; blue = 0;
        string[] set = sets[i].Replace(",","").Split(' ');//remove commas and split by spaces so it's only colours and numbers
        for(int j=0; j<set.Length; j++) {
            //Console.WriteLine(set[j]);
            if(set[j].Equals("red")) {
                red = int.Parse(set[j-1]);
            }
            else if(set[j].Equals("green")) {
                green = int.Parse(set[j-1]);
            }
            else if(set[j].Equals("blue")) {
                blue = int.Parse(set[j-1]);
            }
            if (red > colours[0]) {colours[0] = red;}
            if (green > colours[1]) {colours[1] = green;}
            if (blue > colours[2]) {colours[2] = blue;}
        }
       
        
    }
    //Console.WriteLine(colours[0] + " " + colours[1] + " " + colours[2]);
    if(colours[0] <= redMax && colours[1] <= greenMax && colours[2] <= blueMax) {    
        sum+=game;
    }
    game++;

    powerSum+=colours[0]*colours[1]*colours[2];
    //Console.WriteLine("= " + colours[0]*colours[1]*colours[2]);
}
Console.WriteLine("sum: " + sum);
Console.WriteLine("powerSum: " + powerSum);