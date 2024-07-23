// See https://aka.ms/new-console-template for more information

//int[] arr = { 1, 3, 5, 2, 6, 7 };
//string[] s_arr = { "10", "32", "1", "11"};

//Array.Sort(arr);
//Console.WriteLine("Sorted array : " + string.Join("," ,arr));
//Array.Reverse(arr);
//Console.WriteLine("Reversed array : " + string.Join(",", arr));
//Array.Sort(s_arr);
//Console.WriteLine("Sorted array : " + string.Join(",", s_arr));

//int[] i_arr = Array.ConvertAll(s_arr, int.Parse);
//Console.WriteLine("Converted int array : " + string.Join(",", s_arr));

int[] intArr = { 3, 1, 2 };
string[] strArr = Array.ConvertAll(intArr, x => (2 * x).ToString());
Console.WriteLine("strArr: " + string.Join(", ", strArr));