using System;

class Book
{
    private string title;
    private string content;
    private string eTitle;
    private string eContent;
    private double value = 0;
    private int pages = 0;
    private double titleValue = 0;
    private double contentValue = 0;
    private int i = 0;

    public Book(){
        title = "Very nice book.";
        content = "This is a testing book.";
        value = 15.5;
        pages = 8;
    }

    public Book (string bName, string bContent){
        
        // get names from program
        title = bName;
        content = bContent;

        // get title value
        for(i = 0; i < title.Length; i++){
            if(title[i] != ' ' && title[i] != '\t' && title[i] != '\n'){
                titleValue += .5;
            }
        }
        // get content value
        for(i = 0; i < content.Length; i++){
            if(content[i] != ' ' && content[i] != '\t' && content[i] != '\n'){
                contentValue += .5;
            }
        }     

        // get value of book
        value = titleValue + contentValue;

        // math to get the pages
        pages = Convert.ToInt32(titleValue + contentValue / 5);
    }

    public void encrypt(int key){

        char a;
        char b;

        // create empty strings to add char to later
        string newTitle = "";
        string newContent = "";

        // need to make it all upper for encrypt
        eTitle = title.ToUpper();
        eContent = content.ToUpper();

        // go through title
        for(i = 0; i < eTitle.Length; i++){
            
            // need to make char an int to do math with
            a = Convert.ToChar(eTitle.Substring(i,1));
            int x = Convert.ToInt32(a);
            x += key; 

            // condition if key makes x go outside of ASCII table for A-Z
            if ( x > 90 ){
                int temp = x % 90;
                x = 65 + temp;
            }

            // converting int back to char
            b = Convert.ToChar(x); 

            // adding char back to new title as a string
            newTitle += Convert.ToString(Convert.ToChar(b));
        }

        // set title to new encrypted title
        title = newTitle;

        // start of encrypting content
        for(i = 0; i < eContent.Length; i++){
            
            // do the same as above like you did for title
            a = Convert.ToChar(eContent.Substring(i,1));
            int x = Convert.ToInt32(a);
            x += key;

            // condition for ASCII table
            if ( x > 90 ){
                int temp = x % 90;
                x = 65 + temp;
            }
            
            // conversions back to get the string
            b = Convert.ToChar(x);
            newContent += Convert.ToString(Convert.ToChar(b));
        }

        // set new content to content
        content = newContent;
    }

    public string getTitle(){
        
        return title;
    }

    public string getContents(){

        return content;
    }

    public double getValue(){

        return value;
    }

    public int getPages(){

        return pages;
    }

    public void print(){
        Console.WriteLine("Title: {0}", title);
        Console.WriteLine("Body: {0}", content);
        Console.WriteLine("Value: ${0:F1}", value); // format like this instead of {0:C2} because Athene is dumb
        Console.WriteLine("Pages: {0}", pages);
    }
}