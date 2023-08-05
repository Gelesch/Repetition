
MakeRequest();



static void MakeRequest(int currentRequest = 0, int maxRequest = 10){

    if (currentRequest >= maxRequest)
    {
        Console.WriteLine("Break");
        return;
    }
    var responseResult = GetRandomBoolean();
    Console.WriteLine("Current request: "+ currentRequest);
    Console.WriteLine("Response: "+responseResult);
    
    Thread.Sleep(250);
    if (responseResult==false)
    {
       MakeRequest(currentRequest+1);
    }
}


 static bool GetRandomBoolean() => new Random().Next(1, 10) == 1;