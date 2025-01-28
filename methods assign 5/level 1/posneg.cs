using System;
class Program{
	static void Main(){
		Console.Write("enter number");
		int num = int.Parse(Console.ReadLine());
		int result= numtype(num);
		Console.WriteLine(result);
		static int numtype(int n){
			if(n<0){
				return -1;
			}
			else if(n>0){
				return 1;
			}
			else{
				return 0;
			}
		}
	}
}

