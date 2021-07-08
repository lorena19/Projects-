class Profile:
    #name
    #age
    #list of favorite prime numbers
    #gender
    def __init__(self, name, age, gender): 
        self.name = name
        self.age = age
        self.favPrimes = []
        self.gender = gender

    def printMe(self):
        print(f"My name is {self.name} and i am{self.age} years old!")

def addPrime(self,num):
        #check if self.favPrimes has 5 items
        #if it does, pop one, then push the new one
        #otherwise, still push the new
        if len(self.favPrimes) >= 5:
            self.favPrimes.pop(0)
        self.favPrimes.append(num)


michaelProfile = Profile("Mike", 568, "male")
samProfile = Profile("Sam", 300, "female")
bobothyProfile = Profile("Bobothy", 18, "male")

bobothy.addPrime(23)
bobothy.addPrime(13)
bobothy.addPrime(7)
bobothy.addPrime(29)
bobothy.addPrime(37)
bobothy.addPrime(283)
print(bobothy.favPrimes)
#print(michaelProfile.name)
#print(samProfile.name)/
#print(bobothy.name)