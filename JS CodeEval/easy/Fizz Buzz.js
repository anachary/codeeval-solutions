/*Sample code to read in test cases:*/
var fs  = require("fs");
fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
     var values = line.split(" ");
     var x = parseInt(values[0]);
     var y = parseInt(values[1]);
     var range = parseInt(values[2]);
     var result="";
     for(var i=1;i<=range;i++){
         if(i%x===0 && i%y===0){
            result+="FB "
         }
         else if(i%x===0){
             result+="F ";
         }
         else if(i%y===0){
             result+="B ";
         }
         else{
             result+=i.toString()+ " ";
         }
     }
     console.log(result.trim());
    }
});
