//Generate Coin Change
//Change is inevitable (especially when breaking a twenty). Make generateCoinChange(cents).
//Accept a number of American cents, compute and print how to represent that amount with
//smallest number of coins. Common American coins are pennies (1 cent), nickels (5 cents),
//dimes (10 cents), and quarters (25 cents).

//Return the optimal configuration of coins in an object.

//Example output, given generateCoinChange(94):
//94 cents can be represented by:

//{
//quarters:3,
//dimes:1,
//nickels:1,
//pennies:4
//}

//Second: can you simplify/shorten your code?

//Third: add half-dollar (50 cents) and dollar (100 cents) coins with 40 additional characters
//or less.

//pseudocode 
//declare an object called coin count
//set it to 0 for quarters, dimes, nickels, and pennies
//while there is still change to be counted, you want to keep on counting. 
//keep track of the change starting from the largest to smallest
//see if the amount of change is largest than a quarter.
//if it is largest subtract from 25 
//then add a quarter to the current quarter count
//repeat until the amount of change is less than a quarter. 
//repeat lines 28-31 for dimes, nickels, and pennies. 
//return object coin count 

function generateCoinChange(cents){
    var coincount = {
        "quarters" : 0,
        "dimes" : 0,
        "nickels" : 0,
        "pennies" : 0
    }
        while(cents > 0){
            if(cents >= 25){
                cents -= 25 
                coincount.quarters++
            }
            else if(cents >= 10){
                cents -= 10
                coincount.dimes++
            }
            else if(cents >= 5){
                cents -= 5
                coincount.nickels++
            }
            else if(cents >= 1){
                cents -= 1
                coincount.pennies++
            }
    }
    return coincount
}
console.log(generateCoinChange(90))


function dollarAndCoinChange(dollars){
    var coins = {
        "ten": 0,
        "five": 0,
        "one": 0,
        "quarters": 0,
        "dimes": 0,
        "nickels": 0,
        "pennies": 0,
    }
    while(dollars > 0){
        dollars = dollars.toFixed(2);
        if(dollars >= 10){
            dollars -= 10
            coins.ten++
        }
        else if(dollars >= 5){
            dollars -= 5
            coins.five++
        }
        else if(dollars >= 1){
            dollars -= 1
            coins.one++
        }
        else if(dollars >= 0.25){
            dollars -= 0.25 
            coins.quarters++
        }
        else if(dollars >= 0.1){
            dollars -= 0.1
            coins.dimes++
        }
        else if(dollars >= 0.05){
            dollars -= 0.05
            coins.nickels++
        }
        else if(dollars >= 0.01){
            dollars -= 0.01
            coins.pennies++
        }
}
return coins
}
console.log(dollarAndCoinChange(46.32))

//46.32 -> 4 tens, 1 five, 1 one, 1 quarter, 0 dimes, 1 nickel, 2 pennies