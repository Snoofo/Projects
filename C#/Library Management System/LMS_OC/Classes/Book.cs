using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace LMS_OC
{
    class Book
    {
        int bookID;
        string ISBN;
        string title;
        int authorID;
        double price;
        string rackNo;
        int availableBooks;
        int borrowedBooks;
        int librarianID;

        public Book() { }

        public Book(string isbn, string name, int aID, double cost, string rNo, int avilbooks, int bBooks,int lID)
        {
            this.ISBN = isbn;
            this.title = name;
            this.authorID = aID;
            this.price = cost;
            this.rackNo = rNo;
            this.availableBooks = avilbooks;
            this.borrowedBooks = bBooks;
            this.librarianID = lID;
        }
        public int BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }
        public string BookISBN
        {
            get { return ISBN; }
            set { ISBN = value; }
        }
        public string BookTitle
        {
            get { return title; }
            set { title = value; }
        }
        public int BookAuthorID
        {
            get { return authorID; }
            set { authorID = value; }
        }
        public double BookPrice
        {
            get { return price; }
            set { price = value; }
        }
        public string RackNumber
        {
            get { return rackNo; }
            set { rackNo = value; }
        }
        public int AvailableBooks
        {
            get { return availableBooks; }
            set { availableBooks = value; }
        }
        public int BorrowedBooks
        {
            get { return borrowedBooks; }
            set { borrowedBooks = value; }
        }

        public int LibrarianID
        {
            get { return librarianID; }
            set { librarianID = value; }
        }

        public int AddNewBook()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into Book (title,authorID,price,rackNo,noOfAvailableBooks,noOfBorrowedBooks,librarianID,ISBN) values('" + title + "'," + authorID + "," + price + ",'" + rackNo + "'," + availableBooks + "," + borrowedBooks + "," + librarianID + ",'" + ISBN + "')";
            cmd.Connection = con;
            con.Open();
            int recordInserted= cmd.ExecuteNonQuery();
            con.Close();
            return recordInserted;
        }
        public int EditBook()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Book set title='"+title+"' ,authorID ="+authorID+",price="+price+",rackNo='"+rackNo+"',noOfAvailableBooks="+availableBooks+",librarianID="+librarianID+",ISBN='"+ISBN +"' where bookID="+bookID +"";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }
        public int updateBookQtyOnIssue()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Book set noOfAvailableBooks=noOfAvailableBooks-1, noOfBorrowedBooks=noOfBorrowedBooks+1 where bookID=" + bookID + "";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }
        public int updateBookQtyOnReturn()
        {
            SqlConnection con = ConnectionManager.DBConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "update Book set noOfAvailableBooks=noOfAvailableBooks+1, noOfBorrowedBooks=noOfBorrowedBooks-1 where bookID=" + bookID + "";
            cmd.Connection = con;
            con.Open();
            int recordUpdated = cmd.ExecuteNonQuery();
            con.Close();
            return recordUpdated;
        }

    }
}
