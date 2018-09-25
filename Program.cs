using System;


public class GradeScale
{
    static void Main(string[] args)
    {
        string notes;
        char grd;
        
        Console.Write("Accept a grade and display equivalent description:\n");
               Console.Write("Input the grade :");
        grd = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (grd)
        {
            case 'E':
                notes = " Excellent";
                break;
            case 'V':
                notes = " Very Good";
                break;
            case 'G':
                notes = " Good ";
                break;
            case 'A':
                notes = " Average";
                break;
            case 'F':
                notes = " Fails";
                break;
            default:
                notes = "Invalid Grade Found.";
                break;
        }
        Console.Write("You have chosen  : {0}", notes);
    }
}