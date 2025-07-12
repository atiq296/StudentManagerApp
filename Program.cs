// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections.Generic;

namespace Program{
    
}


class Student {
    public string Name;
    public int Age;
    public double CGPA;
    
    public Student(string name, int age, double cgpa){
        Name=name;
        Age=age;
        CGPA=cgpa;
    }
    
    
    public static void Main(string[] args){
        
        List<Student> studentlist=new  List<Student>();
       
        int choice;
       do{
            Console.WriteLine("Select any from following: \n1. Add new student\n2. Display all students record\n3. Display Average Grade \n4. Exit" );
            choice=Convert.ToInt32(Console.ReadLine());
       
        switch (choice){
            case 1:
            
            
            
            
            Console.WriteLine("enter name of student:");
            string name1=Console.ReadLine();
            
            Console.WriteLine("enter age of student:");
            int age1=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter CGPA of student:");
            double cgpa1=Convert.ToDouble(Console.ReadLine());
            
            
            Student s1=new Student(name1,age1,cgpa1);
            studentlist.Add(s1);
            Console.WriteLine("Student added successfully!");

            
            
            
            break;
            
            
            
            case 2:
            int x=1;
            foreach(Student i in studentlist){
                
                Console.WriteLine($"The name of student {x} is {i.Name}\n The age of {i.Name} is {i.Age}\n The CGPA of student {x} is {i.CGPA}");
                x++;
            }
            break;
            
            case 3:
            double total=0;
             int  x=1;
            foreach(Student i in studentlist){
               
               total=total+i.CGPA;
            }
             double avg=total/studentlist.Count();
            
            
             Console.WriteLine($"The average grade is {avg}");
             break;
             
             case 4:
             Console.Write("Exiting");
             break;
        }
        
       }
       
       while(choice!=4);
        
    }
    
    
}