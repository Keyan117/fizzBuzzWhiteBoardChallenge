// Write a public method that accepts a number
//1. access modifier
//2. return type
//3. method name
//4. parameters
//5. scope

 string FizzBuzz(int number)
{
    var answer = "";

    //when the number is divisible by 3 return the word fizz
    if(number % 3 == 0)
    {
        answer = "fizz";
    }
    
    if(number % 5 == 0)
    {
        answer += "buzz"; //answer = answer + "buzz"
    }

    return answer;
}

