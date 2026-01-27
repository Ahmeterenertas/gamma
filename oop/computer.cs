//Project Computer v.09
////Inheritance 2006, styczen

using System;
using System.Collections.Generic;

namespace OOP_in_Csharp
{
    //--------------------------------
    public class Computer
	{
		public Computer (string ip, string make, string osystem, bool switched)
		{
			this.Ipaddress = ip;
			this.Make = make;
			this.OperatingSystem = osystem;
			this.SwitchedOn = switched;

			compCounter++;
		}

		public Computer ()
		{
			compCounter++;
		}

		// private member variables
		private string _ipadress;
		private bool _switchedOn;
		private string _make;
		private string _operatingSystem;

		private static int compCounter = 0; //counts comps in the network
		private static int switchedCounter = 0; //counts comps that are switched

		public static int CountComps ()
		{
			return compCounter;
		}

		public static int CountSwitched ()
		{
			return switchedCounter;
		}

		public void StartComputer() 
		{
			this.SwitchedOn = true; 
			switchedCounter++;
			Console.WriteLine("The comp {0} is starting ...", this.Ipaddress);
		}

		public void ShutDown() 
		{
			this.SwitchedOn = false; 
			switchedCounter--;
			Console.WriteLine("The comp {0} is shuting down !!!", this.Ipaddress);
		}

		public string IsSwitched() 
		{
			if (this.SwitchedOn) 
			{
				return "switched ON";    
			}
			else
			{
				return "switched OFF";    
			}
		}

		// public properties
		public string Ipaddress
		{
			get { return _ipadress;  }
			set { _ipadress = value; }
		}
		public string Make
		{ 
			get { return _make; }
			set { _make = value; }
		}
		public string OperatingSystem
		{ 
			get { return _operatingSystem; }
			set { _operatingSystem = value; }
		}
		public bool SwitchedOn
		{
			get { return _switchedOn; }
			set { _switchedOn = value; }
		}



	}

    
    //--------------------------------
    public class Server : Computer
	{
		public Server (string ip, string make, string osystem, bool switched, string dest) : base(ip, make, osystem, switched)
		{			
			this.Destination = dest;

		}

		// private member variables
		protected string _destination;

		// public properties
		public string Destination
		{
			get { return _destination;  }
			set { _destination = value; }
		}
	}
    
    public class GraphicsStation : Computer
	{
		public GraphicsStation (string ip, string make, string osystem, bool switched, string graph) : base(ip, make, osystem, switched)
		{			
			this.GraphicsSystem = graph;

		}

		// private member variables
		protected string _graphicsSystem;

		// public properties
		public string GraphicsSystem
		{
			get { return _graphicsSystem;  }
			set { _graphicsSystem = value; }
		}
	}
    
    
    
    
    
    //--------------------------------
	class Program
	{
		public static void Main (string[]args)
		{

			List<Computer> network = new List<Computer>();          

			//Creating the objects 
			Server   omega = new Server ("10.0.0.10", "Dell", "Linux", false, "WEB Server");
			Computer alfa = new Computer ("10.0.0.11", "Dell", "Windows", false);
			Computer beta = new Computer ("10.0.0.12", "Lenovo", "Linux", false);
			Computer gamma = new Computer ("10.0.0.15", "HP", "Windows", false);
			Computer delta = new Computer ("10.0.0.16", "Dell", "Windows", false);
	    	GraphicsStation teta = new GraphicsStation ("10.0.0.17", "Dell", "Windows", false, "Photoshop");

		
			//Adding objects Computer to the list network
			network.Add(omega);
			network.Add(alfa);              
			network.Add(beta);
			network.Add(gamma);
			network.Add(delta);
			network.Add(teta);

			int compsInNetwork = Computer.CountComps ();
			Console.WriteLine ("We have {0} computers in our network.\n", compsInNetwork);

			//"Swithing on the computers"
			for(int i=0; i<network.Count; i++) 
			{
				network[i].StartComputer();       
			}


			Console.WriteLine ("--------------------------------------------------------------------\n"); 

			Console.WriteLine ("We have {0} computers in our network that is switched ON\n", Computer.CountSwitched());	   


			//iterating over the list network	

            
			foreach (Computer comp in network) 
			{
				if (comp.SwitchedOn) 
				{
				    
				    //Console.WriteLine(comp.GetType());
				    
					Console.Write("{0}\t{1}\t\t{2}\t", comp.Ipaddress, comp.OperatingSystem, comp.Make);
					Type type = comp.GetType();
					string stringType = type.ToString ();
					int pos = stringType.IndexOf('.');
					Console.Write(stringType.Substring(pos+1,4));
                    string description="";
					if(stringType.Substring(pos+1,4) == "Serv")
					{
					    
					    description = omega.Destination;
						System.Console.WriteLine("\t{0}", description);
					}
					
					else if(stringType.Substring(pos+1,4) == "Grap")
					{
						description = teta.GraphicsSystem;
						System.Console.WriteLine("\t{0}", description);
					}
	
					else
					Console.WriteLine();	
					
					
					
				

					//Console.WriteLine(comp.GetType());
				}     
			}	    

            
            
            
            
            
            
            
            

			Console.WriteLine ("--------------------------------------------------------------------\n"); 	
			omega.ShutDown();
			//beta.ShutDown();
			Console.WriteLine ("\nWe have {0} computers in our network that is switched ON\n", Computer.CountSwitched());	   

			//iterating over the list network		
			foreach (Computer comp in network) 
			{
				if (comp.SwitchedOn) 
				{
					Console.WriteLine("{0}\t{1}\t\t{2}", comp.Ipaddress, comp.OperatingSystem, comp.Make);
				}     
			}	    
			Console.WriteLine ("--------------------------------------------------------------------\n"); 	    


			//Test of ping to other computers

			Random rnd = new Random();
			double answer;

			Computer myComp = alfa;
			String pingTo = "10.0.0.12";

			bool found = false;	
			foreach (Computer comp in network) 			 	
				//this can be encapsulated
			{
				if ((pingTo == comp.Ipaddress) && (comp.SwitchedOn == true)) 
				{
					found = true;
					break;
				} 
			} // the end of the loop


			if (found) 

			{ 
				for (int i = 5; i < 15; i++) 
				{ 
					answer = (float)(rnd.Next(1, 100))/100;
					Console.WriteLine ("64 bytes from {0} icmp_seq={1} ttl=64 time={2} ms", myComp.Ipaddress, i.ToString(), answer.ToString());
				}
			}	
			else
			{					
				Console.WriteLine ("Adress {0} not found !!! ", pingTo );
			}
			//the end of pinging


		}
	}
}


