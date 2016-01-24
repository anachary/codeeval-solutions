var sum=0;
var counter=1;
var i=2;
while(counter<=1000){
        var isPrime=true;

        for(var j = 2; j<i ;j++){

            if(i%j===0 && i!=j){
                isPrime = false;
              break;
            }

        }
        if(isPrime){
            sum+=i;
            counter++;
        }
        i++;
} console.log(sum);
