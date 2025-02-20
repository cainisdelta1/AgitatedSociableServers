using System;

class MainClass {
  public static void Main (string[] args) {
    SortedList<string, int> pupil = new SortedList<string, int>();
pupil.Add("Bob", 11);
pupil.Add("Ann", 9);
pupil.Add("Mike", 12);
pupil.Remove("Ann");
foreach (string s in pupil.Keys)
  Console.WriteLine(s + ": " + pupil[s]);
  }
}