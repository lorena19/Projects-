//1.Print odds 1-20
// 1.Print out all odd numbers from 1 to 20
// 2.The expected output will be 1, 3, 5, 7, 9, 11, 13, 15, 17, 19
//Pseudocode
//1. given an empty group, look through each item starting at 1
//2. increment by 1 to see which item is odd in group until your item runs false
//3. keep track of all the odd items in your group
//4. print out the list of all odd numbers

function Odds1To20(){
    var odds = []
    for(var i = 1; i<= 20; i++){
        if(i % 2 == 1){
            odds.push(i)
        }
    }
console.log(odds)
}
Odds1To20()



//2.Sum and Print 1-5
//1.Sum numbers from 1 to 5, printing out the current number and sum so far at each step of the way
//2.The expected output will be: Num: 1, Sum: 1, Num: 2, Sum: 3, Num: 3, Sum: 6, Num: 4, Sum: 10, Num: 5, Sum: 15
//Pseudocode
//1.given an empty group, look through each item starting at 1. 
//2. increment the current value by 1 
//3.keep track of the current number. 
//4. keep track of the current sum.
//5. print out both the current item, number and sum. 

function printSum1To5(){
    var sum = 0; 
    for(var i=1; i<= 5; i++){
        sum = sum + i 
        console.log(i,sum)
    }
}
printSum1To5()