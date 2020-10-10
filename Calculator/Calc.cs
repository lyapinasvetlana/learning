using System;
using Newtonsoft.Json;

namespace Vs.Calculator
{
    public static class Calc
    {
       public static int Sum(int a, int b){ 
         return a+b;
       }
       public static string ToJson(int a, int b){
           var t= new {x=a,y=b};
           return JsonConvert.SerializeObject(t);
       }
    }
}
