//Sample code to read in test cases:
var fs  = require("fs");
 var dicCol=[];
        for(var i=1; i<=26;i++)
        {
         dicCol[i-1]= String.fromCharCode("A".charCodeAt()+ i-1);
        }

fs.readFileSync(process.argv[2]).toString().split('\n').forEach(function (line) {
    if (line != "") {
        var value = parseInt(line);
       var codeResult='';

        while(value>26) {
         var modeValue = value % 26;
          var divInt =parseInt(value/26);
         codeResult = modeValue==0 ? dicCol[25]:dicCol[modeValue-1] + codeResult;
         value = modeValue == 0 ? divInt-1 : divInt;
        }
         console.log(dicCol[value-1] + codeResult);
        }
});
 
