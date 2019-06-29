using System;
					
public class Vehicle
{
	public string color;
	public string make;
	public string model;
	public int speed = 35;
	
	public static void Main(string[] args)
	{
		Car myCar1 = new Car();
		myCar1.make = "Ford";
		myCar1.model = "Focus";
		myCar1.color = "blue";

		Car myCar2 = new Car();
		myCar2.make = "Chevy";
		myCar2.model = "Cruze";
		myCar2.color = "red";

		for (int i = 0; i < 35; i++) 
		{
   			myCar2.speedUp();
   			myCar1.speedUp();
   			myCar2.speedUp();
		}
		for (int i =0; i < 10; i++) 
		{
   			myCar2.slowDown();
		}
			myCar1.describe();
			myCar2.describe();

	}
	
	public void describe()
	{
		Console.WriteLine("The " + make + " " + model + " is " + color + " and is going " + speed + " MPH.");
		return;
	}
	
	public void speedUp()
	{
		speed++;
		return;
	}
	
	public void slowDown()
	{
		speed--;
		return;
	}
	
	public class Car : Vehicle
	{
		
	}
}