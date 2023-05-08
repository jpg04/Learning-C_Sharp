using System;
using System.Diagnostics.Metrics;

public class CSPropertiesEg
{
	//private String name;//

	//public String Name
	/*{
		get
		{
			return name;
		}

		set
		{
			name = value;
		}
	}
	*/

	/*{
		get
		{
			return name;
		}
		set
		{
			name = value+ "Patil";
		}
	}
	*/

	private static int iCnt;

	public CSPropertiesEg()
	{
        iCnt++;
	}
	
	public static int Counter
	{
		get
		{
			return iCnt;	
		}
	}
}
