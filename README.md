# Check Telefono

* all'inizio creiamo in for per fare scorrere tutto l'array 

```Javascript
        for (int i = 0; i < input.Length; i++)
        {

        }
``` 

* all'interno del for ci mettiamo un if per controllare i caratteri dell'array di string 

   
```Javascript 
   if((telefono.StartsWith("+39") && telefono.Length == 13) ||
      (telefono.StartsWith("0039") && telefono.Length == 14) ||
      (telefono.StartsWith("3") && telefono.Length == 10) ){ }
 ``` 
* all'interno del if abbiamo messo come condinzione la stringa tellefono nella posizione in cui si trovva array input , poi abbiamo messo un StartWirh("") per controllare la possizione dei caratteri se corrispondo con la condizione che abbiamo messo , poi le || servono a fare piu controlli senza usare altri if e ottimizza il codice

```Javascript 
return telefono;
``` 
* abbiamo messo return del telefono per restituire la variabile string se le condizioni sono state rispettate

```Javascript 
return ""; 
```
* se le condizioni non state rispettate ritorna una niente


