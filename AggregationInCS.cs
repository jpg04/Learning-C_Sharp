using System;

public class Address
{
	public string addressLine, city, state;
	public Address(string addressLine, string city, string state)
	{
		this.addressLine = addressLine;
		this.city = city;
		this.state = state;
	}
}
public class AggregationInCS
{
	public int id;
	public string name;
	public Address address; // Employee HAS-A Address
	public AggregationInCS(int id, string name, Address address)
	{
		this.id = id;
		this.name = name;
		this.address = address;
	}

	public void Display()
	{
        Console.WriteLine(id+" "+name+" "+address.addressLine+" "+address.city+" "+address.state);
    }
}
