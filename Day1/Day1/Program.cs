// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

// This is a really dumb and stupid hack that doesn't actually work perfectly but it was good enough
string clean(string s) {
    StringBuilder sb = new StringBuilder(s);
    sb.Replace("one", "o1e");
    sb.Replace("two", "t2o");
    sb.Replace("three", "t3e");
    sb.Replace("four", "f4r");
    sb.Replace("five", "f5e");
    sb.Replace("six", "s6x");
    sb.Replace("seven", "s7n");
    sb.Replace("eight", "e8t");
    sb.Replace("nine", "n9e");
    return sb.ToString();

}


string line;
string digits;
int val;
long sum = 0;


while((line = Console.ReadLine())!="") {
    if(line=="") {break;}
    //Console.WriteLine("clean line: "+clean(line));
    line = clean(line);
    //Console.WriteLine("clean clean line: " + clean(line));
    line = clean(line);

    digits = new string(line.Where(Char.IsDigit).ToArray());
    val = (digits[0]-'0') * 10 + (digits[digits.Length-1]-'0');
    //Console.WriteLine(val);
    sum +=val;

    
    
}
Console.WriteLine(sum);