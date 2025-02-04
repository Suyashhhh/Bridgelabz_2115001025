using System;
class Book{
	static string LibraryName;
	private string Title {get ; set;}
	private string Auhor {get; set;}
	readonly int ISBN;
	public Book(string libraryname,string title,string author,int isbn){
		LibraryName=libraryname;
		this.Title=title;
		this.Author=author;
		this.ISBN=isbn;
	}
	public static void DisplayLibraryName(){
		Console.WriteLine("the library name is :"+LibraryName);
	}
	public void DisplayDetails(){
		if(this is Book){
		Console.WriteLine("the book title is :"+Title);
		Console.WriteLine("the author is :"+Author);
		Console.WriteLine("the book code is"+ISBN);
		}
	}
}
class Program{
	static void Main(){
		Book book1=new Book("govt library","secrets","alice",43233);
		book1.DisplayDetails();
		Book.DisplayLibraryName();
	}
}