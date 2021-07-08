class User:
    def __init__(self, name, email):  
        self.name = name
        self.email = email
        self.balance = 0
    def make_withdrawal(self, amount):
        self.balance -= amount
        return self
    def make_deposit(self, amount):
        self.balance += amount
        return self
    def display_user_balance(self):
        print(User: {self.name}, Balance: {self.balance})
        return self

lorena = User("lorena", "campos,lorena19@gmail.com")
michelle = User("michelle", "michellecampos@gmail.com")
charles = User("charles", "charlesisadog@gmail.com")

lorena.make_deposit(1000).make_deposit(1000).make_deposit(1000).make_withdrawal(500).display_user_balance()
#balance should be 2,500

michelle.make_deposit(500).make_deposit(500).make_withdrawal(100).make_withdrawal(100).display_user_balance()
#balance should be 800

charles.make_deposit(3000).make_withdrawal(1000).make_withdrawal(1000).make_withdrawal(500).display_user_balance()
#balance should be 500


