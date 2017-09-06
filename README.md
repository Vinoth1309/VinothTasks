# VinothTasks
SolutionFolderName : VinothTasks 

It contains 3 projects

1.TaskConsole 
   - console application which called the WebService (on localhost) to compute the Fibonacci(n) and print the result to the console. 

2.TasWebService
   - ASP.NET WebService with the following Web Methods:

	int Fibonacci(int n)
	string XmlToJson(string xml)
   - Added class library to convert Json (XMLToJson.cs)
   - Included logging for the both web methods using log4net.config
   - Created Configuration for JsonFormat/XML in Web.config.

3.Service1ClientTests 
   - It will call the webreference (onlocalhost) to tests the below test cases of FibonacciTest and XMLToJsonTest prototype. 

   - NUnit Test cases for Fibonacci
	Fibonacci(101) must be return to -1
	Fibonacci(0) must be return to 0
	Fibonacci(1) must be return to 1
	Fibonacci(50) must be return to 12586269025

   - Nunit Test cases for XMLToJson
	XmlToJson("") must be return to "Root element is missing."
