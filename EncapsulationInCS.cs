using System;

public class EncapsulationInCS
{ 
	private int mobPin; //Characteristics 
	public int getValue() //Behavior
	{
		return mobPin;
	}
	public void setValue(int mPin)
	{
		mobPin = mPin;	
	}

}
