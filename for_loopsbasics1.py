#Basic - Print all integers from 0 to 150.
def basic():
    for x in range(0, 151):
        print(x)
basic()

#Multiples of Five - Print all the multiples of 5 from 5 to 1,000
def multiplesOfFive();
    for x in range(5, 1001, 5):
        print(x)
multiplesOfFive()

#Counting, the Dojo Way - Print integers 1 to 100. If divisible by 5, print #"Coding" instead. If divisible by 10, print "Coding Dojo".
def counting():
    for x in range(1, 101):
        if x % 10 == 0:
            print("Coding Dojo")
        elif x % 5 == 0:
            print("Coding")
        else:
            print(x)
counting()

#Whoa. That Sucker's Huge - Add odd integers from 0 to 500,000, and print the #final sum.
def woah():
    sum = 0
    for i in range(0, 5000001):
        sum +=1
        print(sum)
woah()
#comeback to this one, youre probably missing something really dumb. look up sum function again!!!

#Countdown by Fours - Print positive numbers starting at 2018, counting down by fours.
def countdownByFours():
    x = 2018
    while x > 0: 
        x = x - 4
        print(x)       
countdownByFours()



#Flexible Counter - Set three variables: lowNum, highNum, mult. Starting at lowNum and going through highNum, print only the integers that are a multiple of mult. For example, if lowNum=2, highNum=9, and mult=3, the loop should print 3, 6, 9 (on successive lines)

#def flexiableCounter(lowNum, highNum, mult):
    #for x in range(lowNum, highNum):
        #if x % mult == 0:
            #print(x)
#flexiableCounter(2, 9, 3)
#why is it only outputtting 3 and 6??
#do i have multiply the mult to get 9?......ask for help.

def flexiableCounter(lowNum,highNum, mult):
    while lowNum%mult != 0:
        lowNum+=1
    for x in range(lowNum, highNum+1, mult):
        print(x)
flexiableCounter(2,9,3)
