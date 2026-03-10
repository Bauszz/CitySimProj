using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Person
{
	private string name;
	private int ID;
	private int age;
	private bool sex;
	private string race;
	private List<string> traits;

	public List<string> Traits { get; set; }
	public string Name { get => name; set => name = value; }
	public int Age { get => age; set => age = value; }
	public bool Sex { get => sex; set => sex = value; }
	public string Race { get => race; set => race = value; }
	public int Id { get => ID; set => ID = value; }

	public Person(string name, int age, bool sex, string race)
	{
		this.name = name;
		this.id = new Random().Next(0, 1000);
		this.age = age;
		this.sex = sex;
		this.race = race;
		this.traits = new List<string>();
	}

	public override string ToString()
	{
		return $"Name: {this.name}, Age: {this.age}, ID: {this.id} {(this.sex ? "male" : "female")}, Traits: {string.Join(", ", Traits)}";
	}
}