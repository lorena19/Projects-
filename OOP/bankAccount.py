class BankAccount():
	def __init__(self, int_rate, balance):
		self.int_rate = 0.02
		self.balance = 0

	def deposit(self, amount):
		self.balance += amount
		return self

	def withdraw(self, amount): #if there is not enough money, print a message "Insufficient funds: Charging a $5 fee" and deduct $5
		if self.balance >= amount:
				self.balance -= amount
				return
		else:
				print(f"Insufficient funds: Charging a $5 fee", self.balance)
		return self

	def yield_interest(self, amount):
		self.balance += amount * self.int_rate
		return self
	
	def display_account_info(self):
		print(f"Balance: {self.balance}")
		return self


account = BankAccount()
account.deposit(100)
account.depost(100)
account.deposit(400)
account.withdraw(600)
account.display_account_info


