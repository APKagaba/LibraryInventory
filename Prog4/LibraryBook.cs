//LibraryBook class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4
{
    



    public class LibraryBook
    {
        private string _title; //Book's title
        private string _author; //Book's author
        private string _publisher; //Book's publisher
        private int _copyrightyear; //Book's copyright year
        private string _callnumber; //Book's callnumber
        public bool BookCheckout=false; //Safe Default


        //Five-parameter constructor
        public LibraryBook(string title, string author, string publisher, int copyrightyear, string callnumber)
        {
            Title = title; //Validate title via property
             Author = author; //Validate author via property
            Publisher = publisher; //Validate publisher via property
            CopyrightYear = copyrightyear; //Validate copyrightyear via property 
            CallNumber = callnumber; //Validate callnumber via property
        }

        //Property that gets and sets book's title
        public string Title
        {
            // Precondition:  None
            // Postcondition: The title has been returned
            get
            {
                return _title;
            }
            // Precondition:  None
            // Postcondition: The title has been set to the specified value
            set
            {
                _title = value;
            }
        }
        //Property that gets and sets book's author
        public string Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return _author;
            }
            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            set
            {
                _author = value;
            }
        }
        //Property that gets and sets book's publisher
        public string Publisher
        {
            // Precondition:  None
            // Postcondition: The publisher has been returned
            get
            {
                return _publisher;
            }
            // Precondition:  None
            // Postcondition: The publisher has been set to the specified value
            set
            {
                _publisher = value;
            }
        }
        //Property that gets and sets book's copyrightyear
        public int CopyrightYear
        {
            // Precondition:  None
            // Postcondition: The copyrightyear has been returned
            get
            {
                return _copyrightyear;
            }
            // Precondition:  0 <= value, must be a non non-negative integer 
            // Postcondition: The copyrightyear has been set to the specified value
            set
            {
                if (value >= 0) 
                    _copyrightyear = value;
                else // When invalid, set to 2018 instead
                    _copyrightyear = 2018; 
            }
        }
        //Property that gets and sets book's callnumber
        public string CallNumber
        {
            // Precondition:  None
            // Postcondition: The callnumber has been returned
            get
            {
                return _callnumber;
            }
            // Precondition:  None
            // Postcondition: The callnumber has been set to the specified value
            set
            {
                _callnumber = value;
            }
        }
        //Property determines book's checkout status
        public void CheckOut()
        {
            BookCheckout = true;
        }
        //Property determines book's return status
        public void ReturnToShelf()
        {
            BookCheckout = false;
        }
        //Property determines book's checkout status based on if it is or not 
        public bool IsCheckedOut()
        {
            bool isCheckedout;
            if (BookCheckout)
            {
                isCheckedout = true;
               
            }
            else
                isCheckedout = false;
            return isCheckedout;

        }
       
        // Precondition:  None
        // Postcondition: A string is returned presenting the book's information
        public override string ToString() //override is required!
        {
            //Builds the string in steps
            return $"Title: {Title}" + $"{Environment.NewLine}Author: {Author}" + $"{Environment.NewLine}Publisher: {Publisher}" +
            $"{Environment.NewLine}CopyrightYear: { CopyrightYear}" + $"{ Environment.NewLine}CallNumber: {CallNumber}" + $"{Environment.NewLine}CheckedOut: {BookCheckout}";

           
        }

    }
}
