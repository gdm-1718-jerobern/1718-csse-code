using System;
using System.Collections.Generic;

public class Book {
    private string name;
    private List<Author> author;
    private double price;
    private int qtyInStock = 0;
    
    public Book (string name, List<Author> author, double price, int qtyInStock)
    {
        this.name = name;
        this.author = author;
        this.price = price;
        this.qtyInStock = qtyInStock;
    }

    public string getName() 
    {
        return this.name;
    }
    public List<Author> getAuthor()
    {
        return this.author;
    }
    public double Price { get => price ; set => price = value;}
    public int QtyInStock { get => qtyInStock ; set => qtyInStock = value;}

    public void print()
    {
        Console.WriteLine("Printing...");
    }

    public void getAuthorName()
    {
        for (int i = 0; i < author.Count; i++)
        {
            Console.WriteLine(author[i].name);
        }
    }
}