'use strict'

/*
*   Group: IT-92
*   Student: Valentine Shenfeld
*   FIOT
*   2019-09-06
*/

const readln = require('readline').createInterface(process.stdin, process.stdout);

let isStarted = false;

console.clear();
console.log("Для запуска напишите \"start\"");

readln.on("line", (input) => {

    let line = input;

    if (line === "start" && !isStarted) {
        isStarted = true;
        console.clear();
        console.log('Введите число и разрядности из и в которую  ' 
        + 'хотите перевести.\nПример: FF78 16 2');
    };

    if (line !== "start" && isStarted) {

        let lineArr = [];
        let result = "";
        if (typeof line !== "string") line.toString();
        lineArr = line.split(" "); 

        if (lineArr.length === 3) {
            result = parseToElseDec(parseToDec(lineArr[0], lineArr[1]), lineArr[2]);
        }
        if (result === null || result === undefined || lineArr.length !== 3 ) {
            console.clear();
            console.log('Повторите попытку!\nПример: FF78 16 2');
        
        } else if ((result !== null || result !== undefined) && typeof(result) === "string" && result !== "") {

            console.log(`Результат: ${result}`);
        };

    };
});

const parseToDec = (num, from) => {

    let result = 0;
    let dec = num.toString();
    let tmpArr = dec.split("");

    let letterArr = "abcdefghijklmnopqrstuvwxyz".toUpperCase().split("");
    
    for (let kk = 1; kk <11; kk++) letterArr.unshift("");

    if (+from > 10) {
        while(tmpArr.indexOf(tmpArr.find(value => /[a-zA-Z]{1}/.test(value))) !== -1) {
            tmpArr[tmpArr.indexOf(tmpArr.find(value => /[a-zA-Z]{1}/.test(value)))] 
            = letterArr.indexOf(tmpArr.find(value => /[a-zA-Z]{1}/.test(value)).toUpperCase());
        };
    };

    for (let i = 1; i <= tmpArr.length; i++) {
        result += tmpArr[i - 1] * Math.pow(from, tmpArr.length - i);
    }
    return result
}

const parseToElseDec = (num, to) => {

    let tmpArr = [];
    let dec = +num;

    let letterArr = "abcdefghijklmnopqrstuvwxyz".toUpperCase().split("");
    
    for (let kk = 1; kk <11; kk++) letterArr.unshift("");
    
        while (dec >= to ) {
            tmpArr.unshift(dec % to);
            dec = (dec - ( dec % to)) / to;   
        }

        tmpArr.unshift(dec);

        if (+to > 10) {
            tmpArr.forEach((el, i) => {

                if (el === tmpArr.find(value => /[1-3][0-9]/.test(value))) {
                    tmpArr[i] = letterArr[el];

                }
            });
        }

        return tmpArr.join("");

}

