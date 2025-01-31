using System;
class Book{
    string title,author;
	int price;
    
    public Book(int price,string title,string author){
        this.title=title;
		this.author=author;
		this.price=price;
    }

    public void DisplayDetails(){
		Console.WriteLine(title+" is written by "+author+" for a price of "+price);
	}
    static void Main() {
		Book book1=new Book(1200,"JoJo's bizzare adventures","Araki");
		book1.DisplayDetails();

	}
}
