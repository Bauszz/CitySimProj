using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person
{
	public Random random = new Random();
	protected string name;
	protected int id;
	protected int age;
	protected bool sex;
	Race race;
	protected List<string> traits;

	public List<string> Traits { get; set; }
	public string Name { get => name; set => name = value; }
	public int Age { get => age; set => age = value; }
	public bool Sex { get => sex; set => sex = value; }
	internal Race Race{ get => race; set => race = value; }
	public int Id { get => id; set => id = value; }

	public Person(string name, int age, bool sex, Race race)
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
		return $"Name: {this.name}, Age: {this.age}, ID: {this.id} {(this.sex ? "male" : "female")}, Race: {Race},  Traits: {string.Join(", ", Traits)}";
	}

	public Person AddPerson(string name, int age, bool sex, Race race, List<string> traits)
	{
		return Person person = new Person(name, age, sex, race, traits);
	}
}