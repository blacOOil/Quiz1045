using System;
class Program{
   static void Main(string[] args){
    int userchoose;
    
Console.WriteLine("Kfc bangkuntian shine talay---------------------------------------------- ");
    Console.WriteLine("About us Please selection what You want to know");
    Console.WriteLine("1 for basic information  2 for co-founder information");
    Console.WriteLine("3 for Employee informatin 4 for Benefit chart");
    userchoose = int.Parse(Console.ReadLine());
    if(userchoose == 1){
          basicinfor bangkunKfc = new basicinfor();
        basicinfor.startCost = "1,000,000";
        basicinfor.storeName = "KFC Bang kuntian";
        basicinfor.Location = "ShineTalay Road bangkuntian 27 ";
       printbasicinfor(bangkunKfc);

        
    }
     if(userchoose == 2){
        basicinfor founder = new basicinfor();
         basicinfor.foundername = "tawee";
        basicinfor.foundersurname = "jaidede";
        basicinfor.founderPersonalnum = "153-698-4561237";
        basicinfor.foundername1 = "yutde";
        basicinfor.foundersurname1 = "tungjailien";
        basicinfor.founderPersonalnum1 = "742-112-5687412";
        basicinfor.foundername2 = "jame";
        basicinfor.foundersurname2 = "luklogliean";
        basicinfor.founderPersonalnum2 = "541-772-3215689";
        printfouder(founder);
    }
    if(userchoose == 3){
        starterEmployee employee = new starterEmployee();
        starterEmployee.Name = "chaidee";
        starterEmployee.Name1 = "Nondee";
        starterEmployee.Name2 = "Arpaidee";
        starterEmployee.surnamne = "lukdee";
        starterEmployee.surnamne1 = "jaidee";
        starterEmployee.surnamne2 = "liendee";
        starterEmployee.surnamne = "lukdee";
        starterEmployee.surnamne1 = "jaidee";
        starterEmployee.surnamne2 = "liendee";
        starterEmployee.age = "20";
        starterEmployee.age1 = "18";
        starterEmployee.age2 = "22";
        starterEmployee.salary ="15,000";
        
  
         printemploy(employee);
        

       
        
    }
    if(userchoose == 4){
       Console.WriteLine("function uavailiable");
    }
    else {
        Console.WriteLine("invalid number try again");
    }


   }
   public static void getbasicinformation(){
        basicinfor bangkunKfc = new basicinfor();
        basicinfor.startCost = "1,000,000";
        basicinfor.storeName = "KFC Bang kuntian";
        basicinfor.Location = "ShineTalay Road bangkuntian 27 ";

   }
   static void printbasicinfor(basicinfor infor){
    Console.WriteLine("basic infor-----------------");
    Console.WriteLine("startCost : {0}",basicinfor.startCost);
    Console.WriteLine("fanshined Name : {0}",basicinfor.storeName);
    Console.WriteLine("fanshined Location : {0}",basicinfor.Location);

   }
     static void printfouder(basicinfor infor){
    Console.WriteLine("founder infor-----------------");
    Console.Write("  1st founder is  : {0}",basicinfor.foundername);
    Console.Write(" {0}",basicinfor.foundersurname);
    Console.WriteLine(" {0}", basicinfor.founderPersonalnum );
    Console.Write("  2nd founder is  : {0}",basicinfor.foundername1);
    Console.Write(" {0}",basicinfor.foundersurname1);
    Console.WriteLine(" {0}", basicinfor.founderPersonalnum1);
     Console.Write("  3rd founder is  : {0}",basicinfor.foundername2);
    Console.Write(" {0}",basicinfor.foundersurname2);
    Console.WriteLine(" {0}", basicinfor.founderPersonalnum2);
   }
   static void printemploy(starterEmployee starterEmployee){
    Console.WriteLine("Basic Employee---------------");
    Console.Write("1st Employee is :{0}",starterEmployee.Name);
    Console.Write(" {0}",starterEmployee.surnamne);
      Console.Write(" {0}",starterEmployee.age);
      Console.WriteLine("{0}",starterEmployee.salary);
      Console.Write("2nd Employee is :{0}",starterEmployee.Name1);
    Console.Write(" {0}",starterEmployee.surnamne1);
      Console.Write(" {0}",starterEmployee.age1);
      Console.WriteLine("{0}",starterEmployee.salary);
      Console.Write("2nd Employee is :{0}",starterEmployee.Name2);
    Console.Write(" {0}",starterEmployee.surnamne2);
      Console.Write(" {0}",starterEmployee.age2);
      Console.WriteLine("{0}",starterEmployee.salary);
      Console.WriteLine("Delivery Employee---------------");
      

   }
   
   }
