for(var i= 1000; i>=1; i--){
        var isPrime=true;
        for(var j = i-1; j>2 ;j--){
            if(i%j===0){
                isPrime = false;
              break;
            }
        }
        if(isPrime){
            var k = i.toString().split("").reverse().join('');
            if(k===i.toString()){
                console.log(i);
                break;
            }
        }
    }
