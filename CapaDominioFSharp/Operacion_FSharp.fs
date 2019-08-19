module Operacion_FSharp
open System
let Calcular(num1:double)(num2:double)(operacion:string)=       
    if(operacion="Sumar")then 
        num1+num2 
    else if (operacion="Restar")then
        num1-num2
    else if (operacion="Multiplicar")then
        num1*num2
    else 
        num1/num2


     
        
 
